using DevComponents.DotNetBar;
using kss_SocialClub.Capas.Negocio;
using ksslib;
using System;
using System.Windows.Forms;

namespace kss_SocialClub.UI.Templates
{
    public partial class frmPlantillaDatos<TEntity> : frmTemplate
        where TEntity : class

    {
        internal UnitOfWork<TEntity> _unitOfWork;
        internal TEntity EntidadActual { get; set; }
        internal bool isAuxiliarTable;
        internal bool isGuardar;
        internal TEntity tmpEntidad = null;

        public frmPlantillaDatos()
        {
            InitializeComponent();

            btnSelect.Dock = DockStyle.Right;
            base.panel1.Controls.Add(btnSelect);
            base.panel1.Refresh();
        }
        private void frmPlantillaDatos_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            _unitOfWork = new UnitOfWork<TEntity>(Program.Connection);
            _unitOfWork.AsignBtnsDesplz_btnsCRUD(tlDesplazamiento, tlEdicion, tlEditSearch,
                btnFirst, btnPrev, btnNext, btnLast, btnSearch, btnEdit, btnAdd, btnDel, lblCount,
                panelDatos, isAuxiliarTable ? btnSelect : null);
            EntidadActual = _unitOfWork.currentRepository.EntityActual;
            _unitOfWork.currentRepository.statusRegistrosCambiado += CurrentRepository_statusRegistrosCambiado;
            _unitOfWork.currentRepository.EntidadActualChanged += CurrentRepository_EntidadActualChanged; ;
            isGuardar = true;
        }
        #region Eventos Personalizados
        private void CurrentRepository_EntidadActualChanged(TEntity Entidad, long ID)
        {
            EntidadActual = Entidad;
            if (Entidad == null)
                if (ResetControles != null)
                    ResetControles(this, new EventArgs());
        }

        private void CurrentRepository_statusRegistrosCambiado(object sender, enuStatusRegistro e)
        {
            if (e != enuStatusRegistro.Agregando)
                if (CargarDatos != null)
                    CargarDatos((EntidadActual));
        }
        /// <summary>
        /// Evento para limpiar controles en Objeto Heredado
        /// </summary>
        public event EventHandler ResetControles;
        protected virtual void OnResetControles()
        {
            if (ResetControles != null)
                ResetControles(this, new EventArgs());
        }

        /// <summary>
        /// Evento se genera para guardar datos en la BD desde Objeto Heredado
        /// </summary>
        public delegate void guardarDatos_EventHandler(TEntity sender);
        public event guardarDatos_EventHandler GuardarDatos;
        protected virtual void OnGuardarDatos()
        {
            if (GuardarDatos != null)
                GuardarDatos(EntidadActual);
        }

        /// <summary>
        /// Evento para cargar datos en Objeto Heredado
        /// </summary>
        /// <param name="sender"></param>
        public delegate void cargarDatos_EventHandler(TEntity sender);
        public event cargarDatos_EventHandler CargarDatos;
        protected virtual void OnCargarDatos()
        {
            if (CargarDatos != null)
                CargarDatos(EntidadActual);
        }

        #endregion
        /// <summary>
        /// Guardar en BD
        /// </summary>
        /// <param name="entidad"></param>
        /// <param name="enuAciion"></param>
        /// <returns></returns>
        private int GuardarEnBD(TEntity entidad, enuStatusRegistro enuAciion)
        {
            try
            {
                return _unitOfWork.currentRepository.InstertOrUpdate(entidad, new { ID = _unitOfWork.currentRepository.IDActual });
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
                return 0;
            }
            finally
            {
            }
        }

