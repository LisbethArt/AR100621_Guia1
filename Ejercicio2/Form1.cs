using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            {
                if (double.TryParse(txtA.Text, out double a) &&
                    double.TryParse(txtB.Text, out double b) &&
                    double.TryParse(txtC.Text, out double c))
                {
                    double discriminante = Math.Pow(b, 2) - 4 * a * c;

                    if (discriminante >= 0)
                    {
                        double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                        x1 = Math.Round(x1, 3);
                        x2 = Math.Round(x2, 3);

                        txtX1.Text = x1.ToString();
                        txtX2.Text = x2.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Esa ecuación no tiene una solución real, intente con otra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese números válidos para a, b y c.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
