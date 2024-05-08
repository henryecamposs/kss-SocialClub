using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Layout;
using DevComponents.DotNetBar.Metro;
using kss_A_Ganador.Setting;
using ksslib;
using ksslib_c;
using ksslib_c.Enums;

namespace kss_A_Ganador.Forms.Plantillas
{
    public partial class dlgEditMultiple<TEntity> : DialogoOK
        where TEntity : class
    {
        #region Atributos
        protected TEntity EntityBase;
        public string _titulo = "";
        private System.Windows.Forms.Control[] ctrls;
        private bool esFormCargado = false;
        private ksslib.enuStatusRegistro _StatusEdicion;
        private bool esFormCancelarCierre = false;
        private int segundos;
        private string Titulo_MDIParent = "";
        private enuStatusRegistro _OriginalStatusEdicion;
        private bool esESC_pressed;
        private estFormEdit_Status _FormEditStatus;
        private bool esAccionCRUD_OK;
        private System.Windows.Forms.Form.ControlCollection _ControlesSoloLectura;

        //Privilegios
        private bool esPrivilegioCRUD_Modificar;
        private bool esPrivilegioCRUD_Agregar;
        private bool esPrivilegioCRUD_Eliminar;
        private bool esPrivilegioCRUD_Listar;

        //internal PanelEx panelTop;
        internal LayoutControl laycDatos;

        //Datos 
        internal string PrimaryKeyColumnName;
        internal kssEF61Datos.UnitOFWork.UnitOfWork _unitOfWorkBase;
        private GenericRepository<TEntity> adapterBase;

        #region Propiedades

        /// <summary>
        /// Adaptador de Datos Principal
        /// </summary>
        public GenericRepository<TEntity> AdapterBase { get { return adapterBase; } set { adapterBase = value; } }

        /// <summary>
        /// Tabla que contiene los registros principales del formulario enlazado
        /// </summary>
        public string tablaAuxiliarPpal { get; set; }

        /// <summary>
        /// Estado del registro Actual
        /// </summary>
        public ksslib.enuStatusRegistro StatusEdicion
        {
            get
            { return _StatusEdicion; }
            set
            {
                _OriginalStatusEdicion = _StatusEdicion;
                _StatusEdicion = value;
                if (_OriginalStatusEdicion != _StatusEdicion)
                    OnStatusEdicionCambiado();
            }
        }

        /// <summary>
        /// Opcionescde Carga del Formulario
        /// </summary>
        public estFormEdit_Status FormEditStatus
        {
            get { return _FormEditStatus; }
            set { _FormEditStatus = value; }
        }
        public string Titulo
        {
            get { return _titulo; }
            set
            {
                _titulo = value; panelTop.Text = string.Format(panelTop.Text, _titulo);
                Text = _titulo;
            }
        }
        #endregion propiedades

        #endregion Atributos

        private void newClass()
        {
            InitializeComponent();
            ksslib.clsUtilForms _clsUtilForm = new ksslib.clsUtilForms(this);
            base.MouseMove += _clsUtilForm.Me_MouseMove;
            base.MouseDown += _clsUtilForm.Me_MouseDown;
            this.panelTop.MouseMove += _clsUtilForm.Me_MouseMove;
            this.panelTop.MouseDown += _clsUtilForm.Me_MouseDown;
            _unitOfWorkBase = new UnitOfWork();
            BindingSource_PPAL.Position = 0;
            tablaAuxiliarPpal = typeof(TEntity).Name;

        }
        public dlgEditMultiple()
        {
            newClass();
        }
        public dlgEditMultiple(bool editMultiple)
        {
            newClass();
            esEditMultiple = editMultiple;
        }


        private void dlgEditMultiple_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            asignarToolTipsCtrl();
            if (appMain.DatosSesionActual != null)
            {
                //TODO: Corregir Programacion
                ctrls = ksslib_c.clsUtil_Controles.ListaControlesContenedor(laycDatos, ref ctrls);
                if (ctrls != null)
                {
                    ksslib_c.clsUtil_Strings.estiloControles_LoadForm(ctrls);
                    ksslib_c.clsUtil_Strings.formatoControles(ctrls);
                    AgregarEventosControlesEdicion();
                }
                asignarToolTipsCtrl();
                //Activa privilegios CRUD
                if (appMain.DatosSesionActual.unitOfWork.Usuarios_GrupoEntityAdapter != null)
                    if (appMain.DatosSesionActual.unitOfWork.Usuarios_GrupoEntityAdapter.Current != null)
                    {
                        esPrivilegioCRUD_Agregar = (bool)appMain.DatosSesionActual.unitOfWork.Usuarios_GrupoEntityAdapter.Current.esAgregar;
                        esPrivilegioCRUD_Modificar = esPrivilegioCRUD_Agregar ? esPrivilegioCRUD_Agregar : (bool)appMain.DatosSesionActual.unitOfWork.Usuarios_GrupoEntityAdapter.Current.esModificar;
                        esPrivilegioCRUD_Eliminar = (bool)appMain.DatosSesionActual.unitOfWork.Usuarios_GrupoEntityAdapter.Current.esEliminar;
                        esPrivilegioCRUD_Listar = (bool)appMain.DatosSesionActual.unitOfWork.Usuarios_GrupoEntityAdapter.Current.esListar;
                    }
                    else
                    {
                        esPrivilegioCRUD_Modificar = true;
                        esPrivilegioCRUD_Agregar = true;
                        esPrivilegioCRUD_Eliminar = true;
                        esPrivilegioCRUD_Listar = true;
                    }
            }
            // TODO:Crear Evento Para cambios de la Columna
            // Datos.DS_ppal.ColumnaEditada += dsPosadasINN_ColumnaEditada;
            this.Hide();
        }

        internal void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        #region Eventos Datos

        public delegate void statusEdicionCambiado_EventHandler(object sender, statusEdicionCambiadoEventArgs<TEntity> e);

        public event statusEdicionCambiado_EventHandler statusEdicionCambiado;
        protected virtual void OnStatusEdicionCambiado()
        {
            if (statusEdicionCambiado != null)
                if (BindingSource_PPAL.Current != null)
                    statusEdicionCambiado(this, new statusEdicionCambiadoEventArgs<TEntity>((TEntity)BindingSource_PPAL.Current, StatusEdicion));
            statusEdicion_Changed();
        }

        /// <summary>
        /// Muesta Mensaje emergente sobre Estado del Registro
        /// </summary>
        /// <param name="Msj">Estado del Registro</param>
        private void MostrarMsjStatus(string Msj)
        {
            //Muestra un MSJ Delayed
            ToastNotification.Show(this,
               Msj, null,
               500,
               eToastGlowColor.Blue,
               eToastPosition.TopRight);
        }

        /// <summary>
        /// Evento generado cuando un Registro Cambia de Estado.
        /// </summary>
        private void statusEdicion_Changed()
        {
            esFormCancelarCierre = false;
            if (!EsSoloConsulta)
                MostrarMsjStatus(StatusEdicion.Description().ToString());

            switch (StatusEdicion)
            {
                case ksslib.enuStatusRegistro.Editando:
                    if (!EsSoloConsulta)
                        activarBtns_Edicion(true);
                    break;
                case ksslib.enuStatusRegistro.Agregando:
                    activarBtns_Edicion(true);
                    break;
                case ksslib.enuStatusRegistro.Cargando:
                case ksslib.enuStatusRegistro.Eliminando:
                case ksslib.enuStatusRegistro.Modificando:
                    if (StatusEdicion == enuStatusRegistro.Cargando)
                        panelBusqueda.Visible = false;

                    activarBtns_Edicion(false);
                    break;
                case ksslib.enuStatusRegistro.Actualizacion_Rechazada:
                    Application.DoEvents();
                    ksslib.kss_msjDelay.Show(StatusEdicion.Description().ToString(), ksslib.enuMsgBoxImag.msgInformacion, SegundosMostrar: .5);
                    break;
                case ksslib.enuStatusRegistro.Cancelando:
                case ksslib.enuStatusRegistro.Datos_actualizados:
                    if (_OriginalStatusEdicion == enuStatusRegistro.Editando || _OriginalStatusEdicion == enuStatusRegistro.Agregando)
                        ksslib.kss_msjDelay.Show(StatusEdicion.Description().ToString(), ksslib.enuMsgBoxImag.msgInformacion, SegundosMostrar: .5);
                    activarBtns_Edicion(false);
                    break;
                case ksslib.enuStatusRegistro.Moviendo_first:
                case ksslib.enuStatusRegistro.Moviendo_last:
                case ksslib.enuStatusRegistro.Moviendo_next:
                case ksslib.enuStatusRegistro.Moviendo_previous:
                    break;
                case enuStatusRegistro.Registro_Agregado:
                    StatusEdicion = enuStatusRegistro.Editando;
                    break;
                case enuStatusRegistro.Registro_Eliminado:
                    break;
            };

        }

