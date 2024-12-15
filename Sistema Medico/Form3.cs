using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Sistema_Medico
{
    public partial class Form3 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private List<RegistroUsuario> registros = new List<RegistroUsuario>();

        public Form3()
        {
            InitializeComponent();
            this.Text = "Register";
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

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void buttonIngresar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, llena todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RegistroUsuario nuevoRegistro = new RegistroUsuario()
            {
                CarnetIdentidad = carnetTextBox.Text,
                Nombres = nombresTextBox.Text,
                Apellidos = apellidosTextBox.Text,
                Nacionalidad = nacionalidadComboBox.SelectedItem.ToString(),
                FechaNacimiento = fechaNacimientoPicker.Value.ToString("yyyy-MM-dd"),
                Direccion = direccionTextBox.Text,
                Correo = correoTextBox.Text,
                Password = direccionTextBox.Text,
                Seguro = seguroComboBox.SelectedItem.ToString()
            };

            registros.Add(nuevoRegistro);
            GuardarEnArchivo(nuevoRegistro);
            registros.Add(nuevoRegistro);
            GuardarEnArchivo1(nuevoRegistro);

            MessageBox.Show("Registro exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
            Form1 form = new Form1();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(carnetTextBox.Text) ||
                string.IsNullOrWhiteSpace(nombresTextBox.Text) ||
                string.IsNullOrWhiteSpace(apellidosTextBox.Text) ||
                string.IsNullOrWhiteSpace(direccionTextBox.Text) ||
                string.IsNullOrWhiteSpace(correoTextBox.Text) ||
                string.IsNullOrWhiteSpace(direccionTextBox.Text) ||
                nacionalidadComboBox.SelectedItem == null ||
                seguroComboBox.SelectedItem == null)
            {
                return false;
            }

            if (!correoTextBox.Text.Contains("@"))
            {
                MessageBox.Show("Correo electrónico inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void GuardarEnArchivo(RegistroUsuario registro)
        {
            string ruta = "registros.txt";
            string datos = $"CI: {registro.CarnetIdentidad}, Nombre: {registro.Nombres} {registro.Apellidos}, " +
                           $"Nacionalidad: {registro.Nacionalidad}, Fecha Nacimiento: {registro.FechaNacimiento}, " +
                           $"Seguro: {registro.Seguro}, Correo: {registro.Correo}";
            File.AppendAllText(ruta, datos + Environment.NewLine);
        }
        private void GuardarEnArchivo1(RegistroUsuario registro)
        {
            string ruta = "registros1.txt";
            string datos = $"{registro.Correo},{registro.Password}";
            File.AppendAllText(ruta, datos + Environment.NewLine);
        }

        private void LimpiarCampos()
        {
            carnetTextBox.Text = "";
            nombresTextBox.Text = "";
            apellidosTextBox.Text = "";
            nacionalidadComboBox.SelectedIndex = 0;
            direccionTextBox.Text = "";
            correoTextBox.Text = "";
            direccionTextBox.Text = "";
            seguroComboBox.SelectedIndex = 0;
        }

    }
    public class RegistroUsuario
    {
        public string CarnetIdentidad { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Nacionalidad { get; set; }
        public string FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public string Seguro { get; set; }
    }
}
