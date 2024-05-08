using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace kss_SocialClub
{
    internal static class Program
    {
        internal static frmMain frmMain;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(
                new frmMain()
                { WindowState = FormWindowState.Normal, StartPosition = FormStartPosition.CenterScreen });
        }
        
    }
}