        /// <summary>
        /// Actualizar datos del registro actual
        /// </summary>
        /// <param name="row"></param>
        private void Actualizar_FormEditStatus(TEntity row)
        {
            foreach (ColumnsHelper col in adapterBase.CustomColumns)
            {
                if (_FormEditStatus.campoIDAuto == null ? true : false)
                    if (col.esPrimaryKey)
                        _FormEditStatus.campoIDAuto = col.ColumnName;

                if (_FormEditStatus.campoDescripcionPpal == null ? true : false)
                    if (col.esDescripcionColumn)
                        _FormEditStatus.campoDescripcionPpal = col.ColumnName;

                if (_FormEditStatus.campoCodigoPpal == null ? true : false)
                    if (col.esPrimaryKey)
                        _FormEditStatus.campoCodigoPpal = col.ColumnName;
            }
            if (_FormEditStatus.campoCodigoPpal != null)
                _FormEditStatus.valorCodigoPpal = EntityKeyHelper.GetValueColumn(AdapterBase.Current, FormEditStatus.campoCodigoPpal);

            if (_FormEditStatus.campoDescripcionPpal != null)
                _FormEditStatus.valorCampoPpal = EntityKeyHelper.GetValueColumn(AdapterBase.Current, FormEditStatus.campoDescripcionPpal).ToString();

            if (_FormEditStatus.campoIDAuto != null)
                _FormEditStatus.valorIDAuto = (long?)EntityKeyHelper.GetValueColumn(AdapterBase.Current, FormEditStatus.campoCodigoPpal);

            this.Tag = FormEditStatus;
        }

        #endregion Eventos Datos

        #region Modo Edicion CRUD

        #region Metodos Personalizados

        /// <summary>
        /// Evento que Comprueba los Privilegios CRUD del usuario Actual
        /// </summary>
        /// <param name="sender"></param>
        private void ComprobarPrivilegiosCRUD(object sender = null)
        {
            if (sender != null)
            {
                dynamic btn = sender;
                string Name = btn.Name;
                switch (Name)
                {
                    case "BN_eliminar":
                        btn.Visible = esPrivilegioCRUD_Eliminar;
                        break;
                    case "BN_Nuevo":
                        btn.Visible = esPrivilegioCRUD_Agregar;
                        break;
                    case "btnGuardar":
                    case "btnCancelar":
                        btn.Visible = esPrivilegioCRUD_Modificar;
                        break;
                    case "ts_anterior":
                    case "ts_primero":
                    case "ts_siguiente":
                    case "ts_ultimo":
                        btn.Visible = esPrivilegioCRUD_Listar;
                        break;
                }
            }
            else
            {
                btnDatosPPAL_Del.Visible = esPrivilegioCRUD_Eliminar;
                btnDatosPPAL_Add.Visible = esPrivilegioCRUD_Agregar;
                btnGuardar.Visible = esPrivilegioCRUD_Modificar;
                btnCancelar.Visible = esPrivilegioCRUD_Modificar;
                btnEncPrev.Visible = esPrivilegioCRUD_Listar;
                btnEncFirst.Visible = esPrivilegioCRUD_Listar;
                btnEncNext.Visible = esPrivilegioCRUD_Listar;
                btnEncLast.Visible = esPrivilegioCRUD_Listar;
            }

        }

        /// <summary>
        /// Verifica si todos los datos cumplen los requisitos para actualizarse.
        /// </summary>
        /// <returns></returns>
        private bool requisitosActualizacionCompletos()
        {
            try
            {
                if (BindingSource_PPAL.Current != null)
                {
                    TEntity row = (TEntity)BindingSource_PPAL.Current;
                    foreach (ColumnsHelper col in AdapterBase.CustomColumns)
                    {
                        Control ctl = (Control)ksslib.clsUtilControles.buscarControlEnlazado(ctrls, col.ColumnName);
                        bool esCtlVisible = ctl != null ? (ctl.Visible ? true : false) : false;
                        string msg = "";
                        if (!col.ColumnName.Equals(PrimaryKeyColumnName) && esCtlVisible && !col.esNulleableColumn)
                        {
                            switch (col.TypeColumn.Name)
                            {
                                case "System.String":
                                    //TODO:Reparar
                                    //if (string.IsNullOrEmpty(row[col.Name].ToString().Trim()) && !col.Nullable)
                                    //{
                                    //    //TODO: Crear Control de error en Columna
                                    //    // msg = row.GetColumnError(col).ToString().Length > 0 ? row.GetColumnError(col).ToString() : "Debe especificar un valor";
                                    //    row.SetColumnError(col.Name, msg);
                                    //}
                                    break;
                                case "System.Int16":
                                case "System.Int32":
                                case "System.Int64":
                                    if (ctl.GetType().Name == "ComboBoxEx" || ctl.GetType().Name == "ComboBox")
                                    {
                                        bool esTieneItems = false;
                                        switch (ctl.GetType().Name)
                                        {
                                            case "ComboBoxEx":
                                                DevComponents.DotNetBar.Controls.ComboBoxEx cmbX = (DevComponents.DotNetBar.Controls.ComboBoxEx)ctl;
                                                esTieneItems = cmbX.Items.Count > 0 ? true : false;
                                                break;
                                            case "ComboBox":
                                                System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)ctl;
                                                esTieneItems = cmb.Items.Count > 0 ? true : false;
                                                break;
                                        }
                                        if (
                                            col.ColumnName.ToUpper().Substring(0, 3) == "ID_" &&
                                            ctl != null &&
                                            !col.esNulleableColumn &&
                                            !esTieneItems
                                            )
                                        {
                                            msg = "Debe Crear registros en la tabla Auxiliar relacionada";
                                            //Crear Control error en Columna
                                            //row.SetColumnError(col.Nullable, msg);
                                            errorProvider1.SetError(ctl, msg);
                                            ctl.Focus();
                                            return false;
                                        }
                                        else
                                        {
                                            //TODO: Codigo Para leer Propiedades
                                            errorProvider1.SetError(ctl, "");
                                            //row.ClearErrors();
                                        }
                                    }
                                    //TODO: Codigo Para leer Propiedades
                                    //if (row[col.Name] == System.DBNull.Value)
                                    //{
                                    //    //TODO: Crear Control de error en Columna
                                    //    // msg = (string)row.GetColumnError(col).ToString();
                                    //    row.SetColumnError(col.Name, msg);
                                    //}
                                    break;
                                case "system.boolean":
                                    break;
                            }
                            //TODO: Codigo Para leer Propiedades
                            //if (row.HasErrors)
                            //{
                            //    errorProvider1.SetError(ctl, msg);
                            //    ctl.Focus();
                            //    return false;
                            //}
                            //else
                            //    if (ctl != null)
                            //    errorProvider1.SetError(ctl, "");
                        }
                        else
                        {
                            //TODO: Codigo Para leer Propiedades
                            //if (col.TypeName == "System.String")
                            //    if (string.IsNullOrEmpty(row[col.Name].ToString().Trim()) && col.Nullable)
                            //        row[col.Name] += "";
                        }

                    }

                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                ksslib.clsUtilErrors.Manejador_errores(ex);
                return false;
            }
        }

