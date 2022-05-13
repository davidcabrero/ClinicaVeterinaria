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
    public partial class VentanaTrabajador : Form
    {
        public VentanaTrabajador()
        {
            InitializeComponent();
        }

        Conexion conexion = new Conexion();
        DataTable misMascotas = new DataTable();
        DataTable misIdMascota = new DataTable();
        DataTable misIdCita = new DataTable();
        DataTable verCitas = new DataTable();
        DataTable verNombre = new DataTable();

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                //Se muestran los datos de la primera cita
                verCitas = conexion.getCitasPorId(user.Text, idCita);
                fechaLabel.Text = verCitas.Rows[0]["fecha"].ToString();
                causaLabel.Text = verCitas.Rows[0]["causa"].ToString();

                verNombre = conexion.getNombreCitasPorId(user.Text, idCita);
                mascotaLabel.Text = verNombre.Rows[0]["nombre"].ToString();
            }
            catch //En el caso de que no haya añadido citas
            {
                fechaLabel.Text = "No hay datos";
                causaLabel.Text = "No hay datos";
                mascotaLabel.Text = "No hay datos";
            }

            try
            {
                //Se muestran los datos de la primera mascota
                misMascotas = conexion.getMascotasPorId(userMasc.Text, idActual);
                nombreLabel.Text = misMascotas.Rows[0]["nombre"].ToString();
                codigoLabel.Text = misMascotas.Rows[0]["codigoChip"].ToString();
                tipoLabel.Text = misMascotas.Rows[0]["tipo"].ToString();
                edadLabel.Text = misMascotas.Rows[0]["edad"].ToString();
                sexoLabel.Text = misMascotas.Rows[0]["sexo"].ToString();
                observacionesLabel.Text = misMascotas.Rows[0]["observaciones"].ToString();
            }
            catch //En el caso de que no haya añadido mascotas
            {
                nombreLabel.Text = "No hay datos";
                codigoLabel.Text = "No hay datos";
                tipoLabel.Text = "No hay datos";
                edadLabel.Text = "No hay datos";
                sexoLabel.Text = "No hay datos";
                observacionesLabel.Text = "No hay datos";
            }
        }

        int idCitaUser = 0;
        int idMascotaUser = 0;
        int idActual = 1;
        int idCita = 1;

        private void antCita_Click(object sender, EventArgs e) //Mostrar cita anterior
        {
            try
            {
                misIdCita = conexion.getTodoCitasPorUser(user.Text); //Para guardar en un int el número de la cita del usuario
                idCitaUser = misIdCita.Rows.Count; //se cuenta el número de citas del usuario
                idCita--;
                if (idCita > 0)
                {
                    verCitas = conexion.getCitasPorId(user.Text, idCita);
                    fechaLabel.Text = verCitas.Rows[0]["fecha"].ToString();
                    causaLabel.Text = verCitas.Rows[0]["causa"].ToString();

                    verNombre = conexion.getNombreCitasPorId(user.Text, idCita);
                    mascotaLabel.Text = verNombre.Rows[0]["nombre"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("No hay citas");
            }
        }

        private void sigCita_Click(object sender, EventArgs e) //Mostrar siguiente cita
        {
            try
            {
                misIdCita = conexion.getTodoCitasPorUser(user.Text); //Para guardar en un int el numero de la cita del usuario
                idCitaUser = misIdCita.Rows.Count; //se cuenta el num de citas del usuario
                idCita++;
                if (idCita <= idCitaUser)
                {
                    verCitas = conexion.getCitasPorId(user.Text, idCita);
                    fechaLabel.Text = verCitas.Rows[0]["fecha"].ToString();
                    causaLabel.Text = verCitas.Rows[0]["causa"].ToString();

                    verNombre = conexion.getNombreCitasPorId(user.Text, idCita);
                    mascotaLabel.Text = verNombre.Rows[0]["nombre"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("No hay citas");
            }
        }

        private void siguienteButton_Click(object sender, EventArgs e) //Siguiente mascota
        {
            try
            {
                misIdMascota = conexion.getMascotasPorUser(userMasc.Text); //Para guardar en un int el numero de la mascota del usuario
                idMascotaUser = misIdMascota.Rows.Count; //Se cuentan el número de mascotas del usuario

                idActual++;
                if (idActual <= idMascotaUser)
                { //Id menor que el número de mascotas del cliente, salen los datos del siguiente
                    misMascotas = conexion.getMascotasPorId(userMasc.Text, idActual);
                    nombreLabel.Text = misMascotas.Rows[0]["nombre"].ToString();
                    codigoLabel.Text = misMascotas.Rows[0]["codigoChip"].ToString();
                    tipoLabel.Text = misMascotas.Rows[0]["tipo"].ToString();
                    edadLabel.Text = misMascotas.Rows[0]["edad"].ToString();
                    sexoLabel.Text = misMascotas.Rows[0]["sexo"].ToString();
                    observacionesLabel.Text = misMascotas.Rows[0]["observaciones"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("No hay mascotas");
            }
        }

        private void Anterior_Click(object sender, EventArgs e) //Mascota Anterior
        {
            try
            {
                misIdMascota = conexion.getMascotasPorUser(userMasc.Text); //Para guardar en un int el numero de la mascota del usuario
                idMascotaUser = misIdMascota.Rows.Count; //Se cuentan el número de mascotas del usuario

                idActual--;
                if (idActual > 0) //Id mayor que 0, salen los datos del anterior
                {
                    misMascotas = conexion.getMascotasPorId(userMasc.Text, idActual);
                    nombreLabel.Text = misMascotas.Rows[0]["nombre"].ToString();
                    codigoLabel.Text = misMascotas.Rows[0]["codigoChip"].ToString();
                    tipoLabel.Text = misMascotas.Rows[0]["tipo"].ToString();
                    edadLabel.Text = misMascotas.Rows[0]["edad"].ToString();
                    sexoLabel.Text = misMascotas.Rows[0]["sexo"].ToString();
                    observacionesLabel.Text = misMascotas.Rows[0]["observaciones"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("No hay mascotas");
            }
        }

        private void editCita_Click(object sender, EventArgs e) //Editar la cita
        {
            if (user.Text != null)
            {
                misIdCita = conexion.getTodoCitasPorUser(user.Text); //Para guardar en un int el numero de la cita del usuario
                idCitaUser = misIdCita.Rows.Count; //se cuenta el num de citas del usuario
                if (idCitaUser > 0) //Siempre que haya citas
                {
                    this.Hide();
                    EditarCita editarcita = new EditarCita(idCita, user.Text);
                    editarcita.Show();
                }
                else
                {
                    MessageBox.Show("No hay cita para editar");
                }
            }
            else
            {
                MessageBox.Show("Busca un usuario antes");
            }
        }

        private void button2_Click(object sender, EventArgs e) //Editar las observaciones de la mascota
        {
            if (userMasc != null)
            {
                misIdMascota = conexion.getMascotasPorUser(userMasc.Text); //Para guardar en un int el numero de la mascota del usuario
                idMascotaUser = misIdMascota.Rows.Count; //Se cuentan el número de mascotas del usuario
                if (idMascotaUser > 0) //Siempre que haya mascotas
                {
                    this.Hide();
                    EditarObservaciones editarobservaciones = new EditarObservaciones(idActual, user.Text);
                    editarobservaciones.Show();
                }
                else
                {
                    MessageBox.Show("No hay observaciones para editar");
                }
            }
            else
            {
                MessageBox.Show("Busca un usuario antes");
            }
        }

        //Cerrar sesión

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginTrabajador logintrabajador = new LoginTrabajador();
            logintrabajador.Show();
            MessageBox.Show("Se ha cerrado sesión");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginTrabajador logintrabajador = new LoginTrabajador();
            logintrabajador.Show();
            MessageBox.Show("Se ha cerrado sesión");
        }
    }
}
