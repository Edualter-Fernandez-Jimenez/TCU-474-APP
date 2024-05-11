using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Carrera
    {
        public string IdCarrera { get; set; }
        public string NombreCarrera { get; set;}
        public Carrera() { }
        public Carrera(string idCarrera, string nomnreCarrera)
        {
            IdCarrera = idCarrera;
            NombreCarrera = nomnreCarrera;
        }

    }
}
