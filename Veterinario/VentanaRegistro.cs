using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Veterinario
{
    public partial class VentanaRegistro : Form
    {
        Conexion conexion = new Conexion();
        DataTable check = new DataTable();
        public VentanaRegistro()
        {
            InitializeComponent();
            textBoxContraseña.PasswordChar = '•'; //No aparece la contraseña
        }

        private void Registrarme_Click(object sender, EventArgs e)
        {
            check = conexion.comprobarRegistro();
            if ((textBoxCorreoElectronico.Text) != (check.Rows[0]["email"].ToString())) //Siempre que el email no esté cogida ya.
            {
                if ((textBoxDNI.Text) != (check.Rows[0]["DNI"].ToString())) //Siempre que el dni/usuario no esté cogida ya.
                {
                    //Se encripta la contraseña en la bbdd.
                    String textoPassword = textBoxContraseña.Text;
                    string myHash = BCrypt.Net.BCrypt.HashPassword(textoPassword, BCrypt.Net.BCrypt.GenerateSalt());
                    if (conexion.insertaUsuario(textBoxDNI.Text, textBoxNombre.Text, textBoxApellido.Text, textBoxCorreoElectronico.Text, myHash))
                    {
                        MessageBox.Show("Registro completado");
                        this.Hide();
                        VentanaLogin v = new VentanaLogin();
                        v.Show();
                    }
                }
                else
                {
                    MessageBox.Show("El DNI introducido ya está registrado");
                }
            }
            else
            {
                MessageBox.Show("El email introducido ya está registrado");
            }
        }
    }
}
