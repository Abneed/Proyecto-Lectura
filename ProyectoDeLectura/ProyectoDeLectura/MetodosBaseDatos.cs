using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ProyectoDeLectura
{
    class MetodosBaseDatos
    {
        public static Entidad ObtenerEntidadPorId(int intId)
        {
            using (MySqlConnection sqlCon = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM Images WHERE Id = " + intId), sqlCon);
                MySqlDataReader show = cmd.ExecuteReader();
                show.Read();
                sqlCon.Close();
                return new Entidad(show.GetInt32(0), show.GetString(1), show.GetString(2), show.GetString(3));
            } 
        }

        public static List<Entidad> ObtenerTodasEntidades()
        {
            List<Entidad> listEntidad = new List<Entidad>();
            using (MySqlConnection sqlCon = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM Images"), sqlCon);
                MySqlDataReader show = cmd.ExecuteReader();

                while (show.Read())
                    listEntidad.Add(new Entidad(show.GetInt32(0), show.GetString(1), show.GetString(2), show.GetString(3)));

                sqlCon.Close();

                return listEntidad;
            }
        }

        public static List<Entidad> ObtenerTodasEntidadesPorCategoria(string strCategoria)
        {
            List<Entidad> listEntidad = new List<Entidad>();
            using (MySqlConnection sqlCon = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM Images WHERE Categoria = '" + strCategoria + "'"), sqlCon);
                MySqlDataReader show = cmd.ExecuteReader();

                while (show.Read())
                    listEntidad.Add(new Entidad(show.GetInt32(0), show.GetString(1), show.GetString(2), show.GetString(3)));

                sqlCon.Close();

                return listEntidad;
            }
        }

    }
}
