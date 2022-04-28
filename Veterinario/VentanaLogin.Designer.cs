
namespace Veterinario
{
    partial class VentanaLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLogin));
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.LOGIN = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.CORREOELECTRONICO = new System.Windows.Forms.Label();
            this.CONTRASEÑA = new System.Windows.Forms.Label();
            this.NoRegistro = new System.Windows.Forms.Label();
            this.botonRegistrarse = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(86, 251);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(254, 22);
            this.textBoxDNI.TabIndex = 0;
            // 
            // LOGIN
            // 
            this.LOGIN.AutoSize = true;
            this.LOGIN.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Location = new System.Drawing.Point(132, 173);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(159, 48);
            this.LOGIN.TabIndex = 1;
            this.LOGIN.Text = "LOGIN";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(86, 296);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(254, 22);
            this.textBoxContraseña.TabIndex = 2;
            // 
            // CORREOELECTRONICO
            // 
            this.CORREOELECTRONICO.AutoSize = true;
            this.CORREOELECTRONICO.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CORREOELECTRONICO.Location = new System.Drawing.Point(83, 231);
            this.CORREOELECTRONICO.Name = "CORREOELECTRONICO";
            this.CORREOELECTRONICO.Size = new System.Drawing.Size(69, 17);
            this.CORREOELECTRONICO.TabIndex = 3;
            this.CORREOELECTRONICO.Text = "Usuario:";
            // 
            // CONTRASEÑA
            // 
            this.CONTRASEÑA.AutoSize = true;
            this.CONTRASEÑA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONTRASEÑA.Location = new System.Drawing.Point(83, 276);
            this.CONTRASEÑA.Name = "CONTRASEÑA";
            this.CONTRASEÑA.Size = new System.Drawing.Size(96, 17);
            this.CONTRASEÑA.TabIndex = 4;
            this.CONTRASEÑA.Text = "Contraseña:";
            // 
            // NoRegistro
            // 
            this.NoRegistro.AutoSize = true;
            this.NoRegistro.Location = new System.Drawing.Point(111, 374);
            this.NoRegistro.Name = "NoRegistro";
            this.NoRegistro.Size = new System.Drawing.Size(199, 17);
            this.NoRegistro.TabIndex = 5;
            this.NoRegistro.Text = "Todavía no estás registrad@?";
            // 
            // botonRegistrarse
            // 
            this.botonRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistrarse.Location = new System.Drawing.Point(140, 396);
            this.botonRegistrarse.Name = "botonRegistrarse";
            this.botonRegistrarse.Size = new System.Drawing.Size(143, 24);
            this.botonRegistrarse.TabIndex = 6;
            this.botonRegistrarse.Text = "REGÍSTRATE";
            this.botonRegistrarse.UseVisualStyleBackColor = true;
            this.botonRegistrarse.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(122, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(188, 148);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Inicia Sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // VentanalLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.botonRegistrarse);
            this.Controls.Add(this.NoRegistro);
            this.Controls.Add(this.CONTRASEÑA);
            this.Controls.Add(this.CORREOELECTRONICO);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.textBoxDNI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanalLogin";
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label LOGIN;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label CORREOELECTRONICO;
        private System.Windows.Forms.Label CONTRASEÑA;
        private System.Windows.Forms.Label NoRegistro;
        private System.Windows.Forms.Button botonRegistrarse;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button button1;
    }
}

