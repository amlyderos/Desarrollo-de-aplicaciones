using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Logica2
    {
        public static DataTable Listar_libro()
        {
            Libros datos = new Libros();
            DataTable resultado = datos.Listar_Libro();
            return resultado;
        }

        public static DataTable ListarCategoria()
        {
            Libros datos = new Libros();
            DataTable resultado = datos.ListarCategoria();
            return resultado;
        }


        public static string Guardar_libro(Entidades datos)
        {
            Libros data = new Libros();
            return data.Guardar_libro(datos);
        }

        public static DataTable Buscar_Libro(string dato)
        {
            Libros datos = new Libros();
            DataTable resultado = datos.Buscar_Libro(dato);
            return resultado;
        }

        public static string Eliminar_Libro(Entidades id)
        {
            Libros num = new Libros();
            return num.Eliminar_Libro(id);
        }

        public static string Actualizar_Libro(Entidades datos)
        {
            Libros actualizarDatos = new Libros();
            return actualizarDatos.Actualizar_Libro(datos);
        }
    }
}
