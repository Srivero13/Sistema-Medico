using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;

namespace Sistema_Medico
{

    public partial class Form2 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Form2()
        {
            InitializeComponent();
            this.Text = "Login";
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600,
                Primary.Blue700,
                Primary.Blue200,
                Accent.Orange700,
                TextShade.WHITE
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correoIngresado = textBox1.Text;
            string passwordIngresado = textBox2.Text;

            if (ValidarLogin(correoIngresado, passwordIngresado))
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form4 form4 = new Form4(correoIngresado);
                this.Hide();
                form4.Show();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarLogin(string correo, string password)
        {
            string ruta = "registros1.txt";

            if (!File.Exists(ruta))
                return false;

            foreach (string linea in File.ReadLines(ruta))
            {
                string[] datos = linea.Split(',');
                if (datos.Length == 2)
                {
                    string correoGuardado = datos[0];
                    string passwordGuardado = datos[1];

                    if (correo == correoGuardado && password == passwordGuardado)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
