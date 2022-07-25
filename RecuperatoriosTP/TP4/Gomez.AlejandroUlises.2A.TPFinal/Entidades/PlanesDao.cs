using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Exceptions;

namespace Entidades
{
    public static class PlanesDao
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static PlanesDao()
        {
            cadenaConexion = @"Server=.;Database=TPFinal;Trusted_Connection=True;";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static List<Planes> Leer()
        {
            List<Planes> planes = new List<Planes>();

            try
            {
                conexion.Open();
                comando.CommandText = "SELECT CODIGO_PLAN, PRECIO, MEGAS, NOMBRE FROM PLANES";
                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    planes.Add(new Planes(Convert.ToInt32(dataReader["CODIGO_PLAN"]), Convert.ToDouble(dataReader["PRECIO"]), 
                        Convert.ToInt32(dataReader["MEGAS"]), dataReader["NOMBRE"].ToString()));
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
            return planes;
        }

        public static void Guardar(Planes plan)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "INSERT INTO PLANES (NOMBRE, PRECIO, MEGAS) VALUES " +
                    "(@nombre, @precio, @megas)";
                comando.Parameters.AddWithValue("@nombre", plan.Nombre);
                comando.Parameters.AddWithValue("@precio", plan.Precio);
                comando.Parameters.AddWithValue("@megas", plan.Megas);

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

        public static void Eliminar(int codigoPlan)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"DELETE FROM PLANES WHERE CODIGO_PLAN = {codigoPlan}";
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

        public static Planes LeerPorCodigoPlan(int codigoPlan)
        {
            Planes plan = null;

            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * FROM PLANES WHERE CODIGO_PLAN = {codigoPlan}";
                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    plan = new Planes(Convert.ToInt32(dataReader["CODIGO_PLAN"]),
                        Convert.ToInt32(dataReader["PRECIO"]),
                        Convert.ToInt32(dataReader["MEGAS"]),
                        dataReader["NOMBRE"].ToString());
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
            return plan;
        }

        public static void Modificar(Planes plan)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE PLANES SET NOMBRE = @nombre, PRECIO = @precio, MEGAS = @megas WHERE CODIGO_PLAN = {plan.CodigoPlan}";
                comando.Parameters.AddWithValue("@nombre", plan.Nombre);
                comando.Parameters.AddWithValue("@precio", plan.Precio);
                comando.Parameters.AddWithValue("@megas", plan.Megas);

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
