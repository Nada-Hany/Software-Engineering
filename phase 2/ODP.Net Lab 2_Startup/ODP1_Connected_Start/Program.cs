using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ODP1_Connected_Start
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
            Application.Run(new LoginForm());
            //Application.Run(new disconnectedForm_admin());
            //Application.Run(new adminForm());
            //Application.Run(new MoviesForm());
        }
    }
}
