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
        private string archivoCitas = "citas.txt";
        private Dictionary<string, int> contadorEspecialidades = new Dictionary<string, int>();
        private const int limiteCitas = 10;
        public Form4(string correoPaciente)
        {
            InitializeComponent();
            this.Text = "Sistema medico";
            this.correoPaciente=correoPaciente;
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
            InicializarContadorEspecialidades();
            CargarCitas();
            ActualizarLabels();
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
        private void InicializarContadorEspecialidades()
        {
            contadorEspecialidades["Medicina General"] = 0;
            contadorEspecialidades["Urología"] = 0;
            contadorEspecialidades["Neurología"] = 0;
            contadorEspecialidades["Dermatología"] = 0;
            contadorEspecialidades["Ginecología"] = 0;
            contadorEspecialidades["Traumatología"] = 0;
        }
        private void CargarCitas()
        {
            if (File.Exists(archivoCitas))
            {
                foreach (string linea in File.ReadLines(archivoCitas))
                {
                    var datos = linea.Split(';');
                    if (datos.Length == 2)
                    {
                        string especialidad = datos[0];
                        int cantidad = int.Parse(datos[1]);
                        if (contadorEspecialidades.ContainsKey(especialidad))
                        {
                            contadorEspecialidades[especialidad] = cantidad;
                        }
                    }
                }
            }
        }
        private void GuardarCitas()
        {
            using (StreamWriter sw = new StreamWriter(archivoCitas))
            {
                foreach (var especialidad in contadorEspecialidades)
                {
                    sw.WriteLine($"{especialidad.Key};{especialidad.Value}");
                }
            }
        }
        private void ActualizarLabels()
        {
            general.Text = $"{contadorEspecialidades["Medicina General"]}/10";
            urologia.Text = $"{contadorEspecialidades["Urología"]}/10";
            neurologia.Text = $"{contadorEspecialidades["Neurología"]}/10";
            dermatologia.Text = $"{contadorEspecialidades["Dermatología"]}/10";
            ginecologia.Text = $"{contadorEspecialidades["Ginecología"]}/10";
            traumatologia.Text = $"{contadorEspecialidades["Traumatología"]}/10";
        }
        private void ConfirmarCita(string especialidad)
        {
            if (contadorEspecialidades.Values.Sum() >= limiteCitas)
            {
                MessageBox.Show("Se ha alcanzado el límite de 10 pacientes por día.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contadorEspecialidades.ContainsKey(especialidad))
            {
                if (contadorEspecialidades[especialidad] < 10)
                {
                    contadorEspecialidades[especialidad]++;
                    GuardarCitas();
                    ActualizarLabels();
                    MessageBox.Show($"Cita confirmada en {especialidad}.\nTotal pacientes: {contadorEspecialidades[especialidad]}", "Cita Confirmada");
                }
                else
                {
                    MessageBox.Show($"La especialidad {especialidad} ya tiene 10 pacientes.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmarCita("Medicina General");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfirmarCita("Neurología");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConfirmarCita("Ginecología");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConfirmarCita("Urología");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ConfirmarCita("Dermatología");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConfirmarCita("Traumatología");
        }
    }
}
