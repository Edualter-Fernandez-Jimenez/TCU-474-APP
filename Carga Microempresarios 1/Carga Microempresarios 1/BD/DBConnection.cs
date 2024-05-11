using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carga_Microempresarios_1.BD
{
    public class DBConnection
    {
   string connectionString;

        public DBConnection()
        {
            //
            this.connectionString = "Persist Security Info=False;Integrated Security=true;Initial Catalog = TCU-474; Server=DESKTOP-C962NTH;TrustServerCertificate=true;";

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ApplicationException("La variable de entorno no está configurada o es inválida.");
            }
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(connectionString);
        }

        public string OpenConnection(SqlConnection connection)
        {
            try
            {
                connection.Open();
                return ("Conexión exitosa");
            }
            catch (Exception ex)
            {
                return ("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        public string CloseConnection(SqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                return ("Conexión cerrada");
            }
            return ("No hay conexiones");
        }
    }
}
