using Datos.DTO;
using Logica.EstudianteLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Usuario
{
    public partial class frmListarUsuarios : Form
    {
        private readonly UsuarioLogic _ul;

        string nombre;
        string apellidos;
        string carnet;
        string carrera;
        string estado;
        public frmListarUsuarios()
        {
            InitializeComponent();
            _ul = new UsuarioLogic();
            dgvUsuarios.Columns["CarnetId"].DataPropertyName = "Carnet";
            dgvUsuarios.Columns["NombreUsuario"].DataPropertyName = "Nombre";
            dgvUsuarios.Columns["ApellidoUsuario"].DataPropertyName = "Apellido";
            dgvUsuarios.Columns["CarreraUsuario"].DataPropertyName = "nombreCarrera";
            dgvUsuarios.Columns["EstadoUsuario"].DataPropertyName = "nombreEstadoUsuario";
            dgvUsuarios.DataSource = datasourceHanddler();
        }
        private IEnumerable<dynamic> datasourceHanddler()
        {
            var datosMostrar = _ul.getAllUsuarios().Select(m => new
            {
                m.carnet,
                m.nombre,
                m.apellido,
                m.nombreCarrera,
                m.nombreEstadoUsuario
            }).ToList();
            return datosMostrar;
        }

        private void refreshandclean()
        {
            tbNombreEmpresario.Text = string.Empty;
            tbApellidos.Text = string.Empty;
            tbCarne.Text = string.Empty;

            tbNombreholder.Text = string.Empty;
            tbApellidosholder.Text = string.Empty;
            tbCarneholer.Text = string.Empty;
            tbEstadoholder.Text = string.Empty;
            tbCarreraholder.Text = string.Empty;

            carnet = string.Empty;
            nombre = string.Empty;
            apellidos = string.Empty;
            carrera = string.Empty;
            estado = string.Empty;

            dgvUsuarios.Columns["CarnetId"].DataPropertyName = "Carnet";
            dgvUsuarios.Columns["NombreUsuario"].DataPropertyName = "Nombre";
            dgvUsuarios.Columns["ApellidoUsuario"].DataPropertyName = "Apellido";
            dgvUsuarios.Columns["CarreraUsuario"].DataPropertyName = "nombreCarrera";
            dgvUsuarios.Columns["EstadoUsuario"].DataPropertyName = "nombreEstadoUsuario";
            dgvUsuarios.DataSource = datasourceHanddler();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<DTOUsuario> listaFiltrada = null;
            if (tbNombreEmpresario.Text != string.Empty)
            {
                listaFiltrada = _ul.getListaUsuariosFiltrada("nombre", tbNombreEmpresario.Text);
            }
            else if (tbApellidos.Text != string.Empty)
            {
                listaFiltrada = _ul.getListaUsuariosFiltrada("apellido", tbApellidos.Text);

            }
            else if (tbCarne.Text != string.Empty)
            {
                listaFiltrada = _ul.getListaUsuariosFiltrada("carnet", tbCarne.Text);
            }
            else
            {
                listaFiltrada = _ul.getListaUsuariosFiltrada("N/A", "N/A");
            }
            var datosMostrar = listaFiltrada.Select(m => new
            {
                m.carnet,
                m.nombre,
                m.apellido,
                m.nombreCarrera,
                m.nombreEstadoUsuario
            }).ToList();

            dgvUsuarios.Columns["CarnetId"].DataPropertyName = "Carnet";
            dgvUsuarios.Columns["NombreUsuario"].DataPropertyName = "Nombre";
            dgvUsuarios.Columns["ApellidoUsuario"].DataPropertyName = "Apellido";
            dgvUsuarios.Columns["CarreraUsuario"].DataPropertyName = "nombreCarrera";
            dgvUsuarios.Columns["EstadoUsuario"].DataPropertyName = "nombreEstadoUsuario";
            dgvUsuarios.DataSource = datosMostrar;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvUsuarios.Rows[e.RowIndex];
                carnet = (string)selectedRow.Cells["CarnetId"].Value;
                nombre = (string)selectedRow.Cells["NombreUsuario"].Value;
                apellidos = (string)selectedRow.Cells["ApellidoUsuario"].Value;
                carrera = (string)selectedRow.Cells["CarreraUsuario"].Value;
                estado = (string)selectedRow.Cells["EstadoUsuario"].Value;

                tbCarneholer.Text = carnet;
                tbApellidosholder.Text = apellidos;
                tbNombreholder.Text = nombre;
                tbCarreraholder.Text = carrera;
                tbEstadoholder.Text = estado;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(carnet))
            {
                frmConsultarUnoUsuario frmModificar = new frmConsultarUnoUsuario(carnet);
                frmModificar.Show();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar algun elemento para poder realizar una consulta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            refreshandclean();
        }

        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            refreshandclean();
        }
    }
}
