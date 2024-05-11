using Carga_Microempresarios_1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carga_Microempresarios_1.BD
{
    public class QueryExecutorDistrito
    {
        private readonly DBConnection connectionHelper;

        public QueryExecutorDistrito()
        {
            this.connectionHelper = new DBConnection();
        }

        public List<Distrito> getAll()
        {
            List<Distrito> distritos = new List<Distrito>();
            string query = "select * from Distrito";

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
                            Distrito distrito = new Distrito();


                            distrito.Id = reader.GetInt32(0);
                            distrito.Nombre = reader.GetString(1);


                            distritos.Add(distrito);
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
            if (distritos.Count != 0)
            {
                return distritos;

            }
            return null;
        }

        public Distrito getOne(int id)
        {
            Distrito distrito = null;
            string query = "SELECT * FROM Distrito WHERE Id_Distrito = @Parameter1";

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
                            distrito = new Distrito();
                            distrito.Id = reader.GetInt32(0);
                            distrito.Nombre = reader.GetString(1);
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
            if (distrito != null)
            {
                return distrito;

            }
            return null;
        }
    }
}
