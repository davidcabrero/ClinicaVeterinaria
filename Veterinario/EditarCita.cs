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
    public partial class EditarCita : Form
    {
        Conexion conexion = new Conexion();
        private static int idCitaEdit;
        private static String user;
        public EditarCita(int idCita, String dni)
        {
            InitializeComponent();
            idCitaEdit = idCita; //Recogemos la cita a editar
            user = dni; //Recogemos el usuario
            fechaCita.Format = DateTimePickerFormat.Custom;
            fechaCita.CustomFormat = "dd/MM/yyyy HH:mm:ss"; //Día-mes-año y hora en formato 24 horas
        }

        private void cancelar_Click(object sender, EventArgs e) //Vuelve
        {
            this.Hide();
            VentanaTrabajador ventanatrabajador = new VentanaTrabajador();
            ventanatrabajador.Show();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (conexion.editCita(user, fechaCita.Text, causa.Text, idCitaEdit)) //Se edita la cita
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
    }
}
