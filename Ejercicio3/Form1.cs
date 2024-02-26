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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (rdTemperatura.Checked)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else if (rdLongitud.Checked)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else if (rdPeso.Checked)
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una opción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
