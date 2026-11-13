using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace WindowsFormsApp2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DataStore.LoadAll();

            User u;
            using (frmLogin dn = new frmLogin())
            {
                if (dn.ShowDialog() != DialogResult.OK) return;
                u = dn.NguoiDung;
            }
            Application.Run(new frmMain(u));
        }
    }
}
