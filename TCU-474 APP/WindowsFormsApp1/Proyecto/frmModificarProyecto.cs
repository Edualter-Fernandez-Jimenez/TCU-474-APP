using Datos.DTO;
using Datos.Models;
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
    public partial class frmModificarProyecto : Form
    {
        private readonly ProyectoLogic _pl;

        string idProyecto;
        string carnetadd;
        string carnetdelete;
        string nombreadd;
        string nombredelete;
        DTOProyecto p = null;
        public List<string> usuariosAsignados = new List<string>();
        public List<string> microempresariosAsignados = new List<string>();
        public List<string> usuariosEliminados = new List<string>();
        public List<string> microempresariosEliminados = new List<string>();
        public frmModificarProyecto(string idProyecto)
        {
            InitializeComponent();
            this._pl = new ProyectoLogic();
            this.idProyecto = idProyecto;
            this.p = _pl.getOneProyecto(idProyecto);
            cargaInicial();
        }
        public void cargaInicial()
        {
            foreach (var item in _pl.getEstudiantesAsignados(idProyecto))
            {
                usuariosAsignados.Add(item.carnet);
            }
            foreach (var item in _pl.getMicroempresariosAsignados(idProyecto))
            {
                microempresariosAsignados.Add(item.NombreMicroempresario);
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

            dgvUsuarios.Columns["CarnetId"].DataPropertyName = "Carnet";
            dgvUsuarios.Columns["NombreUsuario"].DataPropertyName = "Nombre";
            dgvUsuarios.Columns["ApellidoUsuario"].DataPropertyName = "Apellido";
            dgvUsuarios.Columns["CarreraUsuario"].DataPropertyName = "nombreCarrera";
            dgvUsuarios.Columns["EstadoUsuario"].DataPropertyName = "nombreEstadoUsuario";
            dgvUsuarios.DataSource = usuarioDatasourceHanddler(_pl.getAllUsuarios());

            dgvUsuariosAsignados.Columns["CarnetAsig"].DataPropertyName = "Carnet";
            dgvUsuariosAsignados.Columns["NombreAsig"].DataPropertyName = "Nombre";
            dgvUsuariosAsignados.Columns["ApellidoAsig"].DataPropertyName = "Apellido";
            dgvUsuariosAsignados.Columns["CarreraAsig"].DataPropertyName = "nombreCarrera";
            dgvUsuariosAsignados.Columns["EstadoUsuarioAsig"].DataPropertyName = "nombreEstadoUsuario";
            dgvUsuariosAsignados.DataSource = usuarioDatasourceHanddler(_pl.getEstudiantesAsignados(idProyecto)); ;

             
            dgvMicroempresarios.Columns["Id_Microempresario"].DataPropertyName = "IdMicroempresario";
            dgvMicroempresarios.Columns["Cedula"].DataPropertyName = "Cedula";
            dgvMicroempresarios.Columns["NombreMicroempresario"].DataPropertyName = "NombreMicroempresario";
            dgvMicroempresarios.Columns["ApellidoMicroempresario"].DataPropertyName = "ApellidoMicroempresario";
            dgvMicroempresarios.Columns["NombreE"].DataPropertyName = "NombreEmprendimiento";
            dgvMicroempresarios.Columns["Canton"].DataPropertyName = "Canton";
            dgvMicroempresarios.Columns["Distrito"].DataPropertyName = "Distrito";
            dgvMicroempresarios.DataSource = MicroEmpresarioDatasourceHanddler(_pl.getAllMicroempresarios());

            dgvMicroAsignado.Columns["IdMicroAsig"].DataPropertyName = "IdMicroempresario";
            dgvMicroAsignado.Columns["CedulaMicroAsig"].DataPropertyName = "Cedula";
            dgvMicroAsignado.Columns["NombreMicroAsig"].DataPropertyName = "NombreMicroempresario";
            dgvMicroAsignado.Columns["ApellidoMicroAsig"].DataPropertyName = "ApellidoMicroempresario";
            dgvMicroAsignado.Columns["NombreEmprenAisg"].DataPropertyName = "NombreEmprendimiento";
            dgvMicroAsignado.Columns["CantonAsig"].DataPropertyName = "Canton";
            dgvMicroAsignado.Columns["DistritoAsig"].DataPropertyName = "Distrito";
            dgvMicroAsignado.DataSource = MicroEmpresarioDatasourceHanddler(_pl.getMicroempresariosAsignados(idProyecto));

            if (cbEstado.SelectedValue.ToString().Equals("Finalizado"))
            {
                btnModificar.Enabled = false;
                cbEstado.Enabled = false;
                
                btnAgregarUsuario.Enabled = false;
                btnElimiarUsuario.Enabled = false;
                dgvUsuarios.Enabled = false;
                dgvUsuariosAsignados.Enabled = false;

                btnAgregarMicro.Enabled = false;
                btnEliminarMicro.Enabled = false;
                dgvMicroempresarios.Enabled = false;
                dgvMicroAsignado.Enabled = false;

            }
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
        private string verificadorCampos()
        {
            String aux = "";
            if (string.IsNullOrEmpty(tbNombre.Text))
            {
                aux += "El Nombre del proyecto es obligatorio.\n";
            }
            if (string.IsNullOrEmpty(tbDescripcion.Text))
            {
                aux += "La descripción del proyecto es obligatorio.\n";
            }
            if (usuariosAsignados.Count == 0)
            {
                aux += "Debe asignar almenos un estudiante encargado al proyecto.\n";

            }
            if (microempresariosAsignados.Count == 0)
            {
                aux += "Debe asignar almenos un microempresario al proyecto.\n";
            }
            return aux;
        }

        private void btnOtraAreaInteres_Click(object sender, EventArgs e)
        {
            btnAgregarAreaInteres.Enabled = true;
            btnCancelar.Enabled = true;
            tbNombreAreaInteres.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (tbNombreAreaInteres.Text != string.Empty)
            {
                DialogResult resultado = MessageBox.Show("Estas por limpiar cancelar la inserción de una nueva Area de Interés\n¿Quieres continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    btnAgregarAreaInteres.Enabled = false;
                    btnCancelar.Enabled = false;
                    tbNombreAreaInteres.Enabled = false;
                    tbNombreAreaInteres.Text = string.Empty;
                }
            }
            else
            {
                btnAgregarAreaInteres.Enabled = false;
                btnCancelar.Enabled = false;
                tbNombreAreaInteres.Enabled = false;
                tbNombreAreaInteres.Text = string.Empty;
            }
        }

        private void btnAgregarAreaInteres_Click(object sender, EventArgs e)
        {
            bool existe = false;
            List<string> aux = _pl.listaAreasInteresString();
            foreach (string item in aux)
            {
                if (item == tbNombreAreaInteres.Text.Trim())
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                if (tbNombreAreaInteres.Text.Trim() != "")
                {
                    AreaInteres areaInteres = new AreaInteres(
                        0,
                        tbNombreAreaInteres.Text.Trim()
                        );
                    if (_pl.InsertarBDAreInteres(areaInteres))
                    {
                        btnAgregarAreaInteres.Enabled = false;
                        btnCancelar.Enabled = false;
                        tbNombreAreaInteres.Enabled = false;
                        tbNombreAreaInteres.Text = string.Empty;

                        cbAreaInteres.DataSource = _pl.listaAreasInteresString();
                        cbAreaInteres.Refresh();

                        MessageBox.Show("Se insertó una nueva Area de Interés.\nAhora el Area de Interés se encuentra disponible en el selector de Areas de Interés", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR\nNo se pudo insertar la nueva Area de Interés", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR\nEl nombreadd de el Area de Interés ya se encuentra registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCanton.DataSource = _pl.getListaCantones(cbProvincia.SelectedItem.ToString());
        }

        private void cbCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDistrito.DataSource = _pl.getListaDistritos(cbCanton.SelectedItem.ToString());
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

            dgvUsuarios.Columns["CarnetId"].DataPropertyName = "Carnet";
            dgvUsuarios.Columns["NombreUsuario"].DataPropertyName = "Nombre";
            dgvUsuarios.Columns["ApellidoUsuario"].DataPropertyName = "Apellido";
            dgvUsuarios.Columns["CarreraUsuario"].DataPropertyName = "nombreCarrera";
            dgvUsuarios.Columns["EstadoUsuario"].DataPropertyName = "nombreEstadoUsuario";
            dgvUsuarios.DataSource = datosMostrar;
        }

        private void btnLimpiarFiltroUsuario_Click(object sender, EventArgs e)
        {
            tbNombreEstudiante.Text = string.Empty;
            tbApellidoEstudiante.Text = string.Empty;
            tbCarnet.Text = string.Empty;

            dgvUsuarios.Columns["CarnetId"].DataPropertyName = "Carnet";
            dgvUsuarios.Columns["NombreUsuario"].DataPropertyName = "Nombre";
            dgvUsuarios.Columns["ApellidoUsuario"].DataPropertyName = "Apellido";
            dgvUsuarios.Columns["CarreraUsuario"].DataPropertyName = "nombreCarrera";
            dgvUsuarios.Columns["EstadoUsuario"].DataPropertyName = "nombreEstadoUsuario";
            dgvUsuarios.DataSource = usuarioDatasourceHanddler(_pl.getAllUsuarios());
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvUsuarios.Rows[e.RowIndex];
                carnetadd = (string)selectedRow.Cells["CarnetId"].Value;
                tbCarnetAsignar.Text = carnetadd;
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCarnetAsignar.Text))
            {
                bool aux = false;
                foreach (var carnet in usuariosAsignados)
                {
                    if (carnet != null)
                    {
                        if (carnet == carnetadd)
                        {
                            MessageBox.Show("ERROR\nEl estudiante ya se encuentra asignado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            aux = true;
                        }
                    }
                }
                if (!aux)
                {
                    usuariosAsignados.Add(carnetadd);
                    if (usuariosEliminados.Contains(carnetadd))
                    {
                        usuariosEliminados.RemoveAll(u => u == carnetadd);
                    }
                    var datosMostrar = _pl.getUsuariosAsignados(usuariosAsignados).Select(m => new
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
            }
            else
            {
                MessageBox.Show("ERROR\nDebe seleccionar un estudiante a asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbCarnetAsignar.Text = string.Empty;
        }

        private void btnElimiarUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCarneEliminar.Text))
            {
                usuariosAsignados.RemoveAll(u => u == carnetdelete);
                if (!usuariosEliminados.Contains(carnetdelete))
                {
                    usuariosEliminados.Add(carnetdelete);
                }
                var datosMostrar = _pl.getUsuariosAsignados(usuariosAsignados).Select(m => new
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
            else
            {
                MessageBox.Show("ERROR\nDebe seleccionar un estudiante a quitar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbCarneEliminar.Text = string.Empty;
        }

        private void dgvUsuariosAsignados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvUsuariosAsignados.Rows[e.RowIndex];
                carnetdelete = (string)selectedRow.Cells["CarnetAsig"].Value;
                tbCarneEliminar.Text = carnetdelete;

            }
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
            dgvMicroempresarios.Columns["Id_Microempresario"].DataPropertyName = "IdMicroempresario";
            dgvMicroempresarios.Columns["Cedula"].DataPropertyName = "Cedula";
            dgvMicroempresarios.Columns["NombreMicroempresario"].DataPropertyName = "NombreMicroempresario";
            dgvMicroempresarios.Columns["ApellidoMicroempresario"].DataPropertyName = "ApellidoMicroempresario";
            dgvMicroempresarios.Columns["NombreE"].DataPropertyName = "NombreEmprendimiento";
            dgvMicroempresarios.Columns["Canton"].DataPropertyName = "Canton";
            dgvMicroempresarios.Columns["Distrito"].DataPropertyName = "Distrito";
            dgvMicroempresarios.DataSource = datosMostrar;
        }

        private void btnLimpiarFiltroMicro_Click(object sender, EventArgs e)
        {
            tbNombreMicro.Text = string.Empty;
            tbApellidoMicro.Text = string.Empty;
            tbNombreEmprendimiento.Text = string.Empty;
            tbBuscarDistrito.Text = string.Empty;

            dgvMicroempresarios.Columns["Id_Microempresario"].DataPropertyName = "IdMicroempresario";
            dgvMicroempresarios.Columns["Cedula"].DataPropertyName = "Cedula";
            dgvMicroempresarios.Columns["NombreMicroempresario"].DataPropertyName = "NombreMicroempresario";
            dgvMicroempresarios.Columns["ApellidoMicroempresario"].DataPropertyName = "ApellidoMicroempresario";
            dgvMicroempresarios.Columns["NombreE"].DataPropertyName = "NombreEmprendimiento";
            dgvMicroempresarios.Columns["Canton"].DataPropertyName = "Canton";
            dgvMicroempresarios.Columns["Distrito"].DataPropertyName = "Distrito";
            dgvMicroempresarios.DataSource = MicroEmpresarioDatasourceHanddler(_pl.getAllMicroempresarios());
        }

        private void btnAgregarMicro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNombreAgregar.Text))
            {
                bool aux = false;
                foreach (var micro in microempresariosAsignados)
                {
                    if (micro != null)
                    {
                        if (micro == nombreadd)
                        {
                            MessageBox.Show("ERROR\nEl microempresario ya se encuentra asignado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            aux = true;
                        }
                    }
                }
                if (!aux)
                {
                    microempresariosAsignados.Add(nombreadd);
                    if (microempresariosEliminados.Contains(nombreadd))
                    {
                        microempresariosEliminados.RemoveAll(u => u == nombreadd);
                    }

                    var datosMostrar = _pl.getMicroempresariosAsignados(microempresariosAsignados).Select(m => new
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
            else
            {
                MessageBox.Show("ERROR\nDebe seleccionar un microempresario a asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbNombreAgregar.Text = string.Empty;
        }

        private void btnEliminarMicro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNombreEliminar.Text))
            {
                microempresariosAsignados.RemoveAll(u => u == nombredelete);
                if (!microempresariosEliminados.Contains(nombredelete))
                {
                    microempresariosEliminados.Add(nombredelete);
                }
                var datosMostrar = _pl.getMicroempresariosAsignados(microempresariosAsignados).Select(m => new
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
            else
            {
                MessageBox.Show("ERROR\nDebe seleccionar un microempresario a asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbNombreEliminar.Text = string.Empty;
        }

        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Estas por restablecer el formulario \n¿Quieres continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                cargaInicial();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(verificadorCampos()))
            {
                DTOProyecto proyecto = new DTOProyecto(
                    tbIdProyecto.Text.Trim(),
                    tbNombre.Text.Trim(),
                    tbDescripcion.Text.Trim(),
                    cbModalidad.SelectedValue.ToString(),
                    cbAreaInteres.SelectedValue.ToString(),
                    cbEstado.SelectedValue.ToString(),
                    cbProvincia.SelectedValue.ToString(),
                    cbCanton.SelectedValue.ToString(),
                    cbDistrito.SelectedValue.ToString(),
                    tbOtrasSenas.Text.Trim()
                    );
                
                DTOProyecto proyectoUpdated = p;
                    if (cbEstado.SelectedValue.ToString().Equals("Generado"))
                    {
                        if (proyectoUpdated.fechaIncio != DateTime.MinValue && proyectoUpdated.fechaFin != DateTime.MinValue)
                        {
                            DialogResult resultado = MessageBox.Show("Estas por reiniciar el estado del proyecto.\nSe restableceran la fecha de inicio y de finalizacion.\n¿Quieres continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (resultado == DialogResult.Yes)
                            {
                                proyecto.fechaIncio = DateTime.MinValue;
                                proyecto.fechaFin = DateTime.MinValue;
                                proyecto.nombreEstadoProyecto = cbEstado.SelectedValue.ToString();
                            }
                            else
                            {
                                proyecto.fechaIncio = proyectoUpdated.fechaIncio;
                                proyecto.fechaFin = proyectoUpdated.fechaFin;
                                proyecto.nombreEstadoProyecto = proyectoUpdated.nombreEstadoProyecto;
                            }
                        }
                        else if (proyectoUpdated.fechaIncio != DateTime.MinValue)
                        {
                            DialogResult resultado = MessageBox.Show("Estas por reiniciar el estado del proyecto.\nSe restablecera la fecha de inicio.\n¿Quieres continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (resultado == DialogResult.Yes)
                            {
                                proyecto.fechaIncio = DateTime.MinValue;
                                proyecto.fechaFin = DateTime.MinValue;
                                proyecto.nombreEstadoProyecto = cbEstado.SelectedValue.ToString();
                            }
                            else
                            {
                                proyecto.fechaIncio = proyectoUpdated.fechaIncio;
                                proyecto.fechaFin = proyectoUpdated.fechaFin;
                                proyecto.nombreEstadoProyecto = proyectoUpdated.nombreEstadoProyecto;
                            }
                        }
                        else
                        {
                            proyecto.nombreEstadoProyecto = proyectoUpdated.nombreEstadoProyecto;
                            MessageBox.Show("El proyecto ya se enucuentra en el estado de Generado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    if (cbEstado.SelectedValue.ToString().Equals("En Ejecución"))
                    {
                        if (proyectoUpdated.fechaIncio == DateTime.MinValue && proyectoUpdated.fechaFin == DateTime.MinValue)
                        {
                            proyecto.fechaIncio = DateTime.Now;
                            proyecto.fechaFin = DateTime.MinValue;
                            proyecto.nombreEstadoProyecto = cbEstado.SelectedValue.ToString();
                        }
                        else if (proyectoUpdated.fechaIncio != DateTime.MinValue && proyectoUpdated.fechaFin != DateTime.MinValue)
                        {
                            DialogResult resultado = MessageBox.Show("Estas por reiniciar el estado del proyecto.\nSe restablecera la fecha de finalizacion.\n¿Quieres continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (resultado == DialogResult.Yes)
                            {
                                proyecto.fechaIncio = DateTime.Now;
                                proyecto.fechaFin = DateTime.MinValue;
                                proyecto.nombreEstadoProyecto = cbEstado.SelectedValue.ToString();
                            }
                            else
                            {
                            proyecto.fechaIncio = proyectoUpdated.fechaIncio;
                            proyecto.fechaFin = proyectoUpdated.fechaFin;
                            proyecto.nombreEstadoProyecto = proyectoUpdated.nombreEstadoProyecto;
                            }
                        }
                        else
                        {
                            proyecto.fechaIncio = proyectoUpdated.fechaIncio;
                            proyecto.fechaFin = proyectoUpdated.fechaFin;
                            proyecto.nombreEstadoProyecto = proyectoUpdated.nombreEstadoProyecto;
                        }
                    }

                    if (cbEstado.SelectedValue.ToString().Equals("Finalizado"))
                    {
                        if (proyectoUpdated.fechaIncio == DateTime.MinValue && proyectoUpdated.fechaFin == DateTime.MinValue)
                        {
                            proyecto.fechaIncio = proyectoUpdated.fechaIncio;
                            proyecto.fechaFin = proyectoUpdated.fechaFin;
                            proyecto.nombreEstadoProyecto = proyectoUpdated.nombreEstadoProyecto;
                        MessageBox.Show("No se puede pasar directamente de estado generado a finalizado sin pasar por el estado en ejecución\n Se continuará con la actualización de los demas campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                        else if (proyectoUpdated.fechaIncio != DateTime.MinValue && proyectoUpdated.fechaFin != DateTime.MinValue)
                        {
                            proyecto.fechaIncio = proyectoUpdated.fechaIncio;
                            proyecto.fechaFin = proyectoUpdated.fechaFin;
                            proyecto.nombreEstadoProyecto = proyectoUpdated.nombreEstadoProyecto;
                        }
                        else
                        {
                            proyecto.fechaIncio = proyectoUpdated.fechaIncio; 
                            proyecto.fechaFin = DateTime.Now;
                            proyecto.nombreEstadoProyecto = cbEstado.SelectedValue.ToString();
                        }
                    }
                    proyecto.IdDireccion = p.IdDireccion;

                MessageBox.Show(_pl.updateProyecto(proyecto, usuariosAsignados, microempresariosAsignados, usuariosEliminados, microempresariosEliminados, proyectoUpdated.fechaFin));
                this.Close();
            }
            else
            {
                MessageBox.Show("El formulario contiene los siguientes errores:\n\n" + verificadorCampos() + "\n\n" + "Por favor corrija los errores para continuar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMicroAsignado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvMicroAsignado.Rows[e.RowIndex];
                nombredelete = (string)selectedRow.Cells["NombreMicroAsig"].Value;

                tbNombreEliminar.Text = nombredelete;
            }
        }

        private void dgvMicroempresarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvMicroempresarios.Rows[e.RowIndex];
                nombreadd = (string)selectedRow.Cells["NombreMicroempresario"].Value;

                tbNombreAgregar.Text = nombreadd;
            }
        }
    }
}
