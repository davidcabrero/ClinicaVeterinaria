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
    public partial class LoginTrabajador : Form
    {
        Conexion conexion = new Conexion();
        public LoginTrabajador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Iniciar sesión
        {
            if (conexion.loginTrabajador(textBoxDNI.Text, textBoxContraseña.Text)) //Si el usuario y contraseña coinciden
            {
                this.Hide();
                VentanaTrabajador ventanatrabajador = new VentanaTrabajador();

                ventanatrabajador.Show();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña introducido no es correcto"); //En el caso de no acceder
            }
        }
    }
}
