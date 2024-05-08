using DevComponents.DotNetBar.Metro;
using System;
using System.Windows.Forms;

namespace kss_A_Ganador.Forms.Plantillas
{
    public partial class dlgEdit : DialogoOK
    {
        //internal GenericRepository<dynamic> EntityAdapter { get; private set; }
        //internal DbSet<dynamic> DbSet;
        dynamic EntityAdapter;
        private bool esESC_pressed;
        private string _Titulo;
        private bool editMode;
          
        public dlgEdit(string titulo, dynamic entityAdapter)
        {
            InitializeComponent();
            Titulo = string.IsNullOrWhiteSpace(titulo) ? entityAdapter.ToString() : titulo.ToString();
            this.EntityAdapter = entityAdapter;
            bindingSource1.DataSource = entityAdapter.Current;
            bindingSource1.Position = 0;
        }


        public void btnOK_Click(object sender, EventArgs e)
        {
            EntityAdapter.Update(EntityAdapter.Current);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        internal void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void swbtnActivo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                EntityAdapter.Current.esActivo = swbtnActivo.Value;
            }
            catch { throw; }
        }

        private void DialogoGuardar_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Control && e.KeyCode == Keys.N)
            //{
            //    BN_Nuevo.PerformClick();
            //    return;
            //}
            //if (e.Control && e.KeyCode == Keys.E)
            //{
            //    BN_eliminar.PerformClick();
            //    return;
            //}
            if (esESC_pressed && e.KeyCode != Keys.Escape)
                esESC_pressed = false;

            switch (e.KeyCode)
            {
                case Keys.F1: //Mostrar Ayuda

                    break;
                case Keys.F2: //Buscar
                    break;
                //case Keys.F3: //Buscar
                //    btnFind.PerformClick();
                //    break;
                //case Keys.F4: //
                //    break;
                //case Keys.F5: //Mover Primero
                //    btnsCRUD_Click(ts_primero, new EventArgs());
                //    break;
                //case Keys.F6: //Mover anterior
                //    btnsCRUD_Click(ts_anterior, new EventArgs());
                //    break;
                //case Keys.F7: //Mover siguiente
                //    btnsCRUD_Click(ts_siguiente, new EventArgs());
                //    break;
                //case Keys.F8: //Mover final
                //    btnsCRUD_Click(ts_ultimo, new EventArgs());
                //    break;
                case Keys.F9: //Guardar
                    btnSave.PerformClick();
                    break;
                case Keys.F10://Cancelar
                    btnCancel.PerformClick();
                    break;
                case Keys.F11: //Buscar
                    break;
                case Keys.F12: //Buscar
                    break;
                    //case Keys.Escape: //Buscar
                    //    if (esESC_pressed)
                    //    {
                    //        //Cerrar modulo
                    //        btnClose.PerformClick();
                    //    }
                    //    else
                    //    {
                    //        esESC_pressed = true;
                    //        this.MostrarMsjStatus("Presione ESC de nuevo para SALIR");
                    //    }
                    //    break;
                    //case Keys.Back:
                    //case Keys.Enter:
                    //case Keys.End:
                    //case Keys.Space:
                    //case Keys.Down:
                    //case Keys.Left:
                    //case Keys.Right:
                    //    Control ctrl = (Control)ksslib.clsUtilControles.buscarControlActivo(this);
                    //    switch (e.KeyCode)
                    //    {
                    //        case Keys.Enter:
                    //            switch (ctrl.Name)
                    //            {
                    //                case "txtValorBusqueda":
                    //                    this.btnFind_click(btnFind, e);
                    //                    break;
                    //                default:
                    //                    break;
                    //            }
                    //            break;
                    //        case Keys.Back:
                    //            switch (ctrl.GetType().ToString())
                    //            {
                    //                case "System.Windows.Forms.TextBox":
                    //                case "DevComponents.DotNetBar.Controls.TextBoxX":
                    //                    TextBox _ctrl = (TextBox)ctrl;
                    //                    if (_ctrl.Text.Length == 0)
                    //                        frmPadre.SelectNextControl(_ctrl, false, false, true, true);
                    //                    else
                    //                        StatusEdicion = ksslib.enuStatusRegistro.Editando;
                    //                    break;
                    //                default:
                    //                    frmPadre.SelectNextControl(ctrl, false, false, true, true);
                    //                    break;
                    //            }
                    //            break;
                    //    }
                    //    break;
                    //case Keys.ControlKey:
                    //    break;
                    //default:
                    //    Control ctl_activo = (Control)ksslib.clsUtilControles.buscarControlActivo(this);
                    //    StatusEdicion = ksslib.enuStatusRegistro.Editando;
                    //    break;
            }
        }

        private void labelDatoPpal1_Load(object sender, EventArgs e)
        {

        }
    }
}
