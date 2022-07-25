using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Exceptions;

namespace Entidades
{
    public static class UsuarioDao
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static UsuarioDao()
        {
            cadenaConexion = @"Server=.;Database=TPFinal;Trusted_Connection=True;";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static void Guardar(Usuario usuario)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "INSERT INTO USUARIOS (APELLIDO, NOMBRE, DNI, CODIGO_PLAN, SEXO) VALUES " +
                    "(@apellido, @nombre, @dni, @codigoPlan, @sexo)";
                comando.Parameters.AddWithValue("@apellido", usuario.Apellido);
                comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@dni", usuario.Dni);
                comando.Parameters.AddWithValue("@codigoPlan", usuario.CodigoPlan);
                comando.Parameters.AddWithValue("@sexo", usuario.Sexo);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<Biblioteca> Leer()
        {
            List<Biblioteca> biblioteca = new List<Biblioteca>();
            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT USUARIOS.APELLIDO as apellido, " +
                    $"USUARIOS.NOMBRE as nombre, " +
                    $"USUARIOS.DNI as dni, " +
                    $"USUARIOS.SEXO as sexo, " +
                    $"PLANES.PRECIO as precio, " +
                    $"PLANES.MEGAS as megas, " +
                    $"PLANES.NOMBRE as nombrePlan " +
                    $"FROM USUARIOS JOIN PLANES ON USUARIOS.CODIGO_PLAN = PLANES.CODIGO_PLAN";
                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    biblioteca.Add(new Biblioteca(dataReader["apellido"].ToString(),
                        dataReader["nombre"].ToString(),
                        Convert.ToInt32(dataReader["dni"]),
                        dataReader["sexo"].ToString(),
                        Convert.ToDouble(dataReader["precio"]),
                        Convert.ToInt32(dataReader["megas"]), 
                        dataReader["nombrePlan"].ToString()));
                }
                dataReader.Close();
            }
            catch (Exception exception)
            {

                throw new DbInvalidException("Error al leer base de datos", exception);
            }
            finally
            {
                conexion.Close();
            }
            return biblioteca;
        }

        public static List<Usuario> LeerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT USUARIOS.APELLIDO as apellido, " +
                    $"USUARIOS.NOMBRE as nombre, " +
                    $"USUARIOS.DNI as dni, " +
                    $"USUARIOS.SEXO as sexo, " +
                    $"USUARIOS.CODIGO_PLAN as codigoPlan " +
                    $"FROM USUARIOS JOIN PLANES ON USUARIOS.CODIGO_PLAN = PLANES.CODIGO_PLAN";
                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    usuarios.Add(new Usuario(dataReader["nombre"].ToString(),
                        dataReader["apellido"].ToString(),
                        dataReader["sexo"].ToString(),
                        Convert.ToInt32(dataReader["dni"]), 
                        Convert.ToInt32(dataReader["codigoPlan"])));
                }
                dataReader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            return usuarios;
        }

        public static void Eliminar(int dni)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"DELETE FROM USUARIOS WHERE DNI = {dni}";
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static Usuario LeerPorDni(int dni)
        {
            Usuario usuario = null;

            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * FROM USUARIOS WHERE DNI = {dni}";
                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    usuario = new Usuario(dataReader["NOMBRE"].ToString(),
                        dataReader["APELLIDO"].ToString(),
                        dataReader["SEXO"].ToString(),
                        Convert.ToInt32(dataReader["DNI"]),
                        Convert.ToInt32(dataReader["CODIGO_PLAN"]));
                }
                dataReader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            return usuario;
        }

        public static void Modificar(Usuario usuario)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE USUARIOS SET APELLIDO = '{usuario.Apellido}', NOMBRE = '{usuario.Nombre}', " +
                    $"SEXO = '{usuario.Sexo}', CODIGO_PLAN = {usuario.CodigoPlan} WHERE DNI = {usuario.Dni}";

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
