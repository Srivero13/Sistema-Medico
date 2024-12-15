namespace Sistema_Medico
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.fechaNacimientoPicker = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.seguroComboBox = new System.Windows.Forms.ComboBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nacionalidadComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.carnetTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.fechaNacimientoPicker);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.seguroComboBox);
            this.panel1.Controls.Add(this.correoTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.direccionTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nacionalidadComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.apellidosTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nombresTextBox);
            this.panel1.Controls.Add(this.carnetTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonIngresar);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 495);
            this.panel1.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(152, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Fecha de nacimiento";
            // 
            // fechaNacimientoPicker
            // 
            this.fechaNacimientoPicker.Location = new System.Drawing.Point(152, 182);
            this.fechaNacimientoPicker.Name = "fechaNacimientoPicker";
            this.fechaNacimientoPicker.Size = new System.Drawing.Size(180, 20);
            this.fechaNacimientoPicker.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(25, 314);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(248, 20);
            this.textBox6.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Seguro";
            // 
            // seguroComboBox
            // 
            this.seguroComboBox.FormattingEnabled = true;
            this.seguroComboBox.Items.AddRange(new object[] {
            "CNS",
            "BISA SEGUROS",
            "ALIANZA SEGUROS",
            "DUPA BOLIVIA",
            "NACIONAL SEGUROS",
            "INDEPENDIENTE",
            "NEARSURE",
            "NICE",
            "FARMACORP",
            "EMBOL",
            "EMPRESA D/ TERCEROS"});
            this.seguroComboBox.Location = new System.Drawing.Point(25, 358);
            this.seguroComboBox.Name = "seguroComboBox";
            this.seguroComboBox.Size = new System.Drawing.Size(121, 21);
            this.seguroComboBox.TabIndex = 15;
            // 
            // correoTextBox
            // 
            this.correoTextBox.BackColor = System.Drawing.Color.White;
            this.correoTextBox.Location = new System.Drawing.Point(25, 270);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(248, 20);
            this.correoTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Correo electronico";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.BackColor = System.Drawing.Color.White;
            this.direccionTextBox.Location = new System.Drawing.Point(25, 226);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(248, 20);
            this.direccionTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Direccion";
            // 
            // nacionalidadComboBox
            // 
            this.nacionalidadComboBox.FormattingEnabled = true;
            this.nacionalidadComboBox.Items.AddRange(new object[] {
            "Boliviana",
            "Peruana",
            "Chilena",
            "Estadounidense",
            "Alemana",
            "Española",
            "Argentina",
            "Colombiana",
            "Ecuatoriana",
            "Venezolana",
            "Brasilera",
            "Paraguaya",
            "Uruguaya",
            "Inglesa",
            "Mexicana",
            "Canadiense"});
            this.nacionalidadComboBox.Location = new System.Drawing.Point(25, 181);
            this.nacionalidadComboBox.Name = "nacionalidadComboBox";
            this.nacionalidadComboBox.Size = new System.Drawing.Size(121, 21);
            this.nacionalidadComboBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nacionalidad";
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.BackColor = System.Drawing.Color.White;
            this.apellidosTextBox.Location = new System.Drawing.Point(25, 137);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(248, 20);
            this.apellidosTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellidos";
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.BackColor = System.Drawing.Color.White;
            this.nombresTextBox.Location = new System.Drawing.Point(25, 93);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(248, 20);
            this.nombresTextBox.TabIndex = 6;
            // 
            // carnetTextBox
            // 
            this.carnetTextBox.BackColor = System.Drawing.Color.White;
            this.carnetTextBox.Location = new System.Drawing.Point(25, 49);
            this.carnetTextBox.Name = "carnetTextBox";
            this.carnetTextBox.Size = new System.Drawing.Size(248, 20);
            this.carnetTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Carnet de identidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registro";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.BackColor = System.Drawing.Color.Transparent;
            this.buttonIngresar.Location = new System.Drawing.Point(68, 385);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(174, 33);
            this.buttonIngresar.TabIndex = 0;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sistema_Medico.Properties.Resources._188819729_multiracial_team_of_professional_medical_surgeons_performs_the_surgical_operation_in_hospital;
            this.pictureBox1.Location = new System.Drawing.Point(344, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 495);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 516);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox carnetTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox seguroComboBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox nacionalidadComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker fechaNacimientoPicker;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
    }
}