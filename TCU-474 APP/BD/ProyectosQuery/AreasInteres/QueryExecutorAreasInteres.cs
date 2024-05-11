using Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.ProyectosQuery.AreasInteres
{
    public class QueryExecutorAreasInteres
    {
        private readonly DBConnection connectionHelper;

        public QueryExecutorAreasInteres()
        {
            this.connectionHelper = new DBConnection();
        }

        public List<AreaInteres> getAll()
        {
            List<AreaInteres> areasInteres = new List<AreaInteres>();
            string query = "select * from Areas_Interes";

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
                            AreaInteres areaInteres = new AreaInteres();


                            areaInteres.IdAreaInteres = reader.GetInt32(0);
                            areaInteres.Nombre = reader.GetString(1);


                            areasInteres.Add(areaInteres);
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
            if (areasInteres.Count != 0)
            {
                return areasInteres;

            }
            return null;
        }

        public AreaInteres getOne(int id)
        {
            AreaInteres areaInteres = null;
            string query = "SELECT * FROM Areas_Interes WHERE Id_areaInteres = @Parameter1";

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
                            areaInteres = new AreaInteres();

                            areaInteres.IdAreaInteres = reader.GetInt32(0);
                            areaInteres.Nombre = reader.GetString(1);
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
            if (areaInteres != null)
            {
                return areaInteres;

            }
            return null;
        }

        public string addAreaInteres(AreaInteres areaInteres)
        {
            string query = "INSERT INTO  Areas_Interes(Nombre) VALUES (@Nombre)";
            int rowsAffected = 0;

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Nombre", areaInteres.Nombre);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    return ($"Error al ejecutar la consulta: {ex.Message}");
                }

                connectionHelper.CloseConnection(connection);
            }

            if (rowsAffected >= 1)
            {
                return "Insercion exitosa";

            }
            return "Error";
        }


        public bool updateAreaInteres(AreaInteres areaInteres)
        {
            string query = "UPDATE Areas_Interes SET Nombre = @Nombre WHERE Id_AreaInteres = @Id_AreaInteres";
            int rowsAffected = 0;

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", areaInteres.Nombre);
                        command.Parameters.AddWithValue("@Id_AreaInteres", areaInteres.IdAreaInteres);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }

                connectionHelper.CloseConnection(connection);
            }

            if (rowsAffected >= 1)
            {
                return true;
            }

            return false;
        }

    }
}
