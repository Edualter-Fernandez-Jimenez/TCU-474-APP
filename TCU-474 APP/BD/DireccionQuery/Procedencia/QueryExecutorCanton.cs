using Datos.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.DireccionQuery
{
    public class QueryExecutorCanton
    {
        private readonly DBConnection connectionHelper;

        public QueryExecutorCanton()
        {
            this.connectionHelper = new DBConnection();
        }

        public List<Canton> getAll()
        {
            List<Canton> cantones = new List<Canton>();
            string query = "select * from Canton";

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
                            Canton canton = new Canton();

                          
                            canton.Id = reader.GetInt32(0);
                            canton.Nombre = reader.GetString(1);

                           
                           cantones.Add(canton);
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
            if(cantones.Count != 0)
            {
                return cantones;
        
            }
            return null;
        }

        public Canton getOne(int id) {
            Canton canton = null;
            string query = "SELECT * FROM Canton WHERE Id_Canton = @Parameter1";

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
                             canton = new Canton();
                            canton.Id = reader.GetInt32(0);
                            canton.Nombre = reader.GetString(1);
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
            if (canton != null)
            {
                return canton;

            }
            return null;
        }
    }
}
