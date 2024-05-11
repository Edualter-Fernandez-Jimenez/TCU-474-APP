using BD.UsuarioQuery;
using Datos.DTO;
using Datos.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstudianteLogic
{
    public class UsuarioLogic
    {
        private readonly QueryExecutorUsuario qeu = new QueryExecutorUsuario();

        public UsuarioLogic() { 
        
        }

        public List<string> listaSedesString()
        {
            List<Sede> listaSedes = qeu.getAllSedes();
            
            List<string> sedes = new List<string>();
            foreach (var item in listaSedes)
            {
                sedes.Add(item.NombreSede);
            }
            return sedes;
        }

        public List<string> listaCarrerasString()
        {
            List<Carrera> listaCarreras = qeu.getAllCarreras();

            List<string> carreras = new List<string>();
            foreach (var item in listaCarreras)
            {
                carreras.Add(item.NombreCarrera);
            }
            return carreras;
        }
        public List<Carrera> listaCarrerasOBj()
        {
            return qeu.getAllCarreras();
        }

        public List<string> listaEstadoUsuariosString()
        {
            List<EstadoUsuario> listaEstadosUsuarios = qeu.getAllEstadosUsuarios();

            List<string> estadosUsuarios = new List<string>();
            foreach (var item in listaEstadosUsuarios)
            {
                estadosUsuarios.Add(item.NombreEstadoUsuario);
            }
            return estadosUsuarios;
        }

        public List<Carrera> listaCarrerasOBjFiltrada(string param)
        {
            List<Carrera> lista = qeu.getAllCarreras();
            string parametroMinusculas = param.ToLower();

            return lista.FindAll(item => item.NombreCarrera.ToLower().Contains(parametroMinusculas));
        }

        public int getIdSede(string nombre)
        {
            List<Sede> listaSedes = qeu.getAllSedes();

            foreach (var item in listaSedes)
            {
                
                if (item.NombreSede.ToLower().Equals(nombre.ToLower())) { 
                    return item.IdSede;
                }
            }
            return 0;

        }

        public int getIdEstado(string nombre)
        {
            List<EstadoUsuario> listaEstadosUsuarios = qeu.getAllEstadosUsuarios();

           
            foreach (var item in listaEstadosUsuarios)
            {
                if (item.NombreEstadoUsuario.ToLower().Equals(nombre.ToLower())) {
                    return item.IdEstadoUsuario;
                }
            }
            return 0;
        }

        public string getIdCarrera(string nombre)
        {
            List<Carrera> listaCarreras = qeu.getAllCarreras();

            foreach (var item in listaCarreras)
            {
                if (item.NombreCarrera.ToLower().Equals(nombre.ToLower())) {
                    return item.IdCarrera;
                }
            }
            return "";
        }

        public string InsertarBDUsuario(DTOUsuario usuario)
        {
            if(usuario != null)
            {
                if (!qeu.addUsuario(usuario))
                {
                    return "Error:\n\nNo se pudo realizar la inserción del Estudiante";
                }
                else
                {
                    return "Se ha agregado al estudiante con éxito";
                }
            }
            return "Error:\n\nError Fatal";
        }

        public DTOUsuario getOneUsuario(string carne)
        {
            if(!string.IsNullOrEmpty(carne))
            {
               return qeu.getOneUsuario(carne);
            }
            return null;
        }

        public string modificarBDUsuario(DTOUsuario usuario)
        {
            if (usuario != null)
            {
                if (!qeu.updateUsuario(usuario))
                {
                    return "Error:\n\nNo se pudo realizar la actualización del Estudiante";
                }
                else
                {
                    return "Se ha actualizado al estudiante con éxito";
                }
            }
            return "Error:\n\nError Fatal";
        }

        public List<DTOUsuario> getAllUsuarios()
        {
            return qeu.getAll();            
        }

        public List<DTOUsuario> getListaUsuariosFiltrada(string atributo, string valor)
        {
            List<DTOUsuario> listafiltrada = qeu.getAll();
            switch (atributo.ToLower())
            {
                case "carnet":
                    return listafiltrada.Where(p => p.carnet.ToLower().Contains(valor.ToLower())).ToList();
                case "nombre":
                    return listafiltrada.Where(p => p.nombre.ToLower().Contains(valor.ToLower())).ToList();

                case "apellido":
                    return listafiltrada.Where(p => p.apellido.ToLower().Contains(valor.ToLower())).ToList();
                default:
                    return listafiltrada;
            }
        }

    }
}
