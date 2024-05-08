using MaterialSkin;
using MaterialSkin.Controls;

namespace kss_SocialClub.UI.Templates
{
    public partial class DialogoOK_Mskin : MaterialForm
    {
        public DialogoOK_Mskin()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey300, Primary.Grey700,
                Primary.Red500, Accent.Orange700,
                TextShade.BLACK
            );
        }
    }
}
