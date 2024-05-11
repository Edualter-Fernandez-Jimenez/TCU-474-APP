using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class EstadoUsuario
    {
        public int IdEstadoUsuario { get; set; }
        public string NombreEstadoUsuario { get; set; }

        public EstadoUsuario() { }
        public EstadoUsuario(int idEstadoUsuario, string nombreEstadoUsuario)
        {
            IdEstadoUsuario = idEstadoUsuario;
            NombreEstadoUsuario = nombreEstadoUsuario;
        }   
    }
}
