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
    public partial class EditarObservaciones : Form
    {
        Conexion conexion = new Conexion();
        private static int idMascota;
        private static String user;
        public EditarObservaciones(int idActual, String dni)
        {
            InitializeComponent();
            idMascota = idActual; //Recogemos la mascota que queremos editar la observación
            user = dni; //Recogemos el usuario
        }

        private void guardar_Click(object sender, EventArgs e) //Se guardan las observaciones editadas
        {
            if (conexion.editObservacion(idMascota, observaciones.Text, user))
            {
                MessageBox.Show("Se ha guardado correctamente");
                this.Hide();
                VentanaTrabajador ventanatrabajador = new VentanaTrabajador();
                ventanatrabajador.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void button1_Click(object sender, EventArgs e) //Vuelve
        {
            this.Hide();
            VentanaTrabajador ventanatrabajador = new VentanaTrabajador();
            ventanatrabajador.Show();
        }
    }
}
