
namespace Veterinario
{
    partial class AgregarMascota
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
            this.opcionHembra = new System.Windows.Forms.RadioButton();
            this.opcionMacho = new System.Windows.Forms.RadioButton();
            this.botonVolver = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tipoAnimal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edadAnimal = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreAnimal = new System.Windows.Forms.Label();
            this.nombreMascota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.codigoChip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.observacionesAnimal = new System.Windows.Forms.RichTextBox();
            this.botonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edadAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // opcionHembra
            // 
            this.opcionHembra.AutoSize = true;
            this.opcionHembra.Location = new System.Drawing.Point(104, 409);
            this.opcionHembra.Name = "opcionHembra";
            this.opcionHembra.Size = new System.Drawing.Size(79, 21);
            this.opcionHembra.TabIndex = 29;
            this.opcionHembra.TabStop = true;
            this.opcionHembra.Text = "Hembra";
            this.opcionHembra.UseVisualStyleBackColor = true;
            // 
            // opcionMacho
            // 
            this.opcionMacho.AutoSize = true;
            this.opcionMacho.Location = new System.Drawing.Point(104, 382);
            this.opcionMacho.Name = "opcionMacho";
            this.opcionMacho.Size = new System.Drawing.Size(71, 21);
            this.opcionMacho.TabIndex = 28;
            this.opcionMacho.TabStop = true;
            this.opcionMacho.Text = "Macho";
            this.opcionMacho.UseVisualStyleBackColor = true;
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(644, 371);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(61, 42);
            this.botonVolver.TabIndex = 25;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sexo";
            // 
            // tipoAnimal
            // 
            this.tipoAnimal.FormattingEnabled = true;
            this.tipoAnimal.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Hurón",
            "Hamster",
            "Caballo",
            "Loro",
            "Canario"});
            this.tipoAnimal.Location = new System.Drawing.Point(63, 237);
            this.tipoAnimal.Name = "tipoAnimal";
            this.tipoAnimal.Size = new System.Drawing.Size(178, 24);
            this.tipoAnimal.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tipo Animal";
            // 
            // edadAnimal
            // 
            this.edadAnimal.Location = new System.Drawing.Point(63, 168);
            this.edadAnimal.Name = "edadAnimal";
            this.edadAnimal.Size = new System.Drawing.Size(178, 22);
            this.edadAnimal.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Edad Animal";
            // 
            // nombreAnimal
            // 
            this.nombreAnimal.AutoSize = true;
            this.nombreAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreAnimal.Location = new System.Drawing.Point(96, 74);
            this.nombreAnimal.Name = "nombreAnimal";
            this.nombreAnimal.Size = new System.Drawing.Size(117, 17);
            this.nombreAnimal.TabIndex = 18;
            this.nombreAnimal.Text = "Nombre Animal";
            // 
            // nombreMascota
            // 
            this.nombreMascota.Location = new System.Drawing.Point(63, 94);
            this.nombreMascota.Name = "nombreMascota";
            this.nombreMascota.Size = new System.Drawing.Size(178, 22);
            this.nombreMascota.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "AGREGAR ANIMAL";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Código Chip";
            // 
            // codigoChip
            // 
            this.codigoChip.Location = new System.Drawing.Point(63, 315);
            this.codigoChip.Name = "codigoChip";
            this.codigoChip.Size = new System.Drawing.Size(178, 22);
            this.codigoChip.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(492, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Observaciones";
            // 
            // observacionesAnimal
            // 
            this.observacionesAnimal.Location = new System.Drawing.Point(335, 108);
            this.observacionesAnimal.Name = "observacionesAnimal";
            this.observacionesAnimal.Size = new System.Drawing.Size(428, 229);
            this.observacionesAnimal.TabIndex = 34;
            this.observacionesAnimal.Text = "";
            // 
            // botonAdd
            // 
            this.botonAdd.Location = new System.Drawing.Point(396, 370);
            this.botonAdd.Name = "botonAdd";
            this.botonAdd.Size = new System.Drawing.Size(212, 44);
            this.botonAdd.TabIndex = 35;
            this.botonAdd.Text = "AÑADIR";
            this.botonAdd.UseVisualStyleBackColor = true;
            this.botonAdd.Click += new System.EventHandler(this.botonAdd_Click);
            // 
            // AgregarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonAdd);
            this.Controls.Add(this.observacionesAnimal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.codigoChip);
            this.Controls.Add(this.opcionHembra);
            this.Controls.Add(this.opcionMacho);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tipoAnimal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edadAnimal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombreAnimal);
            this.Controls.Add(this.nombreMascota);
            this.Controls.Add(this.label1);
            this.Name = "AgregarMascota";
            this.Text = "AgregarMascota";
            ((System.ComponentModel.ISupportInitialize)(this.edadAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton opcionHembra;
        private System.Windows.Forms.RadioButton opcionMacho;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tipoAnimal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown edadAnimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nombreAnimal;
        private System.Windows.Forms.TextBox nombreMascota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox codigoChip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox observacionesAnimal;
        private System.Windows.Forms.Button botonAdd;
    }
}