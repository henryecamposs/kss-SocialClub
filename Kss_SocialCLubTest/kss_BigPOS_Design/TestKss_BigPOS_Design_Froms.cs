using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kss_SocialCLubTest.kss_BigPOS_Design
{
    [TestClass]
    public class TestKss_BigPOS_Design_Froms
    {
        [TestMethod]
        public void LoadFormEntityUsuario_ctrlPOSDatosUsuarios_Pruebas()
        {
            new kss_BigPOS.Design.frmEntity() { StartPosition = System.Windows.Forms.FormStartPosition.CenterParent }.ShowDialog();
        }
    }
}
