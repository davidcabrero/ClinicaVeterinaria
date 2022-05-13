
namespace Veterinario
{
    partial class PantallaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.MisDatos = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.UsuarioCliente = new System.Windows.Forms.Label();
            this.correoCliente = new System.Windows.Forms.Label();
            this.apellidoCliente = new System.Windows.Forms.Label();
            this.nombreCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Citas = new System.Windows.Forms.TabPage();
            this.sigCita = new System.Windows.Forms.Button();
            this.antCita = new System.Windows.Forms.Button();
            this.causaLabel = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.mascotaLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.Animales = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Anterior = new System.Windows.Forms.Button();
            this.observacionesLabel = new System.Windows.Forms.Label();
            this.siguienteButton = new System.Windows.Forms.Button();
            this.edadLabel = new System.Windows.Forms.Label();
            this.sexoLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.NombreAnimal = new System.Windows.Forms.Label();
            this.Clientes = new System.Windows.Forms.TabControl();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MisDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Citas.SuspendLayout();
            this.Animales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // MisDatos
            // 
            this.MisDatos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MisDatos.Controls.Add(this.pictureBox4);
            this.MisDatos.Controls.Add(this.pictureBox2);
            this.MisDatos.Controls.Add(this.button1);
            this.MisDatos.Controls.Add(this.emailLabel);
            this.MisDatos.Controls.Add(this.surnameLabel);
            this.MisDatos.Controls.Add(this.userLabel);
            this.MisDatos.Controls.Add(this.nameLabel);
            this.MisDatos.Controls.Add(this.UsuarioCliente);
            this.MisDatos.Controls.Add(this.correoCliente);
            this.MisDatos.Controls.Add(this.apellidoCliente);
            this.MisDatos.Controls.Add(this.nombreCliente);
            this.MisDatos.Controls.Add(this.label3);
            this.MisDatos.Location = new System.Drawing.Point(4, 25);
            this.MisDatos.Name = "MisDatos";
            this.MisDatos.Size = new System.Drawing.Size(792, 426);
            this.MisDatos.TabIndex = 3;
            this.MisDatos.Text = "Mis datos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(728, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Cerrar Sesión");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(311, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 64);
            this.button1.TabIndex = 16;
            this.button1.Text = "EDITAR DATOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(388, 257);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(359, 23);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "label15";
            // 
            // surnameLabel
            // 
            this.surnameLabel.Location = new System.Drawing.Point(388, 210);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(359, 23);
            this.surnameLabel.TabIndex = 14;
            this.surnameLabel.Text = "label14";
            // 
            // userLabel
            // 
            this.userLabel.Location = new System.Drawing.Point(388, 160);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(359, 23);
            this.userLabel.TabIndex = 13;
            this.userLabel.Text = "label7";
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(388, 112);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(359, 23);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "label5";
            // 
            // UsuarioCliente
            // 
            this.UsuarioCliente.AutoSize = true;
            this.UsuarioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioCliente.Location = new System.Drawing.Point(175, 160);
            this.UsuarioCliente.Name = "UsuarioCliente";
            this.UsuarioCliente.Size = new System.Drawing.Size(110, 17);
            this.UsuarioCliente.TabIndex = 11;
            this.UsuarioCliente.Text = "Usuario / DNI:";
            // 
            // correoCliente
            // 
            this.correoCliente.AutoSize = true;
            this.correoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoCliente.Location = new System.Drawing.Point(175, 257);
            this.correoCliente.Name = "correoCliente";
            this.correoCliente.Size = new System.Drawing.Size(148, 17);
            this.correoCliente.TabIndex = 8;
            this.correoCliente.Text = "Correo Electrónico:";
            // 
            // apellidoCliente
            // 
            this.apellidoCliente.AutoSize = true;
            this.apellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoCliente.Location = new System.Drawing.Point(175, 210);
            this.apellidoCliente.Name = "apellidoCliente";
            this.apellidoCliente.Size = new System.Drawing.Size(71, 17);
            this.apellidoCliente.TabIndex = 7;
            this.apellidoCliente.Text = "Apellido:";
            // 
            // nombreCliente
            // 
            this.nombreCliente.AutoSize = true;
            this.nombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCliente.Location = new System.Drawing.Point(175, 112);
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Size = new System.Drawing.Size(69, 17);
            this.nombreCliente.TabIndex = 6;
            this.nombreCliente.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "DATOS DEL CLIENTE";
            // 
            // Citas
            // 
            this.Citas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Citas.Controls.Add(this.pictureBox3);
            this.Citas.Controls.Add(this.sigCita);
            this.Citas.Controls.Add(this.antCita);
            this.Citas.Controls.Add(this.causaLabel);
            this.Citas.Controls.Add(this.fechaLabel);
            this.Citas.Controls.Add(this.mascotaLabel);
            this.Citas.Controls.Add(this.label13);
            this.Citas.Controls.Add(this.label6);
            this.Citas.Controls.Add(this.label4);
            this.Citas.Controls.Add(this.monthCalendar1);
            this.Citas.Controls.Add(this.label2);
            this.Citas.Location = new System.Drawing.Point(4, 25);
            this.Citas.Name = "Citas";
            this.Citas.Size = new System.Drawing.Size(792, 426);
            this.Citas.TabIndex = 2;
            this.Citas.Text = "Citas";
            // 
            // sigCita
            // 
            this.sigCita.Location = new System.Drawing.Point(265, 357);
            this.sigCita.Name = "sigCita";
            this.sigCita.Size = new System.Drawing.Size(93, 38);
            this.sigCita.TabIndex = 14;
            this.sigCita.Text = "Siguiente";
            this.sigCita.UseVisualStyleBackColor = true;
            this.sigCita.Click += new System.EventHandler(this.sigCita_Click);
            // 
            // antCita
            // 
            this.antCita.Location = new System.Drawing.Point(151, 357);
            this.antCita.Name = "antCita";
            this.antCita.Size = new System.Drawing.Size(95, 38);
            this.antCita.TabIndex = 13;
            this.antCita.Text = "Anterior";
            this.antCita.UseVisualStyleBackColor = true;
            this.antCita.Click += new System.EventHandler(this.antCita_Click);
            // 
            // causaLabel
            // 
            this.causaLabel.Location = new System.Drawing.Point(25, 228);
            this.causaLabel.Name = "causaLabel";
            this.causaLabel.Size = new System.Drawing.Size(482, 114);
            this.causaLabel.TabIndex = 12;
            this.causaLabel.Text = "label17";
            this.causaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.causaLabel.Click += new System.EventHandler(this.label17_Click);
            // 
            // fechaLabel
            // 
            this.fechaLabel.Location = new System.Drawing.Point(139, 129);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(368, 17);
            this.fechaLabel.TabIndex = 10;
            this.fechaLabel.Text = "label15";
            // 
            // mascotaLabel
            // 
            this.mascotaLabel.Location = new System.Drawing.Point(161, 91);
            this.mascotaLabel.Name = "mascotaLabel";
            this.mascotaLabel.Size = new System.Drawing.Size(346, 17);
            this.mascotaLabel.TabIndex = 9;
            this.mascotaLabel.Text = "label14";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(476, 25);
            this.label13.TabIndex = 8;
            this.label13.Text = "Causa:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mascota:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(535, 21);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "CITAS PRÓXIMAS";
            // 
            // Animales
            // 
            this.Animales.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Animales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Animales.Controls.Add(this.pictureBox1);
            this.Animales.Controls.Add(this.Anterior);
            this.Animales.Controls.Add(this.observacionesLabel);
            this.Animales.Controls.Add(this.siguienteButton);
            this.Animales.Controls.Add(this.edadLabel);
            this.Animales.Controls.Add(this.sexoLabel);
            this.Animales.Controls.Add(this.label12);
            this.Animales.Controls.Add(this.label11);
            this.Animales.Controls.Add(this.label10);
            this.Animales.Controls.Add(this.label9);
            this.Animales.Controls.Add(this.label8);
            this.Animales.Controls.Add(this.tipoLabel);
            this.Animales.Controls.Add(this.codigoLabel);
            this.Animales.Controls.Add(this.label1);
            this.Animales.Controls.Add(this.nombreLabel);
            this.Animales.Controls.Add(this.NombreAnimal);
            this.Animales.Location = new System.Drawing.Point(4, 25);
            this.Animales.Name = "Animales";
            this.Animales.Padding = new System.Windows.Forms.Padding(3);
            this.Animales.Size = new System.Drawing.Size(792, 426);
            this.Animales.TabIndex = 0;
            this.Animales.Text = "Animales";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(655, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Añadir Mascota");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Anterior
            // 
            this.Anterior.Location = new System.Drawing.Point(586, 302);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(78, 50);
            this.Anterior.TabIndex = 24;
            this.Anterior.Text = "Anterior";
            this.Anterior.UseVisualStyleBackColor = true;
            this.Anterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // observacionesLabel
            // 
            this.observacionesLabel.Location = new System.Drawing.Point(83, 276);
            this.observacionesLabel.Name = "observacionesLabel";
            this.observacionesLabel.Size = new System.Drawing.Size(497, 130);
            this.observacionesLabel.TabIndex = 23;
            this.observacionesLabel.Text = "label15";
            this.observacionesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siguienteButton
            // 
            this.siguienteButton.Location = new System.Drawing.Point(676, 302);
            this.siguienteButton.Name = "siguienteButton";
            this.siguienteButton.Size = new System.Drawing.Size(79, 50);
            this.siguienteButton.TabIndex = 22;
            this.siguienteButton.Text = "Siguiente";
            this.siguienteButton.UseVisualStyleBackColor = true;
            this.siguienteButton.Click += new System.EventHandler(this.siguienteButton_Click);
            // 
            // edadLabel
            // 
            this.edadLabel.Location = new System.Drawing.Point(422, 144);
            this.edadLabel.Name = "edadLabel";
            this.edadLabel.Size = new System.Drawing.Size(158, 27);
            this.edadLabel.TabIndex = 21;
            this.edadLabel.Text = "label14";
            // 
            // sexoLabel
            // 
            this.sexoLabel.Location = new System.Drawing.Point(422, 106);
            this.sexoLabel.Name = "sexoLabel";
            this.sexoLabel.Size = new System.Drawing.Size(158, 27);
            this.sexoLabel.TabIndex = 20;
            this.sexoLabel.Text = "label13";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(273, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 27);
            this.label12.TabIndex = 19;
            this.label12.Text = "Observaciones:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(367, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 27);
            this.label11.TabIndex = 18;
            this.label11.Text = "Edad:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(367, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 27);
            this.label10.TabIndex = 17;
            this.label10.Text = "Sexo:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(165, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 27);
            this.label9.TabIndex = 16;
            this.label9.Text = "Código Chip:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(165, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tipo:";
            // 
            // tipoLabel
            // 
            this.tipoLabel.Location = new System.Drawing.Point(215, 173);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(158, 27);
            this.tipoLabel.TabIndex = 14;
            this.tipoLabel.Text = "label7";
            // 
            // codigoLabel
            // 
            this.codigoLabel.Location = new System.Drawing.Point(268, 132);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(158, 27);
            this.codigoLabel.TabIndex = 13;
            this.codigoLabel.Text = "label6";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.Location = new System.Drawing.Point(239, 94);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(158, 27);
            this.nombreLabel.TabIndex = 11;
            this.nombreLabel.Text = "label4";
            this.nombreLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // NombreAnimal
            // 
            this.NombreAnimal.AutoSize = true;
            this.NombreAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NombreAnimal.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreAnimal.Location = new System.Drawing.Point(70, 12);
            this.NombreAnimal.Name = "NombreAnimal";
            this.NombreAnimal.Size = new System.Drawing.Size(180, 31);
            this.NombreAnimal.TabIndex = 3;
            this.NombreAnimal.Text = "Mis Mascotas";
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.Animales);
            this.Clientes.Controls.Add(this.Citas);
            this.Clientes.Controls.Add(this.MisDatos);
            this.Clientes.Location = new System.Drawing.Point(-1, -1);
            this.Clientes.Name = "Clientes";
            this.Clientes.SelectedIndex = 0;
            this.Clientes.Size = new System.Drawing.Size(800, 455);
            this.Clientes.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(572, 264);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(137, 131);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Añadir Cita");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(252, 336);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaPrincipal";
            this.Text = "Veterinario";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.MisDatos.ResumeLayout(false);
            this.MisDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Citas.ResumeLayout(false);
            this.Citas.PerformLayout();
            this.Animales.ResumeLayout(false);
            this.Animales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage MisDatos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label UsuarioCliente;
        private System.Windows.Forms.Label correoCliente;
        private System.Windows.Forms.Label apellidoCliente;
        private System.Windows.Forms.Label nombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage Citas;
        private System.Windows.Forms.Button sigCita;
        private System.Windows.Forms.Button antCita;
        private System.Windows.Forms.Label causaLabel;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label mascotaLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Animales;
        private System.Windows.Forms.Button Anterior;
        private System.Windows.Forms.Label observacionesLabel;
        private System.Windows.Forms.Button siguienteButton;
        private System.Windows.Forms.Label edadLabel;
        private System.Windows.Forms.Label sexoLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label NombreAnimal;
        private System.Windows.Forms.TabControl Clientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}