        /// <summary>
        /// Manejador de Acciones de Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccion_click(object sender, EventArgs e)
        {
            switch (((ButtonX)sender).Name)
            {
                case "btnSave":
                    int ItemsAfectados = 0;
                    GuardarDatos(tmpEntidad);
                    if (isGuardar)
                    {
                        EntidadActual = tmpEntidad.Copy();
                        if (_unitOfWork.currentRepository.statusRegistro == enuStatusRegistro.Agregando)
                            ItemsAfectados = GuardarEnBD(tmpEntidad, enuStatusRegistro.Agregando);
                        else
                            ItemsAfectados = GuardarEnBD(tmpEntidad, enuStatusRegistro.Editando);
                    }
                    else
                        ItemsAfectados = 0;

                    if (ItemsAfectados == 0)
                    {
                        MostrarMsjStatus("No se realizaron cambios!!");
                        _unitOfWork.currentRepository.statusRegistro = enuStatusRegistro.Actualizacion_Rechazada;
                        CargarDatos(tmpEntidad);
                    }
                    else
                    {
                        if (_unitOfWork.currentRepository.statusRegistro == enuStatusRegistro.Agregando)
                            _unitOfWork.currentRepository.PosicionActual = _unitOfWork.currentRepository.Count - 1;
                        _unitOfWork.currentRepository.statusRegistro = enuStatusRegistro.Datos_actualizados;
                        MostrarMsjStatus("Datos Actualizados Correctamente!!");
                    }
                    break;
                case "btnCancel":
                    //if (_unitOfWork.currentRepository.statusRegistro != enuStatusRegistro.Agregando)
                    EntidadActual = _unitOfWork.currentRepository.EntityActual;
                    _unitOfWork.currentRepository.statusRegistro = enuStatusRegistro.Cancelando;
                    MostrarMsjStatus("Operacion Cancelada!");
                    _unitOfWork.currentRepository.MoveToPosition();
                    break;
                case "btnAdd":
                    tmpEntidad =  EntidadActual.Copy();
                    _unitOfWork.currentRepository.statusRegistro = enuStatusRegistro.Agregando;
                    ResetControles(this, e);
                    EntidadActual = null;
                    break;
                case "btnEdit":
                    if (EntidadActual != null)
                    {
                        tmpEntidad = EntidadActual.Copy();
                        _unitOfWork.currentRepository.statusRegistro = enuStatusRegistro.Editando;
                    }
                    break;
                case "btnDel":
                    if (EntidadActual != null)
                        try
                        {
                            DialogResult Result = kss_msjDelay.Show(string.Format("Desea Eliminar:\n{0}", EntidadActual.ToString()), enuMsgBoxImag.msgInformacion, enuMsgBoxResult.msgYesNO, 10, "Eliminar Registro!");
                            if (Result == DialogResult.Yes)
                                _unitOfWork.currentRepository.Remove(new { ID = _unitOfWork.currentRepository.IDActual });

                            if (_unitOfWork.currentRepository.isEntityRemoved)
                                MostrarMsjStatus("Se ELIMINO Registro!");
                            else
                                MostrarMsjStatus("No se pudo ELIMINAR Registro!");
                        }
                        catch (Exception ex)
                        {
                            clsUtilErrors.Manejador_errores(ex);
                        }
                    break;
                case "btnSearch":
                    _unitOfWork.currentRepository.statusRegistro = enuStatusRegistro.Buscando_Registro;
                    buscarDatos();
                    break;
                case "btnFirst":
                    _unitOfWork.currentRepository.MoveFirst();
                    break;
                case "btnPrev":
                    _unitOfWork.currentRepository.MovePrevious();
                    break;
                case "btnNext":
                    _unitOfWork.currentRepository.MoveNext();
                    break;
                case "btnLast":
                    _unitOfWork.currentRepository.MoveLast();
                    break;

            }
        }

        private void buscarDatos()
        {

        }


        /// <summary>
        /// Muesta Mensaje emergente sobre Estado del Registro
        /// </summary>
        /// <param name="Msj">Estado del Registro</param>
        internal void MostrarMsjStatus(string Msj)
        {
            //Muestra un MSJ Delayed
            ToastNotification.Show(this,
               Msj, null,
               700,
               eToastGlowColor.Blue,
               eToastPosition.TopRight);
        }

        /// <summary>
        /// Asignar ToolTips a Controles
        /// </summary>
        private void AsignarToolTipsCtrl()
        {
            this.superTooltip1.SetSuperTooltip(this.btnAdd, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "<b>Agregar</b> Registro <b>CTRL + N</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnDel, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "<b>Eliminar</b> Registro <b>CTRL + E</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnFirst, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Mover al <b>Primer</b> Registro <b>F5</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnPrev, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Mover al <b>Anterior</b> <b>F6</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnNext, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Mover al <b>Siguiente</b> <b>F7</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnLast, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Mover al <b>Último</b> Registro <b>F8</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnCancel, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "<b>Cancelar</b> Edición <b>F10</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnSave, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "<b>Guardar</b> Cambios <b>F9</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnEdit, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "<b>Editar</b> Registro <b>ESC</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnSearch, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "<b>Buscar</b> Registro <b>F3</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
        }

    }
    //Formularios heredados
    
    public class ClientesEdit : frmPlantillaDatos<Clientes>
    {
    }
     
    

}
