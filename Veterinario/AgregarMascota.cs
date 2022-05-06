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

        Conexion conexion = new Conexion();
        DataTable misPerfiles = new DataTable();
        DataTable misIdMascota = new DataTable();

        private void botonVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
            PantallaPrincipal pantallaprincipal = new PantallaPrincipal();
            pantallaprincipal.Show();
        }

        private void botonAdd_Click(object sender, EventArgs e)
        {
            String opcionSexo = ""; //Depende del sexo del animal

            if (opcionMacho.Checked == true)
            {
                opcionSexo = "Macho";
            }
            if (opcionHembra.Checked == true)
            {
                opcionSexo = "Hembra";
            }

            String dniUsuario = VentanaLogin.usuario; //Cogemos el usuario que ha iniciado sesión.
            
            int idMascotaUser = 0;

            misIdMascota = conexion.getMascotasPorUser(dniUsuario); //Para guardar en un int el numero de la mascota del usuario
            idMascotaUser = misIdMascota.Rows.Count; //Se cuentan el número de mascotas del usuario
            idMascotaUser++; //Se suma una mascota al usuario

            if (conexion.insertaMacota(codigoChip.Text, nombreMascota.Text, edadAnimal.Text, tipoAnimal.Text, observacionesAnimal.Text, dniUsuario, opcionSexo, idMascotaUser))
            {
                MessageBox.Show("Mascota Añadida"); //Se añade la mascota
                this.Close();
                PantallaPrincipal v = new PantallaPrincipal();
                v.Show();
            }          
            else
            {
                MessageBox.Show("Error"); //Fallo
            }
            conexion.insertaPerfil(idMascotaUser, dniUsuario); //Se cambia el numero de perfiles del usuario
        }
    }
}
