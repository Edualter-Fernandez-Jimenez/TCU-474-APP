using Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.ProyectosQuery.EstadosProyecto
{
    public class QueryExecutorEstadosProyecto
    {
        private readonly DBConnection connectionHelper;

        public QueryExecutorEstadosProyecto()
        {
            this.connectionHelper = new DBConnection();
        }

        public List<EstadoProyecto> getAll()
        {
            List<EstadoProyecto> estadosProyectos = new List<EstadoProyecto>();
            string query = "select * from Estados_Proyectos";

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
                            EstadoProyecto estadoProyecto = new EstadoProyecto();


                            estadoProyecto.idEstadoProyecto = reader.GetInt32(0);
                            estadoProyecto.Nombre = reader.GetString(1);


                            estadosProyectos.Add(estadoProyecto);
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
            if (estadosProyectos.Count != 0)
            {
                return estadosProyectos;

            }
            return null;
        }

        public EstadoProyecto getOne(int id)
        {
            EstadoProyecto estadoProyecto = null;
            string query = "SELECT * FROM Estados_Proyectos WHERE Id_Estado_Proyecto = @Parameter1";

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
                            estadoProyecto = new EstadoProyecto();

                            estadoProyecto.idEstadoProyecto = reader.GetInt32(0);
                            estadoProyecto.Nombre = reader.GetString(1);
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
            if (estadoProyecto != null)
            {
                return estadoProyecto;

            }
            return null;
        }
    }
}
