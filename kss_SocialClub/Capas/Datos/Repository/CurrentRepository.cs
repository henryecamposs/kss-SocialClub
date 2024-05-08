using ksslib;
using ksslib_c;
using ksslib_c.Utiles;
using MoralesLarios.Data.Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace kss_SocialClub.Capas.Datos.Repository

{
    public class CurrentRepository<TEntity> : DPGenericRepository<TEntity> where TEntity : class
    {
        public enuStatusRegistro original_StatusRegistro { get; private set; }
        private enuStatusRegistro _statusRegistro;

        private bool _HasError;
        public bool isLastID;
        public bool isFirstID;
        private int _PosicionActual;
        private SQLiteConnection Connection;
        private TEntity _entidadActual;

        public long IDActual { get; internal set; }
        public string TableName { get; }
        public string IDCampo { get; private set; }
        //Registros
        //public TEntity EntityActual { get => this.Find(new { id = IDActual }); }
        public TEntity EntityActual
        {
            get => _entidadActual;
            private set
            {
                if (value != null)
                {
                    IDActual = Convert.ToInt32(clsUtil_Class.GetPropValue(value, "ID"));
                    if (EntidadActualChanged != null)
                        EntidadActualChanged(value, IDActual);
                }
                else
                    if (EntidadActualChanged != null)
                    EntidadActualChanged(null, 0);

                _entidadActual = value;
            }
        }
        public TEntity EntityAnterior { get; set; }
        public List<TEntity> Rows { get => (List<TEntity>)base.All(); }
        public int Count
        {
            get
            {
                List<TEntity> tmp = Rows;
                if (tmp == null)
                {
                    EntityActual = null;
                    return 0;
                }
                else
                    return tmp.Count;
            }
        }
        public int PosicionActual
        {
            get => _PosicionActual;
            set
            {
                _PosicionActual = value;
                isFirstID = _PosicionActual == 0 ? true : false;
                isLastID = _PosicionActual == Count - 1 ? true : false;

            }
        }
        public enuStatusRegistro statusRegistro
        {
            get => _statusRegistro;
            set
            {
                original_StatusRegistro = _statusRegistro;
                _statusRegistro = value;
                OnStatusEdicionCambiado();
            }
        }

        public CurrentRepository(SQLiteConnection conn, string idcampo = "ID", char parameterIdentified = '@') : base(conn, parameterIdentified)
        {
            try
            {
                IDCampo = idcampo;
                All();
                Connection = conn;
                TableName = typeof(TEntity).Name;
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
            }
        }


        #region  Desplazamiento
        public void MoveFirst()
        {
            PosicionActual = 0;
            MoveToPosition(PosicionActual);
            statusRegistro = enuStatusRegistro.Moviendo_first;
        }
        public int MovePrevious()
        {
            if (PosicionActual > 0)
                PosicionActual--;
            else
                PosicionActual = 0;
            MoveToPosition(PosicionActual);
            statusRegistro = enuStatusRegistro.Moviendo_previous;
            return PosicionActual;
        }
        public int MoveNext()
        {
            if (PosicionActual < Count - 1)
                PosicionActual++;
            else
                PosicionActual = Count - 1;
            MoveToPosition(PosicionActual);
            statusRegistro = enuStatusRegistro.Moviendo_next;
            return PosicionActual;
        }
        public void MoveLast()
        {
            PosicionActual = Count - 1;
            MoveToPosition(PosicionActual);
            statusRegistro = enuStatusRegistro.Moviendo_last;
        }
        public void MoveToPosition(int? Posicion = null)
        {
            if (Posicion == null)
                Posicion = PosicionActual;
            PosicionActual = (int)Posicion;
            if (Rows != null && Count > 0)
                EntityActual = Rows[PosicionActual];
            else
                EntityActual = null;
        }
        #endregion

        #region Base de Datos
        public new IEnumerable<TEntity> All()
        {
            statusRegistro = enuStatusRegistro.Cargando;
            return Rows;
        }
        public new int Add(TEntity entity)
        {
            int result = 0;
            statusRegistro = enuStatusRegistro.Agregando;
            result = base.Add(entity);
            if (result > 0) MoveLast();
            return result;
        }
        public new void Remove(object key)
        {
            statusRegistro = enuStatusRegistro.Eliminando;
            base.Remove(key);
            if ((isEntityRemoved = Find(key) != null ? false : true))
                MoveNext();
            else
                MoveToPosition(PosicionActual);
        }
        public new int Update(TEntity entity, object pks)
        {
            int result = 0;
            statusRegistro = enuStatusRegistro.Actualizando;
            result = base.Update(entity, pks);
            MoveToPosition(PosicionActual);
            return result;
        }
        public new int InstertOrUpdate(TEntity entity, object pks)
        {
            int result = 0;
            if (Find(pks) != null)
                statusRegistro = enuStatusRegistro.Actualizando;
            else
                statusRegistro = enuStatusRegistro.Agregando;
            result = base.InstertOrUpdate(entity, pks);
            if (result > 0 && statusRegistro == enuStatusRegistro.Agregando) MoveLast();
            if (result > 0 && statusRegistro == enuStatusRegistro.Actualizando) MoveToPosition(PosicionActual);
            return result;
        }
        public long LastID() => Extension_Methods.ExecuteDb.LastID(Connection.ConnectionString, TableName);
        #endregion

        //Aplicaciones 
        public string MsjError { get; set; }
        public bool HasError
        {
            get => _HasError;
            set => _HasError = value;
        }

        public bool isEntityRemoved { get; private set; }

        /// <summary>
        /// Muesta Mensaje emergente sobre Estado del Registro
        /// </summary>
        /// <param name="Msj">Estado del Registro</param>
        private void MostrarMsjStatus(string Msj)
        {
            //Muestra un MSJ Delayed

        }


        #region Eventos
        public delegate void statusEdicionCambiado_EventHandler(object sender, enuStatusRegistro e);
        public event statusEdicionCambiado_EventHandler statusRegistrosCambiado;
        protected virtual void OnStatusEdicionCambiado()
        {
            if (statusRegistrosCambiado != null)
                statusRegistrosCambiado(EntityActual, statusRegistro);
        }

        public delegate void EntidadChange_EventHandler(TEntity Entidad, long ID);
        public event EntidadChange_EventHandler EntidadActualChanged;
        protected virtual void OnEntidadActualChanged()
        {
            if (EntidadActualChanged != null)
                EntidadActualChanged(EntityActual, IDActual);
        }
        #endregion
        /// <summary>
        /// Evento generado cuando un Registro Cambia de Estado.
        /// </summary>
        private void statusEdicion_Changed()
        {
            //Generar accion al cambiar registro


        }

    }
}
