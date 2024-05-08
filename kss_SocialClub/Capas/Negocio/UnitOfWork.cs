﻿using kss_SocialClub.Capas.Datos.Repository;
using ksslib;
using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Windows.Forms;

namespace kss_SocialClub.Capas.Negocio
{
    public interface IBaseEntity
    {
        int Id { get; set; }
    }

    internal interface IUnitOfWork<TEntity> : IDisposable
        where TEntity : class
    {
        //Transacciones
        bool IsInTransaction { get; }
        bool isCommit { get; }
        bool isRollBack { get; }
        SQLiteTransaction Transaction { get; }
        void Commit();
        void Rollback();
    }

    public class UnitOfWork<TEntity> : IUnitOfWork<TEntity>
        where TEntity : class
    {

        private bool disposed = false;
        private readonly SQLiteConnection _dbConnection;
        internal readonly CurrentRepository<TEntity> currentRepository;

        //Botones Edicion y Desplazamiento
        private TableLayoutPanel tlDesplazamiento;
        private TableLayoutPanel tlEdicion;
        private TableLayoutPanel tlEdit_Search;
        private DevComponents.DotNetBar.ButtonX btnFirst;
        private DevComponents.DotNetBar.ButtonX btnPrev;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private DevComponents.DotNetBar.ButtonX btnLast;
        //Tools Edit Search
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnDel;
        private DevComponents.DotNetBar.ButtonX btnSelect;
        private DevComponents.DotNetBar.LabelX lblCount;
        private Panel panelDatos;


        public UnitOfWork(SQLiteConnection dbConnection, string id_campo = "ID")
        {
            if (dbConnection != null)
            {
                bool isDbDisponible = false;
                if (!string.IsNullOrEmpty(dbConnection.ConnectionString))
                    using (SQLiteConnection db = dbConnection)
                    {
                        try
                        {
                            db.Open();
                            isDbDisponible = true;
                        }
                        catch (Exception)
                        {
                            isDbDisponible = false;
                        }
                        finally
                        {
                            if (db.State == System.Data.ConnectionState.Open) db.Close();
                        }
                    }
                else
                    kss_msjDelay.Show("Ruta de Conexión está vacia.");

                if (isDbDisponible)
                {
                    this._dbConnection = dbConnection;
                    _dbConnection.Commit += _dbConnection_Commit;
                    _dbConnection.RollBack += _dbConnection_RollBack;
                    currentRepository = new CurrentRepository<TEntity>(_dbConnection, id_campo);
                    currentRepository.statusRegistrosCambiado += CurrentRepository_statusRegistrosCambiado;
                }
                else
                    kss_msjDelay.Show("No existe comunicación con la Base de Datos.");

            }
            else
                kss_msjDelay.Show("Conexión nula o no Asignada.");
        }



        public void AsignBtnsDesplz_btnsCRUD(
            TableLayoutPanel tlDesplz, TableLayoutPanel tlEdit, TableLayoutPanel tlEditSearch,
            DevComponents.DotNetBar.ButtonX btnFirst, DevComponents.DotNetBar.ButtonX btnPrev, DevComponents.DotNetBar.ButtonX btnNext, DevComponents.DotNetBar.ButtonX btnLast,
            DevComponents.DotNetBar.ButtonX btnSearch, DevComponents.DotNetBar.ButtonX btnEdit, DevComponents.DotNetBar.ButtonX btnAdd, DevComponents.DotNetBar.ButtonX btnDel,
            DevComponents.DotNetBar.LabelX lblCount, Panel panelDatos = null, DevComponents.DotNetBar.ButtonX btnSelect = null)
        {
            tlDesplazamiento = tlDesplz;
            tlEdicion = tlEdit;
            tlEdit_Search = tlEditSearch;
            this.btnFirst = btnFirst;
            this.btnPrev = btnPrev;
            this.btnNext = btnNext;
            this.btnLast = btnLast;
            this.btnSelect = btnSelect;
            //Tools Edit
            this.btnSearch = btnSearch;
            this.btnEdit = btnEdit;
            this.btnAdd = btnAdd;
            this.btnDel = btnDel;
            this.panelDatos = panelDatos;
            this.lblCount = lblCount;
            currentRepository.MoveFirst();
        }

        private void CurrentRepository_statusRegistrosCambiado(object sender, enuStatusRegistro e)
        {
            switch (e)
            {
                case ksslib.enuStatusRegistro.Modificando:
                case ksslib.enuStatusRegistro.Editando:
                case ksslib.enuStatusRegistro.Agregando:
                    BtnsEditDesplz(false);
                    break;
                case ksslib.enuStatusRegistro.Cargando:
                case ksslib.enuStatusRegistro.Eliminando:
                    BtnsEditDesplz(true);
                    break;
                case ksslib.enuStatusRegistro.Actualizacion_Rechazada:
                    Application.DoEvents();
                    ksslib.kss_msjDelay.Show(e.Description().ToString(), ksslib.enuMsgBoxImag.msgInformacion, SegundosMostrar: .5);
                    currentRepository.MovePrevious();
                    BtnsEditDesplz(true);
                    break;
                case ksslib.enuStatusRegistro.Cancelando:
                case ksslib.enuStatusRegistro.Datos_actualizados:
                    Application.DoEvents();
                    ksslib.kss_msjDelay.Show(e.Description().ToString(), ksslib.enuMsgBoxImag.msgInformacion, SegundosMostrar: .5);
                    BtnsEditDesplz(true);
                    break;
                case ksslib.enuStatusRegistro.Moviendo_first:
                case ksslib.enuStatusRegistro.Moviendo_last:
                case ksslib.enuStatusRegistro.Moviendo_next:
                case ksslib.enuStatusRegistro.Moviendo_previous:
                    BtnsEditDesplz(true);
                    break;
                case enuStatusRegistro.Registro_Agregado:
                    currentRepository.statusRegistro = enuStatusRegistro.Editando;
                    BtnsEditDesplz(true);
                    break;
                case enuStatusRegistro.Registro_Eliminado:
                    BtnsEditDesplz(true);
                    break;
            };

        }

        private void BtnsEditDesplz(bool ActivarDesplz)
        {
            tlDesplazamiento.Visible = ActivarDesplz;
            tlEdicion.Visible = !ActivarDesplz;
            tlEdit_Search.Enabled = ActivarDesplz;
            btnFirst.Enabled = !currentRepository.isFirstID;
            btnLast.Enabled = !currentRepository.isLastID;
            btnPrev.Enabled = btnFirst.Enabled;
            btnNext.Enabled = btnLast.Enabled;
            tlDesplazamiento.Enabled = currentRepository.Count == 0 ? false : true;
            btnSearch.Enabled = currentRepository.Count == 0 ? false : true;

            if (btnSelect != null)
                btnSelect.Visible = true;

            if (panelDatos != null)
                panelDatos.Enabled = !tlDesplazamiento.Visible;


            if (currentRepository.EntityActual == null)
            {
                btnEdit.Enabled = false;
                btnDel.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnDel.Enabled = true;
            }
            if (currentRepository.statusRegistro == enuStatusRegistro.Agregando || currentRepository.statusRegistro == enuStatusRegistro.Editando)
            {
                panelDatos.Enabled = true;
            }
            lblCount.Text = string.Format("{0} de {1}", currentRepository.Count == 0 ? 0 : currentRepository.PosicionActual + 1, currentRepository.Count);
        }

        #region Transacciones

        private SQLiteTransaction _transaction;

        //Transacciones
        public bool IsInTransaction { get; private set; }
        public bool isCommit { get; private set; }
        public bool isRollBack { get; private set; }
        /// <summary>
        /// Transaccion Actual
        /// </summary>
        public SQLiteTransaction Transaction
        {
            get => _transaction;
            private set
            {
                _transaction = null;
                _transaction = _dbConnection.BeginTransaction();
            }
        }
        /// <summary>
        /// Evento se cancelaron los cambios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _dbConnection_RollBack(object sender, EventArgs e) => isRollBack = true;

        /// <summary>
        /// Evento se Aceptaron los cambios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _dbConnection_Commit(object sender, CommitEventArgs e) => isCommit = true;

        /// <summary>
        /// Guardar los Cambios
        /// </summary>
        public void Commit()
        {
            if (Transaction != null)
                Transaction.Commit();
        }

        /// <summary>
        /// Deshacer los Cambios
        /// </summary>
        public void Rollback()
        {
            if (Transaction != null)
                Transaction.Rollback();
        }

        #endregion

        /// <summary>
        /// Protected Virtual Dispose method
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Debug.WriteLine("UnitOfWork is being disposed");
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }



}
