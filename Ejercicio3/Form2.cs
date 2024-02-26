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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMetros.Text, out double metros))
            {
                double pies = metros * 3.28084;

                pies = Math.Round(pies, 3);

                txtPies.Text = pies.ToString();
            }

            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido en metros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMetros.Clear();
            txtPies.Clear();
        }
    }
}
