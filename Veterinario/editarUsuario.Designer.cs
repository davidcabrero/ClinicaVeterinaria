
namespace Veterinario
{
    partial class editarUsuario
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
            this.correoCliente = new System.Windows.Forms.Label();
            this.apellidoCliente = new System.Windows.Forms.Label();
            this.nombreCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editNombre = new System.Windows.Forms.TextBox();
            this.editApellido = new System.Windows.Forms.TextBox();
            this.editEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UsuarioCliente = new System.Windows.Forms.Label();
            this.editContraseña = new System.Windows.Forms.TextBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // correoCliente
            // 
            this.correoCliente.AutoSize = true;
            this.correoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoCliente.Location = new System.Drawing.Point(123, 230);
            this.correoCliente.Name = "correoCliente";
            this.correoCliente.Size = new System.Drawing.Size(148, 17);
            this.correoCliente.TabIndex = 14;
            this.correoCliente.Text = "Correo Electrónico:";
            // 
            // apellidoCliente
            // 
            this.apellidoCliente.AutoSize = true;
            this.apellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoCliente.Location = new System.Drawing.Point(123, 183);
            this.apellidoCliente.Name = "apellidoCliente";
            this.apellidoCliente.Size = new System.Drawing.Size(71, 17);
            this.apellidoCliente.TabIndex = 13;
            this.apellidoCliente.Text = "Apellido:";
            // 
            // nombreCliente
            // 
            this.nombreCliente.AutoSize = true;
            this.nombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCliente.Location = new System.Drawing.Point(123, 132);
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Size = new System.Drawing.Size(69, 17);
            this.nombreCliente.TabIndex = 12;
            this.nombreCliente.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 49);
            this.label1.TabIndex = 16;
            this.label1.Text = "EDITAR USUARIO\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editNombre
            // 
            this.editNombre.Location = new System.Drawing.Point(302, 129);
            this.editNombre.Name = "editNombre";
            this.editNombre.Size = new System.Drawing.Size(345, 22);
            this.editNombre.TabIndex = 17;
            // 
            // editApellido
            // 
            this.editApellido.Location = new System.Drawing.Point(302, 178);
            this.editApellido.Name = "editApellido";
            this.editApellido.Size = new System.Drawing.Size(345, 22);
            this.editApellido.TabIndex = 19;
            // 
            // editEmail
            // 
            this.editEmail.Location = new System.Drawing.Point(302, 227);
            this.editEmail.Name = "editEmail";
            this.editEmail.Size = new System.Drawing.Size(345, 22);
            this.editEmail.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 57);
            this.button1.TabIndex = 21;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UsuarioCliente
            // 
            this.UsuarioCliente.AutoSize = true;
            this.UsuarioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioCliente.Location = new System.Drawing.Point(123, 278);
            this.UsuarioCliente.Name = "UsuarioCliente";
            this.UsuarioCliente.Size = new System.Drawing.Size(96, 17);
            this.UsuarioCliente.TabIndex = 15;
            this.UsuarioCliente.Text = "Contraseña:";
            // 
            // editContraseña
            // 
            this.editContraseña.Location = new System.Drawing.Point(302, 275);
            this.editContraseña.Name = "editContraseña";
            this.editContraseña.Size = new System.Drawing.Size(345, 22);
            this.editContraseña.TabIndex = 18;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(458, 367);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(106, 42);
            this.botonCancelar.TabIndex = 22;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // editarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editEmail);
            this.Controls.Add(this.editApellido);
            this.Controls.Add(this.editContraseña);
            this.Controls.Add(this.editNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsuarioCliente);
            this.Controls.Add(this.correoCliente);
            this.Controls.Add(this.apellidoCliente);
            this.Controls.Add(this.nombreCliente);
            this.Name = "editarUsuario";
            this.Text = "editarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label correoCliente;
        private System.Windows.Forms.Label apellidoCliente;
        private System.Windows.Forms.Label nombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox editNombre;
        private System.Windows.Forms.TextBox editApellido;
        private System.Windows.Forms.TextBox editEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label UsuarioCliente;
        private System.Windows.Forms.TextBox editContraseña;
        private System.Windows.Forms.Button botonCancelar;
    }
}