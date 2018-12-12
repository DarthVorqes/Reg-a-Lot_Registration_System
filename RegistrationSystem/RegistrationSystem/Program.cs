using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RegistrationSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// Was downgraded for lab computers
        /// test
        [STAThread]
        static void Main()
        {
            User usr = new User();
            usr.Authenticate(5, "test123");

            //var values = usr.GetSemesters();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
        }
    }
}
