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
    public partial class VentanaCitas : Form
    {
        public VentanaCitas()
        {
            InitializeComponent();
        }

        Conexion conexion = new Conexion();
        DataTable misCitas = new DataTable();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            String dniUsuario = VentanaLogin.usuario; //Cogemos el usuario que ha iniciado sesión.

            int idUserCitas = 0;

            misCitas = conexion.getTodoCitasPorUser(dniUsuario); //Cogemos el valor de codigo cita y lo incrementamos
            idUserCitas = misCitas.Rows.Count;
            idUserCitas++;

            if (conexion.insertaCita(codigo.Text, dniUsuario, fecha.Text, causa.Text, idUserCitas))
            {
                MessageBox.Show("Cita Añadida"); //Se añade la cita
                this.Close();
                PantallaPrincipal v = new PantallaPrincipal();
                v.Show();
            }
            else
            {
                MessageBox.Show("Error"); //Fallo
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            PantallaPrincipal pantallaprincipal = new PantallaPrincipal();
            pantallaprincipal.Show();
        }
    }
}
