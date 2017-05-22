using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using MySql.Data.MySqlClient;

namespace ProyectoDeLectura
{
    class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=24981149rc;database=proyectolectura");
            con.Open();
            return con;
        }
    }
}
