using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class Logica
    {
        public static DataTable Listar_prestamo()
        {
            Prestamos datos = new Prestamos();
            DataTable resultado = datos.Listar_Prestamo();
            return resultado;
        }


        public static string Guardar_prestamo(Entidades datos)
        {
            Prestamos data = new Prestamos();
            return data.Guardar_prestamo(datos);
        }

        public static DataTable Buscar_prestamo(string dato)
        {
            Prestamos datos = new Prestamos();
            DataTable resultado = datos.Buscar_prestamo(dato);
            return resultado;
        }

        public static string Eliminar_prestamo(Entidades id)
        {
            Prestamos num = new Prestamos();
            return num.Eliminar_prestamo(id);
        }

        public static string Actualizar_prestamo(Entidades datos)
        {
            Prestamos actualizarDatos = new Prestamos();
            return actualizarDatos.Actualizar_prestamo(datos);
        }
    }
}
