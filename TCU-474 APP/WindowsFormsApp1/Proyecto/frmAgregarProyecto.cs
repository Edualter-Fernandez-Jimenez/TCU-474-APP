using Datos.DTO;
using Datos.Models;
using Logica.ProyectoLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace WindowsFormsApp1.Proyecto
{
    public partial class frmAgregarProyecto : Form
    {
        private readonly ProyectoLogic _pl;

        string carnetadd;
        string carnetdelete;
        string nombreadd;
        string nombredelete;
        public List<string> usuariosAsignados = new List<string>();
        public List<string> microempresariosAsignados = new List<string>();
        public frmAgregarProyecto()
        {
            InitializeComponent();
            this._pl = new ProyectoLogic();
            cargaInicial();
        }

        public void cargaInicial()
        {
            tbIdProyecto.Text = _pl.getNewIdProyecto();

            cbAreaInteres.DataSource = _pl.listaAreasInteresString();

            List<string> estados = _pl.listaEstadoString();
            List<string> estadosFiltrados = new List<string>();

            foreach (string estado in estados)
            {
                if (!estado.Equals("Finalizado"))
                {
                    estadosFiltrados.Add(estado);
                }
            }
            cbEstado.DataSource = estadosFiltrados;

            cbModalidad.DataSource = _pl.listaModalidadesString();

            cbProvincia.DataSource = _pl.getListaProvincias();

            dgvUsuarios.Columns["CarnetId"].DataPropertyName = "Carnet";
            dgvUsuarios.Columns["NombreUsuario"].DataPropertyName = "Nombre";
            dgvUsuarios.Columns["ApellidoUsuario"].DataPropertyName = "Apellido";
            dgvUsuarios.Columns["CarreraUsuario"].DataPropertyName = "nombreCarrera";
            dgvUsuarios.Columns["EstadoUsuario"].DataPropertyName = "nombreEstadoUsuario";
            dgvUsuarios.DataSource = usuarioDatasourceHanddler();

            dgvMicroempresarios.Columns["Id_Microempresario"].DataPropertyName = "IdMicroempresario";
            dgvMicroempresarios.Columns["Cedula"].DataPropertyName = "Cedula";
            dgvMicroempresarios.Columns["NombreMicroempresario"].DataPropertyName = "NombreMicroempresario";
            dgvMicroempresarios.Columns["ApellidoMicroempresario"].DataPropertyName = "ApellidoMicroempresario";
            dgvMicroempresarios.Columns["NombreE"].DataPropertyName = "NombreEmprendimiento";
            dgvMicroempresarios.Columns["Canton"].DataPropertyName = "Canton";
            dgvMicroempresarios.Columns["Distrito"].DataPropertyName = "Distrito";
            dgvMicroempresarios.DataSource = MicroEmpresarioDatasourceHanddler();

        }
        private IEnumerable<dynamic> usuarioDatasourceHanddler()
        {
            var datosMostrar = _pl.getAllUsuarios().Select(m => new
            {
                m.carnet,
                m.nombre,
                m.apellido,
                m.nombreCarrera,
                m.nombreEstadoUsuario
            }).ToList();
            return datosMostrar;
        }
        private IEnumerable<dynamic> MicroEmpresarioDatasourceHanddler()
        {
            var datosMostrar = _pl.getAllMicroempresarios().Select(m => new
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
        private bool contieneInformacion()
        {
            if (!string.IsNullOrEmpty(tbNombre.Text)||
                !string.IsNullOrEmpty(tbDescripcion.Text)||
                !string.IsNullOrEmpty(tbNombreAreaInteres.Text)||
                usuariosAsignados.Count > 0 ||
                microempresariosAsignados.Count>0)
            {
                return true;
            }
            return false;
        }

        private void limpiarform()
        {
            tbNombre.Text = string.Empty;
            tbDescripcion.Text = string.Empty;

            cbModalidad.SelectedIndex = 0;

            cbAreaInteres.SelectedIndex = 0;
            btnAgregarAreaInteres.Enabled = false;
            btnCancelar.Enabled = false;
            tbNombreAreaInteres.Enabled = false;
            tbNombreAreaInteres.Text = string.Empty;

            cbEstado.SelectedIndex = 0;

            cbProvincia.SelectedIndex = 0;
            tbOtrasSenas.Text = string.Empty;

            tbNombreEstudiante.Text = string.Empty;
            tbApellidoEstudiante.Text = string.Empty;
            tbCarnet.Text = string.Empty;
            tbCarnetAsignar.Text = string.Empty;
            tbCarneEliminar.Text = string.Empty;
            usuariosAsignados.Clear();
            var datosMostrarUsuarios = _pl.getUsuariosAsignados(usuariosAsignados).Select(m => new
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
            dgvUsuariosAsignados.DataSource = datosMostrarUsuarios;

            tbNombreMicro.Text = string.Empty;
            tbApellidoMicro.Text = string.Empty;
            tbNombreEmprendimiento.Text = string.Empty;
            tbBuscarDistrito.Text = string.Empty;
            tbNombreAgregar.Text = string.Empty;
            tbNombreEliminar.Text = string.Empty;
            microempresariosAsignados.Clear();
            var datosMostrarMicro = _pl.getMicroempresariosAsignados(microempresariosAsignados).Select(m => new
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
            dgvMicroAsignado.DataSource = datosMostrarMicro;
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
            if(microempresariosAsignados.Count == 0)
            {
                aux += "Debe asignar almenos un microempresario al proyecto.\n";
            }
            return aux;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCanton.DataSource = _pl.getListaCantones(cbProvincia.SelectedItem.ToString());
        }

        private void cbCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDistrito.DataSource = _pl.getListaDistritos(cbCanton.SelectedItem.ToString());
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
            dgvUsuarios.DataSource = usuarioDatasourceHanddler();
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
            dgvMicroempresarios.DataSource = MicroEmpresarioDatasourceHanddler();
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

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvUsuarios.Rows[e.RowIndex];
                carnetadd = (string)selectedRow.Cells["CarnetId"].Value;
                tbCarnetAsignar.Text = carnetadd;
            }
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

        private void dgvMicroempresarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvMicroempresarios.Rows[e.RowIndex];
                nombreadd = (string)selectedRow.Cells["NombreMicroempresario"].Value;

                tbNombreAgregar.Text = nombreadd;
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
            if (contieneInformacion())
            {
                DialogResult resultado = MessageBox.Show("Estas por limpiar un formulario que contiene información\n¿Quieres continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    limpiarform();
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(verificadorCampos())) { 
                DateTime dateTime = new DateTime();
                if (cbEstado.SelectedValue.ToString().Equals("En Ejecución"))
                {
                    dateTime = DateTime.Now;
                }
                else
                {
                    dateTime = DateTime.MinValue;
                }
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
                proyecto.fechaIncio = dateTime;

               MessageBox.Show(_pl.AddProyecto(proyecto, usuariosAsignados, microempresariosAsignados));
               this.Close();
            }
            else
            {
                MessageBox.Show("El formulario contiene los siguientes errores:\n\n" + verificadorCampos() + "\n\n" + "Por favor corrija los errores para continuar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
