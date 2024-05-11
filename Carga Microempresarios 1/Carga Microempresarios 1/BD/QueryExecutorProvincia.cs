using Carga_Microempresarios_1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carga_Microempresarios_1.BD
{
    public class QueryExecutorProvincia
    {
        private readonly DBConnection connectionHelper;

        public QueryExecutorProvincia()
        {
            this.connectionHelper = new DBConnection();
        }

        public List<Provincia> getAll()
        {
            List<Provincia> provincias = new List<Provincia>();
            string query = "select * from Provincia";

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Provincia provincia = new Provincia();


                            provincia.Id = reader.GetInt32(0);
                            provincia.Nombre = reader.GetString(1);


                            provincias.Add(provincia);
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al ejecutar la consulta: {ex.Message}");
                }

                connectionHelper.CloseConnection(connection);
            }
            if (provincias.Count != 0)
            {
                return provincias;

            }
            return null;
        }

        public Provincia getOne(int id)
        {
            Provincia provincia = null;
            string query = "SELECT * FROM Canton WHERE Id_Provincia = @Parameter1";

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Parameter1", id);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            provincia = new Provincia();

                            provincia.Id = reader.GetInt32(0);
                            provincia.Nombre = reader.GetString(1);
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al ejecutar la consulta: {ex.Message}");
                }

                connectionHelper.CloseConnection(connection);
            }
            if (provincia != null)
            {
                return provincia;

            }
            return null;
        }
    }
}
