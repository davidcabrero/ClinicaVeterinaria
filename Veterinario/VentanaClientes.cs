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
        public PantallaPrincipal()
        {
            InitializeComponent();         
        }

        int idActual = 1;
       
        private void PantallaPrincipal_Load(object sender, EventArgs e)
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

        
        private void AñadirAnimal_Click(object sender, EventArgs e)
        {
            this.Close();
            AgregarMascota agregarmascota = new AgregarMascota();
            agregarmascota.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        int idMascotaUser = 0;
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
    }
}
