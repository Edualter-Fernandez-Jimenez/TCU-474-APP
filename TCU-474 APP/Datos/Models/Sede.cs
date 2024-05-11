using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Sede
    {
        public int IdSede { get; set; }
        public string NombreSede { get; set; }


        public Sede() { }
        public Sede(int idSede, string nombreSede)
        {
            IdSede = idSede;
            NombreSede = nombreSede;
        }   
    }
}
