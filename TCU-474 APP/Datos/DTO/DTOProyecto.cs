using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTO
{
    public class DTOProyecto
    {
        public string idProyecto { get; set; } 
        public string nombre { get; set;}
        public string descripcion { get; set;}
        public DateTime fechaIncio { get; set;}
        public DateTime fechaFin { get; set;}
        public DateTime fechaCreacion { get; set; }
       
        public int idModalidad { get; set;}
        public string nombreModalidad { get; set;}
        public int idAreaInteres { get; set;}
        public string nombreAreaInteres { get;set;}
        public int idEstadoProyecto { get; set; }
        public string nombreEstadoProyecto { get; set; }
        public int IdDireccion { get; set;}
        public string provincia { get; set;}
        public string canton { get; set;}
        public string distrito { get; set;}
        public string otrasSenas { get; set;}
        public DTOProyecto(string idProyecto, string nombre, string descripcion, string nombreModalidad, string nombreAreaInteres, string nombreEstadoProyecto, string provincia, string canton, string distrito, string otrasSenas)
        {
            this.idProyecto = idProyecto;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.nombreModalidad = nombreModalidad;
            this.nombreAreaInteres = nombreAreaInteres;
            this.nombreEstadoProyecto = nombreEstadoProyecto;
            this.provincia = provincia;
            this.canton = canton;
            this.distrito = distrito;
            this.otrasSenas = otrasSenas;
        }
        public DTOProyecto(string idProyecto, string nombre, string descripcion, DateTime fechaIncio, DateTime fechaFin, int idModalidad, int idAreaInteres, int idEstadoProyecto)
        {
            this.idProyecto = idProyecto;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.fechaIncio = fechaIncio;
            this.fechaFin = fechaFin;
            this.idModalidad = idModalidad;
            this.idAreaInteres = idAreaInteres;
            this.idEstadoProyecto = idEstadoProyecto;
        }
    }
}