        /// <summary>
        /// Establace los controles enlazados a Solo lectura
        /// </summary>
        /// <param name="esSoloLectura"></param>
        private void ControlesSoloLectura(bool esSoloLectura = true)
        {
            if (ctrls != null)
                foreach (Control ctl in ctrls)
                {
                    switch (ctl.GetType().ToString())
                    {
                        case "System.Windows.Forms.TextBox":
                        case "DevComponents.DotNetBar.Controls.TextBoxX":
                            System.Windows.Forms.TextBox txtBox = (System.Windows.Forms.TextBox)ctl;
                            txtBox.ReadOnly = esSoloLectura;
                            break;
                        case "DevComponents.DotNetBar.Controls.ComboBoxEx":
                        case "System.Windows.Forms.ComboBox":
                            ComboBox cmbBox = (ComboBox)ctl;
                            cmbBox.Enabled = !esSoloLectura;
                            break;
                        case "System.Windows.Forms.RadioButton":
                            System.Windows.Forms.RadioButton OptionControlRadio = (System.Windows.Forms.RadioButton)ctl;
                            OptionControlRadio.Enabled = !esSoloLectura;
                            break;
                        case "System.Windows.Forms.CheckBox":
                            System.Windows.Forms.CheckBox OptionControl = (System.Windows.Forms.CheckBox)ctl;
                            OptionControl.Enabled = !esSoloLectura;
                            break;
                        case "DevComponents.DotNetBar.Controls.SwitchButton":
                            DevComponents.DotNetBar.Controls.SwitchButton switchButton1 = (DevComponents.DotNetBar.Controls.SwitchButton)ctl;
                            switchButton1.Enabled = !esSoloLectura;
                            break;
                        case "DevComponents.DotNetBar.ButtonX":
                            DevComponents.DotNetBar.ButtonX buttonx = (DevComponents.DotNetBar.ButtonX)ctl;
                            buttonx.Enabled = !esSoloLectura;
                            break;
                        case "System.Windows.Forms.Button":
                            System.Windows.Forms.Button button = (System.Windows.Forms.Button)ctl;
                            button.Enabled = !esSoloLectura;
                            break;
                    }
                }
        }

