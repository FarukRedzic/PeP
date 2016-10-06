using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI.Forms;

namespace WinFormUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //frmLogin frmLogin = new frmLogin();
            //frmLogin.ShowDialog();
            Application.Run(new frmLogin());
        }
    }
}
