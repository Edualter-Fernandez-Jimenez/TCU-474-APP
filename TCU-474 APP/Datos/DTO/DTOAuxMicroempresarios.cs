using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTO
{
    public class DTOAuxMicroempresarios
    {
        public string cedula { get; set; }
        public string provincia { get; set; }
        public string canton { get; set; }
        public string distrito { get; set; }    
        public DateTime fechaAtencion { get; set; }
        public DTOAuxMicroempresarios() { }
        public DTOAuxMicroempresarios(string cedula, string provincia, string canton, string distrito, DateTime fechaAtencion)
        {
            this.cedula = cedula;
            this.provincia = provincia;
            this.canton = canton;
            this.distrito = distrito;
            this.fechaAtencion = fechaAtencion;
        }
    }
}
