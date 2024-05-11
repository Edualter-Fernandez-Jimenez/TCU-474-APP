using Datos.DTO;
using Datos.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BD.ProyectosQuery
{
    public class QueryExecutorProyecto
    {
        private readonly DBConnection connectionHelper;
        public QueryExecutorProyecto() {
            this.connectionHelper = new DBConnection();
        }

        public int getLastID()
        {
            int id = 1;
            string query = @"SELECT TOP 1 Id
            FROM Proyectos
            ORDER BY Id DESC;";
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
                            if (reader.GetInt32(0) != 0)
                            {
                                id = reader.GetInt32(0)+1;
                            }
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
        public List<AreaInteres> getAllAreasInteres()
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
            return areasInteres;
        }
        public bool addAreaInteres(AreaInteres areaInteres)
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
        public List<Modalidad> getAllModalidad()
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
                            Modalidad auxModalidad = new Modalidad();


                            auxModalidad.idModalidad = reader.GetInt32(0);
                            auxModalidad.nombreModalidad = reader.GetString(1);


                            modalidades.Add(auxModalidad);
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
            return modalidades;
        }

        public List<EstadoProyecto> getAllEstadosProyecto()
        {
            List<EstadoProyecto> estadosProyecto = new List<EstadoProyecto>();
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
                            EstadoProyecto auxEstadoProyecto = new EstadoProyecto();


                            auxEstadoProyecto.idEstadoProyecto = reader.GetInt32(0);
                            auxEstadoProyecto.nombreEstadoProyecto = reader.GetString(1);


                            estadosProyecto.Add(auxEstadoProyecto);
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
            return estadosProyecto;
        }
        
        public List<DTOUsuario> getAllUsuarios()
        {
            List<DTOUsuario> usuarios = new List<DTOUsuario>();
            string query = @" SELECT U.Carnet,
            U.Cedula,
            U.Nombre,
            U.Apellido,
            U.Numero_Telefono,
            U.Correo_Electronico,
            C.Nombre AS Nombre_Carrera,
            S.Nombre AS Nombre_Sede,
            EU.Nombre AS Nombre_Estado_Usuario
            FROM Usuarios U
            JOIN Carreras C ON U.Id_Carrera = C.Id_Carrera
            JOIN Sedes S ON U.Id_Sede = S.Id_Sede
            JOIN Estados_Usuarios EU ON U.Id_Estado_Usuario = EU.Id_Estado_Usuario
            WHERE EU.Nombre IN ('prorroga', 'activo');";

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
                            reader.GetString(6),
                            reader.GetString(7),
                            reader.GetString(8)
                             );

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

        public bool addProyecto(DTOProyecto proyecto)
        {
            string query = @"INSERT INTO proyectos 
            (Id_Proyecto, Nombre, Descripcion, Fecha_Inicio, Fecha_Fin,Fecha_Creacion, Id_Modalidad, Id_area_Interes, Id_Estado_Proyecto,Id_Direccion)
            VALUES (@idProyecto, @nombre, @descripcion, @fechaInicio, @fechaFin, @Fecha_Creacion, @idModalidad, @idAreaInteres, @idEstadoProyecto,@idDireccion);";
            int rowsAffected = 0;

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@idProyecto", proyecto.idProyecto);
                        command.Parameters.AddWithValue("@nombre", proyecto.nombre);
                        command.Parameters.AddWithValue("@descripcion", proyecto.descripcion);
                        if (proyecto.fechaIncio == DateTime.MinValue)
                        {
                            command.Parameters.AddWithValue("@fechaInicio", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@fechaInicio", proyecto.fechaIncio);
                        }
                        
                        if (proyecto.fechaFin == DateTime.MinValue)
                        {
                            command.Parameters.AddWithValue("@fechaFin", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@fechaFin", proyecto.fechaIncio);
                        }
                        
                        if (proyecto.fechaCreacion == DateTime.MinValue)
                        {
                            command.Parameters.AddWithValue("@Fecha_Creacion", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Fecha_Creacion", proyecto.fechaCreacion);
                        }

                        command.Parameters.AddWithValue("@idModalidad", proyecto.idModalidad);
                        command.Parameters.AddWithValue("@idAreaInteres", proyecto.idAreaInteres);
                        command.Parameters.AddWithValue("@idEstadoProyecto", proyecto.idEstadoProyecto);
                        command.Parameters.AddWithValue("@idDireccion", proyecto.IdDireccion);

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

        public bool addProyectoMicroempresario(int idMicroempresario, string idProyecto)
        {
            string query = @"INSERT INTO Proyecto_Microempresarios 
            (Id_Microempresario, Id_Proyecto)
            VALUES (@idMicroempresario, @idProyecto);";
            int rowsAffected = 0;

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@idMicroempresario", idMicroempresario);
                        command.Parameters.AddWithValue("@idProyecto", idProyecto);

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

        public bool addProyectoUsuario(string carnet, string idProyecto)
        {
            string query = @"INSERT INTO Usuarios_Proyectos
            (Carnet, Id_Proyecto)
            VALUES (@carnet, @idProyecto);";
            int rowsAffected = 0;

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@carnet", carnet);
                        command.Parameters.AddWithValue("@idProyecto", idProyecto);

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
        public List<DTOProyecto> getAllProyectos()
        {
            List<DTOProyecto> proyectos = new List<DTOProyecto>();
            string query = @" SELECT 
                p.Id_Proyecto,
                p.Nombre AS Nombre_Proyecto,
                p.Descripcion,
                p.Fecha_Inicio,
                p.Fecha_Fin,
                m.Nombre AS Modalidad,
                ai.Nombre AS Area_Interes,
                ep.Nombre AS Estado_Proyecto,
                pr.Nombre AS Provincia,
                c.Nombre AS Canton,
                d.Nombre AS Distrito,
                di.Otras_Señas,
                p.Id_Direccion,
                p.Fecha_Creacion
                FROM 
                dbo.Proyectos p
                JOIN 
                dbo.Modalidad m ON p.Id_Modalidad = m.Id_Modalidad
                JOIN 
                dbo.Areas_Interes ai ON p.Id_area_Interes = ai.Id_areaInteres
                JOIN 
                dbo.Estados_Proyectos ep ON p.Id_Estado_Proyecto = ep.Id_Estado_Proyecto
                JOIN 
                dbo.Direccion di ON p.Id_Direccion = di.Id_Direccion
                JOIN 
                dbo.Provincia pr ON di.Id_Provincia = pr.Id_Provincia
                JOIN 
                dbo.Canton c ON di.Id_Canton = c.Id_Canton
                JOIN 
                dbo.Distrito d ON di.Id_Distrito = d.Id_Distrito;";

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
                            DTOProyecto proyectoAux = new DTOProyecto(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(5),
                            reader.GetString(6),
                            reader.GetString(7),
                            reader.GetString(8),
                            reader.GetString(9),
                            reader.GetString(10),
                            reader.GetString(11)
                             );
                            if (reader.IsDBNull(3))
                            {
                                proyectoAux.fechaIncio = DateTime.MinValue;
                            }
                            else
                            {
                                proyectoAux.fechaIncio = reader.GetDateTime(3);
                            }

                            if (reader.IsDBNull(4))
                            {
                                proyectoAux.fechaFin = DateTime.MinValue;
                            }
                            else
                            {
                                proyectoAux.fechaFin = reader.GetDateTime(4);
                            }
                            proyectoAux.IdDireccion = reader.GetInt32(12);

                            if (reader.IsDBNull(13))
                            {
                                proyectoAux.fechaCreacion = DateTime.MinValue;
                            }
                            else
                            {
                                proyectoAux.fechaCreacion = reader.GetDateTime(13);
                            }

                            proyectos.Add(proyectoAux);
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

            return proyectos;

        }

        public DTOProyecto getOneProyectos(string idProyecto)
        {
            string query = @" SELECT 
                p.Id_Proyecto,
                p.Nombre AS Nombre_Proyecto,
                p.Descripcion,
                p.Fecha_Inicio,
                p.Fecha_Fin,
                m.Nombre AS Modalidad,
                ai.Nombre AS Area_Interes,
                ep.Nombre AS Estado_Proyecto,
                pr.Nombre AS Provincia,
                c.Nombre AS Canton,
                d.Nombre AS Distrito,
                di.Otras_Señas,
                p.Id_Direccion
                FROM 
                dbo.Proyectos p
                JOIN 
                dbo.Modalidad m ON p.Id_Modalidad = m.Id_Modalidad
                JOIN 
                dbo.Areas_Interes ai ON p.Id_area_Interes = ai.Id_areaInteres
                JOIN 
                dbo.Estados_Proyectos ep ON p.Id_Estado_Proyecto = ep.Id_Estado_Proyecto
                JOIN 
                dbo.Direccion di ON p.Id_Direccion = di.Id_Direccion
                JOIN 
                dbo.Provincia pr ON di.Id_Provincia = pr.Id_Provincia
                JOIN 
                dbo.Canton c ON di.Id_Canton = c.Id_Canton
                JOIN 
                dbo.Distrito d ON di.Id_Distrito = d.Id_Distrito
                WHERE  p.Id_Proyecto = @IdProyecto;";

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdProyecto", idProyecto);

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            DTOProyecto proyectoAux = new DTOProyecto(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(5),
                            reader.GetString(6),
                            reader.GetString(7),
                            reader.GetString(8),
                            reader.GetString(9),
                            reader.GetString(10),
                            reader.GetString(11)
                             );
                            if (reader.IsDBNull(3))
                            {
                                proyectoAux.fechaIncio = DateTime.MinValue;
                            }
                            else
                            {
                                proyectoAux.fechaIncio = reader.GetDateTime(3);
                            }

                            if (reader.IsDBNull(4))
                            {
                                proyectoAux.fechaFin = DateTime.MinValue;
                            }
                            else
                            {
                                proyectoAux.fechaFin = reader.GetDateTime(4);
                            }
                            proyectoAux.IdDireccion = reader.GetInt32(12);
                            return  proyectoAux;
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

            return null;
        }

        public bool UpdateProyecto(DTOProyecto proyecto)
        {
            int rowsAffected = 0;
            string query = @"UPDATE proyectos 
            SET Nombre = @nombre, 
                Descripcion = @descripcion, 
                Fecha_Inicio = @fechaInicio, 
                Fecha_Fin = @fechaFin, 
                Id_Modalidad = @idModalidad, 
                Id_Area_Interes = @idAreaInteres, 
                Id_Estado_Proyecto = @idEstadoProyecto, 
                Id_Direccion = @idDireccion
            WHERE Id_Proyecto = @idProyecto;";

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@idProyecto", proyecto.idProyecto);
                        command.Parameters.AddWithValue("@nombre", proyecto.nombre);
                        command.Parameters.AddWithValue("@descripcion", proyecto.descripcion);
                        if (proyecto.fechaIncio == DateTime.MinValue)
                        {
                            command.Parameters.AddWithValue("@fechaInicio", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@fechaInicio", proyecto.fechaIncio);
                        }

                        if (proyecto.fechaFin == DateTime.MinValue)
                        {
                            command.Parameters.AddWithValue("@fechaFin", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@fechaFin", proyecto.fechaFin);
                        }
                        command.Parameters.AddWithValue("@idModalidad", proyecto.idModalidad);
                        command.Parameters.AddWithValue("@idAreaInteres", proyecto.idAreaInteres);
                        command.Parameters.AddWithValue("@idEstadoProyecto", proyecto.idEstadoProyecto);
                        command.Parameters.AddWithValue("@idDireccion", proyecto.IdDireccion);

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

        public List<DTOMicroempresario> getAllMicroProyecto(string idProyecto)
        {
            List<DTOMicroempresario> microempresarios = new List<DTOMicroempresario>();
            string query = @" SELECT 
                    m.[Id_Microempresario],                        
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
                JOIN 
                    [dbo].[Proyecto_Microempresarios] pm ON m.[Id_Microempresario] = pm.[Id_Microempresario]
                WHERE 
                    pm.[Id_Proyecto] = @idProyecto;";

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       command.Parameters.AddWithValue("@idProyecto", idProyecto);
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

        public List<DTOUsuario> getAllUsuarioProyecto(string idProyecto)
        {
            List<DTOUsuario> usuarios = new List<DTOUsuario>();
            string query = @" SELECT U.Carnet,
            U.Cedula,
            U.Nombre,
            U.Apellido,
            U.Numero_Telefono,
            U.Correo_Electronico,
            C.Nombre AS Nombre_Carrera,
            S.Nombre AS Nombre_Sede,
            EU.Nombre AS Nombre_Estado_Usuario
            FROM Usuarios U
            JOIN Carreras C ON U.Id_Carrera = C.Id_Carrera
            JOIN Sedes S ON U.Id_Sede = S.Id_Sede
            JOIN Estados_Usuarios EU ON U.Id_Estado_Usuario = EU.Id_Estado_Usuario
            JOIN 
			[dbo].[Usuarios_Proyectos] pm ON U.[carnet] = pm.[carnet]
			WHERE  pm.[Id_Proyecto] = @idProyecto;";

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {

                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idProyecto", idProyecto);
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
                            reader.GetString(6),
                            reader.GetString(7),
                            reader.GetString(8)
                             );

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

        public bool delProyectoMicroempresario(int idMicroempresario, string idProyecto)
        {
            string query = @"
            DELETE FROM Proyecto_Microempresarios 
            WHERE Id_Microempresario = @idMicroempresario 
            AND Id_Proyecto = @idProyecto;";
            int rowsAffected = 0;

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@idMicroempresario", idMicroempresario);
                        command.Parameters.AddWithValue("@idProyecto", idProyecto);

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

        public bool delProyectoUsuario(string carnet, string idProyecto)
        {
            string query = @"
            DELETE FROM Usuarios_Proyectos 
            WHERE Carnet = @carnet 
            AND Id_Proyecto = @idProyecto;
            ";
            int rowsAffected = 0;

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@carnet", carnet);
                        command.Parameters.AddWithValue("@idProyecto", idProyecto);

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

        public bool UpdateFechasMicro(DateTime fechaFin, string idProyecto)
        {
            string query = @"UPDATE m
            SET m.[Ult_Fecha_Atencion] = @fecha 
            FROM [dbo].[Microempresarios] m
            JOIN [dbo].[Proyecto_Microempresarios] pm ON m.[Id_Microempresario] = pm.[Id_Microempresario]
            WHERE pm.[Id_Proyecto] = @idProyecto;";
            int rowsAffected = 0;

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@idProyecto", idProyecto);
                        command.Parameters.AddWithValue("@fecha", fechaFin);

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
        public bool delProyectoMicroempresario(string idProyecto)
        {
            string query = @"
            DELETE FROM Proyecto_Microempresarios WHERE 
            Id_Proyecto = @idProyecto;";
            int rowsAffected = 0;

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@idProyecto", idProyecto);

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

        public bool delProyectoUsuario(string idProyecto)
        {
            string query = @"
            DELETE FROM Usuarios_Proyectos WHERE 
            Id_Proyecto = @idProyecto;
            ";
            int rowsAffected = 0;

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@idProyecto", idProyecto);

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

        public bool delProyecto(string idProyecto)
        {
            string query = @"
            DELETE FROM proyectos WHERE 
            Id_Proyecto = @idProyecto;
            ";
            int rowsAffected = 0;

            using (SqlConnection connection = connectionHelper.CreateConnection())
            {
                connectionHelper.OpenConnection(connection);

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@idProyecto", idProyecto);

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