        /// <summary>
        /// Activa los Botones Mantenimientos (Agregar, Cancelar)
        /// </summary>
        /// <param name="esActivar"></param>
        private void activarBtns_Edicion(bool esActivar = true)
        {

            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            btnDatosPPAL_Add.Visible = true;
            btnDatosPPAL_Del.Visible = true;
            btnEncPrev.Visible = true;
            btnEncFirst.Visible = true;
            btnEncNext.Visible = true;
            btnEncLast.Visible = true;

            this.btnGuardar.Enabled = esActivar;
            this.btnCancelar.Enabled = esActivar;
            bnDatosPPAL.Enabled = (!esActivar);
            //Modo privilegios

            //Modo de carga de form
            switch (_FormEditStatus.enuAccionCarga)
            {
                case enuFormEditAccionCarga.Modo_Edicion:

                    break;
                case enuFormEditAccionCarga.Consulta:
                case enuFormEditAccionCarga.Modo_Seleccionar:
                    btnGuardar.Visible = false;
                    btnCancelar.Visible = false;
                    bnDatosPPAL.Visible = false;
                    break;
                case enuFormEditAccionCarga.Modo_Consulta:
                case enuFormEditAccionCarga.Buscar:
                case enuFormEditAccionCarga.Seleccionar:
                    btnGuardar.Visible = false;
                    btnCancelar.Visible = false;
                    btnDatosPPAL_Add.Visible = false;
                    btnDatosPPAL_Del.Visible = false;
                    bnDatosPPAL.Visible = true;
                    break;
                case enuFormEditAccionCarga.Agregar:
                    btnEncPrev.Visible = false;
                    btnEncFirst.Visible = false;
                    btnEncNext.Visible = false;
                    btnEncLast.Visible = false;
                    btnDatosPPAL_Del.Visible = false;
                    break;
                case enuFormEditAccionCarga.Editar:
                    bnDatosPPAL.Visible = false;
                    break;
                case enuFormEditAccionCarga.Eliminar:
                    btnEncPrev.Visible = false;
                    btnEncFirst.Visible = false;
                    btnEncNext.Visible = false;
                    btnEncLast.Visible = false;
                    btnGuardar.Visible = false;
                    btnCancelar.Visible = false;
                    btnDatosPPAL_Add.Visible = false;
                    btnDatosPPAL_Del.Visible = true;
                    bnDatosPPAL.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// Activar Botoned de Desplazamiento, Agregar y eliminar(CRUD)
        /// </summary>
        /// <param name="esActivar"></param>
        private void activarBtns_Desplazamiento(bool esActivar)
        {
            btnEncFirst.Visible = esActivar;
            btnEncPrev.Visible = esActivar;
            btnEncNext.Visible = esActivar;
            btnEncLast.Visible = esActivar;
        }

        /// <summary>
        /// Verifica si la Tabla tiene Registros, o en su defecto le pasa el numero de filas que posee
        /// </summary>
        /// <param name="filas">Numero de filas de la tabla en la Base de Datos</param>
        /// <returns></returns>
        public bool esTablaConRegistros()
        {
            if (tablaAuxiliarPpal != null)
                if (this.BindingSource_PPAL.Count == 0)
                    switch (_FormEditStatus.enuAccionCarga)
                    {
                        case enuFormEditAccionCarga.Agregar:
                        case enuFormEditAccionCarga.Seleccionar:
                        case enuFormEditAccionCarga.Modo_Edicion:
                            if (esPrivilegioCRUD_Agregar)
                            {
                                ksslib.kss_msjDelay.Show("No existen Registros.<br/>Se Agregará un Registro Nuevo.", ksslib.enuMsgBoxImag.msgRecomendacion, SegundosMostrar: 2);
                                btnsCRUD_Click(btnDatosPPAL_Add, new EventArgs());
                            }
                            else
                            {
                                ksslib.kss_msjDelay.Show("No existen Registros.", ksslib.enuMsgBoxImag.btnCancel, SegundosMostrar: 2);
                            }
                            return esAccionCRUD_OK;
                        case enuFormEditAccionCarga.Consulta:
                        case enuFormEditAccionCarga.Modo_Seleccionar:
                        case enuFormEditAccionCarga.Modo_Consulta:
                            ksslib.kss_msjDelay.Show("No existen Registros para mostrar", ksslib.enuMsgBoxImag.msgRecomendacion, SegundosMostrar: 2);
                            return false;
                        default:
                            return false;
                    }
                else
                    return true;
            else
                return false;
        }

        /// <summary>
        /// Agrega eventos a controles para controlar su funcionamiento
        /// </summary>
        private void AgregarEventosControlesEdicion()
        {
            try
            {
                foreach (Control ctl in ctrls)
                {
                    bool esctlEnlazado = (((System.Windows.Forms.Control)(ctl)).Parent).Name != "panelBusqueda" ? true : false;
                    switch (ctl.GetType().ToString())
                    {
                        case "System.Windows.Forms.RadioButton":
                            System.Windows.Forms.RadioButton OptionControlRadio = (System.Windows.Forms.RadioButton)ctl;
                            if (esctlEnlazado)
                                OptionControlRadio.CheckedChanged += new System.EventHandler(OptionControlRadio_ValueChanged);
                            break;
                        case "System.Windows.Forms.CheckBox":
                            System.Windows.Forms.CheckBox OptionControl = (System.Windows.Forms.CheckBox)ctl;
                            if (esctlEnlazado)
                                OptionControl.CheckedChanged += new System.EventHandler(OptionControl_ValueChanged);
                            break;
                        case "DevComponents.DotNetBar.Controls.SwitchButton":
                            DevComponents.DotNetBar.Controls.SwitchButton switchButton1 = (DevComponents.DotNetBar.Controls.SwitchButton)ctl;
                            if (esctlEnlazado)
                                switchButton1.ValueChanged += new System.EventHandler(switchButton1_ValueChanged);
                            break;
                        case "DevComponents.DotNetBar.Controls.ComboBoxEx":
                        case "System.Windows.Forms.ComboBox":
                            ComboBox cmbBox = (ComboBox)ctl;
                            if (esctlEnlazado)
                                cmbBox.SelectedIndexChanged += new System.EventHandler(ComboBoxEnlazado_SelectedIndexChanged);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ksslib.clsUtilErrors.Manejador_errores(ex);
            }
        }
        #endregion

        #region Eventos Controles de edicion

        /// <summary>
        /// Eventos para botones que controlan la edición y desplazamiento de los registos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsCRUD_Click(System.Object sender, System.EventArgs e)
        {
            dynamic btn = sender;
            try
            {
                bool esContinuar = false;
                switch ((enuBtnsRegistro)Convert.ToInt16(btn.Tag))
                {
                    case enuBtnsRegistro.Primero:
                    case enuBtnsRegistro.Anterior:
                    case enuBtnsRegistro.Siguiente:
                    case enuBtnsRegistro.Ultimo:
                        if (StatusEdicion == ksslib.enuStatusRegistro.Editando | StatusEdicion == ksslib.enuStatusRegistro.Agregando)
                            btnsCRUD_Click(btnCancelar, new EventArgs());
                        break;
                }
                switch ((enuBtnsRegistro)Convert.ToInt16(btn.Tag))
                {
                    case enuBtnsRegistro.Primero:
                        StatusEdicion = ksslib.enuStatusRegistro.Moviendo_first;
                        break;
                    case enuBtnsRegistro.Anterior:
                        StatusEdicion = ksslib.enuStatusRegistro.Moviendo_previous;
                        break;
                    case enuBtnsRegistro.Siguiente:
                        StatusEdicion = ksslib.enuStatusRegistro.Moviendo_next;
                        break;
                    case enuBtnsRegistro.Ultimo:
                        StatusEdicion = ksslib.enuStatusRegistro.Moviendo_last;
                        break;
                    case enuBtnsRegistro.Agregar:
                        StatusEdicion = ksslib.enuStatusRegistro.Agregando;
                        if (StatusEdicion == enuStatusRegistro.Agregando)
                        {
                            BindingSource_PPAL.AddNew();
                            StatusEdicion = enuStatusRegistro.Registro_Agregado;
                        }
                        break;
                    case enuBtnsRegistro.Eliminar:
                        try
                        {
                            StatusEdicion = enuStatusRegistro.Eliminando;
                            if (ksslib.kss_msjDelay.Show("Se va a eliminar un Registro.<br/><b>¿Desea continuar?</b>", enuMsgBoxImag.msgAyuda, enuMsgBoxResult.msgYesNO, 7, StatusEdicion.Description()) == DialogResult.Yes)
                            {
                                bool esEliminar = true;
                                if (Convert.ToInt64(_FormEditStatus.CurrentRow[_FormEditStatus.campoIDAuto]) == 0)
                                {
                                    StatusEdicion = ksslib.enuStatusRegistro.Cancelando;
                                    ksslib.kss_msjDelay.Show("No se puede eliminar.<br/><b>REGISTRO DE SISTEMA</b>", ksslib.enuMsgBoxImag.msgCuidado, "Registro Protegido", 10);
                                    esEliminar = false;
                                }
                                else
                                {
                                    //Hay datos Relacionados
                                    if (_FormEditStatus.campoIDAuto.Length > 0)
                                    {
                                        //TODO: Crear Codigo para verificar si existen datos enlazados en otras tablas
                                        //DS_ppal.EnforceConstraints = false;
                                        //foreach (DataTable dt in this.DS_ppal.Tables)
                                        //    if (!dt.TableName.Equals(_FormEditStatus.CurrentRow.Table.TableName))
                                        //        if (dt.Columns.Contains(_FormEditStatus.campoIDAuto))
                                        //        {
                                        //            SQLiteConnection cnn = new SQLiteConnection(appMain.DatosSesionActual.ClsConfig.appCadenaConexionHostServer);
                                        //            SQLiteDataAdapter da = new SQLiteDataAdapter(
                                        //                new SQLiteCommand(string.Format("select {0} from {1} where {0}={2}", _FormEditStatus.campoIDAuto, dt.TableName, Convert.ToInt64(_FormEditStatus.CurrentRow[_FormEditStatus.campoIDAuto])),
                                        //                    cnn));
                                        //            using (cnn)
                                        //            {
                                        //                SQLiteCommand cmmTablas = new SQLiteCommand(string.Format("SELECT name FROM sqlite_master WHERE TYPE = 'table' AND name='{0}' ", dt.TableName), cnn);
                                        //                cnn.Open();
                                        //                if (cmmTablas.ExecuteNonQuery() > 0)
                                        //                    if (da.Fill(DS_ppal.Tables[dt.TableName]) > 0)
                                        //                    {
                                        //                        DS_ppal.Tables[dt.TableName].Clear();
                                        //                        esEliminar = false;
                                        //                        break;
                                        //                    }
                                        //                cmmTablas = null;
                                        //            }
                                        //            cnn = null;
                                        //            da = null;
                                        //        }
                                    }
                                    else
                                    {
                                        esEliminar = true;
                                    }
                                    if (esEliminar)
                                    {
                                        StatusEdicion = ksslib.enuStatusRegistro.Eliminando;
                                        if (StatusEdicion == enuStatusRegistro.Eliminando)
                                        {
                                            BindingSource_PPAL.RemoveCurrent();
                                            StatusEdicion = enuStatusRegistro.Registro_Eliminado;
                                            this.BindingSource_PPAL.EndEdit();
                                            //TODO: Actualizar todo

                                            //Si es el ultimo registro Cerrar
                                            if (BindingSource_PPAL.Count == 0)
                                            {
                                                if (kss_msjDelay.Show("Ha Eliminado el último Registro.<br /><b>¿Desea cerrar el Archivo?</b>", enuMsgBoxImag.msgAyuda, enuMsgBoxResult.msgYesNO, 5, "No existen Registros") == System.Windows.Forms.DialogResult.Yes)
                                                    btnCerrar_click(btnClose, new EventArgs());
                                            }
                                            StatusEdicion = ksslib.enuStatusRegistro.Registro_Eliminado;
                                        }
                                    }
                                    else
                                    {
                                        StatusEdicion = ksslib.enuStatusRegistro.Cancelando;
                                        ksslib.kss_msjDelay.Show("No se puede eliminar.<br/><b>REGISTRO CON MOVIMIENTOS</b>", ksslib.enuMsgBoxImag.btnCancel, "Registro con Movimientos", 10);
                                    }
                                }
                            }
                            else
                            {
                                StatusEdicion = ksslib.enuStatusRegistro.Cancelando;
                                this.BindingSource_PPAL.CancelEdit();
                            }
                        }
                        catch (Exception ex)
                        {
                            clsUtilErrors.Manejador_errores(ex);
                            throw;
                        }
                        finally
                        {
                            //Instruciones Finales
                        }
                        break;
                    case enuBtnsRegistro.Guardar:
                        Cursor tmp = this.Cursor;
                        try
                        {
                            Cursor = Cursors.WaitCursor;
                            StatusEdicion = ksslib.enuStatusRegistro.Actualizando;
                            if (StatusEdicion == enuStatusRegistro.Actualizacion_Rechazada)
                                btnsCRUD_Click(btnClose, new EventArgs());
                            else
                            {
                                esContinuar = requisitosActualizacionCompletos();
                                if (!esContinuar)
                                    break;
                                else
                                {
                                    //TODO VErificar si tienes Errores la Entity
                                    //DataRow row = ((System.Data.DataRowView)BindingSource_PPAL.Current).Row;
                                    //esContinuar = !row.HasErrors;
                                }
                                if (esContinuar)
                                {
                                    this.Validate();
                                    this.BindingSource_PPAL.EndEdit();
                                    //TODO:Activar para actualizar registros
                                    StatusEdicion = ksslib.enuStatusRegistro.Datos_actualizados;
                                }
                                else
                                    StatusEdicion = ksslib.enuStatusRegistro.Actualizacion_Rechazada;
                            }
                        }
                        catch (Exception ex)
                        {
                            clsUtilErrors.Manejador_errores(ex);
                            throw;
                        }
                        finally
                        {
                            this.Cursor = tmp;
                        }
                        break;
                    case enuBtnsRegistro.Cancelar:
                        BindingSource_PPAL.CancelEdit();

                        StatusEdicion = ksslib.enuStatusRegistro.Cancelando;
                        break;
                }
                esAccionCRUD_OK = true;

                if (BindingSource_PPAL.Count == 0)
                    ControlesSoloLectura();
                else
                    if (!this.EsSoloConsulta)
                    ControlesSoloLectura(false);
            }
            catch (Exception ex)
            {
                switch ((enuBtnsRegistro)Convert.ToInt32(btn.Tag))
                {
                    case enuBtnsRegistro.Primero:
                    case enuBtnsRegistro.Anterior:
                    case enuBtnsRegistro.Siguiente:
                    case enuBtnsRegistro.Ultimo:
                        break;
                    case enuBtnsRegistro.Agregar:
                    case enuBtnsRegistro.Eliminar:
                        StatusEdicion = ksslib.enuStatusRegistro.Actualizacion_Rechazada;
                        break;
                    case enuBtnsRegistro.Guardar:
                        StatusEdicion = ksslib.enuStatusRegistro.Actualizacion_Rechazada;
                        BindingSource_PPAL.CancelEdit();
                        break;
                    case enuBtnsRegistro.Cancelar:
                        break;
                }
                clsUtilErrors.Manejador_errores(ex);
                esAccionCRUD_OK = false;
            }
            finally
            {
            }
        }

        /// <summary>
        /// Comprueba privilegios  para visibilidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsCRUD_VisibleChanged(object sender, EventArgs e)
        {
            dynamic btn = sender;
            if (btn.Visible)
                switch (sender.GetType().Name)
                {
                    case "ToolStripButton":
                        ToolStripButton ts = (ToolStripButton)sender;
                        ComprobarPrivilegiosCRUD(btn);
                        break;
                    case "ButtonX":
                        ButtonX btnX = (ButtonX)sender;
                        ComprobarPrivilegiosCRUD(btnX);
                        break;
                }
        }

        /// <summary>
        /// Evento Para control enlazado RadioButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptionControlRadio_ValueChanged(object sender, EventArgs e)
        {
            RadioButton OptionControl = (RadioButton)sender;
            if (OptionControl.ContainsFocus)
                StatusEdicion = ksslib.enuStatusRegistro.Editando;
        }

        /// <summary>
        /// Evento para control enlazado OptionControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptionControl_ValueChanged(object sender, EventArgs e)
        {
            CheckBox OptionControl = (CheckBox)sender;
            if (OptionControl.ContainsFocus)
                StatusEdicion = ksslib.enuStatusRegistro.Editando;
        }

        /// <summary>
        /// Evento Control enlazado switchButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switchButton1_ValueChanged(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.Controls.SwitchButton switchButton1 = (DevComponents.DotNetBar.Controls.SwitchButton)sender;
            if (switchButton1.ContainsFocus)
                StatusEdicion = ksslib.enuStatusRegistro.Editando;
        }

        /// <summary>
        /// Evento control enlazado ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxEnlazado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmbBox = (ComboBox)sender;
            if (cmbBox.ContainsFocus)
                StatusEdicion = ksslib.enuStatusRegistro.Editando;
        }

        /// <summary>
        /// Evento BindingPpal Cambios Registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BindingSource_PPAL_CurrentChanged(object sender, EventArgs e)
        {
            if (BindingSource_PPAL.Current != null)
            {
                AdapterBase.Current = (TEntity)BindingSource_PPAL.Current;
                Actualizar_FormEditStatus((TEntity)BindingSource_PPAL.Current);
                ksslib_c.clsUtil_Strings.formatoControles(ctrls);
            }
            else
                activarBtns_Edicion(false);
        }

        /// <summary>
        /// Evento BindingPpal Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BindingSource_PPAL_AddingNew(object sender, System.ComponentModel.AddingNewEventArgs e)
        {
            activarBtns_Edicion(true);
        }

        /// <summary>
        /// Evento BindingPpal Posicion Cambiada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BindingSource_PPAL_PositionChanged(object sender, System.EventArgs e)
        {
            btnsCRUD_Click(btnCancelar, new EventArgs());
            activarBtns_Edicion(false);
        }

        #endregion Eventos Controles de edicion

        #endregion  Modo Edicion CRUD

        #region Modo Busqueda
        internal List<dynamic> drDatosEncontrados_Busqueda;
        string _criterio;
        BindingSource _bs;
        internal string campo_tabla;
        internal string Radio_btn_selected;
        internal bool es_BusquedaNumerica = false;
        private bool esRegistroEncontrado;
        private bool _esEditMultiple;

        public bool EsSoloConsulta
        {
            get; set;
        }
        public bool esEditMultiple
        {
            get { return _esEditMultiple; }
            private set
            {
                _esEditMultiple = value;
                bnDatosPPAL.Visible = !value;
                panelBusqueda.Visible = !value;
            }
        }


        #region Eventos

        private void tsl_criterio_TextChanged(object sender, System.EventArgs e)
        {
            if (esFormCargado)
                if (!(_criterio == lblDatosEnc_Status.Text))
                {
                    _criterio = "{" + lblDatosEnc_Status.Text + "}";
                    lblDatosEnc_Status.Text = _criterio;
                }
        }

        private void txt_valor1_GotFocus(object sender, System.EventArgs e)
        {
            txtFind.BackColor = Color.LightCoral;
        }

        private void txtFind_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (es_BusquedaNumerica)
            {
                //solo numeros
                if (char.IsDigit(e.KeyChar))
                    e.Handled = false;
                else if (char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void txtFind_LostFocus(object sender, System.EventArgs e)
        {
            txtFind.BackColor = Color.White;
        }

        private void Buscar_BindingNavigator_positionChanged(System.Object sender, System.EventArgs e)
        {
            //posicionar el binding source al registro encontrado
            if (drDatosEncontrados_Busqueda.Count > 0)
            {
                TEntity row = (TEntity)drDatosEncontrados_Busqueda[this.bnEncontrados.BindingSource.Position];
                //TODO: Crear codigo busqueda en Enitty
                //int itemFound = BindingSource_PPAL.Find(_FormEditStatus.campoIDAuto,row.);
                //BindingSource_PPAL.Position = itemFound;
                ksslib_c.clsUtil_Strings.formatoControles(ctrls);
            }
        }

        private void btnFind_click(System.Object sender, System.EventArgs e)
        {
            try
            {
                esRegistroEncontrado = false;
                if (txtFind.Text.Length > 0 && tablaAuxiliarPpal != null)
                    if (this.BindingSource_PPAL.Count > 0)
                    {
                        btnsCRUD_Click(btnCancelar, new EventArgs());
                        if (esAccionCRUD_OK)
                        {
                            StatusEdicion = ksslib.enuStatusRegistro.Buscando_Registro;
                            string criterio = this.txtFind.Text;
                            drDatosEncontrados_Busqueda = (List<dynamic>)BindingSource_PPAL.List; // (campo_tabla + filtroBusqueda(es_BusquedaNumerica));
                            if (drDatosEncontrados_Busqueda != null)
                            {
                                bnEncontrados.Visible = true;
                                bnEncontrados.BindingSource.DataSource = drDatosEncontrados_Busqueda;
                                lblDatosEnc_Status.Text = Radio_btn_selected + " " + this.cmbBusqueda.Text + " '" + txtFind.Text + "'";
                                if (drDatosEncontrados_Busqueda.Count > 0)
                                {
                                    this.bnEncontrados.BindingSource.PositionChanged += new System.EventHandler(this.Buscar_BindingNavigator_positionChanged);
                                    Buscar_BindingNavigator_positionChanged(sender, e);
                                    esRegistroEncontrado = true;
                                    return;
                                }
                                else
                                {
                                    kss_msjDelay.Show("No se encontraron registros.", enuMsgBoxImag.msgBuscar, SegundosMostrar: 3);
                                    this.bnEncontrados.BindingSource.PositionChanged -= new System.EventHandler(this.Buscar_BindingNavigator_positionChanged);
                                    return;
                                }
                            }
                            else
                            {
                                bnEncontrados.BindingSource.DataSource = null;
                                return;
                            }
                        }
                    }
                    else
                    {
                        bnEncontrados.Visible = esRegistroEncontrado;
                        return;
                    }
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
                throw;
            }
            finally
            {
                //Instruciones Finales

            }
        }

        private void chkFind_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            RadioButton _radiobuton = (RadioButton)sender;
            if (_radiobuton.Checked)
            {
                campo_tabla = _radiobuton.Tag.ToString();
                Radio_btn_selected = _radiobuton.Text;
                txtFind.Text = "";
                txtFind.Focus();
                var property = AdapterBase.EdmColumns
                .FirstOrDefault(p => p.Name.Equals(campo_tabla));
                if (property != null)
                    switch (property.TypeName.ToLower())
                    {
                        case "system.single":
                        case "system.int64":
                        case "system.int32":
                        case "system.double":
                            es_BusquedaNumerica = true;
                            break;
                        case "system.string":
                            es_BusquedaNumerica = false;
                            break;
                        case "system.boolean":
                            break;
                    }
                switch (es_BusquedaNumerica)
                {
                    case true:
                        cmbBusqueda.Items.Clear();
                        cmbBusqueda.Items.Add(ksslib.enuCriteriosBusqueda.es_igual_a.Description());
                        cmbBusqueda.Items.Add(ksslib.enuCriteriosBusqueda.es_distinto_a.Description());
                        //.Items.Add(ksslib.enuCriteriosBusqueda.contiene.Description)
                        //.Items.Add(ksslib.enuCriteriosBusqueda.no_contiene.Description)
                        //.Items.Add(ksslib.enuCriteriosBusqueda.empieza_con.Description)
                        //.Items.Add(ksslib.enuCriteriosBusqueda.termina_con.Description)
                        cmbBusqueda.Items.Add(ksslib.enuCriteriosBusqueda.mayor_que.Description());
                        cmbBusqueda.Items.Add(ksslib.enuCriteriosBusqueda.menor_que.Description());
                        //.Items.Add(ksslib.enuCriteriosBusqueda.entre.Description)
                        cmbBusqueda.SelectedIndex = 0;
                        cmbBusqueda.Refresh();
                        break;
                    case false:
                        cmbBusqueda.Items.Clear();
                        cmbBusqueda.Items.Add(ksslib.enuCriteriosBusqueda.es_igual_a.Description());
                        //.Items.Add(ksslib.enuCriteriosBusqueda.es_distinto_a.Description)
                        cmbBusqueda.Items.Add(ksslib.enuCriteriosBusqueda.contiene.Description());
                        //_with2.Items.Add(ksslib.enuCriteriosBusqueda.no_contiene.Description());
                        cmbBusqueda.Items.Add(ksslib.enuCriteriosBusqueda.empieza_con.Description());
                        cmbBusqueda.Items.Add(ksslib.enuCriteriosBusqueda.termina_con.Description());
                        //.Items.Add(ksslib.enuCriteriosBusqueda.mayor_que.Description)
                        //.Items.Add(ksslib.enuCriteriosBusqueda.menor_que.Description)
                        //.Items.Add(ksslib.enuCriteriosBusqueda.entre.Description)
                        cmbBusqueda.SelectedIndex = 2;
                        cmbBusqueda.Refresh();
                        break;
                }
            }
        }

        private void Buscar_BindingNavigator_VisibleChanged(object sender, EventArgs e)
        {
            panelBusqueda.Height = bnEncontrados.Visible ? panelBusqueda.Height + bnEncontrados.Height : panelBusqueda.Height - bnEncontrados.Height;
            panelBusqueda.Visible = true;
        }

        #endregion

        internal string filtroBusqueda(bool esNumero = false)
        {
            string functionReturnValue = null;
            string valor1 = this.txtFind.Text.Trim();
            functionReturnValue = "";
            if (this.cmbBusqueda.SelectedItem.Equals(ksslib.enuCriteriosBusqueda.es_igual_a.Description()))
            {
                functionReturnValue = (esNumero ? "=" + valor1 : " like '" + valor1 + "'");
            }
            else if (this.cmbBusqueda.SelectedItem.Equals(ksslib.enuCriteriosBusqueda.es_distinto_a.Description()))
            {
                functionReturnValue = (esNumero ? "<>" + valor1 : " like not '" + valor1 + "'");
            }
            else if (this.cmbBusqueda.SelectedItem.Equals(ksslib.enuCriteriosBusqueda.contiene.Description()))
            {
                functionReturnValue = (esNumero ? ">=" + valor1 : " like '%" + valor1 + "%'");
            }
            else if (this.cmbBusqueda.SelectedItem.Equals(ksslib.enuCriteriosBusqueda.no_contiene.Description()))
            {
                functionReturnValue = (esNumero ? "<>" + valor1 : " like not '%" + valor1 + "%'");
            }
            else if (this.cmbBusqueda.SelectedItem.Equals(ksslib.enuCriteriosBusqueda.empieza_con.Description()))
            {
                functionReturnValue = (esNumero ? "=" + valor1 : " like '" + valor1 + "%'");
            }
            else if (this.cmbBusqueda.SelectedItem.Equals(ksslib.enuCriteriosBusqueda.termina_con.Description()))
            {
                functionReturnValue = (esNumero ? "<=" + valor1 : " like '%" + valor1 + "'");
            }
            else if (this.cmbBusqueda.SelectedItem.Equals(ksslib.enuCriteriosBusqueda.mayor_que.Description()))
            {
                functionReturnValue = (esNumero ? ">" + valor1 : " like '" + valor1 + "%'");
            }
            else if (this.cmbBusqueda.SelectedItem.Equals(ksslib.enuCriteriosBusqueda.menor_que.Description()))
            {
                functionReturnValue = (esNumero ? "<" + valor1 : " like '%" + valor1 + "'");
            }
            else if (this.cmbBusqueda.SelectedItem.Equals(ksslib.enuCriteriosBusqueda.entre.Description()))
            {

            }
            return functionReturnValue;
        }

        //#endregion

        #region cargar Form Auxiliar ComboBox

        /// <summary>
        /// Ordena Las columnas de la tabla utilizada para rellenar el ComboBox
        /// </summary>
        /// <param name="ExprSort"></param>
        /// <param name="Tabla"></param>
        /// <param name="Binding"></param>
        public void OrdenarAuxiliar(string ExprSort, dynamic Tabla, BindingSource Binding)
        {
            System.Data.DataTable dTable = Tabla;
            System.Data.DataView view1 = dTable.DefaultView;
            view1.Sort = ExprSort;
            Binding.DataSource = view1;
        }

        /// <summary>
        /// Cargar formulario auxiliar desde un Combobox para agregar datos
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="cmb"></param>
        /// <param name="EntityAdapter"></param>
        /// <param name="Tabla"></param>
        public void CargarAuxiliar(Form frm, ComboBox cmb, dynamic EntityAdapter, dynamic Tabla)
        {
            if (ksslib.clsUtiles.cargarForm(frm, ksslib.enuTipoForm.Dialogo_Modal) == System.Windows.Forms.DialogResult.OK)
            {
                EntityAdapter.Fill(Tabla);
                cmb.SelectedValue = (long)((System.Data.DataRow)frm.Tag)[((System.Windows.Forms.ListControl)(cmb)).ValueMember.ToString()];
                cmb.Focus();
            }
        }

        #endregion cargar Form Auxiliar ComboBox

        #region Formulario

        #region Metodos

        #region  Modo Carga de Formulario

        /// <summary>
        /// Carga en Modo Seleccionar registro actual.
        /// </summary>
        /// <param name="CampoIDAuto">Nombre del Campo ID</param>
        /// <param name="ValorIDAuto">Valor del Campo ID</param>
        /// <returns></returns>
        private bool CargarModoSeleccionarRegistro(string CampoIDAuto = "", string ValorIDAuto = "")
        {
            bool Result = false;
            try
            {
                this.panelBusqueda.Visible = false;
                CampoIDAuto = FormEditStatus.campoIDAuto == null ? CampoIDAuto : FormEditStatus.campoIDAuto;
                ValorIDAuto = FormEditStatus.valorIDAuto == null ? ValorIDAuto : FormEditStatus.valorIDAuto.ToString();
                return CargarModoBuscar(CampoIDAuto, ValorIDAuto);
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
                return Result;
                throw;
            }
            finally
            {
                //Instruciones Finales

            }

        }

        /// <summary>
        /// Cargar el Formulario en Modo busqueda
        /// </summary>
        /// <param name="CampoBusqueda">Nombre del Campo de busqueda</param>
        /// <param name="valorBusqueda">Valor de la Busqueda</param>
        /// <returns></returns>
        private bool CargarModoBuscar(string CampoBusqueda = "", string valorBusqueda = "")
        {
            bool Result = false;
            try
            {
                if (Result = CargarModoEdicion())
                {
                    CampoBusqueda = FormEditStatus.CampoBusqueda == null ? CampoBusqueda : FormEditStatus.CampoBusqueda;
                    valorBusqueda = FormEditStatus.ValorBusqueda == null ? valorBusqueda : FormEditStatus.ValorBusqueda;
                    if (tablaAuxiliarPpal != null)
                    {
                        ControlesSoloLectura();
                        if (FormEditStatus.enuAccionCarga != enuFormEditAccionCarga.Eliminar)
                        {
                            this.btnOK.Symbol = "";
                            this.btnOK.Text = "<b>F2</b> Selec.";
                        }
                        //TODO: Revisar codigo que hacer cuando sea descripcion
                        if (CampoBusqueda.Length > 0 && valorBusqueda.Length > 0)
                            if (PrimaryKeyColumnName.Equals(CampoBusqueda))
                            {
                                _criterio = "";
                                chkBusqueda01.Text = "Código";
                                chkBusqueda01.Tag = CampoBusqueda;
                                chkBusqueda01.Checked = true;
                                chkFind_CheckedChanged(chkBusqueda01, new EventArgs());
                                txtFind.Text = valorBusqueda;
                                txtFind.Focus();
                                _bs = new BindingSource();
                                bnEncontrados.BindingSource = _bs;
                                btnFind_click(btnFind, new EventArgs());
                                Result = esRegistroEncontrado;
                            }
                            else
                                kss_msjDelay.Show("La columna de búsqueda no existe en la tabla.", enuMsgBoxImag.msgError, "Campo de Búqueda inválido", 7);
                    }
                }
                return Result;
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
                return Result;
                throw;
            }
            finally
            {
                //Instruciones Finales

            }
        }

        /// <summary>
        /// Cargar formulario en modo Edición
        /// </summary>
        /// <returns></returns>
        private bool CargarModoEdicion()
        {
            bool Result = false;
            try
            {
                if (esPrivilegioCRUD_Modificar)
                {
                    StatusEdicion = enuStatusRegistro.Cargando;
                    this.panelBusqueda.Visible = true;
                    bnEncontrados.Visible = false;
                    return true;
                }
                else
                {
                    kss_msjDelay.Show("No tiene Privilegios para Editar Registros.", enuMsgBoxImag.msgLogout);
                    return false;
                }
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
                return Result;
            }
            finally
            {
                //Instruciones Finales

            }
        }

        /// <summary>
        /// Cargar Formulario en Modo Consultar Registro
        /// </summary>
        /// <returns></returns>
        private bool CargarModoConsultarRegistro()
        {
            bool Result = false;
            try
            {
                CargarModoConsulta();
                return true;
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
                return Result;
            }
            finally
            {
                //Instruciones Finales

            }
        }

        /// <summary>
        /// Cargar formulario en modo Eliminar Registro 
        /// </summary>
        /// <param name="CampoIDAuto">Nombre de Campos ID Principal</param>
        /// <param name="ValorIDAuto">Valor del Campo ID</param>
        /// <returns></returns>
        private bool CargarModoEliminarRegistro(string CampoIDAuto = "", string ValorIDAuto = "")
        {
            bool Result = false;
            try
            {
                if (esPrivilegioCRUD_Eliminar)
                {
                    CampoIDAuto = FormEditStatus.campoIDAuto == null ? CampoIDAuto : FormEditStatus.campoIDAuto;
                    ValorIDAuto = FormEditStatus.valorIDAuto == null ? ValorIDAuto : FormEditStatus.valorIDAuto.ToString();
                    CargarModoBuscar(CampoIDAuto, ValorIDAuto);
                    panelBusqueda.Visible = false;
                    btnsCRUD_Click(btnDatosPPAL_Del, new EventArgs());
                }
                else
                    kss_msjDelay.Show("No tiene Privilegios para Eliminar Registros.", enuMsgBoxImag.msgLogout);
                return esAccionCRUD_OK;
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
                return Result;
                throw;
            }
            finally
            {
                //Instruciones Finales

            }
        }

        /// <summary>
        /// Cargar formulario en modoe editar Registro.
        /// </summary>
        /// <returns></returns>
        private bool CargarModoEditarRegistro()
        {
            bool Result = false;
            try
            {
                if (esPrivilegioCRUD_Modificar)
                {
                    StatusEdicion = enuStatusRegistro.Editando;
                    this.panelBusqueda.Visible = true;
                    bnEncontrados.Visible = false;
                    return true;
                }
                else
                {
                    kss_msjDelay.Show("No tiene Privilegios para Editar Registros.", enuMsgBoxImag.msgLogout);
                    return false;
                }
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
                return Result;
                throw;
            }
            finally
            {
                //Instruciones Finales

            }

        }

        /// <summary>
        /// Cargar Formulario en modo Agregar Registro
        /// </summary>
        /// <returns></returns>
        private bool CargarModoAgregarregistro()
        {
            bool Result = false;
            try
            {
                if (esPrivilegioCRUD_Agregar)
                    btnsCRUD_Click(btnDatosPPAL_Add, new EventArgs());
                else
                    kss_msjDelay.Show("No tiene Privilegios para Agregar Registros.", enuMsgBoxImag.msgLogout);
                return esAccionCRUD_OK;
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
                return Result;
                throw;
            }
            finally
            {
                //Instruciones Finales

            }
        }

        /// <summary>
        /// Cargar Formulario en modo Consulta
        /// </summary>
        /// <returns></returns>
        private bool CargarModoConsulta()
        {
            bool Result = false;
            try
            {
                if (esPrivilegioCRUD_Listar)
                {
                    ControlesSoloLectura();
                    EsSoloConsulta = true;
                    return true;
                }
                else
                {
                    kss_msjDelay.Show("No tiene Privilegios para Consultar Registros.", enuMsgBoxImag.msgLogout);
                    return false;
                }
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
                return Result;
                throw;
            }
            finally
            {
                //Instruciones Finales

            }
        }

        /// <summary>
        /// CArgar formulario en modo Seleccionar Registro
        /// </summary>
        /// <param name="CampoIDAuto"></param>
        /// <param name="ValorIDAuto"></param>
        /// <returns></returns>
        private bool CargarModoSeleccionar(string CampoIDAuto = "", string ValorIDAuto = "")
        {
            bool Result = false;
            try
            {
                if (CargarModoSeleccionarRegistro(CampoIDAuto, ValorIDAuto))
                    Result = CargarModoConsulta();
                return Result;
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
                return Result;
                throw;
            }
            finally
            {
                //Instruciones Finales

            }
        }

        #endregion  Modo Carga de Formulario

        /// <summary>
        /// Asignar ToolTips a Controles
        /// </summary>
        private void asignarToolTipsCtrl()
        {
            this.superTooltip1.SetSuperTooltip(this.btnDatosPPAL_Add, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "<b>Agregar</b> Registro <b>CTRL + N</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnDatosPPAL_Del, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "<b>Eliminar</b> Registro <b>CTRL + E</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnEncFirst, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Mover al <b>Primer</b> Registro <b>F5</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnEncPrev, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Mover al <b>Anterior</b> <b>F6</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnEncNext, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Mover al <b>Siguiente</b> <b>F7</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnEncLast, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Mover al <b>Último</b> Registro <b>F8</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnCancelar, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "<b>Cancelar</b> Edición <b>F10</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnGuardar, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "<b>Guardar</b> Cambios <b>F9</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnOK, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "<b>Cerrar</b> Módulo <b>ESC</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.superTooltip1.SetSuperTooltip(this.btnFind, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "<b>Buscar</b> Registro <b>F3</b>", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
        }

        /// <summary>
        /// Confirma el Cierre del Formulario
        /// </summary>
        /// <returns></returns>
        private bool formConfirmarCierre()
        {
            System.EventArgs e = null;
            switch (StatusEdicion)
            {
                case ksslib.enuStatusRegistro.Editando:
                    switch (ksslib.kss_msjDelay.Show("Existen datos no han sido guardados.<br/><b>¿Desea Guardar los cambios?</b>", enuMsgBoxImag.msgAyuda, enuMsgBoxResult.msgYesNO, 7, "Editando Registros"))
                    {
                        case DialogResult.Cancel:
                            esFormCancelarCierre = true;
                            timer1.Enabled = true;
                            return true;
                        case DialogResult.Yes:
                            btnsCRUD_Click(this.btnGuardar, e);
                            return false;
                        case DialogResult.No:
                            btnsCRUD_Click(this.btnOK, e);
                            return false;
                    }
                    break;
            }
            return false;
        }

        private bool formMostrado()
        {
            bool Result = false;
            try
            {
                if (esRequiereDatosPrevios())
                    return false;
                if (esTablaConRegistros())
                {
                    if (_FormEditStatus.OriginalRow != null)
                        Actualizar_FormEditStatus(_FormEditStatus.OriginalRow);

                    ComprobarPrivilegiosCRUD();
                    switch (_FormEditStatus.enuAccionCarga)
                    {
                        case enuFormEditAccionCarga.Modo_Edicion:
                            if (!(Result = CargarModoEdicion()))
                                if (Result = CargarModoConsulta())
                                    _FormEditStatus.enuAccionCarga = enuFormEditAccionCarga.Modo_Consulta;
                            break;
                        case enuFormEditAccionCarga.Modo_Consulta:
                            Result = CargarModoConsulta();
                            break;
                        case enuFormEditAccionCarga.Modo_Seleccionar:
                            Result = CargarModoSeleccionar();
                            break;
                        case enuFormEditAccionCarga.Seleccionar:
                            Result = CargarModoSeleccionarRegistro();
                            break;
                        case enuFormEditAccionCarga.Agregar:
                            Result = CargarModoAgregarregistro();
                            break;
                        case enuFormEditAccionCarga.Editar:
                            Result = CargarModoEditarRegistro();
                            break;
                        case enuFormEditAccionCarga.Eliminar:
                            Result = CargarModoEliminarRegistro();
                            break;
                        case enuFormEditAccionCarga.Consulta:
                            Result = CargarModoConsultarRegistro();
                            break;
                        case enuFormEditAccionCarga.Buscar:
                            Result = CargarModoBuscar();
                            break;
                    }
                }
                //}
                //else
                //	switch (_FormEditAccionCargar.enuAccionCarga)
                //	{
                //		case enuFormEditAccionCarga.Modo_Edicion:
                //			if (!(CargarModoEdicion()))
                //				if (Result = CargarModoConsulta())
                //					_FormEditAccionCargar.enuAccionCarga = enuFormEditAccionCarga.Modo_Consulta;
                //			break;
                //		case enuFormEditAccionCarga.Agregar:
                //			Result = CargarAgregarregistro();
                //			break;
                //	}
                return Result;
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
                return false;
            }
            finally
            {
                //Instruciones Finales

            }
        }

        /// <summary>
        /// Verifica si el Formulario requiere datos previos antes de cargar
        /// </summary>
        /// <returns></returns>
        private bool esRequiereDatosPrevios()
        {
            if (ctrls != null)
                foreach (Control ctl in ctrls)
                {
                    string TablaEnlazada = "*Sin Tablas*";
                    bool esRequerido = false;
                    switch (ctl.GetType().Name)
                    {
                        case "ComboBox":
                        case "ComboBoxEx":
                            System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)ctl;
                            esRequerido = cmb.Items.Count == 0 && (cmb.Visible || cmb.Enabled) ? true : false;
                            if (cmb.DataSource != null)
                                if (cmb.DataSource.GetType().Name == "BindingSource")
                                    TablaEnlazada = ((System.Windows.Forms.BindingSource)(cmb.DataSource)).DataMember.ToString();
                            break;
                    }
                    if (esRequerido)
                    {
                        //Comprobar columna no espermite null
                        foreach (ColumnsHelper col in AdapterBase.CustomColumns)
                            if (
                                col.ColumnName.ToUpper().Substring(0, 3) == "ID_" &&
                                col.TypeColumn.Name.Contains("System.Int") &&
                                ctl != null &&
                                !col.esNulleableColumn
                                )
                            {
                                kss_msjDelay.Show(
                                    string.Format("Éste módulo requiere datos previos en la tabla <b>{0}</b>", TablaEnlazada.ToUpper()),
                                    enuMsgBoxImag.msgCancel, "Datos Previos Requeridos", 10
                                    );
                                return true;
                            }
                    }
                }
            return false;
        }
        #endregion

        #region Eventos Formulario

        private void timer1_Tick(System.Object sender, System.EventArgs e)
        {
            if (esFormCancelarCierre & segundos == 3)
            {
                esFormCancelarCierre = false;
                timer1.Enabled = false;
            }
            else
                segundos += 1;
        }

        private void form_Activated(object sender, System.EventArgs e)
        {
            esFormCancelarCierre = false;
            if (_titulo == null | _titulo == "")
            {
                tablaAuxiliarPpal = tablaAuxiliarPpal == null ? "" : tablaAuxiliarPpal.ToUpper();
                _titulo = _FormEditStatus.enuAccionCarga.Description().ToString() + tablaAuxiliarPpal;
            }
            this.Text = _titulo;
            if (this.IsMdiChild)
            {
                if (this.MdiParent != null)
                {
                    Titulo_MDIParent = this.MdiParent.Text;
                    this.MdiParent.Text += " [ " + _titulo + " ] ";
                }
            }
        }

        private void form_Deactivate(object sender, System.EventArgs e)
        {
            if (this.IsMdiChild)
                if (this.MdiParent != null)
                    this.MdiParent.Text = Titulo_MDIParent;
        }

        private void form_Closed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            esFormCargado = false;
        }

        private void form_Closing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (!esFormCancelarCierre)
            {
                e.Cancel = formConfirmarCierre();
                if (StatusEdicion == ksslib.enuStatusRegistro.Actualizacion_Rechazada)
                {
                    esFormCancelarCierre = true;
                    timer1.Enabled = true;
                    e.Cancel = esFormCancelarCierre;
                }
            }
            else
                e.Cancel = esFormCancelarCierre;

        }

        private void form_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                btnDatosPPAL_Add.RaiseClick();
                return;
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                btnDatosPPAL_Del.RaiseClick();
                return;
            }
            if (esESC_pressed && e.KeyCode != Keys.Escape)
                esESC_pressed = false;

