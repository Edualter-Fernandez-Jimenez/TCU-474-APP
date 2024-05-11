using Datos.DTO;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BD.ReportesQuery
{
    public class QueryExecutorReportes
    {
        private readonly DBConnection connectionHelper;

        public QueryExecutorReportes()
        {
            this.connectionHelper = new DBConnection();

        }

        public List<DTOAuxMicroempresarios> getAllMicroAtendZona(DateTime fechaInicial, DateTime fechaFinal)
        {
            List<DTOAuxMicroempresarios> listaMicro = new List<DTOAuxMicroempresarios>();
            string query = @"SELECT  
                    mic.Cedula,
                    prov.Nombre AS Nombre_Provincia,
                    cant.Nombre AS Nombre_Canton,
                    dist.Nombre AS Nombre_Distrito,
	                MIN(pro.Fecha_Fin) AS Fecha_Fin
                FROM 
                    Microempresarios mic
                JOIN 
                    Emprendimientos emp ON mic.Id_Emprendimiento = emp.Id_Emprendimiento
                JOIN 
                    Proyecto_Microempresarios pm ON mic.Id_Microempresario = pm.Id_Microempresario
                JOIN 
                    Proyectos pro ON pm.Id_Proyecto = pro.Id_Proyecto
                JOIN 
                    Direccion dir ON emp.Id_Direccion = dir.Id_Direccion
                JOIN 
                    Provincia prov ON dir.Id_Provincia = prov.Id_Provincia
                JOIN 
                    Canton cant ON dir.Id_Canton = cant.Id_Canton
                JOIN 
                    Distrito dist ON dir.Id_Distrito = dist.Id_Distrito
                WHERE 
                pro.Fecha_Fin >= @fechaInicial
                AND pro.Fecha_Fin <= @fechaFinal
                AND pro.Fecha_Fin IS NOT NULL
                GROUP BY
                mic.Cedula,
                prov.Nombre,
                cant.Nombre,
                dist.Nombre;";

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fechaInicial", fechaInicial);
                        command.Parameters.AddWithValue("@fechaFinal", fechaFinal);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            DTOAuxMicroempresarios microaux = new DTOAuxMicroempresarios(
                                  reader.GetString(0),
                                  reader.GetString(1),
                                  reader.GetString(2),
                                  reader.GetString(3),
                                  reader.GetDateTime(4)
                            );

                            listaMicro.Add(microaux);

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
            if (listaMicro.Count != 0)
            {
                return listaMicro;
            }
            else
            {
                return null;
            }
        }

        public List<DTOProyAreaRepo> GetProyAreaRepos()
        {
            List<DTOProyAreaRepo> listaPro = new List<DTOProyAreaRepo>();
            string query = @"SELECT AI.Nombre AS Area_Interes, COUNT(P.Id) AS cantidad_de_proyectos
                    FROM Proyectos AS P
                    INNER JOIN Areas_Interes AS AI ON P.Id_area_Interes = AI.Id_areaInteres
                    INNER JOIN Estados_Proyectos AS EP ON P.Id_Estado_Proyecto = EP.Id_Estado_Proyecto
                    GROUP BY AI.Nombre;
                    ";

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
                            DTOProyAreaRepo proyAux = new DTOProyAreaRepo(
                                  reader.GetString(0),
                                  reader.GetInt32(1)
                            );
                            listaPro.Add(proyAux);

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
            return listaPro;
        }

        public DTOAuxFehcas getFechaPrimerPCreado()
        {
            DTOAuxFehcas fechas = new DTOAuxFehcas();
            string query = @"SELECT MIN(Fecha_Fin),MAX(Fecha_Fin),
                    COUNT(DISTINCT YEAR(Fecha_Fin)) AS Total_Anios_Distintos
                    FROM Proyectos; ";

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
                            if (!reader.IsDBNull(0))
                            {
                                fechas.fechaMenor = reader.GetDateTime(0);
                            }
                            else
                            {
                                fechas.fechaMenor = DateTime.MinValue;
                            }

                            if (!reader.IsDBNull(1))
                            {
                                fechas.fechaMayor = reader.GetDateTime(1);
                            }
                            else
                            {
                                fechas.fechaMayor= DateTime.MinValue;
                            }
                            fechas.totalFechas = reader.GetInt32(2);
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
            return fechas;
        }

        public int GetCantidadMiccroAttendAlAnio(DateTime fechaInicial, DateTime fechaFinal)
        {
            int cantidad = 0;
            string query = @"SELECT  
                        COUNT(DISTINCT mic.Id_Microempresario) AS Cantidad_Microempresarios
                    FROM 
                        Proyectos pro
                    JOIN 
                        Proyecto_Microempresarios pm ON pro.Id_Proyecto = pm.Id_Proyecto
                    JOIN 
                        Microempresarios mic ON pm.Id_Microempresario = mic.Id_Microempresario
                    JOIN 
                        Emprendimientos emp ON mic.Id_Emprendimiento = emp.Id_Emprendimiento
                    WHERE 
                       pro.Fecha_Fin >= @fechaInicial
                        AND pro.Fecha_Fin <= @fechaFinal
                        AND pro.Fecha_Fin IS NOT NULL; ";

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
               
                connectionHelper.OpenConnection(connection);

                try
                {

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fechaInicial", fechaInicial);
                        command.Parameters.AddWithValue("@fechaFinal", fechaFinal);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                          cantidad = reader.GetInt32(0);
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
            return cantidad;
        }
    }
}
