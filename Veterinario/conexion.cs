using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Veterinario
{
    class Conexion
    {
        public MySqlConnection conexion;
        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root; Pwd =; Port = 3306");
        }

        //Para iniciar sesión
        public Boolean loginVeterinario(String DNI, String password)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM usuario WHERE DNI = @DNI ", conexion); //Se verifica que el dni de la bbdd coincide con el introducido
                consulta.Parameters.AddWithValue("@DNI", DNI);
                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    string passwordConHash = resultado.GetString("password"); //Se pasa la contraseña de la bbdd a string

                    if (BCrypt.Net.BCrypt.Verify(password, passwordConHash)) //Se verifica que la contraseña introducida y la encriptada son la misma
                    {
                        return true;
                    }

                }

                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                return false; //No accede
            }
        }

        //Registrar un nuevo usuario
        public Boolean insertaUsuario(String DNI, String Nombre, String Apellido, String email, String password) 
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO usuario (DNI, Nombre, Apellido, " +
                    "email, password) VALUES " +
                    "(@DNI, @Nombre, @Apellido, " +
                    "@email, @password)", conexion); //datos a introducir, se introducen los string en los campos de la bbdd.
                consulta.Parameters.AddWithValue("@DNI", DNI);
                consulta.Parameters.AddWithValue("@Nombre", Nombre);
                consulta.Parameters.AddWithValue("@Apellido", Apellido);
                consulta.Parameters.AddWithValue("@email", email);
                consulta.Parameters.AddWithValue("@password", password);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }
        
    }
}
