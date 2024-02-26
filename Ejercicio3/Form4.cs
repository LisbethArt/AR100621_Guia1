using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtKilo.Text, out double kilos))
            {
                double libras = (kilos * 2.2046);

                libras = Math.Round(libras, 3);

                txtLibra.Text = libras.ToString();
            }

            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido en metros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLibra.Clear();
            txtKilo.Clear();
        }
    }
}
