using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario
{
    public partial class AgregarMascota : Form
    {
        public AgregarMascota()
        {
            InitializeComponent();
        }


        private void botonVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
            PantallaPrincipal pantallaprincipal = new PantallaPrincipal();
            pantallaprincipal.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //configuracion  de algunos parametros del openFileDialog
            // directorio inicial donde se abrira
            openFileDialog1.InitialDirectory = "C:\\";
            // filtro de archivos.
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            // codigo para abrir el cuadro de dialogo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string str_RutaArchivo = openFileDialog1.FileName;
                    textBox2.Text = str_RutaArchivo;

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
