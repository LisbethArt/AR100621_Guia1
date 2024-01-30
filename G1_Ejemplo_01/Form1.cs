using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G1_Ejemplo_01
{
    public partial class frmventana : Form
    {
        public frmventana()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string texto = txtnombre.Text;
            string mensaje = string.Format("Bienvenido al segundo formulario " + texto);
            Form2 frmrecibe = new Form2(mensaje); /* Creo un objeto del segundo formulario,
                                                     adonde mando información */
            frmrecibe.Visible = true; // Muestra el nuevo formulario
            this.Visible = false; // Esconde el formulario actual

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Termina la aplicación
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmventana_Load(object sender, EventArgs e)
        {

        }
    }
}
