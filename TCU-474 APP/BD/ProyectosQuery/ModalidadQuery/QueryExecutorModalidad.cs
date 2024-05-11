using Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.ProyectosQuery.ModalidadQuery

{
    public class QueryExecutorModalidad
    {
        private readonly DBConnection connectionHelper;

        public QueryExecutorModalidad()
        {
            this.connectionHelper = new DBConnection();
        }

        public List<Modalidad> getAll()
        {
            List<Modalidad> modalidades = new List<Modalidad>();
            string query = "select * from Modalidad";

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
                            Modalidad modalidad = new Modalidad();


                            modalidad.idModalidad = reader.GetInt32(0);
                            modalidad.Nombre = reader.GetString(1);


                            modalidades.Add(modalidad);
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
            if (modalidades.Count != 0)
            {
                return modalidades;

            }
            return null;
        }

        public Modalidad getOne(int id)
        {
            Modalidad modalidad = null;
            string query = "SELECT * FROM Modalidad WHERE Id_Modalidad = @Parameter1";

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
                            modalidad = new Modalidad();

                            modalidad.idModalidad = reader.GetInt32(0);
                            modalidad.Nombre = reader.GetString(1);
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
            if (modalidad != null)
            {
                return modalidad;

            }
            return null;
        }
    }
}
