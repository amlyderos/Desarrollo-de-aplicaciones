using Microsoft.Data.SqlClient;
using System;
using CapaEntidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Prestamos
    {
        public DataTable Listar_Prestamo()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = Conexion.GetInstancia().CreaConexion())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ListadoPrestamos", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        resultado = cmd.ExecuteReader();
                        tabla.Load(resultado);
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }
            return tabla;
        }


        public string Guardar_prestamo(Entidades datos)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion = Conexion.GetInstancia().CreaConexion();
                SqlCommand cmd = new SqlCommand("sp_GuardarPrestamo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar).Value = datos.NombreUsuario;
                cmd.Parameters.Add("@Titulo", SqlDbType.VarChar).Value = datos.Titulo;
                cmd.Parameters.Add("@CorreoCliente", SqlDbType.VarChar).Value = datos.CorreoCliente;
                cmd.Parameters.Add("@Fecha_Prestamo", SqlDbType.VarChar).Value = datos.Fecha_Prestamo;
                cmd.Parameters.Add("@Fecha_Devolucion", SqlDbType.VarChar).Value = datos.Fecha_Devolucion;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = datos.Estado;
                conexion.Open();
                respuesta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se ejecutó correctamente";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return respuesta;
        }



        public DataTable Buscar_prestamo(string valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion = Conexion.GetInstancia().CreaConexion();
                SqlCommand cmd = new SqlCommand("sp_BuscarPrestamoPorNombre", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar).Value = valor;
                conexion.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (SqlException ex)
            {
                conexion = null;
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }



        public string Eliminar_prestamo(Entidades datos)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion = Conexion.GetInstancia().CreaConexion();
                SqlCommand cmd = new SqlCommand("sp_EliminarPrestamo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_Prestamo", SqlDbType.Int).Value = datos.ID_Prestamo;
                conexion.Open();
                respuesta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se ejecutó correctamente";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return respuesta;
        }




        public string Actualizar_prestamo(Entidades datos)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion = Conexion.GetInstancia().CreaConexion();
                SqlCommand cmd = new SqlCommand("sp_ActualizarPrestamo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar).Value = datos.NombreUsuario;
                cmd.Parameters.Add("@TituloLibro", SqlDbType.VarChar).Value = datos.Titulo;
                cmd.Parameters.Add("@CorreoCliente", SqlDbType.VarChar).Value = datos.CorreoCliente;
                cmd.Parameters.Add("@Fecha_Prestamo", SqlDbType.VarChar).Value = datos.Fecha_Prestamo;
                cmd.Parameters.Add("@Fecha_Devolucion", SqlDbType.VarChar).Value = datos.Fecha_Devolucion;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = datos.Estado;
                conexion.Open();
                respuesta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se ejecutó correctamente";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return respuesta;
        }
       
    }
}