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
    public partial class PantallaPrincipal : Form
    {
        Conexion conexion = new Conexion();
        DataTable misMascotas = new DataTable();
        DataTable misIdMascota = new DataTable();
        DataTable misIdCita = new DataTable();
        DataTable verCitas = new DataTable();
        DataTable verNombre = new DataTable();
        DataTable userDatos = new DataTable();

        public PantallaPrincipal()
        {
            InitializeComponent();         
        }

        int idActual = 1;
        int idCita = 1;
       
        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            //Se muestran los datos de la primera mascota
            String user = VentanaLogin.usuario;
            misMascotas = conexion.getMascotasPorId(user, idActual);
            nombreLabel.Text = misMascotas.Rows[0]["nombre"].ToString();
            codigoLabel.Text = misMascotas.Rows[0]["codigoChip"].ToString();
            tipoLabel.Text = misMascotas.Rows[0]["tipo"].ToString();
            edadLabel.Text = misMascotas.Rows[0]["edad"].ToString();
            sexoLabel.Text = misMascotas.Rows[0]["sexo"].ToString();
            observacionesLabel.Text = misMascotas.Rows[0]["observaciones"].ToString();

            //Se muestran los datos de la primera cita
            verCitas = conexion.getCitasPorId(user, idCita);
            fechaLabel.Text = verCitas.Rows[0]["fecha"].ToString();
            causaLabel.Text = verCitas.Rows[0]["causa"].ToString();

            verNombre = conexion.getNombreCitasPorId(user, idCita);
            mascotaLabel.Text = verNombre.Rows[0]["nombre"].ToString();

            //Se muestran los datos del usuario
            userDatos = conexion.getDatosUsuario(user);
            nameLabel.Text = userDatos.Rows[0]["Nombre"].ToString();
            userLabel.Text = userDatos.Rows[0]["DNI"].ToString();
            surnameLabel.Text = userDatos.Rows[0]["Apellido"].ToString();
            emailLabel.Text = userDatos.Rows[0]["email"].ToString();
        }

        
        private void AñadirAnimal_Click(object sender, EventArgs e) //Se abre la ventana de añadir mascota
        {
            this.Close();
            AgregarMascota agregarmascota = new AgregarMascota();
            agregarmascota.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        int idMascotaUser = 0;
        int idCitaUser = 0;
        String dniUsuario = VentanaLogin.usuario;

        private void siguienteButton_Click(object sender, EventArgs e) //Siguiente mascota
        {
            misIdMascota = conexion.getMascotasPorUser(dniUsuario); //Para guardar en un int el numero de la mascota del usuario
            idMascotaUser = misIdMascota.Rows.Count; //Se cuentan el número de mascotas del usuario

            idActual++;
            if (idActual <= idMascotaUser) { //Id menor que el número de mascotas del cliente, salen los datos del siguiente
                String user = VentanaLogin.usuario;
                misMascotas = conexion.getMascotasPorId(user, idActual);
                nombreLabel.Text = misMascotas.Rows[0]["nombre"].ToString();
                codigoLabel.Text = misMascotas.Rows[0]["codigoChip"].ToString();
                tipoLabel.Text = misMascotas.Rows[0]["tipo"].ToString();
                edadLabel.Text = misMascotas.Rows[0]["edad"].ToString();
                sexoLabel.Text = misMascotas.Rows[0]["sexo"].ToString();
                observacionesLabel.Text = misMascotas.Rows[0]["observaciones"].ToString();
            }
        }

        private void Anterior_Click(object sender, EventArgs e) //Mascota Anterior
        {
            misIdMascota = conexion.getMascotasPorUser(dniUsuario); //Para guardar en un int el numero de la mascota del usuario
            idMascotaUser = misIdMascota.Rows.Count; //Se cuentan el número de mascotas del usuario

            idActual--;
            if (idActual > 0) //Id mayor que 0, salen los datos del anterior
            {
                String user = VentanaLogin.usuario;
                misMascotas = conexion.getMascotasPorId(user, idActual);
                nombreLabel.Text = misMascotas.Rows[0]["nombre"].ToString();
                codigoLabel.Text = misMascotas.Rows[0]["codigoChip"].ToString();
                tipoLabel.Text = misMascotas.Rows[0]["tipo"].ToString();
                edadLabel.Text = misMascotas.Rows[0]["edad"].ToString();
                sexoLabel.Text = misMascotas.Rows[0]["sexo"].ToString();
                observacionesLabel.Text = misMascotas.Rows[0]["observaciones"].ToString();
            }
        }

        private void addCita_Click(object sender, EventArgs e) //Se abre la ventana para añadir cita
        {
            this.Hide();
            VentanaCitas ventanacitas = new VentanaCitas();
            ventanacitas.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void antCita_Click(object sender, EventArgs e) //Mostrar cita anterior
        {
            misIdCita = conexion.getTodoCitasPorUser(dniUsuario); //Para guardar en un int el número de la cita del usuario
            idCitaUser = misIdCita.Rows.Count; //se cuenta el número de citas del usuario
            idCita--;
            if (idCita > 0)
            {
                String user = VentanaLogin.usuario;
                verCitas = conexion.getCitasPorId(user, idCita);
                fechaLabel.Text = verCitas.Rows[0]["fecha"].ToString();
                causaLabel.Text = verCitas.Rows[0]["causa"].ToString();

                verNombre = conexion.getNombreCitasPorId(user, idCita);
                mascotaLabel.Text = verNombre.Rows[0]["nombre"].ToString();
            }
        }

        private void sigCita_Click(object sender, EventArgs e) //Mostrar siguiente cita
        {
            misIdCita = conexion.getTodoCitasPorUser(dniUsuario); //Para guardar en un int el numero de la cita del usuario
            idCitaUser = misIdCita.Rows.Count; //se cuenta el num de citas del usuario
            idCita++;
            if (idCita <= idCitaUser)
            {
                String user = VentanaLogin.usuario;
                verCitas = conexion.getCitasPorId(user, idCita);
                fechaLabel.Text = verCitas.Rows[0]["fecha"].ToString();
                causaLabel.Text = verCitas.Rows[0]["causa"].ToString();

                verNombre = conexion.getNombreCitasPorId(user, idCita);
                mascotaLabel.Text = verNombre.Rows[0]["nombre"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e) //Editar datos del usuario
        {
            this.Hide();
            editarUsuario editarusuario = new editarUsuario();
            editarusuario.Show();
        }

        private void button2_Click(object sender, EventArgs e) //Para que el usuario cierre sesión.
        {
            this.Close();
            VentanaLogin v = new VentanaLogin();
            v.Show();
        }
    }
}
