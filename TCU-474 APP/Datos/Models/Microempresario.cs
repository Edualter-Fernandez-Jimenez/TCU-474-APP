using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Microempresario
    {
        public int IdMicroempresario { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set;}
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime UltimaFechaAtencion { get; set; }
        public int IdEmprendimiento { get; set; }

        public Microempresario(int IdMicroempresario, string Nombre, string Apellidos, string Cedula, string Telefono, string CorreoElectronico, DateTime UltimaFechaAtencion) {
            this.IdMicroempresario = IdMicroempresario;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Cedula = Cedula;
            this.Telefono = Telefono;
            this.CorreoElectronico = CorreoElectronico;
            this.UltimaFechaAtencion = UltimaFechaAtencion;
        }
        public Microempresario() { }
    }
}
