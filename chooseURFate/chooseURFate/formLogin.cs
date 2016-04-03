using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chooseURFate
{
    public partial class formLogin: Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void IntroTexto(object sender, EventArgs e)
        {
            if (txtB_passwd.Text.Length > 0 && txtB_Usuario.Text.Length > 0)
            {
                btn_Login.Enabled = true;
                btn_ResetDatos.Enabled = true;
            }
            else
            {
                btn_Login.Enabled = false;
                btn_ResetDatos.Enabled = false;
            }
        }

        private void IntentoLogin(object sender, EventArgs e)
        {

            Program.loginCorrecto = false;
            if (!ComprobarLogin.ComprobarCredenciales(txtB_Usuario.Text, txtB_passwd.Text))
                MessageBox.Show("Login incorrecto");
            else
            {
                Program.loginCorrecto = true;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
