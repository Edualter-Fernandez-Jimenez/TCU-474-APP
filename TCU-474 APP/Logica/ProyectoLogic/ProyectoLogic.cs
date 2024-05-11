using BD.DireccionQuery;
using BD.MicroempresarioQuery;
using BD.ProyectosQuery;
using BD.ProyectosQuery.AreasInteres;
using BD.UsuarioQuery;
using Datos.DTO;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Logica.ProyectoLogic
{
    public class ProyectoLogic
    {
        private readonly QueryExecutorProyecto qep = new QueryExecutorProyecto();

        private readonly QueryExecutorProvincia qepr = new QueryExecutorProvincia();
        private readonly QueryExecutorCanton qec = new QueryExecutorCanton();
        private readonly QueryExecutorDistrito qed = new QueryExecutorDistrito();

        private List<Provincia> listaProvincias = null;
        private List<Canton> listaCantones = null;
        private List<Distrito> listaDistritos = null;

        public ProyectoLogic() {
            listaProvincias = qepr.getAll();
            listaCantones = qec.getAll();
            listaDistritos = qed.getAll();
        }

        #region cbProyecto
        public string getNewIdProyecto()
        {
            //revisar
            int a = qep.getLastID();
            return "TCU-"+ DateTime.Now.ToString("yyyy")+"-"+a;
        }

        public List<string> listaAreasInteresString()
        {
            List<AreaInteres> listaAreasInteres = qep.getAllAreasInteres();

            List<string> areaInteres = new List<string>();
            foreach (var item in listaAreasInteres)
            {
                areaInteres.Add(item.Nombre);
            }
            return areaInteres;
        }
        public int getAreaInteres(string nombre)
        {
            List<AreaInteres> listaAreasInteres = qep.getAllAreasInteres();
            foreach (var item in listaAreasInteres)
            {
                if (item.Nombre.Equals(nombre)) {
                    return item.IdAreaInteres;
                }
            }
            return 0;
        }

        public List<string> listaEstadoString()
        {
            List<EstadoProyecto> listaEstadoProyecto = qep.getAllEstadosProyecto();

            List<string> estadosProtecto = new List<string>();
            foreach (var item in listaEstadoProyecto)
            {
                estadosProtecto.Add(item.nombreEstadoProyecto);
            }
            return estadosProtecto;
        }

        public int getEstado(string nombre)
        {
            List<EstadoProyecto> listaEstadoProyecto = qep.getAllEstadosProyecto();
            foreach (var item in listaEstadoProyecto)
            {
                if (item.nombreEstadoProyecto.Equals(nombre))
                {
                    return item.idEstadoProyecto;
                }
            }
            return 0;
        }

        public List<string> listaModalidadesString()
        {
            List<Modalidad> listaModalidades = qep.getAllModalidad();

            List<string> modalidades = new List<string>();
            foreach (var item in listaModalidades)
            {
                modalidades.Add(item.nombreModalidad);
            }
            return modalidades;
        }

        public int getModalidad(string nombre)
        {
            List<Modalidad> listaModalidades = qep.getAllModalidad();

            List<string> modalidades = new List<string>();
            foreach (var item in listaModalidades)
            {
                if (item.nombreModalidad.Equals(nombre)) { 
                    return item.idModalidad;
                }
            }
            return 0;
        }
        #endregion
        #region direccion
        public List<string> getListaProvincias()
        {
            List<string> provincias = new List<string>();
            foreach (var item in listaProvincias)
            {
                provincias.Add(item.Nombre);
            }
            return provincias;
        }
        public List<string> getListaCantones(String provincia)
        {
            List<string> cantones = new List<string>();
            string idProvincia = "";
            foreach (var item1 in listaProvincias)
            {
                if (item1.Nombre.Equals(provincia))
                {
                    idProvincia = item1.Id.ToString();
                }
            }

            foreach (var item2 in listaCantones)
            {
                string aux = item2.Id.ToString();
                if (aux.StartsWith(idProvincia))
                {
                    cantones.Add(item2.Nombre);
                }

            }

            return cantones;
        }

        public List<string> getListaDistritos(string canton)
        {
            List<string> distritos = new List<string>();
            string idCanton = "";
            foreach (var item1 in listaCantones)
            {
                if (item1.Nombre.Equals(canton))
                {
                    idCanton = item1.Id.ToString();
                }
            }

            foreach (var item2 in listaDistritos)
            {
                string aux = item2.Id.ToString();
                if (aux.StartsWith(idCanton))
                {
                    distritos.Add(item2.Nombre);
                }

            }

            return distritos;
        }

        private Direccion generarDireccion(DTOProyecto proyecto, int idDireccion)
        {
            int IdProvincia = 0;
            int IdCanton = 0;
            int IdDistrito = 0;
            //provincia
            foreach (var item1 in listaProvincias)
            {
                if (item1.Nombre.Equals(proyecto.provincia))
                {
                    IdProvincia = item1.Id;
                }
            }
            //canton


            foreach (var item2 in listaCantones)
            {
                string aux = item2.Id.ToString();
                if (aux.StartsWith(IdProvincia.ToString()))
                {
                    if (proyecto.canton.Equals(item2.Nombre))
                    {
                        IdCanton = item2.Id;
                    }

                }

            }
            //distrito
            foreach (var item2 in listaDistritos)
            {
                string aux = item2.Id.ToString();
                if (aux.StartsWith(IdCanton.ToString()))
                {
                    if (proyecto.distrito.Equals(item2.Nombre))
                    {
                        IdDistrito = item2.Id;
                    }

                }

            }


            Direccion direccion = new Direccion(
                idDireccion,
                proyecto.otrasSenas,
                IdProvincia,
                 IdCanton,
                IdDistrito
                );
            return direccion;
        }
        #endregion

        public List<DTOUsuario> getAllUsuarios()
        {
            return qep.getAllUsuarios();
        }
        public List<DTOUsuario> getListaUsuariosFiltrada(string atributo, string valor)
        {
            List<DTOUsuario> listafiltrada = qep.getAllUsuarios();
            switch (atributo.ToLower())
            {
                case "carnet":
                    return listafiltrada.Where(p => p.carnet.ToLower().Contains(valor.ToLower())).ToList();
                case "nombre":
                    return listafiltrada.Where(p => p.nombre.ToLower().Contains(valor.ToLower())).ToList();

                case "apellido":
                    return listafiltrada.Where(p => p.apellido.ToLower().Contains(valor.ToLower())).ToList();
                default:
                    return listafiltrada;
            }
        }
        public List<DTOUsuario> getUsuariosAsignados(List<string> carnets)
        {
            List<DTOUsuario> users = new List<DTOUsuario>();
            List<DTOUsuario> aux = getAllUsuarios();

            if (carnets != null)
            {
                foreach (var carnet in carnets)
                {
                    var usuario = aux.Find(u => u.carnet == carnet);
                    if (usuario != null)
                    {
                        users.Add(usuario);
                    }
                }
            }

            return users;

        }

        public List<DTOMicroempresario> getAllMicroempresarios()
        {
            QueryExecutorMicroempresario qem = new QueryExecutorMicroempresario();
            return qem.getAll();
        }
        public List<DTOMicroempresario> getListaMicroempresariosFiltrada(string atributo, string valor)
        {
            QueryExecutorMicroempresario qem = new QueryExecutorMicroempresario();
            List<DTOMicroempresario> listafiltrada = qem.getAll();

            switch (atributo.ToLower())
            {
                case "nombre":
                    return listafiltrada.Where(p => p.NombreMicroempresario.ToLower().Contains(valor.ToLower())).ToList();
                case "apellido":
                    return listafiltrada.Where(p => p.ApellidoMicroempresario.ToLower().Contains(valor.ToLower())).ToList();
                case "nombreemprendimiento":
                    return listafiltrada.Where(p => p.NombreEmprendimiento.ToLower().Contains(valor.ToLower())).ToList();
                case "distrito":
                    return listafiltrada.Where(p => p.Distrito.ToLower().Contains(valor.ToLower())).ToList();
                default:
                    return listafiltrada;
            }
        }
        public List<DTOMicroempresario> getMicroempresariosAsignados(List<string> nombresMicro)
        {
            List<DTOMicroempresario> microempresarios = new List<DTOMicroempresario>();
            List<DTOMicroempresario> aux = getAllMicroempresarios();

            if (nombresMicro != null)
            {
                foreach (var carnet in nombresMicro)
                {
                    var usuario = aux.Find(u => u.NombreMicroempresario == carnet);
                    if (usuario != null)
                    {
                        microempresarios.Add(usuario);
                    }
                }
            }

            return microempresarios;

        }
        public bool InsertarBDAreInteres(AreaInteres areaInteres)
        {
            return qep.addAreaInteres(areaInteres);
        }
        public string AddProyecto(DTOProyecto proyecto, List<string> usuariosAsignados, List<string> microempresariosAsignados)
        {
            if (proyecto != null ||
                usuariosAsignados != null ||
                microempresariosAsignados != null)
            {
                Direccion direccion = generarDireccion(proyecto, 0);
                DTOProyecto newPoryecto = generarDTOProyecto(proyecto);
                newPoryecto.fechaCreacion = DateTime.Now;

                QueryExecutorDireccion qed = new QueryExecutorDireccion();
                newPoryecto.IdDireccion = qed.addDireccion(direccion);
                
                if (newPoryecto.IdDireccion == 0)
                {
                    return "Error:\n\nNo se pudo realizar la inserción de la dirección";
                }
                if (!qep.addProyecto(newPoryecto))
                {
                    qed.EliminarDireccion(newPoryecto.IdDireccion);
                    return "Error:\n\nNo se pudo realizar la inserción del proyecto";
                }
                else
                {
                    if (addPryMicro(microempresariosAsignados, newPoryecto.idProyecto)) {
                        if(addpryEstud(usuariosAsignados, newPoryecto.idProyecto))
                        {
                            return "Se ha agregado el proyecto con éxito";
                        }
                    }
                    else
                    {
                        return "Error:\n\nNo se pudo realizar la inserción del proyecto";
                    }
                }
            }
            return "Error:\n\nError Fatal";
        }
        private bool addPryMicro(List<string> microempresariosAsignados, string idProyecto)
        {
            QueryExecutorMicroempresario qem = new QueryExecutorMicroempresario();
            List<DTOMicroempresario> aux = qem.getAll();

            foreach (var nombreMicroempresario in microempresariosAsignados)
            {
                DTOMicroempresario microempresarioEncontrado = aux.FirstOrDefault(m => m.NombreMicroempresario == nombreMicroempresario);

                if (microempresarioEncontrado != null)
                {
                    if(!qep.addProyectoMicroempresario(microempresarioEncontrado.IdMicroempresario, idProyecto))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        private bool delPryMicro(List<string> del, string idProyecto) {

            QueryExecutorMicroempresario qem = new QueryExecutorMicroempresario();
            List<DTOMicroempresario> aux = qem.getAll();

            foreach (var nombreMicroempresario in del)
            {
                DTOMicroempresario microempresarioEncontrado = aux.FirstOrDefault(m => m.NombreMicroempresario == nombreMicroempresario);

                if (microempresarioEncontrado != null)
                {
                    if (!qep.delProyectoMicroempresario(microempresarioEncontrado.IdMicroempresario, idProyecto))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool addpryEstud(List<string> usuariosAsignados, string idProyecto)
        {
            QueryExecutorUsuario queryExecutorUsuario = new QueryExecutorUsuario();
            List<DTOUsuario> aux = queryExecutorUsuario.getAll();

            foreach (var item in usuariosAsignados)
            {
                if (aux.Any(usuario => usuario.carnet == item))
                {
                    if(!qep.addProyectoUsuario(item, idProyecto))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool delPryEstud(List<string> del, string idProyecto)
        {
            QueryExecutorUsuario queryExecutorUsuario = new QueryExecutorUsuario();
            List<DTOUsuario> aux = queryExecutorUsuario.getAll();

            foreach (var item in del)
            {
                if (aux.Any(usuario => usuario.carnet == item))
                {
                    if (!qep.delProyectoUsuario(item, idProyecto))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private DTOProyecto generarDTOProyecto(DTOProyecto proyecto)
        {
            return new DTOProyecto(
            
              proyecto.idProyecto,
              proyecto.nombre,
              proyecto.descripcion,
              proyecto.fechaIncio,
              proyecto.fechaFin,
              getModalidad(proyecto.nombreModalidad),
              getAreaInteres(proyecto.nombreAreaInteres),
              getEstado(proyecto.nombreEstadoProyecto)
            );
        }

        public List<DTOProyecto> getAllProyctos()
        {
           return qep.getAllProyectos();
        }

        public List<DTOProyecto> getListaProyectosFiltrada(string atributo, string valor)
        {
            List<DTOProyecto> listafiltrada = qep.getAllProyectos();

            switch (atributo.ToLower())
            {
                case "idproyecto":
                    return listafiltrada.Where(p => p.idProyecto.ToLower().Contains(valor.ToLower())).ToList();
                case "nombre":
                    return listafiltrada.Where(p => p.nombre.ToLower().Contains(valor.ToLower())).ToList();
                case "distrito":
                    return listafiltrada.Where(p => p.distrito.ToLower().Contains(valor.ToLower())).ToList();
                default:
                    return listafiltrada;
            }
        }

        public DTOProyecto getOneProyecto(string idProyecto)
        {
            return qep.getOneProyectos(idProyecto);
        }

        public string UpdateEstado(DTOProyecto proyecto)
        {
            DTOProyecto newPoryecto = generarDTOProyecto(proyecto);
            newPoryecto.IdDireccion = proyecto.IdDireccion;
            if (qep.UpdateProyecto(newPoryecto))
            {
                if (newPoryecto.fechaFin != DateTime.MinValue)
                {
                    qep.UpdateFechasMicro(newPoryecto.fechaFin, newPoryecto.idProyecto);
                    return "Se actualizó el estado del proyecto con éxito a: ";
                    
                }

                return "Se actualizó el estado del proyecto con éxito a: ";
            }
            else
            {
                return "Error al actualizar el estado del proyecto con éxito a: ";
            }
            
        }

        public List<DTOMicroempresario> getMicroempresariosAsignados(string idProyecto)
        {
            return qep.getAllMicroProyecto(idProyecto);
        }
        public List<DTOUsuario> getEstudiantesAsignados(string idProyecto)
        {
            return qep.getAllUsuarioProyecto(idProyecto);
        }

        public string updateProyecto(DTOProyecto proyecto, List<string> usuariosAsignados, List<string> microempresariosAsignados, List<string> usuariosEliminados, List<string> microempresariosEliminados, DateTime fechaFin)
        {
            if (proyecto != null ||
              usuariosAsignados != null ||
              microempresariosAsignados != null ||
              usuariosEliminados !=null ||
              microempresariosEliminados !=null)
            {
               
                Direccion direccion = generarDireccion(proyecto, proyecto.IdDireccion);
                DTOProyecto newPoryecto = generarDTOProyecto(proyecto);
                newPoryecto.IdDireccion = proyecto.IdDireccion;
                QueryExecutorDireccion qed = new QueryExecutorDireccion();
                qed.modificarDireccion(direccion);

                if (newPoryecto.IdDireccion == 0)
                {
                    return "Error:\n\nNo se pudo realizar la modificación de la dirección";
                }
                if (!qep.UpdateProyecto(newPoryecto))
                {
                    return "Error:\n\nNo se pudo realizar la modificación del proyecto";
                }
                else
                {
                    if (updatePryMicro(microempresariosAsignados,microempresariosEliminados, newPoryecto.idProyecto))
                    {
                        if (updatePryEstud(usuariosAsignados,usuariosEliminados, newPoryecto.idProyecto))
                        {
                            if (fechaFin != newPoryecto.fechaFin)
                            { 
                                if (newPoryecto.fechaFin != DateTime.MinValue)
                                {
                                    qep.UpdateFechasMicro(newPoryecto.fechaFin, newPoryecto.idProyecto);
                                    return "Se ha actualizado el proyecto con éxito";

                                }
                            }
                            return "Se ha actualizado el proyecto con éxito";
                        }
                    }
                    else
                    {
                        return "Error:\n\nNo se pudo realizar la actualización del proyecto";
                    }
                }
            }
            return "Error:\n\nError Fatal";
        }

        private bool updatePryEstud(List<string> usuariosAsignados, List<string> usuariosEliminados, string idProyecto)
        {
            List<string> add = new List<string>();
            List<string> del = new List<string>();
            foreach (var item in usuariosEliminados)
            {
                if (verificarExistenciaProyectoUsuario(idProyecto, item))
                {
                    del.Add(item);
                }

            }
            foreach (var item in usuariosAsignados)
            {
                if (!verificarExistenciaProyectoUsuario(idProyecto, item))
                {
                    add.Add(item);
                }
            }
            if (delPryEstud(del, idProyecto) && addpryEstud(add, idProyecto))
            {
                return true;
            }
            return false;
        }


        private bool updatePryMicro(List<string> microempresariosAsignados, List<string> microempresariosEliminados, string idProyecto)
        {
            List<string> add = new List<string>();
            List<string> del = new List<string>();
            
            foreach (var item in microempresariosEliminados)
            {
                if (verificarExistenciaProyectoMicro(idProyecto, item)){
                    del.Add(item);
                }
               
            }

            foreach (var item in microempresariosAsignados)
            {
                if (!verificarExistenciaProyectoMicro(idProyecto, item))
                {
                    add.Add(item);
                }
            }

            if(delPryMicro(del, idProyecto) && addPryMicro(add, idProyecto))
            {
                return true;
            }
            return false;

        }

        private bool verificarExistenciaProyectoMicro(string idProyecto, string nombre)
        {
            foreach (var item in getMicroempresariosAsignados(idProyecto))
            {
                if (item.NombreMicroempresario.Equals(nombre))
                {
                    return true;
                }
            }
            return false;
        }
        private bool verificarExistenciaProyectoUsuario(string idProyecto, string carnet)
        {
            foreach (var item in getEstudiantesAsignados(idProyecto))
            {
                if (item.carnet.Equals(carnet))
                {
                    return true;
                }
            }
            return false;
        }

        public bool elimiarProyecto(string idProyecto)
        {
           if(!string.IsNullOrEmpty(idProyecto))
            {
                if (qep.delProyectoUsuario(idProyecto) && qep.delProyectoMicroempresario(idProyecto))
                {
                    if (qep.delProyecto(idProyecto))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public object getListaAreaInteresObj()
        {
            QueryExecutorAreasInteres qea = new QueryExecutorAreasInteres();
            return qea.getAll();
        }

        public bool modificarAreaInteres(AreaInteres areaInteres)
        {
            QueryExecutorAreasInteres qea = new QueryExecutorAreasInteres();
            return qea.updateAreaInteres(areaInteres);
        }
    }
}
