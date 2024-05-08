using DevComponents.DotNetBar.Metro;
using System;

namespace kss_A_Ganador.Forms.Plantillas
{
    public partial class DialogoOK : MetroForm
    {
		private string _Titulo;

		public string Titulo
		{
			get
			{
				return _Titulo;
			}
			set
			{
				_Titulo = value;
				panelTitulo.Text = string.Format(panelTitulo.Text, _Titulo);
			}
		}
        private void initForm(string Titulo= "Cuadro de Dialogo")
        {
			InitializeComponent();
			ksslib.clsUtilForms _clsUtilForm = new ksslib.clsUtilForms(this);
			base.MouseMove += _clsUtilForm.Me_MouseMove;
			base.MouseDown += _clsUtilForm.Me_MouseDown;
			this.panelTitulo.MouseMove += _clsUtilForm.Me_MouseMove;
			this.panelTitulo.MouseDown += _clsUtilForm.Me_MouseDown;
        }
        public DialogoOK() => initForm();
		public DialogoOK(string titulo)
		{
            initForm();
            Titulo = titulo;
		}

		internal void btnClose_Click(object sender, EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.Cancel;
		}

        private void btnEsc_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.None;
        }
    }
}
