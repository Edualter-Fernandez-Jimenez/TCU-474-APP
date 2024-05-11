using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Emprendimiento
    {
     
        public int IdEmprendimiento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CantidadColaboradores { get; set;}
        public int IdDireccion { get; set; }

        public Emprendimiento(int IdEmprendimiento, string Nombre,string Descripcion, int CantidadColaboradores)
        {
            this.IdEmprendimiento = IdEmprendimiento;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.CantidadColaboradores= CantidadColaboradores;
        }
        public Emprendimiento() { }
    }

}
