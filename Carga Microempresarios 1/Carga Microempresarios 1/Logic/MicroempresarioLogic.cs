using Carga_Microempresarios_1.BD;
using Carga_Microempresarios_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carga_Microempresarios_1.Logic
{
    public class MicroempresarioLogic
    {
        private readonly QueryExecutorProvincia qep = new QueryExecutorProvincia();
        private readonly QueryExecutorCanton qec = new QueryExecutorCanton();
        private readonly QueryExecutorDistrito qed = new QueryExecutorDistrito();

        private List<Provincia> listaProvincias = null;
        private List<Canton> listaCantones = null;
        private List<Distrito> listaDistritos = null;

        public MicroempresarioLogic()
        {

            listaProvincias = qep.getAll();
            listaCantones = qec.getAll();
            listaDistritos = qed.getAll();
        }

        #region CargaFrontEnd


        public List<string> getListaProvincias()
        {
            List<string> provincias = new List<string>();
            foreach (var item in listaProvincias)
            {
                provincias.Add(item.Nombre);
            }
            return provincias;
        }
        public List<string> getListaCantones(String provincia)
        {
            List<string> cantones = new List<string>();
            string idProvincia = "";
            foreach (var item1 in listaProvincias)
            {
                if (item1.Nombre.Equals(provincia))
                {
                    idProvincia = item1.Id.ToString();
                }
            }

            foreach (var item2 in listaCantones)
            {
                string aux = item2.Id.ToString();
                if (aux.StartsWith(idProvincia))
                {
                    cantones.Add(item2.Nombre);
                }

            }

            return cantones;
        }

        public List<string> getListaDistritos(string canton)
        {
            List<string> distritos = new List<string>();
            string idCanton = "";
            foreach (var item1 in listaCantones)
            {
                if (item1.Nombre.Equals(canton))
                {
                    idCanton = item1.Id.ToString();
                }
            }

            foreach (var item2 in listaDistritos)
            {
                string aux = item2.Id.ToString();
                if (aux.StartsWith(idCanton))
                {
                    distritos.Add(item2.Nombre);
                }

            }

            return distritos;
        }
        #endregion
        #region handler
        private Emprendimiento generarEmprendimiento(DTOMicroempresario microempresario, int IdEmprendimiento)
        {

            Emprendimiento emprendimiento = new Emprendimiento(
               IdEmprendimiento,
                microempresario.NombreEmprendimiento,
               microempresario.DescripcionEmprendimiento,
               microempresario.CantidadColaboradores
                );
            return emprendimiento;
        }

        private Direccion generarDireccion(DTOMicroempresario microempresario, int idDireccion)
        {
            int IdProvincia = 0;
            int IdCanton = 0;
            int IdDistrito = 0;
            //provincia
            foreach (var item1 in listaProvincias)
            {
                if (item1.Nombre.Equals(microempresario.Provincia))
                {
                    IdProvincia = item1.Id;
                }
            }
            //canton


            foreach (var item2 in listaCantones)
            {
                string aux = item2.Id.ToString();
                if (aux.StartsWith(IdProvincia.ToString()))
                {
                    if (microempresario.Canton.Equals(item2.Nombre))
                    {
                        IdCanton = item2.Id;
                    }

                }

            }
            //distrito
            foreach (var item2 in listaDistritos)
            {
                string aux = item2.Id.ToString();
                if (aux.StartsWith(IdCanton.ToString()))
                {
                    if (microempresario.Distrito.Equals(item2.Nombre))
                    {
                        IdDistrito = item2.Id;
                    }

                }

            }


            Direccion direccion = new Direccion(
                idDireccion,
                microempresario.OtrasSenas,
                IdProvincia,
                 IdCanton,
                IdDistrito
                );
            return direccion;
        }

        private Microempresario generarMicroempresario(DTOMicroempresario dtomicroempresario)
        {
            Microempresario microempresario = new Microempresario(
                0,
                dtomicroempresario.NombreMicroempresario,
                dtomicroempresario.ApellidoMicroempresario,
                dtomicroempresario.Cedula,
                dtomicroempresario.Telefono,
                dtomicroempresario.CorreoElectronico,
                dtomicroempresario.UltimaFechaAtencion
                );

            return microempresario;
        }
        #endregion

        public bool InsertarBDMicroempresario(DTOMicroempresario dtoMicroempresario)
        {

            if (dtoMicroempresario != null)
            {
                Direccion direccion = generarDireccion(dtoMicroempresario, 0);
                Emprendimiento emprendimiento = generarEmprendimiento(dtoMicroempresario, 0);
                Microempresario microempresario = generarMicroempresario(dtoMicroempresario);

                QueryExecutorDireccion qed = new QueryExecutorDireccion();
                QueryExecutorMicroempresario qem = new QueryExecutorMicroempresario();

                emprendimiento.IdDireccion = qed.addDireccion(direccion);

                if (emprendimiento.IdDireccion == 0)
                {
                    return false;
                }
                if (!qem.addMicroempresarioEmprendimiento(microempresario, emprendimiento))
                {
                    qed.EliminarDireccion(emprendimiento.IdDireccion);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public List<DTOMicroempresario> getListaMicroempresariosFiltrada(string atributo, string valor)
        {
            QueryExecutorMicroempresario qem = new QueryExecutorMicroempresario();
            List<DTOMicroempresario> listafiltrada = qem.getAll();

            switch (atributo.ToLower())
            {
                case "nombre":
                    return listafiltrada.Where(p => p.NombreMicroempresario.ToLower().Contains(valor.ToLower())).ToList();
                case "apellido":
                    return listafiltrada.Where(p => p.ApellidoMicroempresario.ToLower().Contains(valor.ToLower())).ToList();
                case "nombreemprendimiento":
                    return listafiltrada.Where(p => p.NombreEmprendimiento.ToLower().Contains(valor.ToLower())).ToList();
                case "distrito":
                    return listafiltrada.Where(p => p.Distrito.ToLower().Contains(valor.ToLower())).ToList();
                default:
                    return listafiltrada;
            }
        }

        public List<DTOMicroempresario> getAllMicroempresarios()
        {
            QueryExecutorMicroempresario qem = new QueryExecutorMicroempresario();
            return qem.getAll();
        }

        public DTOMicroempresario getOneMicroempresario(int idMicroempresario)
        {
            QueryExecutorMicroempresario qem = new QueryExecutorMicroempresario();
            return qem.getOne(idMicroempresario);
        }

        public string ModificarBDMicroempresario(DTOMicroempresario dtoMicroempresario)
        {
            if (dtoMicroempresario != null)
            {
                QueryExecutorDireccion qed = new QueryExecutorDireccion();
                QueryExecutorMicroempresario qem = new QueryExecutorMicroempresario();

                Direccion direccion = generarDireccion(dtoMicroempresario, qed.getidByMicroempresario(dtoMicroempresario.IdMicroempresario));

                Emprendimiento emprendimiento = generarEmprendimiento(dtoMicroempresario, qem.getIdEmprendimineto(dtoMicroempresario.IdMicroempresario));

                emprendimiento.IdDireccion = direccion.Id;

                Microempresario microempresario = generarMicroempresario(dtoMicroempresario);
                microempresario.IdMicroempresario = dtoMicroempresario.IdMicroempresario;

                qed.modificarDireccion(direccion);

                if (!qem.modificarMicroempresarioEmprendimiento(microempresario, emprendimiento))
                {
                    return "Error:\n\nNo se pudo realizar la inserción del microempresario y su emprendimiento";
                }
                else
                {
                    return "Se ha agregado al microempresario y su emprendimiento con éxito";
                }
            }
            return "Error:\n\nError Fatal";
        }
    
    }
}
