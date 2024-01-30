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
    public partial class Form2 : Form
    {
        public Form2(string textx)
        {
            InitializeComponent();
            lbrecibido.Text = textx; // Asignamos lo recibido al label
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            frmventana form1 = new frmventana(); // Instanciamos al primer formulario
            this.Close(); // Cerramos el formulario actual
            form1.Visible = true; // Hacemos visible al form1 de nuevo
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
