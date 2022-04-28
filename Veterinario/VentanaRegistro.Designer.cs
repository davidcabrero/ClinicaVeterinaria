
namespace Veterinario
{
    partial class VentanaRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaRegistro));
            this.REGISTRO = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.textBoxCorreoElectronico = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.Registrarme = new System.Windows.Forms.Button();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // REGISTRO
            // 
            this.REGISTRO.AutoSize = true;
            this.REGISTRO.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTRO.Location = new System.Drawing.Point(102, 9);
            this.REGISTRO.Name = "REGISTRO";
            this.REGISTRO.Size = new System.Drawing.Size(235, 48);
            this.REGISTRO.TabIndex = 0;
            this.REGISTRO.Text = "REGISTRO";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(173, 137);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(69, 17);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(110, 157);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(216, 22);
            this.textBoxNombre.TabIndex = 2;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.Location = new System.Drawing.Point(173, 197);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(71, 17);
            this.Apellido.TabIndex = 3;
            this.Apellido.Text = "Apellido:";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(110, 217);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(216, 22);
            this.textBoxApellido.TabIndex = 4;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(141, 255);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(148, 17);
            this.Email.TabIndex = 5;
            this.Email.Text = "Correo Electrónico:";
            // 
            // textBoxCorreoElectronico
            // 
            this.textBoxCorreoElectronico.Location = new System.Drawing.Point(110, 275);
            this.textBoxCorreoElectronico.Name = "textBoxCorreoElectronico";
            this.textBoxCorreoElectronico.Size = new System.Drawing.Size(216, 22);
            this.textBoxCorreoElectronico.TabIndex = 6;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(164, 310);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(96, 17);
            this.Contraseña.TabIndex = 7;
            this.Contraseña.Text = "Contraseña:";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(110, 330);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(216, 22);
            this.textBoxContraseña.TabIndex = 8;
            // 
            // Registrarme
            // 
            this.Registrarme.Location = new System.Drawing.Point(158, 380);
            this.Registrarme.Name = "Registrarme";
            this.Registrarme.Size = new System.Drawing.Size(113, 47);
            this.Registrarme.TabIndex = 9;
            this.Registrarme.Text = "Registrarme";
            this.Registrarme.UseVisualStyleBackColor = true;
            this.Registrarme.Click += new System.EventHandler(this.Registrarme_Click);
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(110, 101);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(216, 22);
            this.textBoxDNI.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "DNI:";
            // 
            // VentanaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registrarme);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.textBoxCorreoElectronico);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.REGISTRO);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaRegistro";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "REGISTRO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label REGISTRO;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox textBoxCorreoElectronico;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Button Registrarme;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label1;
    }
}