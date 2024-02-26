using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LoginBasico
{
    public partial class Form1 : Form
    {
        string password;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            string usuario = txtuser.Text;
            string contra = txtpass.Text;
            string url= "C:\\Users\\LisbethArt\\Prácticas\\Clase\\LPP0G01\\.NET\\AR100621_Guia1\\LoginBasico\\AR100621\\" + usuario +".txt"; // Usted elige ubicación de carpeta, la que hizo en el paso 3, pero esta debe existir
            if(File.Exists(url)) // Verifica que el archive exista
            {
                MessageBox.Show("ERROR. ¡Usuario ya existe!"); // Usuario registrado
                txtuser.Clear(); // Limpiamos todos los textbox
                txtpass.Clear();
            } else
            {
                File.WriteAllText(url, contra); /* Crea un Nuevo archivo con ese nombre y guarda
                                                    dentro del archivo el valor del segundo parámetro */
                MessageBox.Show("Usuario Registrado con éxito");
                txtuser.Clear();
                txtpass.Clear();
            }
        }

        private void btningreso_Click(object sender, EventArgs e)
        {
            {
                string usuario = txtuser.Text; // Capturamos los valores de usuario y contraseña
                string contra = txtpass.Text;
                string url = "C:\\Users\\LisbethArt\\Prácticas\\Clase\\LPP0G01\\.NET\\AR100621_Guia1\\LoginBasico\\AR100621\\" + usuario + ".txt";
                if (File.Exists(url)) // Verifica si existe
                {
                    password = File.ReadAllText(url); // Lee el texto almacenado dentro del archivo
                    if (contra.Equals(password)) // Verifica si contraseña es igual al archivo
                    {
                        MessageBox.Show("¡Ingreso exitoso, bienvenido!"); // Login exitoso
                    }
                    else
                    {
                        MessageBox.Show("¡Contraseña incorrecta!");// Login fallido
                    }
                }
                else
                {
                    MessageBox.Show("¡Usuario incorrecto!"); // Usuario incorrecto
                }
            }
        }
    }
}
