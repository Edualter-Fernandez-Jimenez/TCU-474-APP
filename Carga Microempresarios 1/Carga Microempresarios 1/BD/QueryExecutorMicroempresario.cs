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
    public class QueryExecutorMicroempresario
    {

        private readonly DBConnection connectionHelper;

        public QueryExecutorMicroempresario()
        {
            this.connectionHelper = new DBConnection();
        }

        public bool addMicroempresarioEmprendimiento(Microempresario microempresario, Emprendimiento emprendimiento)
        {
            string spNombre = "InsertarMicroempresarioEmprendimiento";

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(spNombre, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        //Microempresario
                        command.Parameters.AddWithValue("@NombreMicroempresario", microempresario.Nombre);
                        command.Parameters.AddWithValue("@ApellidoMicroempresario", microempresario.Apellidos);
                        command.Parameters.AddWithValue("@Cedula", microempresario.Cedula);
                        command.Parameters.AddWithValue("@Telefono", microempresario.Telefono);
                        command.Parameters.AddWithValue("@CorreoElectronico", microempresario.CorreoElectronico);
                        if (microempresario.UltimaFechaAtencion == DateTime.MinValue)
                        {
                            command.Parameters.AddWithValue("@UltimaFechaAtencion", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@UltimaFechaAtencion", microempresario.UltimaFechaAtencion);
                        }

                        //Emprendimiento
                        command.Parameters.AddWithValue("@NombreEmprendimiento", emprendimiento.Nombre);
                        command.Parameters.AddWithValue("@DescripcionEmprendimiento", emprendimiento.Descripcion);
                        command.Parameters.AddWithValue("@CantidadColaboradores", emprendimiento.CantidadColaboradores);
                        command.Parameters.AddWithValue("@Id_Direccion", emprendimiento.IdDireccion);


                        // Ejecutar el procedimiento almacenado
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    return false;
                    // Puedes decidir cómo manejar el error, por ejemplo, lanzar una excepción o registrar el error
                }
                finally
                {
                    connectionHelper.CloseConnection(connection);
                }
                return true;
            }

        }
        public DTOMicroempresario getOne(int idEmprendimiento)
        {
            DTOMicroempresario microempresario = new DTOMicroempresario();
            string query = @" SELECT m.[Id_Microempresario],                        
            m.[Nombre] AS [Nombre_Microempresario],
            m.[Apellidos],
            m.[Cedula],
            m.[Telefono],
            m.[Correo_Electronico],
			e.[Nombre] AS [Nombre_Emprendimiento],
			e.[Cantidad_Colaboradores],
			e.[Descripcion] AS [Descripcion_Emprendimiento],
            p.[Nombre] AS [Nombre_Provincia],
            c.[Nombre] AS [Nombre_Canton],
            dis.[Nombre] AS [Nombre_Distrito],
			d.[Otras_Señas],
			m.[Ult_Fecha_Atencion]
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
               WHERE
		   m.Id_Microempresario = @IdEmprendimiento
            ";

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdEmprendimiento", idEmprendimiento);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            DTOMicroempresario auxMicroempresario = new DTOMicroempresario(
                            reader.GetInt32(0), //id micro
                            reader.GetString(1), //nombre micro
                            reader.GetString(2), //appellido micro
                            reader.GetString(3), //cedula
                            reader.GetString(4), //tel
                            reader.GetString(5), //correo
                            reader.GetString(6), //nombre empren
                            reader.GetInt32(7), //cant colabs
                            reader.GetString(8), //descrip
                            reader.GetString(9),//prov
                            reader.GetString(10), //cant
                            reader.GetString(11), //distro
                            reader.GetString(12) //otras
                             );

                            if (reader.IsDBNull(13))
                            {
                                auxMicroempresario.UltimaFechaAtencion = DateTime.MinValue;
                            }
                            else
                            {
                                auxMicroempresario.UltimaFechaAtencion = reader.GetDateTime(13);
                            }

                            microempresario = auxMicroempresario;
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
            if (microempresario != null)
            {
                return microempresario;

            }
            return null;
        }

        public List<DTOMicroempresario> getAll()
        {
            List<DTOMicroempresario> microempresarios = new List<DTOMicroempresario>();
            string query = @" SELECT m.[Id_Microempresario],                        
            m.[Nombre] AS [Nombre_Microempresario],
            m.[Apellidos],
            m.[Cedula],
            m.[Telefono],
            m.[Correo_Electronico],
			e.[Nombre] AS [Nombre_Emprendimiento],
			e.[Cantidad_Colaboradores],
			e.[Descripcion] AS [Descripcion_Emprendimiento],
            p.[Nombre] AS [Nombre_Provincia],
            c.[Nombre] AS [Nombre_Canton],
            dis.[Nombre] AS [Nombre_Distrito],
			d.[Otras_Señas],
			m.[Ult_Fecha_Atencion]
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
            [dbo].[Distrito] dis ON d.[Id_Distrito] = dis.[Id_Distrito];";

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
                            DTOMicroempresario microempresario = new DTOMicroempresario(
                                reader.GetInt32(0), //id micro
                            reader.GetString(1), //nombre micro
                            reader.GetString(2), //appellido micro
                            reader.GetString(3), //cedula
                            reader.GetString(4), //tel
                            reader.GetString(5), //correo
                            reader.GetString(6), //nombre empren
                            reader.GetInt32(7), //cant colabs
                            reader.GetString(8), //descrip
                            reader.GetString(9),//prov
                            reader.GetString(10), //cant
                            reader.GetString(11), //distro
                            reader.GetString(12) //otras
                                );

                            if (reader.IsDBNull(13))
                            {
                                microempresario.UltimaFechaAtencion = DateTime.MinValue;
                            }
                            else
                            {
                                microempresario.UltimaFechaAtencion = reader.GetDateTime(13);
                            }

                            microempresarios.Add(microempresario);
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

            return microempresarios;

        }
        public int getIdEmprendimineto(int idEmprendimiento)
        {
            int id = 0;
            DTOMicroempresario microempresario = new DTOMicroempresario();
            string query = @" SELECT e.[Id_Emprendimiento]
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
			where e.Id_Emprendimiento = @Microempresario
            ";

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Microempresario", idEmprendimiento);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {

                            id = reader.GetInt32(0);
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
            return id;
        }

        public bool modificarMicroempresarioEmprendimiento(Microempresario microempresario, Emprendimiento emprendimiento)
        {
            string spNombre = "ModificarMicroempresarioEmprendimiento";

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(spNombre, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        //Microempresario
                        command.Parameters.AddWithValue("@idMicroempresario", microempresario.IdMicroempresario);
                        command.Parameters.AddWithValue("@NombreMicroempresario", microempresario.Nombre);
                        command.Parameters.AddWithValue("@ApellidoMicroempresario", microempresario.Apellidos);
                        command.Parameters.AddWithValue("@Cedula", microempresario.Cedula);
                        command.Parameters.AddWithValue("@Telefono", microempresario.Telefono);
                        command.Parameters.AddWithValue("@CorreoElectronico", microempresario.CorreoElectronico);
                        if (microempresario.UltimaFechaAtencion == DateTime.MinValue)
                        {
                            command.Parameters.AddWithValue("@UltimaFechaAtencion", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@UltimaFechaAtencion", microempresario.UltimaFechaAtencion);
                        }

                        //Emprendimiento
                        command.Parameters.AddWithValue("@IdEmprendimiento", emprendimiento.IdEmprendimiento);
                        command.Parameters.AddWithValue("@NombreEmprendimiento", emprendimiento.Nombre);
                        command.Parameters.AddWithValue("@DescripcionEmprendimiento", emprendimiento.Descripcion);
                        command.Parameters.AddWithValue("@CantidadColaboradores", emprendimiento.CantidadColaboradores);
                        command.Parameters.AddWithValue("@Id_Direccion", emprendimiento.IdDireccion);

                        // Ejecutar el procedimiento almacenado
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    return false;
                    // Puedes decidir cómo manejar el error, por ejemplo, lanzar una excepción o registrar el error
                }
                finally
                {
                    connectionHelper.CloseConnection(connection);
                }
                return true;
            }

        }
    }
}
