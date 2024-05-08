using DevComponents.DotNetBar.Metro;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace kss_SocialClub
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1_Resize(this, new EventArgs());
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            itemPanel1.Location = new Point((this.Width - itemPanel1.Width) / 2, (this.Height / 2) - (itemPanel1.Height / 2));
            metroToolbar1.Location = new Point((this.Width - metroToolbar1.Width) / 2, this.Height - metroToolbar1.Height - 34);
            panelEx2.Location = new Point((this.Width - panelEx2.Width) / 2, panelEx1.Height);
        }

        private void newInvoiceButton_Click(object sender, EventArgs e)
        {

        }

        private void metroTileItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new kss_BigPOS.Design.Forms.POS.frmPOSFacturar( ksslib_c.Enums.enuKssSistemas.kssSocialClub,"")
            {
                WindowState = FormWindowState.Maximized,
                StartPosition = FormStartPosition.CenterScreen
            }).ShowDialog();
        }

        private void metroTileItem2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
