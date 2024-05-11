using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTO
{
    public class DTOMicroempresario
    {
        public int IdMicroempresario { get; set; }
        public string NombreMicroempresario { get; set; }
        public string ApellidoMicroempresario { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime UltimaFechaAtencion { get; set; }
        public string NombreEmprendimiento { get; set; }
        public int CantidadColaboradores { get; set; }
        public string DescripcionEmprendimiento { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string OtrasSenas { get; set; }

        // Constructor
        public DTOMicroempresario() { }
        public DTOMicroempresario(
            string nombreMicroempresario,
            string apellidoMicroempresario,
            string cedula,
            string telefono,
            string correoElectronico,
            DateTime ultimaFechaAtencion,
            string nombreEmprendimiento,
            int cantidadColaboradores,
            string descripcionEmprendimiento,
            string provincia,
            string canton,
            string distrito,
            string otrasSenas)
        {
            NombreMicroempresario = nombreMicroempresario;
            ApellidoMicroempresario = apellidoMicroempresario;
            Cedula = cedula;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
            UltimaFechaAtencion = ultimaFechaAtencion;
            NombreEmprendimiento = nombreEmprendimiento;
            CantidadColaboradores = cantidadColaboradores;
            DescripcionEmprendimiento = descripcionEmprendimiento;
            Provincia = provincia;
            Canton = canton;
            Distrito = distrito;
            OtrasSenas = otrasSenas;
        }
        public DTOMicroempresario(
            int idMicroempresario,
            string nombreMicroempresario,
            string apellidoMicroempresario,
            string cedula,
            string telefono,
            string correoElectronico,
            string nombreEmprendimiento,
            int cantidadColaboradores,
            string descripcionEmprendimiento,
            string provincia,
            string canton,
            string distrito,
            string otrasSenas)
        {
            IdMicroempresario = idMicroempresario;
            NombreMicroempresario = nombreMicroempresario;
            ApellidoMicroempresario = apellidoMicroempresario;
            Cedula = cedula;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
            NombreEmprendimiento = nombreEmprendimiento;
            CantidadColaboradores = cantidadColaboradores;
            DescripcionEmprendimiento = descripcionEmprendimiento;
            Provincia = provincia;
            Canton = canton;
            Distrito = distrito;
            OtrasSenas = otrasSenas;
        }
    }
}
