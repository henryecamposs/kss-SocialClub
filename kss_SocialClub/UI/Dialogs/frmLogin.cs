using System;
using System.Windows.Forms;

namespace kss_SocialClub.UI.Dialogs
{
    enum enFrmAccion
    {
        INICIO,
        FIN,
        REGRESO,
        INICIO_RECHAZADO,
        INICIO_ACEPTADO,
        INICIAR_SESION
    }
    public partial class frmLogin : kss_SocialClub_Design.Dialogs.DialogOK_mskin
    {
        private enFrmAccion _enuAccon;
        private string _Usuario;
        private string _Clave;
        private string _lblLabelUsuario = "Usuario:";
        private string _lblLabelPssword = "Contraseña";
        private string _lblBtnSiguiente = "Siguiente";
        private string _lblBtnIniciarSesion = "Iniciar Sesión";

        private enFrmAccion enuAccion
        {
            get
            {
                return _enuAccon;
            }
            set
            {
                _enuAccon = value;
                _Clave = "";
                switch (_enuAccon)
                {
                    case enFrmAccion.FIN:
                        _Usuario = txtText.Text;
                        txtText.Text = "";
                        txtText.UseSystemPasswordChar = true;
                        lblLabel.Text = _lblLabelPssword;
                        btnAnterior.Visible = true;
                        btnSiguiente.Text = _lblBtnIniciarSesion;
                        break;
                    case enFrmAccion.INICIO:
                    case enFrmAccion.REGRESO:
                        txtText.Text = string.IsNullOrEmpty(_Usuario) ? "" : _Usuario;
                        txtText.UseSystemPasswordChar = false;
                        lblLabel.Text = _lblLabelUsuario;
                        btnAnterior.Visible = false;
                        btnSiguiente.Text = _lblBtnSiguiente;
                        break;
                    case enFrmAccion.INICIAR_SESION:
                        _Clave = txtText.Text;
                        btnSiguiente.PerformClick();
                        break;
                    case enFrmAccion.INICIO_ACEPTADO:
                        //Cargar frmain o frmPOS segun usuario logeado o configuracion de estación
                        this.Hide();
                        Program.frmMain= new frmMain() { WindowState = FormWindowState.Maximized };
                        Program.frmMain.ShowDialog();
                        break;
                    case enFrmAccion.INICIO_RECHAZADO:
                        break;
                    default:

                        break;
                }

            }
        }
        public frmLogin()
        {
            InitializeComponent();
            btnOK.Visible = false;
            enuAccion = enFrmAccion.INICIO;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            switch (enuAccion)
            {
                case enFrmAccion.REGRESO:
                case enFrmAccion.INICIO:
                    enuAccion = enFrmAccion.FIN;
                    break;
                case enFrmAccion.FIN:
                    if (string.IsNullOrEmpty(txtText.Text))
                    {
                        ksslib.kss_msjDelay.Show("Debe indicar una contraseña.", ksslib.enuMsgBoxImag.msgCritical,"Contraseña inválida");
                    }
                    else
                        enuAccion = enFrmAccion.INICIAR_SESION;

                    break;
                case enFrmAccion.INICIAR_SESION:
                    if (_Usuario.Equals("kss") && _Clave.Equals("001"))
                    {
                        ksslib.kss_msjDelay.Show("Acceso Garantizado!", ksslib.enuMsgBoxImag.msgLogin, "Acceso Autorizado");
                        enuAccion = enFrmAccion.INICIO_ACEPTADO;
                    }
                    else
                    {
                        ksslib.kss_msjDelay.Show("Contraseña o Nombre de Usuario no coinciden!", ksslib.enuMsgBoxImag.msgLogout, "Acceso Denegado");
                        enuAccion = enFrmAccion.INICIO_RECHAZADO;
                    }
                    break;
                case enFrmAccion.INICIO_RECHAZADO:
                    enuAccion = enFrmAccion.INICIAR_SESION;
                    break;
                default:
                    break;
            }
            txtText.Focus();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            enuAccion = enFrmAccion.REGRESO;
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Olvido Contraseña!");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtText.Focus();
        }
    }
}
