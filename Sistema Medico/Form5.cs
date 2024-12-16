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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Sistema_Medico
{
    public partial class Form5 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Form5(string especialidad, int precio)
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            this.Text = "Cita";
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
            label1.Text = $"Especialidad: {especialidad}";
            label2.Text = $"Total a pagar por consulta: {precio} Bs.";

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            MostrarSeguroEnLabel();
        }
        private void MostrarSeguroEnLabel()
        {
            string filePath = "registros.txt";
            if (File.Exists(filePath))
            {
                string seguro = ObtenerSeguro(filePath);

                label8.Text = $"Seguro: {seguro}";
            }
            else
            {
                label8.Text = "Archivo no encontrado.";
            }
        }
        private string ObtenerSeguro(string filePath)
        {
            var lineas = File.ReadAllLines(filePath);

            foreach (var linea in lineas)
            {
                if (linea.Contains("Seguro:"))
                {
                    string[] partes = linea.Split(',');
                    foreach (var parte in partes)
                    {
                        if (parte.Trim().StartsWith("Seguro:"))
                        {
                            return parte.Split(':')[1].Trim();
                        }
                    }
                }
            }

            return "No especificado";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }
        private void CalcularTotal()
        {
            decimal totalBase = ObtenerTotalBaseDesdeLabel();
            decimal costoAmbulancia = 150;
            decimal descuentoSeguro = 0.5m;
            decimal totalFinal = totalBase;

            if (materialCheckBox1.Checked)
            {
                totalFinal += costoAmbulancia;
            }

            string seguro = label8.Text.Replace("Seguro:", "").Trim();

            if (!seguro.Equals("Independiente", StringComparison.OrdinalIgnoreCase))
            {
                totalFinal *= (1 - descuentoSeguro);
            }

            label9.Text = $"Total a pagar: {totalFinal} Bs.";
        }
        private decimal ObtenerTotalBaseDesdeLabel()
        {
            try
            {
                string textoLabel = label2.Text;
                string numeroComoTexto = textoLabel.Split(':')[1].Replace("Bs.", "").Trim();
                return Convert.ToDecimal(numeroComoTexto);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el monto base de la consulta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            CalcularTotal();
            pictureBox1.Visible = true;

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cita confirmada");
        }
    }
}
