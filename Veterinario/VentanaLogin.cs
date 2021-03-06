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
    public partial class VentanaLogin : Form
    {
        Conexion conexion = new Conexion();
        public VentanaLogin()
        {
            InitializeComponent();
            textBoxContraseña.PasswordChar = '•'; //No aparece la contraseña
        }

        internal static string usuario;

        private void button1_Click(object sender, EventArgs e) //Botón para registrarse
        {
            VentanaRegistro ventanaregistro = new VentanaRegistro();
            this.Hide();
            ventanaregistro.Show();
            
            //abrir ventana registro
        }

        private void button1_Click_1(object sender, EventArgs e) //Botón para Iniciar sesión
        {
            if (conexion.loginVeterinario(textBoxDNI.Text, textBoxContraseña.Text)) //Si el usuario y contraseña coinciden
            {
                this.Hide();
                usuario = textBoxDNI.Text;
                PantallaPrincipal pantallaprincipal = new PantallaPrincipal();
                
                pantallaprincipal.Show();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña introducido no es correcto"); //En el caso de no acceder
            }
        }

        private void button2_Click(object sender, EventArgs e) //Inicio de sesión del trabajador
        {
            this.Hide();
            LoginTrabajador logintrabajador = new LoginTrabajador();

            logintrabajador.Show();
        }
    }
}
