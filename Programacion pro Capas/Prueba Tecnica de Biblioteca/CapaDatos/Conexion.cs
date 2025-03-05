using Microsoft.Data.SqlClient;
namespace CapaDatos
{
    public class Conexion
    {
        private static Conexion instancia = null;


        private string conexionDB = "Server = DESKTOP-16CBIF4\\MSSQLSERVER02; Database = BibliotecaDB; Integrated security = true; TrustServerCertificate=True";


        public static Conexion GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Conexion();
            }
            return instancia;
        }

        public SqlConnection CreaConexion()
        {
            SqlConnection conexion = new SqlConnection(conexionDB);
            return conexion;
        }
    }

    public class Program
    {

        public static void Main(string[] args)
        {

            Conexion conexion = Conexion.GetInstancia();


            SqlConnection conn = conexion.CreaConexion();


            try
            {
                conn.Open();
                Console.WriteLine("Conexión creada correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            finally
            {

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Conexión cerrada.");
                }
            }
        }
    }
}

