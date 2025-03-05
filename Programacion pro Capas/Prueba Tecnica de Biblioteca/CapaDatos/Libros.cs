using CapaEntidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Libros
    {
        public DataTable Listar_Libro()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = Conexion.GetInstancia().CreaConexion())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ListadoLibros", conexion))
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

        public DataTable ListarCategoria()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = Conexion.GetInstancia().CreaConexion())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("ListarCategoria", conexion))
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

        public string Guardar_libro(Entidades datos)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion = Conexion.GetInstancia().CreaConexion();
                SqlCommand cmd = new SqlCommand("sp_GuardarLibro", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Titulo", SqlDbType.VarChar).Value = datos.Titulo;
                cmd.Parameters.Add("@Autor", SqlDbType.VarChar).Value = datos.Autor;
                cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = datos.Categoria;
                cmd.Parameters.Add("@CantidadDisponible", SqlDbType.Int).Value = datos.CantidadDisponible;
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

        public DataTable Buscar_Libro(string valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion = Conexion.GetInstancia().CreaConexion();
                SqlCommand cmd = new SqlCommand("sp_BuscarPrestamoPorLibro", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Titulo", SqlDbType.VarChar).Value = valor;
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

        public string Eliminar_Libro(Entidades datos)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion = Conexion.GetInstancia().CreaConexion();
                SqlCommand cmd = new SqlCommand("sp_EliminarLibro", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_Libro", SqlDbType.Int).Value = datos.Id_Libro;
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

        public string Actualizar_Libro(Entidades datos)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion = Conexion.GetInstancia().CreaConexion();
                SqlCommand cmd = new SqlCommand("sp_ActualizarLibro", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id_Libro", SqlDbType.Int).Value = datos.Id_Libro;
                cmd.Parameters.Add("@Titulo", SqlDbType.VarChar).Value = datos.Titulo;
                cmd.Parameters.Add("@Autor", SqlDbType.VarChar).Value = datos.Autor;
                cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = datos.Categoria;
                cmd.Parameters.Add("@CantidadDisponible", SqlDbType.Int).Value = datos.CantidadDisponible;
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
