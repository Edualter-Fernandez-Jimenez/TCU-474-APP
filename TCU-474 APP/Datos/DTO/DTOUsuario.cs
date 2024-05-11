using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTO
{
    public class DTOUsuario
    {
        public string carnet { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set;}
        public string apellido { get; set; }
        public string numeroTelefono { get; set; }
        public string correoElectronico { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get;set; }


        public string  idCarrera { get; set; }
        public string nombreCarrera { get; set; }
        public int idSede { get; set; }
        public string nombreSede { get; set; }
        public int idEstadoUsuario { get; set; }
        public string nombreEstadoUsuario { get; set; }

        public DTOUsuario() { }

        public DTOUsuario(string carnet, string cedula, string nombre, string apellido, string numeroTelefono, string correoElectronico, string idCarrera, int idSede, int idEstadoUsuario) { 
            this.carnet = carnet;
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.numeroTelefono= numeroTelefono;
            this.correoElectronico = correoElectronico;
            this.idCarrera = idCarrera;
            this.idSede = idSede;
            this.idEstadoUsuario = idEstadoUsuario;
        }
        public DTOUsuario(string carnet, string cedula, string nombre, string apellido, string numeroTelefono, string correoElectronico, string nombreCarrera, string nombreSede, string nombreEstadoUsuario)
        {
            this.carnet = carnet;
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.numeroTelefono = numeroTelefono;
            this.correoElectronico = correoElectronico;
            this.nombreCarrera = nombreCarrera;
            this.nombreSede = nombreSede;
            this.nombreEstadoUsuario = nombreEstadoUsuario;
        }

    }
}
