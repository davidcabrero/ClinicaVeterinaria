
namespace Veterinario
{
    partial class VentanaTrabajador
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
            this.Trabajador = new System.Windows.Forms.TabControl();
            this.Citas = new System.Windows.Forms.TabPage();
            this.Mascotas = new System.Windows.Forms.TabPage();
            this.sigCita = new System.Windows.Forms.Button();
            this.antCita = new System.Windows.Forms.Button();
            this.causaLabel = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.mascotaLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.editCita = new System.Windows.Forms.Button();
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
            this.label3 = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.userMasc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Trabajador.SuspendLayout();
            this.Citas.SuspendLayout();
            this.Mascotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Trabajador
            // 
            this.Trabajador.Controls.Add(this.Citas);
            this.Trabajador.Controls.Add(this.Mascotas);
            this.Trabajador.Location = new System.Drawing.Point(-1, -1);
            this.Trabajador.Name = "Trabajador";
            this.Trabajador.SelectedIndex = 0;
            this.Trabajador.Size = new System.Drawing.Size(801, 477);
            this.Trabajador.TabIndex = 0;
            // 
            // Citas
            // 
            this.Citas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Citas.Controls.Add(this.editCita);
            this.Citas.Controls.Add(this.label1);
            this.Citas.Controls.Add(this.search);
            this.Citas.Controls.Add(this.user);
            this.Citas.Controls.Add(this.sigCita);
            this.Citas.Controls.Add(this.antCita);
            this.Citas.Controls.Add(this.causaLabel);
            this.Citas.Controls.Add(this.fechaLabel);
            this.Citas.Controls.Add(this.mascotaLabel);
            this.Citas.Controls.Add(this.label13);
            this.Citas.Controls.Add(this.label6);
            this.Citas.Controls.Add(this.label4);
            this.Citas.Controls.Add(this.label2);
            this.Citas.Location = new System.Drawing.Point(4, 25);
            this.Citas.Name = "Citas";
            this.Citas.Padding = new System.Windows.Forms.Padding(3);
            this.Citas.Size = new System.Drawing.Size(793, 448);
            this.Citas.TabIndex = 0;
            this.Citas.Text = "Citas";
            // 
            // Mascotas
            // 
            this.Mascotas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Mascotas.Controls.Add(this.button2);
            this.Mascotas.Controls.Add(this.label7);
            this.Mascotas.Controls.Add(this.label5);
            this.Mascotas.Controls.Add(this.button1);
            this.Mascotas.Controls.Add(this.userMasc);
            this.Mascotas.Controls.Add(this.Anterior);
            this.Mascotas.Controls.Add(this.observacionesLabel);
            this.Mascotas.Controls.Add(this.siguienteButton);
            this.Mascotas.Controls.Add(this.edadLabel);
            this.Mascotas.Controls.Add(this.sexoLabel);
            this.Mascotas.Controls.Add(this.label12);
            this.Mascotas.Controls.Add(this.label11);
            this.Mascotas.Controls.Add(this.label10);
            this.Mascotas.Controls.Add(this.label9);
            this.Mascotas.Controls.Add(this.label8);
            this.Mascotas.Controls.Add(this.tipoLabel);
            this.Mascotas.Controls.Add(this.codigoLabel);
            this.Mascotas.Controls.Add(this.label3);
            this.Mascotas.Controls.Add(this.nombreLabel);
            this.Mascotas.Location = new System.Drawing.Point(4, 25);
            this.Mascotas.Name = "Mascotas";
            this.Mascotas.Padding = new System.Windows.Forms.Padding(3);
            this.Mascotas.Size = new System.Drawing.Size(793, 448);
            this.Mascotas.TabIndex = 1;
            this.Mascotas.Text = "Mascotas";
            // 
            // sigCita
            // 
            this.sigCita.Location = new System.Drawing.Point(271, 388);
            this.sigCita.Name = "sigCita";
            this.sigCita.Size = new System.Drawing.Size(93, 38);
            this.sigCita.TabIndex = 25;
            this.sigCita.Text = "Siguiente";
            this.sigCita.UseVisualStyleBackColor = true;
            this.sigCita.Click += new System.EventHandler(this.sigCita_Click);
            // 
            // antCita
            // 
            this.antCita.Location = new System.Drawing.Point(157, 388);
            this.antCita.Name = "antCita";
            this.antCita.Size = new System.Drawing.Size(95, 38);
            this.antCita.TabIndex = 24;
            this.antCita.Text = "Anterior";
            this.antCita.UseVisualStyleBackColor = true;
            this.antCita.Click += new System.EventHandler(this.antCita_Click);
            // 
            // causaLabel
            // 
            this.causaLabel.Location = new System.Drawing.Point(31, 244);
            this.causaLabel.Name = "causaLabel";
            this.causaLabel.Size = new System.Drawing.Size(482, 114);
            this.causaLabel.TabIndex = 23;
            this.causaLabel.Text = "label17";
            this.causaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fechaLabel
            // 
            this.fechaLabel.Location = new System.Drawing.Point(145, 145);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(368, 17);
            this.fechaLabel.TabIndex = 22;
            this.fechaLabel.Text = "label15";
            // 
            // mascotaLabel
            // 
            this.mascotaLabel.Location = new System.Drawing.Point(167, 107);
            this.mascotaLabel.Name = "mascotaLabel";
            this.mascotaLabel.Size = new System.Drawing.Size(346, 17);
            this.mascotaLabel.TabIndex = 21;
            this.mascotaLabel.Text = "label14";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(37, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(476, 25);
            this.label13.TabIndex = 20;
            this.label13.Text = "Causa:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mascota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(541, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "CITAS PRÓXIMAS";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(40, 46);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(364, 22);
            this.user.TabIndex = 26;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(410, 42);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 30);
            this.search.TabIndex = 27;
            this.search.Text = "Buscar";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Introduce el DNI de un cliente";
            // 
            // editCita
            // 
            this.editCita.Location = new System.Drawing.Point(589, 218);
            this.editCita.Name = "editCita";
            this.editCita.Size = new System.Drawing.Size(127, 76);
            this.editCita.TabIndex = 29;
            this.editCita.Text = "Editar Cita";
            this.editCita.UseVisualStyleBackColor = true;
            this.editCita.Click += new System.EventHandler(this.editCita_Click);
            // 
            // Anterior
            // 
            this.Anterior.Location = new System.Drawing.Point(572, 345);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(78, 50);
            this.Anterior.TabIndex = 38;
            this.Anterior.Text = "Anterior";
            this.Anterior.UseVisualStyleBackColor = true;
            this.Anterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // observacionesLabel
            // 
            this.observacionesLabel.Location = new System.Drawing.Point(28, 265);
            this.observacionesLabel.Name = "observacionesLabel";
            this.observacionesLabel.Size = new System.Drawing.Size(497, 130);
            this.observacionesLabel.TabIndex = 37;
            this.observacionesLabel.Text = "label15";
            this.observacionesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siguienteButton
            // 
            this.siguienteButton.Location = new System.Drawing.Point(665, 345);
            this.siguienteButton.Name = "siguienteButton";
            this.siguienteButton.Size = new System.Drawing.Size(79, 50);
            this.siguienteButton.TabIndex = 36;
            this.siguienteButton.Text = "Siguiente";
            this.siguienteButton.UseVisualStyleBackColor = true;
            this.siguienteButton.Click += new System.EventHandler(this.siguienteButton_Click);
            // 
            // edadLabel
            // 
            this.edadLabel.Location = new System.Drawing.Point(304, 160);
            this.edadLabel.Name = "edadLabel";
            this.edadLabel.Size = new System.Drawing.Size(158, 27);
            this.edadLabel.TabIndex = 35;
            this.edadLabel.Text = "label14";
            // 
            // sexoLabel
            // 
            this.sexoLabel.Location = new System.Drawing.Point(300, 105);
            this.sexoLabel.Name = "sexoLabel";
            this.sexoLabel.Size = new System.Drawing.Size(158, 27);
            this.sexoLabel.TabIndex = 34;
            this.sexoLabel.Text = "label13";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 27);
            this.label12.TabIndex = 33;
            this.label12.Text = "Observaciones:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(249, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 27);
            this.label11.TabIndex = 32;
            this.label11.Text = "Edad:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(247, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 27);
            this.label10.TabIndex = 31;
            this.label10.Text = "Sexo:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(505, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 27);
            this.label9.TabIndex = 30;
            this.label9.Text = "Código Chip:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(507, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 27);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tipo:";
            // 
            // tipoLabel
            // 
            this.tipoLabel.Location = new System.Drawing.Point(557, 160);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(158, 27);
            this.tipoLabel.TabIndex = 28;
            this.tipoLabel.Text = "label7";
            // 
            // codigoLabel
            // 
            this.codigoLabel.Location = new System.Drawing.Point(608, 104);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(158, 27);
            this.codigoLabel.TabIndex = 27;
            this.codigoLabel.Text = "label6";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 27);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nombre:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.Location = new System.Drawing.Point(116, 105);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(158, 27);
            this.nombreLabel.TabIndex = 25;
            this.nombreLabel.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Introduce el DNI de un cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 40;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.search_Click);
            // 
            // userMasc
            // 
            this.userMasc.Location = new System.Drawing.Point(40, 46);
            this.userMasc.Name = "userMasc";
            this.userMasc.Size = new System.Drawing.Size(364, 22);
            this.userMasc.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(612, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 26);
            this.label7.TabIndex = 42;
            this.label7.Text = "MASCOTAS";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 76);
            this.button2.TabIndex = 43;
            this.button2.Text = "Editar Observación";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VentanaTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.Trabajador);
            this.Name = "VentanaTrabajador";
            this.Text = "VentanaTrabajador";
            this.Trabajador.ResumeLayout(false);
            this.Citas.ResumeLayout(false);
            this.Citas.PerformLayout();
            this.Mascotas.ResumeLayout(false);
            this.Mascotas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Trabajador;
        private System.Windows.Forms.TabPage Citas;
        private System.Windows.Forms.TabPage Mascotas;
        private System.Windows.Forms.Button sigCita;
        private System.Windows.Forms.Button antCita;
        private System.Windows.Forms.Label causaLabel;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label mascotaLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Button editCita;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userMasc;
    }
}