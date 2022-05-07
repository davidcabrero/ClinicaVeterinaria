namespace Veterinario
{
    partial class VentanaCitas
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
            this.aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.causa = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(793, 412);
            this.aceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(179, 90);
            this.aceptar.TabIndex = 0;
            this.aceptar.Text = "aceptar y continuar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "introduce la fecha\r\n(Año-mes-día)\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "introduce la causa";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(575, 412);
            this.cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(141, 90);
            this.cancelar.TabIndex = 7;
            this.cancelar.Text = "cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // causa
            // 
            this.causa.Location = new System.Drawing.Point(372, 200);
            this.causa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.causa.Name = "causa";
            this.causa.Size = new System.Drawing.Size(599, 22);
            this.causa.TabIndex = 13;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(372, 93);
            this.fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(599, 22);
            this.fecha.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "introduce el chip";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(373, 285);
            this.codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(599, 22);
            this.codigo.TabIndex = 16;
            // 
            // VentanaCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.causa);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aceptar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentanaCitas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.TextBox causa;
        private System.Windows.Forms.TextBox fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codigo;
    }
}