using System;
using System.Collections.Generic;
using System.Data;
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

        public Boolean loginTrabajador(String DNI, String password)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM trabajador WHERE DNI = @DNI ", conexion); //Se verifica que el dni de la bbdd coincide con el introducido
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

        public DataTable comprobarRegistro() //Para comprobar que el dni registrado no existe en la bbdd
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM usuario", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable datos = new DataTable();
                datos.Load(resultado);
                conexion.Close();
                return datos;
            }
            catch (MySqlException e)
            {
                throw e;
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


        //Registrar una nueva mascota
        public Boolean insertaMacota(String codigoChip, String nombre, String edad, String tipo, String observaciones, String dni_usuario, String Sexo, int idMascotaUser)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO mascota (codigoChip, nombre, edad, tipo, observaciones, dni_usuario, Sexo, idMascotaUser) VALUES (@codigoChip, @nombre, @edad, @tipo, @observaciones, @dni_usuario, @Sexo, @idMascotaUser)", conexion); //datos a introducir, se introducen los string en los campos de la bbdd.
                consulta.Parameters.AddWithValue("@codigoChip", codigoChip);
                consulta.Parameters.AddWithValue("@nombre", nombre);
                consulta.Parameters.AddWithValue("@edad", edad);
                consulta.Parameters.AddWithValue("@tipo", tipo);
                consulta.Parameters.AddWithValue("@observaciones", observaciones);
                consulta.Parameters.AddWithValue("@dni_usuario", dni_usuario);
                consulta.Parameters.AddWithValue("@Sexo", Sexo);
                consulta.Parameters.AddWithValue("@idMascotaUser", idMascotaUser);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public Boolean insertaPerfil(int numPerfil, String dniUsuario)
        {
            //Para añadir un perfil (mascota) al usuario y actualizar el número de mascotas
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("UPDATE usuario SET perfil = @numPerfil WHERE DNI = @dniUsuario", conexion); //datos a introducir.
                consulta.Parameters.AddWithValue("@numPerfil", numPerfil);
                consulta.Parameters.AddWithValue("@dniusuario", dniUsuario);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public DataTable getMascotasPorUser(String usuario) //Datos de mascotas
        {
                try
                {
                    conexion.Open();
                    MySqlCommand consulta = new MySqlCommand("SELECT * FROM mascota WHERE dni_usuario = @usuarioCliente", conexion);
                    consulta.Parameters.AddWithValue("@usuarioCliente", usuario);
                    MySqlDataReader resultado = consulta.ExecuteReader();
                    DataTable datos = new DataTable();
                    datos.Load(resultado);
                    conexion.Close();
                    return datos;
                }
                catch (MySqlException e)
                {
                    throw e;
                }
        }
        public DataTable getMascotasPorId(String usuario, int id) //Sacar mascotas según usuario y id mascota del usuario
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM mascota WHERE dni_usuario = @usuarioCliente AND idMascotaUser = @id", conexion);
                consulta.Parameters.AddWithValue("@usuarioCliente", usuario);
                consulta.Parameters.AddWithValue("@id", id);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable datos = new DataTable();
                datos.Load(resultado);
                conexion.Close();
                return datos;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }      

        public Boolean insertaCita(String codigoMascota, String dni_usuario, String fecha, String causa, int idCitasUser)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO citas (codigo_mascota, codigo_usuario, fecha, causa, idCitasUser) VALUES (@codigoMascota, @dni_usuario, @fecha, @causa, @idCitasUser)", conexion); //datos a introducir, se introducen los string en los campos de la bbdd.
                consulta.Parameters.AddWithValue("@codigoMascota", codigoMascota);
                consulta.Parameters.AddWithValue("@fecha", fecha);
                consulta.Parameters.AddWithValue("@causa", causa);
                consulta.Parameters.AddWithValue("@idCitasUser", idCitasUser);
                consulta.Parameters.AddWithValue("@dni_usuario", dni_usuario);


                consulta.ExecuteNonQuery();

                conexion.Close();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message.ToString());
                return false;

            }
        }

        public DataTable getTodoCitasPorUser(String usuario)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM citas WHERE codigo_usuario = @usuarioCliente", conexion);
                consulta.Parameters.AddWithValue("@usuarioCliente", usuario);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable datos = new DataTable();
                datos.Load(resultado);
                conexion.Close();
                return datos;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getDatosUsuario(String usuario) //Sacar datos del usuario
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM usuario WHERE DNI = @usuarioCliente", conexion);
                consulta.Parameters.AddWithValue("@usuarioCliente", usuario);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable datos = new DataTable();
                datos.Load(resultado);
                conexion.Close();
                return datos;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public Boolean editaUser(String DNI, String Nombre, String Apellido, String email, String password)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("UPDATE usuario SET Nombre = @Nombre, Apellido = @Apellido, email = @email, password = @password WHERE DNI = @DNI", conexion); //datos a introducir, se introducen los string en los campos de la bbdd.
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

        public DataTable getFecha() //Para que solo 1 usuario tenga una fecha exacta.
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM citas", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable datos = new DataTable();
                datos.Load(resultado);
                conexion.Close();
                return datos;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getCitasPorId(String usuario, int id) //Sacar citas según usuario e id de cita del usuario
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM citas WHERE codigo_usuario = @usuarioCliente AND idCitasUser = @id", conexion);
                consulta.Parameters.AddWithValue("@usuarioCliente", usuario);
                consulta.Parameters.AddWithValue("@id", id);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable datos = new DataTable();
                datos.Load(resultado);
                conexion.Close();
                return datos;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getNombreCitasPorId(String usuario, int id) //Sacar el nombre de la mascota de la cita
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM mascota WHERE codigoChip = (SELECT codigo_mascota FROM citas WHERE codigo_usuario = @usuario AND idCitasUser = @id)", conexion);
                consulta.Parameters.AddWithValue("@usuario", usuario);
                consulta.Parameters.AddWithValue("@id", id);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable datos = new DataTable();
                datos.Load(resultado);
                conexion.Close();
                return datos;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getAllMascotas() //Sacar todos los datos de mascotas
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM mascota", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable datos = new DataTable();
                datos.Load(resultado);
                conexion.Close();
                return datos;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}
