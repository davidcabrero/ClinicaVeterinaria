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
            fechaCita.Format = DateTimePickerFormat.Custom;
            fechaCita.CustomFormat = "dd/MM/yyyy HH:mm:ss"; //Día-mes-año y hora en formato 24 horas
        }

        Conexion conexion = new Conexion();
        DataTable misCitas = new DataTable();
        DataTable fechaUnica = new DataTable();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            String dniUsuario = VentanaLogin.usuario; //Cogemos el usuario que ha iniciado sesión.

            int idUserCitas = 0;

            misCitas = conexion.getTodoCitasPorUser(dniUsuario); //Cogemos el último valor valor de codigo cita por usuario y lo incrementamos
            fechaUnica = conexion.getFecha();
            idUserCitas = misCitas.Rows.Count;
            idUserCitas++;
            if ((fechaCita.Text) != (fechaUnica.Rows[0]["fecha"].ToString())) //Siempre que la cita no esté cogida ya.
            {
                if (conexion.insertaCita(codigo.Text, dniUsuario, fechaCita.Text, causa.Text, idUserCitas))
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
            else
            {
                MessageBox.Show("La fecha elegida no está disponible, por favor cambie de fecha");
            }
        }

        private void cancelar_Click(object sender, EventArgs e) //Vuelve
        {
            this.Close();
            PantallaPrincipal pantallaprincipal = new PantallaPrincipal();
            pantallaprincipal.Show();
        }
    }
}
