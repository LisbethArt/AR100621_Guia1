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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string nombre, string apellido, string rol)
            : this()
        {

            lblCompleto.Text = $"{nombre} {apellido}";
            lblCargo.Text = $"Tu Cargo es: {rol}";

            CalcularSalarios(rol);

        }

        private void CalcularSalarios(string rol)
        {
            double salarioBase = 0;
            double porcentajeDescuento = 0;

            switch (rol)
            {
                case "Gerente":
                    salarioBase = 600;
                    porcentajeDescuento = 0.20;
                    break;
                case "Subgerente":
                    salarioBase = 450;
                    porcentajeDescuento = 0.15;
                    break;
                case "Secretaria":
                    salarioBase = 365;
                    porcentajeDescuento = 0.05;
                    break;
                default:
                    // Configuración predeterminada si no coincide con ninguno
                    break;
            }

            double descuento = salarioBase * porcentajeDescuento;
            double salarioNeto = salarioBase - descuento;

            txtSalario.Text = salarioBase.ToString();
            txtDescuento.Text = descuento.ToString();
            txtNeto.Text = salarioNeto.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
