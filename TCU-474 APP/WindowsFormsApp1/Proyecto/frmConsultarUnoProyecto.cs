using Datos.DTO;
using Logica.ProyectoLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Proyecto
{
    public partial class frmConsultarUnoProyecto : Form
    {
        string idProyecto;
        private readonly ProyectoLogic _pl;

        public frmConsultarUnoProyecto(string idProyecto)
        {
            InitializeComponent();
            this._pl = new ProyectoLogic();
            this.idProyecto = idProyecto;
            cargaInicial();
        }
        public void cargaInicial()
        {
            DTOProyecto p = _pl.getOneProyecto(idProyecto);
            if (p.fechaIncio != DateTime.MinValue)
            {
                tbFechaInico.Text = p.fechaIncio.ToString("dd/MM/yyyy");
            }
            else
            {
                tbFechaInico.Text = "-";
            }
            if (p.fechaFin != DateTime.MinValue)
            {
                tbFechaFin.Text = p.fechaFin.ToString("dd/MM/yyyy");
            }
            else
            {
                tbFechaFin.Text = "-";
            }


            tbIdProyecto.Text = p.idProyecto;
            tbNombre.Text = p.nombre;
            tbDescripcion.Text = p.descripcion;

            cbAreaInteres.DataSource = _pl.listaAreasInteresString();
            cbAreaInteres.SelectedIndex = cbAreaInteres.Items.IndexOf(p.nombreAreaInteres);

            cbEstado.DataSource = _pl.listaEstadoString();
            cbEstado.SelectedIndex = cbEstado.Items.IndexOf(p.nombreEstadoProyecto);

            cbModalidad.DataSource = _pl.listaModalidadesString();
            cbModalidad.SelectedIndex = cbModalidad.Items.IndexOf(p.nombreModalidad);

            cbProvincia.DataSource = _pl.getListaProvincias();
            cbProvincia.SelectedIndex = cbProvincia.Items.IndexOf(p.provincia);

            cbCanton.DataSource = _pl.getListaCantones(cbProvincia.SelectedItem.ToString());
            cbCanton.SelectedIndex = cbCanton.Items.IndexOf(p.canton);

            cbDistrito.DataSource = _pl.getListaDistritos(cbCanton.SelectedItem.ToString());
            cbDistrito.SelectedIndex = cbDistrito.Items.IndexOf(p.distrito);
            tbOtrasSenas.Text = p.otrasSenas;

            dgvUsuariosAsignados.Columns["CarnetAsig"].DataPropertyName = "Carnet";
            dgvUsuariosAsignados.Columns["NombreAsig"].DataPropertyName = "Nombre";
            dgvUsuariosAsignados.Columns["ApellidoAsig"].DataPropertyName = "Apellido";
            dgvUsuariosAsignados.Columns["CarreraAsig"].DataPropertyName = "nombreCarrera";
            dgvUsuariosAsignados.Columns["EstadoUsuarioAsig"].DataPropertyName = "nombreEstadoUsuario";
            dgvUsuariosAsignados.DataSource = usuarioDatasourceHanddler(_pl.getEstudiantesAsignados(idProyecto));

            dgvMicroAsignado.Columns["IdMicroAsig"].DataPropertyName = "IdMicroempresario";
            dgvMicroAsignado.Columns["CedulaMicroAsig"].DataPropertyName = "Cedula";
            dgvMicroAsignado.Columns["NombreMicroAsig"].DataPropertyName = "NombreMicroempresario";
            dgvMicroAsignado.Columns["ApellidoMicroAsig"].DataPropertyName = "ApellidoMicroempresario";
            dgvMicroAsignado.Columns["NombreEmprenAisg"].DataPropertyName = "NombreEmprendimiento";
            dgvMicroAsignado.Columns["CantonAsig"].DataPropertyName = "Canton";
            dgvMicroAsignado.Columns["DistritoAsig"].DataPropertyName = "Distrito";
            dgvMicroAsignado.DataSource = MicroEmpresarioDatasourceHanddler(_pl.getMicroempresariosAsignados(idProyecto));
        }
        private IEnumerable<dynamic> usuarioDatasourceHanddler(List<DTOUsuario> lista)
        {
            var datosMostrar = lista.Select(m => new
            {
                m.carnet,
                m.nombre,
                m.apellido,
                m.nombreCarrera,
                m.nombreEstadoUsuario
            }).ToList();
            return datosMostrar;
        }
        private IEnumerable<dynamic> MicroEmpresarioDatasourceHanddler(List<DTOMicroempresario> lista)
        {
            var datosMostrar = lista.Select(m => new
            {
                m.IdMicroempresario,
                m.Cedula,
                m.NombreMicroempresario,
                m.ApellidoMicroempresario,
                m.NombreEmprendimiento,
                m.Canton,
                m.Distrito
            }).ToList();
            return datosMostrar;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarFiltroUsuario_Click(object sender, EventArgs e)
        {
            tbNombreEstudiante.Text = string.Empty;
            tbApellidoEstudiante.Text = string.Empty;
            tbCarnet.Text = string.Empty;

            dgvUsuariosAsignados.Columns["CarnetAsig"].DataPropertyName = "Carnet";
            dgvUsuariosAsignados.Columns["NombreAsig"].DataPropertyName = "Nombre";
            dgvUsuariosAsignados.Columns["ApellidoAsig"].DataPropertyName = "Apellido";
            dgvUsuariosAsignados.Columns["CarreraAsig"].DataPropertyName = "nombreCarrera";
            dgvUsuariosAsignados.Columns["EstadoUsuarioAsig"].DataPropertyName = "nombreEstadoUsuario";
            dgvUsuariosAsignados.DataSource = usuarioDatasourceHanddler(_pl.getEstudiantesAsignados(idProyecto));
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            List<DTOUsuario> listaFiltrada = null;
            if (tbNombreEstudiante.Text != string.Empty)
            {
                listaFiltrada = _pl.getListaUsuariosFiltrada("nombre", tbNombreEstudiante.Text);
            }
            else if (tbApellidoEstudiante.Text != string.Empty)
            {
                listaFiltrada = _pl.getListaUsuariosFiltrada("apellido", tbApellidoEstudiante.Text);

            }
            else if (tbCarnet.Text != string.Empty)
            {
                listaFiltrada = _pl.getListaUsuariosFiltrada("carnet", tbCarnet.Text);
            }
            else
            {
                listaFiltrada = _pl.getListaUsuariosFiltrada("N/A", "N/A");
            }
            var datosMostrar = listaFiltrada.Select(m => new
            {
                m.carnet,
                m.nombre,
                m.apellido,
                m.nombreCarrera,
                m.nombreEstadoUsuario
            }).ToList();

            dgvUsuariosAsignados.Columns["CarnetAsig"].DataPropertyName = "Carnet";
            dgvUsuariosAsignados.Columns["NombreAsig"].DataPropertyName = "Nombre";
            dgvUsuariosAsignados.Columns["ApellidoAsig"].DataPropertyName = "Apellido";
            dgvUsuariosAsignados.Columns["CarreraAsig"].DataPropertyName = "nombreCarrera";
            dgvUsuariosAsignados.Columns["EstadoUsuarioAsig"].DataPropertyName = "nombreEstadoUsuario";
            dgvUsuariosAsignados.DataSource = datosMostrar;
        }

        private void btnLimpiarFiltroMicro_Click(object sender, EventArgs e)
        {
            tbNombreMicro.Text = string.Empty;
            tbApellidoMicro.Text = string.Empty;
            tbNombreEmprendimiento.Text = string.Empty;
            tbBuscarDistrito.Text = string.Empty;

            dgvMicroAsignado.Columns["IdMicroAsig"].DataPropertyName = "IdMicroempresario";
            dgvMicroAsignado.Columns["CedulaMicroAsig"].DataPropertyName = "Cedula";
            dgvMicroAsignado.Columns["NombreMicroAsig"].DataPropertyName = "NombreMicroempresario";
            dgvMicroAsignado.Columns["ApellidoMicroAsig"].DataPropertyName = "ApellidoMicroempresario";
            dgvMicroAsignado.Columns["NombreEmprenAisg"].DataPropertyName = "NombreEmprendimiento";
            dgvMicroAsignado.Columns["CantonAsig"].DataPropertyName = "Canton";
            dgvMicroAsignado.Columns["DistritoAsig"].DataPropertyName = "Distrito";
            dgvMicroAsignado.DataSource = MicroEmpresarioDatasourceHanddler(_pl.getMicroempresariosAsignados(idProyecto));
        }

        private void btnBuscarMicro_Click(object sender, EventArgs e)
        {
            List<DTOMicroempresario> listaFiltrada = null;
            if (tbNombreMicro.Text != string.Empty)
            {
                listaFiltrada = _pl.getListaMicroempresariosFiltrada("nombre", tbNombreMicro.Text);
            }
            else if (tbApellidoMicro.Text != string.Empty)
            {
                listaFiltrada = _pl.getListaMicroempresariosFiltrada("apellido", tbApellidoMicro.Text);

            }
            else if (tbNombreEmprendimiento.Text != string.Empty)
            {
                listaFiltrada = _pl.getListaMicroempresariosFiltrada("nombreemprendimiento", tbNombreEmprendimiento.Text);
            }
            else if (tbBuscarDistrito.Text != string.Empty)
            {
                listaFiltrada = _pl.getListaMicroempresariosFiltrada("distrito", tbBuscarDistrito.Text);
            }
            else
            {
                listaFiltrada = _pl.getListaMicroempresariosFiltrada("N/A", "N/A");
            }

            var datosMostrar = listaFiltrada.Select(m => new
            {
                m.IdMicroempresario,
                m.Cedula,
                m.NombreMicroempresario,
                m.ApellidoMicroempresario,
                m.NombreEmprendimiento,
                m.Canton,
                m.Distrito
            }).ToList();
            dgvMicroAsignado.Columns["IdMicroAsig"].DataPropertyName = "IdMicroempresario";
            dgvMicroAsignado.Columns["CedulaMicroAsig"].DataPropertyName = "Cedula";
            dgvMicroAsignado.Columns["NombreMicroAsig"].DataPropertyName = "NombreMicroempresario";
            dgvMicroAsignado.Columns["ApellidoMicroAsig"].DataPropertyName = "ApellidoMicroempresario";
            dgvMicroAsignado.Columns["NombreEmprenAisg"].DataPropertyName = "NombreEmprendimiento";
            dgvMicroAsignado.Columns["CantonAsig"].DataPropertyName = "Canton";
            dgvMicroAsignado.Columns["DistritoAsig"].DataPropertyName = "Distrito";
            dgvMicroAsignado.DataSource = datosMostrar;
        }
    }
}
