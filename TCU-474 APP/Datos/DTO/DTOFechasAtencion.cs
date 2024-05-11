using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTO
{
    public class DTOFechasAtencion
    {
        public string anio { get; set; }
        public int cantidad { get; set;}

        public DTOFechasAtencion(string anio, int cantidad)
        {
            this.anio = anio;
            this.cantidad = cantidad;
        }
    }
}
