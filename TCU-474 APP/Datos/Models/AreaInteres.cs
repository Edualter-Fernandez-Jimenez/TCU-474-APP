using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class AreaInteres
    {
     
        public int IdAreaInteres { get; set; }
        public string Nombre { get; set; }

        public AreaInteres() { }

        public AreaInteres(int IdAreaInteres, string Nombre) { 
            this.IdAreaInteres = IdAreaInteres;
            this.Nombre = Nombre;
        }
    }
}
