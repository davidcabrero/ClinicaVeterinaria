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
        public PantallaPrincipal()
        {
            InitializeComponent();         
        }
       
        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            String user = VentanaLogin.usuario;
            misMascotas = conexion.getMascotasPorUser(user);
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

        private void siguienteButton_Click(object sender, EventArgs e)
        {
            String user = VentanaLogin.usuario;
            misMascotas = conexion.getMascotasPorUser(user);
            nombreLabel.Text = misMascotas.Rows[0]["nombre"].ToString();
            codigoLabel.Text = misMascotas.Rows[0]["codigoChip"].ToString();
            tipoLabel.Text = misMascotas.Rows[0]["tipo"].ToString();
            edadLabel.Text = misMascotas.Rows[0]["edad"].ToString();
            sexoLabel.Text = misMascotas.Rows[0]["sexo"].ToString();
            observacionesLabel.Text = misMascotas.Rows[0]["observaciones"].ToString();

        }
    }
}
