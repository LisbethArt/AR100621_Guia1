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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                double faren = (celsius * 1.8) + 32;

                faren = Math.Round(faren, 2);

                txtFaren.Text = faren.ToString();
            }

            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido en metros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFaren.Clear();
            txtCelsius.Clear();
        }
    }
}
