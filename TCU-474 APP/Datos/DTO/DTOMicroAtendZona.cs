using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class DTOMicroAtendZona
    {
        public string Ubicacion { get; set; }
        public int Cantidad { get; set; }

        public DTOMicroAtendZona() { }
        public DTOMicroAtendZona(string ubicacion, int cantidad)
        {
            this.Ubicacion = ubicacion;
            this.Cantidad = cantidad;
        }
    }
}
