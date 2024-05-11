using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTO
{
    public class DTOProyAreaRepo
    {
        public string nombreAreaInteres { get; set; } 
        public int cantidad { get; set; }

        public DTOProyAreaRepo() { }

        public DTOProyAreaRepo(string nombreAreaInteres, int cantidad)
        {
            this.nombreAreaInteres = nombreAreaInteres;
            this.cantidad = cantidad;
        }
    }
}
