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
using System.IO;
using MaterialSkin.Controls;

namespace Sistema_Medico
{
    public partial class Form4 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private string correoPaciente;
        public Form4(string correoPaciente)
        {
            InitializeComponent();
            this.Text = "Sistema medico";
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
            this.correoPaciente=correoPaciente;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CargarDatosPorCorreo(correoPaciente);
        }
        private void CargarDatosPorCorreo(string correo)
        {
            string ruta = "registros.txt";

            if (!File.Exists(ruta))
            {
                MessageBox.Show("El archivo de registros no existe.");
                return;
            }

            foreach (string linea in File.ReadLines(ruta))
            {
                if (linea.Contains($"Correo: {correo}"))
                {
                    listBox1.Items.Add(linea);
                    return;
                }
            }

            MessageBox.Show("No se encontraron datos para el correo ingresado.");
        }


    }
}
