using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chooseURFate
{
    static class Program
    {
        public static bool loginCorrecto = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new formLogin());
            if (loginCorrecto)
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Login incorrecto");
            }
        }
    }
}
