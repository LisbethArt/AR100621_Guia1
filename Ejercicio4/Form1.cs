using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            listbArreglo.Items.Add(txbNumero.Text);
            txbNumero.Clear();
            txbNumero.Focus();
        }

        private void RealizarCalculos()
        {
            // Operación 1 / Numero mayor de pares negativos
            int mayorneg = -1000;
            bool hayNegativoPar = false;

            for (int i = 0; i < listbArreglo.Items.Count; i++)
            {
                string valor = listbArreglo.Items[i].ToString();
                int numero = int.Parse(valor);

                if (numero < 0 && numero % 2 == 0)
                {
                    if (numero > mayorneg)
                    {
                        mayorneg = numero;
                        hayNegativoPar = true;
                    }
                }
            }

            if (hayNegativoPar)
                txbCalculo1.Text = mayorneg.ToString();
            else
                txbCalculo1.Text = "No hay números negativos pares";

            // Operación 2 / Porcentaje de ceros en el arreglo
            double cantidadNumeros = listbArreglo.Items.Count;
            double cantidadCeros = 0;
            double porcentaje = 0;

            for (int i = 0; i < listbArreglo.Items.Count; i++)
            {
                string valor = listbArreglo.Items[i].ToString();
                int numero = int.Parse(valor);

                if (numero == 0)
                {
                    cantidadCeros = cantidadCeros + 1;
                }
            }

            porcentaje = (cantidadCeros / cantidadNumeros) * 100;
            double porcentajeRedondeado = Math.Round(porcentaje, 2);
            txbCalculo2.Text = (porcentajeRedondeado.ToString("0.00") + "%");

            // Operación 3 / Promedio de impares positivos
            double prom;
            double cantidadImpares = 0;
            double suma = 0;

            for (int i = 0; i < listbArreglo.Items.Count; i++)
            {
                string valor = listbArreglo.Items[i].ToString();
                int numero = int.Parse(valor);

                if (numero > 0 && numero % 2 != 0)
                {
                    suma = suma + numero;
                    cantidadImpares = cantidadImpares + 1;
                }
            }

            // Operación 4 / Mayor de los pares positivos
            prom = suma / cantidadImpares;
            double promedioRedondeado = Math.Round(prom, 2);
            txbCalculo3.Text = promedioRedondeado.ToString();

            int mayor = 0;

            for (int i = 0; i < listbArreglo.Items.Count; i++)
            {
                string valor = listbArreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 == 0)
                {
                    if (numero > mayor)
                        mayor = numero;
                }
            }
            txbCalculo4.Text = mayor.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            RealizarCalculos();
        }
    }
}