            switch (e.KeyCode)
            {
                case Keys.F1: //Mostrar Ayuda

                    break;
                case Keys.F2: //Buscar
                    break;
                case Keys.F3: //Buscar
                    btnFind.PerformClick();
                    break;
                case Keys.F4: //
                    break;
                case Keys.F5: //Mover Primero
                    btnsCRUD_Click(btnEncFirst, new EventArgs());
                    break;
                case Keys.F6: //Mover anterior
                    btnsCRUD_Click(btnEncPrev, new EventArgs());
                    break;
                case Keys.F7: //Mover siguiente
                    btnsCRUD_Click(btnEncNext, new EventArgs());
                    break;
                case Keys.F8: //Mover final
                    btnsCRUD_Click(btnEncLast, new EventArgs());
                    break;
                case Keys.F9: //Guardar
                    btnGuardar.PerformClick();
                    break;
                case Keys.F10://Cancelar
                    btnCancelar.PerformClick();
                    break;
                case Keys.F11: //Buscar
                    break;
                case Keys.F12: //Buscar
                    break;
                case Keys.Escape: //Buscar
                    if (esESC_pressed)
                    {
                        //Cerrar modulo
                        btnOK.PerformClick();
                    }
                    else
                    {
                        esESC_pressed = true;
                        this.MostrarMsjStatus("Presione ESC de nuevo para SALIR");
                    }
                    break;
                case Keys.Back:
                case Keys.Enter:
                case Keys.End:
                case Keys.Space:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                    Control ctrl = (Control)ksslib.clsUtilControles.buscarControlActivo(this);
                    switch (e.KeyCode)
                    {
                        case Keys.Enter:
                            switch (ctrl.Name)
                            {
                                case "txtBusqueda":
                                    this.btnFind_click(btnFind, e);
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Keys.Back:
                            switch (ctrl.GetType().ToString())
                            {
                                case "System.Windows.Forms.TextBox":
                                case "DevComponents.DotNetBar.Controls.TextBoxX":
                                    TextBox _ctrl = (TextBox)ctrl;
                                    if (_ctrl.Text.Length == 0)
                                        this.SelectNextControl(_ctrl, false, false, true, true);
                                    else
                                        StatusEdicion = ksslib.enuStatusRegistro.Editando;
                                    break;
                                default:
                                    this.SelectNextControl(ctrl, false, false, true, true);
                                    break;
                            }
                            break;
                    }
                    break;
                case Keys.ControlKey:
                    break;
                default:
                    Control ctl_activo = (Control)ksslib.clsUtilControles.buscarControlActivo(this);
                    StatusEdicion = ksslib.enuStatusRegistro.Editando;
                    break;
            }
        }


