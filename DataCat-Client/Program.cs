using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataCat_Client
{
    static class Program
    {
        static bool EnableLogin = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());

            
        }
    }
}
