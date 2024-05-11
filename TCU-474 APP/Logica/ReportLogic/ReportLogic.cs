using BD.DireccionQuery;
using BD.ProyectosQuery;
using BD.ReportesQuery;
using Datos.DTO;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Logica.ReportLogic
{
    public class ReportLogic
    {
        public ReportLogic() { }
        #region Reporte Microempresarios por zona atendida
        public List<DTOMicroAtendZona> GetAtendZona(DateTime fechaDe, DateTime fechaHasta, string canton)
        {
            List<DTOAuxMicroempresarios> listaFiltrada = generarFiltrarMicroAtendZona(fechaDe,fechaHasta, canton);
            return generarFiltrarMicroAtendZona(listaFiltrada, false);
        }
        public List<DTOMicroAtendZona> GetAtendZonaDist(DateTime fechaDe, DateTime fechaHasta, string canton)
        {
            List<DTOAuxMicroempresarios> listaFiltrada = generarFiltrarMicroAtendZona(fechaDe, fechaHasta, canton);
            return generarFiltrarMicroAtendZona(listaFiltrada, true);
        }

        private List<DTOAuxMicroempresarios> generarFiltrarMicroAtendZona(DateTime fechaDe, DateTime fechaHasta, string canton)
        {
            List<DTOAuxMicroempresarios> totalMicrosAtendidos = getAllMicro();
            bool filtroF = false;
            bool filtroC = false;

            if (fechaDe.Date != fechaHasta.Date)
            {
                filtroF = true;
            }
            if (!canton.Equals("N/A"))
            {
                filtroC = true;
            }

            if (filtroF && filtroC)
            {
                List<DTOAuxMicroempresarios> aux = new List<DTOAuxMicroempresarios>();
                foreach (var item in totalMicrosAtendidos)
                {
                    if ((item.fechaAtencion >= fechaDe) &&
                        (item.fechaAtencion <= fechaHasta))
                    {

                        if (item.canton.Equals(canton))
                        {
                            aux.Add(item);
                        }
                    }
                }
                return aux;

            }
            else if (filtroF)
            {   
                List< DTOAuxMicroempresarios> aux = new List<DTOAuxMicroempresarios>();
                foreach (var item in totalMicrosAtendidos)
                {
                    if ((item.fechaAtencion >= fechaDe) &&
                        (item.fechaAtencion <= fechaHasta))
                    {
                        aux.Add(item);
                    }
                }
                return aux;
            }
            else if (filtroC)
            {
                List<DTOAuxMicroempresarios> aux = new List<DTOAuxMicroempresarios>();
                foreach (var item in totalMicrosAtendidos)
                {
                    if (item.canton.Equals(canton))
                    {
                        aux.Add(item);
                    }
                }
                return aux;

            }
            else
            {
                return totalMicrosAtendidos;

            }
        }

        private List<DTOMicroAtendZona> generarFiltrarMicroAtendZona(List<DTOAuxMicroempresarios> aux, bool distrito)
        {
            // Diccionario para mantener el recuento de cada ubicación
            Dictionary<string, int> countByUbicacion = new Dictionary<string, int>();
            string ubicacion = "";
            // Recorremos la lista aux y actualizamos el diccionario
            if (aux != null)
            {
                foreach (var item in aux)
                {
                    // Construimos la ubicación como se solicita
                    if (!distrito)
                    {
                        ubicacion = item.canton;
                    }
                    else
                    {
                        ubicacion = item.distrito;
                    }

                    // Si la ubicación ya está en el diccionario, aumentamos el recuento
                    if (countByUbicacion.ContainsKey(ubicacion))
                    {
                        countByUbicacion[ubicacion]++;
                    }
                    // Si no, agregamos la ubicación al diccionario con un recuento inicial de 1
                    else
                    {
                        countByUbicacion[ubicacion] = 1;
                    }
                }
            }

            // Creamos la lista de DTOs a devolver
            List<DTOMicroAtendZona> microAtendZonas = new List<DTOMicroAtendZona>();

            // Iteramos sobre el diccionario y creamos los DTOs correspondientes
            foreach (var kvp in countByUbicacion)
            {
                // Creamos un nuevo DTO con la ubicación y el recuento
                DTOMicroAtendZona dto = new DTOMicroAtendZona(kvp.Key, kvp.Value);
                // Agregamos el DTO a la lista
                microAtendZonas.Add(dto);
            }

            return microAtendZonas;
        }
        #endregion

        public List<string> getCantones()
        {
            QueryExecutorCanton qec = new QueryExecutorCanton();
            List<string> cantones = new List<string>();
            foreach (var item in qec.getAll())
            {
                cantones.Add(item.Nombre);
            }
            // Ordenar alfabéticamente
            cantones = cantones.OrderBy(c => c).ToList();
            return cantones;
        }
        #region ProyectosRealizados
        public List<DTOProyAreaRepo> GetProyectosRealizados(DateTime fechaDe, DateTime fechaHasta, string canton, string estado)
        {
            QueryExecutorProyecto qep = new QueryExecutorProyecto();

            List<DTOProyecto> proyectos = qep.getAllProyectos();
            List<DTOProyAreaRepo> listaProyectos;

            bool filtroF = false;
            bool filtroC = false;
            bool filtroE = false;

            if (fechaDe.Date != fechaHasta.Date)
            {
                filtroF = true; 
            }
            if (!canton.Equals("N/A"))
            {
                filtroC = true;
            }
            if (!estado.Equals("Todo"))
            {
                filtroE = true;
            }
            listaProyectos = aplicacionFiltros(proyectos,filtroF,filtroC,filtroE,fechaDe,fechaHasta,canton,estado);

            return listaProyectos;
        }

        private List<DTOProyAreaRepo> aplicacionFiltros(List<DTOProyecto> proyectosaux,bool filtroF, bool filtroC, bool filtroE, DateTime fechaDe, DateTime fechaHasta, string canton, string Estado)
        {
            List<DTOProyecto> aux = new List<DTOProyecto>();

            // Caso 1: Ningún filtro activo
            if (!filtroF && !filtroC && !filtroE)
            {
                QueryExecutorReportes qer = new QueryExecutorReportes();
                return qer.GetProyAreaRepos();
            }
            // Caso 2: Solo el filtro de fecha activo
            else if (filtroF && !filtroC && !filtroE)
            {
                aux = filtrarFecha(proyectosaux,fechaDe, fechaHasta);
                return countProyectos(aux);
            }
            // Caso 3: Solo el filtro de cantón activo
            else if (!filtroF && filtroC && !filtroE)
            {
                aux = filtrarCanton(proyectosaux, canton);
                return countProyectos(aux);
            }
            // Caso 4: Solo el filtro de estado activo
            else if (!filtroF && !filtroC && filtroE)
            {
                aux = filtrarEstado(proyectosaux, Estado);
                return countProyectos(aux);
            }
            // Caso 5: Filtro de fecha y cantón activos
            else if (filtroF && filtroC && !filtroE)
            {
                aux = filtrarFecha(filtrarCanton(proyectosaux, canton), fechaDe, fechaHasta);
                return countProyectos(aux);
            }
            // Caso 6: Filtro de fecha y estado activos
            else if (filtroF && !filtroC && filtroE)
            {
                aux = filtrarFecha(filtrarEstado(proyectosaux, Estado), fechaDe, fechaHasta);
                return countProyectos(aux);
            }
            // Caso 7: Filtro de cantón y estado activos
            else if (!filtroF && filtroC && filtroE)
            {
                aux = filtrarEstado(filtrarCanton(proyectosaux, canton), Estado);
                return countProyectos(aux);
            }
            // Caso 8: Filtro de fecha, cantón y estado activos
            else if (filtroF && filtroC && filtroE)
            {
                aux = filtrarFecha(filtrarEstado(filtrarCanton(proyectosaux, canton), Estado), fechaDe, fechaHasta);
                return countProyectos(aux);
            }
            return new List<DTOProyAreaRepo>();

        }

        private List<DTOProyAreaRepo> countProyectos(List<DTOProyecto> aux)
        {
            List<DTOProyAreaRepo> count = new List<DTOProyAreaRepo>();
            foreach (var item in aux)
            {
                // Verificar si el nombre de área de interés está presente en count
                var proyectoExistente = count.FirstOrDefault(p => p.nombreAreaInteres == item.nombreAreaInteres);

                if (proyectoExistente != null)
                {
                    // Si el nombre de área de interés está presente, incrementar la cantidad
                    proyectoExistente.cantidad++;
                }
                else
                {
                    // Si el nombre de área de interés no está presente, crear un nuevo objeto y agregarlo a count
                    count.Add(new DTOProyAreaRepo(item.nombreAreaInteres, 1));
                }
            }
            return count;
        }

        private List<DTOProyecto> filtrarFecha(List<DTOProyecto> proyectosaux, DateTime fechaDe, DateTime fechaHasta)
        {
            List<DTOProyecto> aux = new List<DTOProyecto>();
            foreach (var item in proyectosaux)
            {
                if ((item.fechaCreacion >= fechaDe) &&
                    (item.fechaCreacion <= fechaHasta))
                {
                    aux.Add(item);
                }
            }
            return aux;
        }
    
        private List<DTOProyecto> filtrarCanton(List<DTOProyecto> proyectosaux, string canton)
        {
            List<DTOProyecto> aux = new List<DTOProyecto>();
            foreach (var item in proyectosaux)
            {
                if(item.canton.Equals(canton)) { 
                    aux.Add(item); 
                }
            }
                return aux;
        }
        private List<DTOProyecto> filtrarEstado(List<DTOProyecto> proyectosaux, string Estado)
        {
            List<DTOProyecto> aux = new List<DTOProyecto>();
            foreach (var item in proyectosaux)
            {
                if (item.nombreEstadoProyecto.Equals(Estado))
                {
                    aux.Add(item);
                }
            }
            return aux;
        }
        #endregion
        #region Microempresarios atendidos por año
        public List<DTOFechasAtencion> GetFechasAtencion()
        {
           QueryExecutorReportes qema = new QueryExecutorReportes();
           DTOAuxFehcas fechasIniciales = qema.getFechaPrimerPCreado();
           List<DTOFechasAtencion> listaAtencion = new List<DTOFechasAtencion>();
            if (fechasIniciales.totalFechas != 0)
            {
                if (fechasIniciales.fechaMenor != DateTime.MinValue && fechasIniciales.fechaMayor != DateTime.MinValue)
                {
                    DateTime fechaInicio = new DateTime(fechasIniciales.fechaMenor.Year, fechasIniciales.fechaMayor.Month, fechasIniciales.fechaMayor.Day);
                    DateTime fechaFin = new DateTime(fechasIniciales.fechaMayor.Year + 1, fechasIniciales.fechaMayor.Month, fechasIniciales.fechaMayor.Day);
                    bool primero = true;

                    DateTime fechaInicial = new DateTime();
                    DateTime fechaFinal = new DateTime();
                    int cant = 0;
                    for (;  fechaInicio.Year != fechaFin.Year;)
                    {

                        if (primero)
                        {
                            //consultar todos los proyectos de la fehca inicial a la fecha inicial -1
                             fechaInicial = new DateTime(fechaInicio.Year-1,10,31);
                             fechaFinal = new DateTime(fechaInicio.Year, 10, 31);

                            //consulta:
                            cant = qema.GetCantidadMiccroAttendAlAnio(fechaInicial,fechaFinal);
                            if (cant!= 0)
                            {
                                DTOFechasAtencion fechaAux = new DTOFechasAtencion(fechaInicial.Year+" - "+fechaFinal.Year,cant);
                                listaAtencion.Add(fechaAux);
                            }
                            primero = false;
                        }
                        
                        fechaInicial = new DateTime(fechaInicio.Year, 10, 31);
                        fechaFinal = new DateTime(fechaInicio.Year + 1, 10, 31);
                        //consulta:
                        cant = qema.GetCantidadMiccroAttendAlAnio(fechaInicial, fechaFinal);
                        if (cant != 0)
                        {
                            DTOFechasAtencion fechaAux = new DTOFechasAtencion(fechaInicial.Year + " - " + fechaFinal.Year, cant);
                            listaAtencion.Add(fechaAux);
                        }

                        fechaInicio = new DateTime(fechaInicio.Year + 1, fechasIniciales.fechaMayor.Month, fechasIniciales.fechaMayor.Day);
                    }
                }
            }
            List<DTOFechasAtencion> listaFinal = listaAtencion.Skip(Math.Max(0, listaAtencion.Count - 5)).ToList();

            return listaFinal;
        }

        private List<DTOAuxMicroempresarios> getAllMicro()
        {
            QueryExecutorReportes qema = new QueryExecutorReportes();
            DTOAuxFehcas fechasIniciales = qema.getFechaPrimerPCreado();
            List<DTOAuxMicroempresarios> micros = new List<DTOAuxMicroempresarios>();
            if (fechasIniciales.totalFechas != 0)
            {
                if (fechasIniciales.fechaMenor != DateTime.MinValue && fechasIniciales.fechaMayor != DateTime.MinValue)
                {
                    DateTime fechaInicio = new DateTime(fechasIniciales.fechaMenor.Year, fechasIniciales.fechaMayor.Month, fechasIniciales.fechaMayor.Day);
                    DateTime fechaFin = new DateTime(fechasIniciales.fechaMayor.Year + 1, fechasIniciales.fechaMayor.Month, fechasIniciales.fechaMayor.Day);
                    bool primero = true;

                    DateTime fechaInicial = new DateTime();
                    DateTime fechaFinal = new DateTime();
                    List<DTOAuxMicroempresarios> aux = null;
                    for (; fechaInicio.Year != fechaFin.Year;)
                    {

                        if (primero)
                        {
                            //consultar todos los proyectos de la fehca inicial a la fecha inicial -1
                            fechaInicial = new DateTime(fechaInicio.Year - 1, 10, 31);
                            fechaFinal = new DateTime(fechaInicio.Year, 10, 31);

                            //consulta:
                            aux = qema.getAllMicroAtendZona(fechaInicial, fechaFinal);
                            if (aux!=null)
                            {
                                foreach(var item in aux)
                                {
                                    if (item!=null)
                                    {
                                        micros.Add(item);
                                    }
                                }
                            }
                            primero = false;
                        }

                        fechaInicial = new DateTime(fechaInicio.Year, 10, 31);
                        fechaFinal = new DateTime(fechaInicio.Year + 1, 10, 31);
                        //consulta:
                        aux = qema.getAllMicroAtendZona(fechaInicial, fechaFinal);
                        if (aux != null)
                        {
                            foreach (var item in aux)
                            {
                                if (item != null)
                                {
                                    micros.Add(item);
                                }
                            }
                        }

                        fechaInicio = new DateTime(fechaInicio.Year + 1, fechasIniciales.fechaMayor.Month, fechasIniciales.fechaMayor.Day);
                    }
                }
            }
            if(micros.Count != 0)
            {
                return micros;
            }
            else {  
                return null; 
            }
        }
        #endregion
    }
}
