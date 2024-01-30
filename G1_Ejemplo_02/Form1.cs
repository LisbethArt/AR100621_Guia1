using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G1_Ejemplo_02
{
    public partial class Ejemplo2 : Form
    {
        public Ejemplo2()
        {
            InitializeComponent();
        }

        private void Ejemplo2_Load(object sender, EventArgs e)
        {
            // Agrega item al comboBox
            cmbop.Items.Clear();
            cmbop.Items.Add("Sumar");
            cmbop.Items.Add("Restar");
            // Agrega item a la lista
            listadvance.Items.Clear();
            listadvance.Items.Add
            ("Multiplicación");
            listadvance.Items.Add("División");
            listadvance.TabIndex = 0; // Habilita por defecto la primera opción
            cmbop.Enabled = false;  // Inhabilita el combo y la lista
            listadvance.Enabled = false;
        }

        private void rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn1.Checked == true)
            {
                cmbop.Enabled = true;
                listadvance.Enabled = false;
            }
        }

        private void rbtn2_CheckedChanged(object sender, EventArgs e)
        {
            cmbop.Enabled = false;
            listadvance.Enabled = true;

            //me permite seleccionar el primer elemento de la lista
            listadvance.SelectedIndex = 0;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, r;
            n1 = Convert.ToDouble(txtnum1.Text);
            n2 = Convert.ToDouble(txtnum2.Text);
            if (cmbop.Enabled == true)
            {
                if (cmbop.SelectedItem.ToString() == "Sumar")
                    r = n1 + n2;
                else
                    r = n1 - n2;

                MessageBox.Show("El Resultado es " + r.ToString(), "Respuesta");
            }
            if (listadvance.Enabled == true)
            {
                if (listadvance.SelectedItem.ToString() == "Multiplicación")
                    r = n1 * n2;
                else
                    r = n1 / n2;
                MessageBox.Show("El Resultado es " + r.ToString(), "Respuesta");
            }
        }
    }
}
