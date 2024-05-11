using Datos.DTO;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.UsuarioQuery
{
    public class QueryExecutorUsuario
    {
        private readonly DBConnection connectionHelper;
        public QueryExecutorUsuario()
        {
            this.connectionHelper = new DBConnection();
        }
        #region listOrtherTables
        public List<Sede> getAllSedes()
        {
            List<Sede> sedes = new List<Sede>();
            string query = "select * from Sedes";

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
                            Sede sede = new Sede();


                            sede.IdSede = reader.GetInt32(0);
                            sede.NombreSede = reader.GetString(1);


                            sedes.Add(sede);
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
            return sedes;
        }
        public List<Carrera> getAllCarreras()
        {
            List<Carrera> carreras = new List<Carrera>();
            string query = "select * from Carreras";

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
                            Carrera carrera = new Carrera();


                            carrera.IdCarrera = reader.GetString(0);
                            carrera.NombreCarrera = reader.GetString(1);


                            carreras.Add(carrera);
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
            return carreras;
        }
        public List<EstadoUsuario> getAllEstadosUsuarios()
        {
            List<EstadoUsuario> estadosUsuarios = new List<EstadoUsuario>();
            string query = "select * from Estados_Usuarios";

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
                            EstadoUsuario estadoUsuario = new EstadoUsuario();


                            estadoUsuario.IdEstadoUsuario = reader.GetInt32(0);
                            estadoUsuario.NombreEstadoUsuario = reader.GetString(1);


                            estadosUsuarios.Add(estadoUsuario);
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
            return estadosUsuarios;
        }
        #endregion

        public bool addUsuario(DTOUsuario usuario)
        {
            string query = @"INSERT INTO Usuarios (Carnet, Cedula, Nombre, Apellido, Numero_Telefono, Correo_Electronico, Fecha_Inicio,Fecha_Fin, Id_Carrera, Id_Sede, Id_Estado_Usuario) 
                 VALUES (@Carnet, @Cedula, @Nombre, @Apellido, @Numero_Telefono, @Correo_Electronico, @Fecha_Inicio, @Fecha_Fin, @Id_Carrera, @Id_Sede, @Id_Estado_Usuario)";

            int rowsAffected = 0;

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Carnet", usuario.carnet);
                        command.Parameters.AddWithValue("@Cedula", usuario.cedula);
                        command.Parameters.AddWithValue("@Nombre", usuario.nombre);
                        command.Parameters.AddWithValue("@Apellido", usuario.apellido);
                        command.Parameters.AddWithValue("@Numero_Telefono", usuario.numeroTelefono);
                        command.Parameters.AddWithValue("@Correo_Electronico", usuario.correoElectronico);
                       
                       
                        command.Parameters.AddWithValue("@Id_Carrera", usuario.idCarrera);
                        command.Parameters.AddWithValue("@Id_Sede", usuario.idSede);
                        command.Parameters.AddWithValue("@Id_Estado_Usuario", usuario.idEstadoUsuario);
                        
                        if (usuario.fechaInicio == DateTime.MinValue)
                        {
                            command.Parameters.AddWithValue("@Fecha_Inicio", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Fecha_Inicio", usuario.fechaInicio);
                        }
                        
                        if (usuario.fechaFin == DateTime.MinValue)
                        {
                            command.Parameters.AddWithValue("@Fecha_Fin", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Fecha_Fin", usuario.fechaFin);
                        }

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

        public DTOUsuario getOneUsuario(string carnet)
        {
            DTOUsuario usuario = new DTOUsuario();
            string query = @" SELECT U.Carnet,
            U.Cedula,
            U.Nombre,
            U.Apellido,
            U.Numero_Telefono,
            U.Correo_Electronico,
            U.Fecha_Inicio,
            U.Fecha_Fin,
            C.Nombre AS Nombre_Carrera,
            S.Nombre AS Nombre_Sede,
            EU.Nombre AS Nombre_Estado_Usuario
            FROM Usuarios U
            JOIN Carreras C ON U.Id_Carrera = C.Id_Carrera
            JOIN Sedes S ON U.Id_Sede = S.Id_Sede
            JOIN Estados_Usuarios EU ON U.Id_Estado_Usuario = EU.Id_Estado_Usuario
            WHERE U.Carnet = @Carnet;";

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Carnet", carnet);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            DTOUsuario usuarioAux = new DTOUsuario(
                            reader.GetString(0), 
                            reader.GetString(1), 
                            reader.GetString(2), 
                            reader.GetString(3), 
                            reader.GetString(4), 
                            reader.GetString(5), 
                            reader.GetString(8), 
                            reader.GetString(9), 
                            reader.GetString(10)
                             );
                            if (reader.IsDBNull(6))
                            {
                                usuarioAux.fechaInicio = DateTime.MinValue;
                            }
                            else
                            {
                                usuarioAux.fechaInicio = reader.GetDateTime(6);
                            }

                            if (reader.IsDBNull(7))
                            {
                                usuarioAux.fechaFin = DateTime.MinValue;
                            }
                            else
                            {
                                usuarioAux.fechaFin = reader.GetDateTime(7);
                            }


                            usuario = usuarioAux;
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
            if (usuario != null)
            {
                return usuario;

            }
            return null;
        }

        public bool updateUsuario(DTOUsuario usuario)
        {
            string query = @"UPDATE Usuarios 
                 SET Cedula = @Cedula, 
                     Nombre = @Nombre, 
                     Apellido = @Apellido, 
                     Numero_Telefono = @Numero_Telefono, 
                     Correo_Electronico = @Correo_Electronico,
                     Fecha_Inicio = @Fecha_Inicio,
                     Fecha_Fin = @Fecha_Fin,
                     Id_Carrera = @Id_Carrera, 
                     Id_Sede = @Id_Sede, 
                     Id_Estado_Usuario = @Id_Estado_Usuario
                 WHERE Carnet = @Carnet";

            int rowsAffected = 0;

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Carnet", usuario.carnet);
                        command.Parameters.AddWithValue("@Cedula", usuario.cedula);
                        command.Parameters.AddWithValue("@Nombre", usuario.nombre);
                        command.Parameters.AddWithValue("@Apellido", usuario.apellido);
                        command.Parameters.AddWithValue("@Numero_Telefono", usuario.numeroTelefono);
                        command.Parameters.AddWithValue("@Correo_Electronico", usuario.correoElectronico);
                        command.Parameters.AddWithValue("@Id_Carrera", usuario.idCarrera);
                        command.Parameters.AddWithValue("@Id_Sede", usuario.idSede);
                        command.Parameters.AddWithValue("@Id_Estado_Usuario", usuario.idEstadoUsuario);

                        if (usuario.fechaInicio == DateTime.MinValue)
                        {
                            command.Parameters.AddWithValue("@Fecha_Inicio", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Fecha_Inicio", usuario.fechaInicio);
                        }

                        if (usuario.fechaFin == DateTime.MinValue)
                        {
                            command.Parameters.AddWithValue("@Fecha_Fin", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Fecha_Fin", usuario.fechaFin);
                        }

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

        public List<DTOUsuario> getAll()
        {
            List<DTOUsuario> usuarios = new List<DTOUsuario>();
            string query = @" SELECT U.Carnet,
            U.Cedula,
            U.Nombre,
            U.Apellido,
            U.Numero_Telefono,
            U.Correo_Electronico,
            U.Fecha_Inicio,
            U.Fecha_Fin,
            C.Nombre AS Nombre_Carrera,
            S.Nombre AS Nombre_Sede,
            EU.Nombre AS Nombre_Estado_Usuario
            FROM Usuarios U
            JOIN Carreras C ON U.Id_Carrera = C.Id_Carrera
            JOIN Sedes S ON U.Id_Sede = S.Id_Sede
            JOIN Estados_Usuarios EU ON U.Id_Estado_Usuario = EU.Id_Estado_Usuario;";

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
                            DTOUsuario usuarioAux = new DTOUsuario(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetString(5),
                            reader.GetString(8),
                            reader.GetString(9),
                            reader.GetString(10)
                             );
                            if (reader.IsDBNull(6))
                            {
                                usuarioAux.fechaInicio = DateTime.MinValue;
                            }
                            else
                            {
                                usuarioAux.fechaInicio = reader.GetDateTime(6);
                            }

                            if (reader.IsDBNull(7))
                            {
                                usuarioAux.fechaFin = DateTime.MinValue;
                            }
                            else
                            {
                                usuarioAux.fechaFin = reader.GetDateTime(7);
                            }

                            usuarios.Add(usuarioAux);
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

            return usuarios;

        }
    }
}
