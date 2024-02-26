using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class frmventana : Form
    {
        public frmventana()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            MessageBox.Show("Bienvenido a LPN0 " + nombre + " este es tu primer formulario");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Termina la aplicación
        }
    }
}
