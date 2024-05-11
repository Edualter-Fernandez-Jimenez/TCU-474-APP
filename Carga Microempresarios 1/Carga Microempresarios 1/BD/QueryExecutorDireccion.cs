using Carga_Microempresarios_1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carga_Microempresarios_1.BD
{
    public class QueryExecutorDireccion
    {

        private readonly DBConnection connectionHelper;

    public QueryExecutorDireccion()
    {
        this.connectionHelper = new DBConnection();
    }
    /*Get all*/
    public List<Direccion> getAll()
    {
        List<Direccion> provincias = new List<Direccion>();
        string query = "select * from Direccion";

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
                        Direccion direccion = new Direccion();


                        direccion.Id = reader.GetInt32(0);
                        direccion.OtrasSenas = reader.GetString(1);
                        direccion.IdProvincia = reader.GetInt32(2);
                        direccion.IdCanton = reader.GetInt32(3);
                        direccion.IdDistrito = reader.GetInt32(4);

                        provincias.Add(direccion);
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
    /*GetOne*/
    public Direccion getOne(int id)
    {
        Direccion direccion = null;
        string query = "SELECT * FROM Direccion WHERE Id_Direccion = @Parameter1";

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
                        direccion = new Direccion();

                        direccion.Id = reader.GetInt32(0);
                        direccion.OtrasSenas = reader.GetString(1);
                        direccion.IdProvincia = reader.GetInt32(2);
                        direccion.IdCanton = reader.GetInt32(3);
                        direccion.IdDistrito = reader.GetInt32(4);
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
        if (direccion != null)
        {
            return direccion;

        }
        return null;
    }



    /*Insert*/
    public int addDireccion(Direccion direccion)
    {
        string spNombre = "InsertarDireccion";
        int idDireccion = 0;

        using (SqlConnection connection = connectionHelper.CreateConnection())
        {
            connectionHelper.OpenConnection(connection);

            try
            {
                using (SqlCommand command = new SqlCommand(spNombre, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Otras_Señas", direccion.OtrasSenas);
                    command.Parameters.AddWithValue("@Id_Provincia", direccion.IdProvincia);
                    command.Parameters.AddWithValue("@Id_Canton", direccion.IdCanton);
                    command.Parameters.AddWithValue("@Id_Distrito", direccion.IdDistrito);

                    // Agregar el parámetro de salida para obtener el valor de la identidad
                    SqlParameter outputParameter = new SqlParameter("@Id_Direccion", SqlDbType.Int);
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);

                    // Ejecutar el procedimiento almacenado
                    command.ExecuteNonQuery();

                    // Obtener el valor del parámetro de salida
                    idDireccion = Convert.ToInt32(outputParameter.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                // Puedes decidir cómo manejar el error, por ejemplo, lanzar una excepción o registrar el error
            }
            finally
            {
                connectionHelper.CloseConnection(connection);
            }

            return idDireccion;
        }

    }

    public void EliminarDireccion(int idDireccion)
    {
        string spNombre = "EliminarDireccion";

        using (SqlConnection connection = connectionHelper.CreateConnection())
        {
            connectionHelper.OpenConnection(connection);

            try
            {
                using (SqlCommand command = new SqlCommand(spNombre, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar el parámetro de entrada para el ID de dirección
                    command.Parameters.AddWithValue("@Id_Direccion", idDireccion);

                    // Ejecutar el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                // Puedes decidir cómo manejar el error, por ejemplo, lanzar una excepción o registrar el error
            }
            finally
            {
                connectionHelper.CloseConnection(connection);
            }
        }

    }

    public int getidByMicroempresario(int id)
    {
        int idDireccion = 0;
        string query = @"SELECT 
		e.[Id_Direccion]
            FROM 
            [dbo].[Microempresarios] m
            JOIN 
            [dbo].[Emprendimientos] e ON m.[Id_Emprendimiento] = e.[Id_Emprendimiento]
            JOIN 
            [dbo].[Direccion] d ON e.[Id_Direccion] = d.[Id_Direccion]
            LEFT JOIN 
            [dbo].[Provincia] p ON d.[Id_Provincia] = p.[Id_Provincia]
            LEFT JOIN 
            [dbo].[Canton] c ON d.[Id_Canton] = c.[Id_Canton]
            LEFT JOIN 
            [dbo].[Distrito] dis ON d.[Id_Distrito] = dis.[Id_Distrito]
            where m.Id_Microempresario = @Parameter1 ";

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
                        idDireccion = reader.GetInt32(0);
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
        return idDireccion;
    }
    //edit

    public void modificarDireccion(Direccion direccion)
    {
        string spNombre = "ModificarDireccion";

        using (SqlConnection connection = connectionHelper.CreateConnection())
        {
            connectionHelper.OpenConnection(connection);

            try
            {
                using (SqlCommand command = new SqlCommand(spNombre, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Otras_Señas", direccion.OtrasSenas);
                    command.Parameters.AddWithValue("@Id_Provincia", direccion.IdProvincia);
                    command.Parameters.AddWithValue("@Id_Canton", direccion.IdCanton);
                    command.Parameters.AddWithValue("@Id_Distrito", direccion.IdDistrito);
                    command.Parameters.AddWithValue("@Id_Direccion", direccion.Id);

                    // Ejecutar el procedimiento almacenado
                    command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
            }
            finally
            {
                connectionHelper.CloseConnection(connection);
            }
        }

    }
}
}