        private void btnCerrar_click(System.Object sender, System.EventArgs e)
        {
            btnsCRUD_Click(btnCancelar, new EventArgs());
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            _FormEditStatus.DialogResult = this.DialogResult;
            this.Close();
        }

        private void form_Shown(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            try
            {
                if (tablaAuxiliarPpal != null)
                    if (!(esFormCargado = formMostrado()))
                    {
                        kss_msjDelay.Show("Ha Fallado la carga de este Módulo.<br />Por Favor verifique los requisitos de carga!", enuMsgBoxImag.msgError, "Imposible cargar Módulo", 10);
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        this.Close();
                    }
                    else
                    {
                        this.Visible = true;
                    }
            }
            catch
            {
            }
        }
        #endregion
        #endregion
        #endregion
    }

    #region Plantillas
    public class PaisesEditMultiple : dlgEditMultiple<world_Paises>
    {
    }
    public class ClientesEditMultiple : dlgEditMultiple<Clientes>
    {
    }
    public class HipodromoJornadasDiariasEditMultiple : dlgEditMultiple<Hipodromos_Jornadas_Diarias>
    {
    }
    public class HipodromoJornadasSemanalesEditMultiple : dlgEditMultiple<Hipodromos_Jornadas>
    {
    }
    public class JornadasEditMultiple : dlgEditMultiple<Jornadas>
    {
    }
    public class TiposEmpresaEditMultiple : dlgEditMultiple<TiposComercios>
    {
    }
    public class TiposPagoEditMultiple : dlgEditMultiple<TiposPago>
    {
    }
    public class UsuariosEditMultiple : dlgEditMultiple<Usuarios>
    {
    }
    public class GrupoUsuariosEditMultiple : dlgEditMultiple<Usuarios_Grupo>
    {
    }
    public class EmpresasEditMultiple : dlgEditMultiple<Empresas>
    {
    }
    public class HipodromosEditMultiple : dlgEditMultiple<Hipodromos>
    {
    }
    #endregion
    //public class ClientesEditMultiple : dlgEditMultiple<Clientes> { }
}
