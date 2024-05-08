using MaterialSkin;
using MaterialSkin.Controls;

namespace kss_SocialClub_Design.Dialogs
{
    public partial class DialogOK_mskin : MaterialForm
    {
        public DialogOK_mskin()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.LightBlue300, Primary.LightBlue700,
                Primary.Red500, Accent.Orange700,
                TextShade.BLACK
            );
        }

        private void DialogOK_mskin_Shown(object sender, System.EventArgs e)
        {
            btnOK.Location = new System.Drawing.Point(this.Width - btnOK.Width - 4, this.Height - btnOK.Height - 4);
            pickssLogo.Location = new System.Drawing.Point( 4  , this.Height - btnOK.Height - 4);
        }

        private void DialogOK_mskin_Resize(object sender, System.EventArgs e)
        {

            btnOK.Location = new System.Drawing.Point(this.Width - btnOK.Width - 4, this.Height - btnOK.Height - 4);
            pickssLogo.Location = new System.Drawing.Point(4, this.Height - btnOK.Height - 4);
        }
    }
}
