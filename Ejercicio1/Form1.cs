using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string rol = ObtenerRolSeleccionado();

            Form2 form2 = new Form2(nombre, apellido, rol);

            form2.Show();

            this.Hide();
        }

        private string ObtenerRolSeleccionado()
        {
            // Determinar qué RadioButton está seleccionado
            if (rdGerente.Checked)
                return "Gerente";
            else if (rdSubgerente.Checked)
                return "Subgerente";
            else if (rdSecretaria.Checked)
                return "Secretaria";

            return string.Empty; // Si ninguno está seleccionado
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string rol = ObtenerRolSeleccionado();

            Form2 form2 = new Form2(nombre, apellido, rol);

            form2.Show();

            this.Hide();
        }
    }
}
