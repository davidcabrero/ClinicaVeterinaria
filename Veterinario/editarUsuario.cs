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
    public partial class editarUsuario : Form
    {
        Conexion conexion = new Conexion();
        public editarUsuario()
        {
            InitializeComponent();
            editContraseña.PasswordChar = '•'; //No aparece la contraseña
        }

        private void button1_Click(object sender, EventArgs e) //Cambiar los datos del usuario
        {
            String user = VentanaLogin.usuario;
            //Se encripta la contraseña en la bbdd.
            String textoPassword = editContraseña.Text;
            string myHash = BCrypt.Net.BCrypt.HashPassword(textoPassword, BCrypt.Net.BCrypt.GenerateSalt());
            if (conexion.editaUser(user, editNombre.Text, editApellido.Text, editEmail.Text, myHash))
            {
                MessageBox.Show("Se han guardado sus datos");
                this.Hide();
                VentanaLogin v = new VentanaLogin();
                v.Show();
            }
        }
    }
}
