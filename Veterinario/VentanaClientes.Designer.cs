
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.MisDatos = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreCliente0 = new System.Windows.Forms.Label();
            this.apellidoCliente0 = new System.Windows.Forms.Label();
            this.CorreoElectronico0 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Citas = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Animales = new System.Windows.Forms.TabPage();
            this.FotoAnimal1 = new System.Windows.Forms.PictureBox();
            this.NombreAnimal = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.Label();
            this.edadAnimal1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SexoAnimal1 = new System.Windows.Forms.Label();
            this.AñadirAnimal = new System.Windows.Forms.Button();
            this.Clientes = new System.Windows.Forms.TabControl();
            this.Facturas = new System.Windows.Forms.TabPage();
            this.MisDatos.SuspendLayout();
            this.Citas.SuspendLayout();
            this.Animales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoAnimal1)).BeginInit();
            this.Clientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // MisDatos
            // 
            this.MisDatos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MisDatos.Controls.Add(this.button2);
            this.MisDatos.Controls.Add(this.label5);
            this.MisDatos.Controls.Add(this.CorreoElectronico0);
            this.MisDatos.Controls.Add(this.apellidoCliente0);
            this.MisDatos.Controls.Add(this.nombreCliente0);
            this.MisDatos.Controls.Add(this.label3);
            this.MisDatos.Location = new System.Drawing.Point(4, 25);
            this.MisDatos.Name = "MisDatos";
            this.MisDatos.Size = new System.Drawing.Size(792, 426);
            this.MisDatos.TabIndex = 3;
            this.MisDatos.Text = "Mis datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "NOMBRE DEL CLIENTE";
            // 
            // nombreCliente0
            // 
            this.nombreCliente0.AutoSize = true;
            this.nombreCliente0.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCliente0.Location = new System.Drawing.Point(34, 102);
            this.nombreCliente0.Name = "nombreCliente0";
            this.nombreCliente0.Size = new System.Drawing.Size(69, 17);
            this.nombreCliente0.TabIndex = 6;
            this.nombreCliente0.Text = "Nombre:";
            // 
            // apellidoCliente0
            // 
            this.apellidoCliente0.AutoSize = true;
            this.apellidoCliente0.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoCliente0.Location = new System.Drawing.Point(34, 166);
            this.apellidoCliente0.Name = "apellidoCliente0";
            this.apellidoCliente0.Size = new System.Drawing.Size(71, 17);
            this.apellidoCliente0.TabIndex = 7;
            this.apellidoCliente0.Text = "Apellido:";
            // 
            // CorreoElectronico0
            // 
            this.CorreoElectronico0.AutoSize = true;
            this.CorreoElectronico0.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoElectronico0.Location = new System.Drawing.Point(34, 224);
            this.CorreoElectronico0.Name = "CorreoElectronico0";
            this.CorreoElectronico0.Size = new System.Drawing.Size(148, 17);
            this.CorreoElectronico0.TabIndex = 8;
            this.CorreoElectronico0.Text = "Correo Electrónico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dueño de:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(322, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "CAMBIAR CONTRASEÑA";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Citas
            // 
            this.Citas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Citas.Controls.Add(this.monthCalendar1);
            this.Citas.Controls.Add(this.label2);
            this.Citas.Location = new System.Drawing.Point(4, 25);
            this.Citas.Name = "Citas";
            this.Citas.Size = new System.Drawing.Size(792, 426);
            this.Citas.TabIndex = 2;
            this.Citas.Text = "Citas";
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
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(535, 21);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // Animales
            // 
            this.Animales.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Animales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Animales.Controls.Add(this.AñadirAnimal);
            this.Animales.Controls.Add(this.SexoAnimal1);
            this.Animales.Controls.Add(this.label1);
            this.Animales.Controls.Add(this.edadAnimal1);
            this.Animales.Controls.Add(this.edad);
            this.Animales.Controls.Add(this.NombreAnimal);
            this.Animales.Controls.Add(this.FotoAnimal1);
            this.Animales.Location = new System.Drawing.Point(4, 25);
            this.Animales.Name = "Animales";
            this.Animales.Padding = new System.Windows.Forms.Padding(3);
            this.Animales.Size = new System.Drawing.Size(792, 426);
            this.Animales.TabIndex = 0;
            this.Animales.Text = "Animales";
            // 
            // FotoAnimal1
            // 
            this.FotoAnimal1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FotoAnimal1.Location = new System.Drawing.Point(8, 56);
            this.FotoAnimal1.MaximumSize = new System.Drawing.Size(250, 250);
            this.FotoAnimal1.MinimumSize = new System.Drawing.Size(250, 250);
            this.FotoAnimal1.Name = "FotoAnimal1";
            this.FotoAnimal1.Size = new System.Drawing.Size(250, 250);
            this.FotoAnimal1.TabIndex = 2;
            this.FotoAnimal1.TabStop = false;
            // 
            // NombreAnimal
            // 
            this.NombreAnimal.AutoSize = true;
            this.NombreAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NombreAnimal.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreAnimal.Location = new System.Drawing.Point(70, 12);
            this.NombreAnimal.Name = "NombreAnimal";
            this.NombreAnimal.Size = new System.Drawing.Size(115, 31);
            this.NombreAnimal.TabIndex = 3;
            this.NombreAnimal.Text = "Animal1";
            // 
            // edad
            // 
            this.edad.AutoSize = true;
            this.edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad.Location = new System.Drawing.Point(286, 60);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(55, 17);
            this.edad.TabIndex = 6;
            this.edad.Text = "EDAD:";
            // 
            // edadAnimal1
            // 
            this.edadAnimal1.AutoSize = true;
            this.edadAnimal1.Location = new System.Drawing.Point(347, 60);
            this.edadAnimal1.Name = "edadAnimal1";
            this.edadAnimal1.Size = new System.Drawing.Size(59, 17);
            this.edadAnimal1.TabIndex = 7;
            this.edadAnimal1.Text = "12 años";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "SEXO:";
            // 
            // SexoAnimal1
            // 
            this.SexoAnimal1.AutoSize = true;
            this.SexoAnimal1.Location = new System.Drawing.Point(350, 123);
            this.SexoAnimal1.Name = "SexoAnimal1";
            this.SexoAnimal1.Size = new System.Drawing.Size(50, 17);
            this.SexoAnimal1.TabIndex = 9;
            this.SexoAnimal1.Text = "Macho";
            // 
            // AñadirAnimal
            // 
            this.AñadirAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AñadirAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AñadirAnimal.Location = new System.Drawing.Point(672, 29);
            this.AñadirAnimal.Name = "AñadirAnimal";
            this.AñadirAnimal.Size = new System.Drawing.Size(75, 48);
            this.AñadirAnimal.TabIndex = 10;
            this.AñadirAnimal.Text = "AÑADIR ANIMAL";
            this.AñadirAnimal.UseVisualStyleBackColor = true;
            this.AñadirAnimal.Click += new System.EventHandler(this.AñadirAnimal_Click);
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.Animales);
            this.Clientes.Controls.Add(this.Citas);
            this.Clientes.Controls.Add(this.MisDatos);
            this.Clientes.Controls.Add(this.Facturas);
            this.Clientes.Location = new System.Drawing.Point(-1, -1);
            this.Clientes.Name = "Clientes";
            this.Clientes.SelectedIndex = 0;
            this.Clientes.Size = new System.Drawing.Size(800, 455);
            this.Clientes.TabIndex = 0;
            // 
            // Facturas
            // 
            this.Facturas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Facturas.Location = new System.Drawing.Point(4, 25);
            this.Facturas.Name = "Facturas";
            this.Facturas.Padding = new System.Windows.Forms.Padding(3);
            this.Facturas.Size = new System.Drawing.Size(792, 426);
            this.Facturas.TabIndex = 4;
            this.Facturas.Text = "Facturas";
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
            this.Citas.ResumeLayout(false);
            this.Citas.PerformLayout();
            this.Animales.ResumeLayout(false);
            this.Animales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoAnimal1)).EndInit();
            this.Clientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage MisDatos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CorreoElectronico0;
        private System.Windows.Forms.Label apellidoCliente0;
        private System.Windows.Forms.Label nombreCliente0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage Citas;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Animales;
        private System.Windows.Forms.Button AñadirAnimal;
        private System.Windows.Forms.Label SexoAnimal1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label edadAnimal1;
        private System.Windows.Forms.Label edad;
        private System.Windows.Forms.Label NombreAnimal;
        private System.Windows.Forms.PictureBox FotoAnimal1;
        private System.Windows.Forms.TabControl Clientes;
        private System.Windows.Forms.TabPage Facturas;
    }
}