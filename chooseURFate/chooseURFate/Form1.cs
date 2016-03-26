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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numAcciones = 0;

        private void SumandoAcciones(object sender, MouseEventArgs e)
        {
            numAcciones++;
            this.Text = numAcciones.ToString();
            if (GestorEventos.ContarAcciones(numAcciones))
            {
                MessageBox.Show("Evento");
                numAcciones = 0;
            }
        }
    }
}
