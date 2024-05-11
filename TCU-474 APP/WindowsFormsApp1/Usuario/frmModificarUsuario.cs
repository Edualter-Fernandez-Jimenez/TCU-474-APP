using Datos.DTO;
using Logica.EstudianteLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Usuario
{
    public partial class frmModificarUsuario : Form
    {
        string nombreCarrera;
        string siglaCarrera;
        private readonly UsuarioLogic _ul;
        public frmModificarUsuario(string carnet)
        {
            InitializeComponent();
            _ul = new UsuarioLogic();
            cargaInicial(carnet);
        }

        private void cargaInicial(string carne) {
            DTOUsuario usuario = _ul.getOneUsuario(carne);
            if (usuario != null)
            {

                tbCarnet.Text = usuario.carnet;
                tbCedula.Text = usuario.cedula;
                tbNombre.Text = usuario.nombre;
                tbApellido.Text = usuario.apellido;
                tbTelefono.Text = usuario.numeroTelefono;
                tbEmail.Text = usuario.correoElectronico;
                dtpFechaInicio.Value= usuario.fechaInicio;
                dtpFechaFin.Value = usuario.fechaFin;
                tbCarreraSeleccionada.Text = usuario.nombreCarrera;

                cbSede.DataSource = _ul.listaSedesString();
                cbEstado.DataSource = _ul.listaEstadoUsuariosString();

                cbSede.SelectedIndex = cbSede.Items.IndexOf(usuario.nombreSede);
                cbEstado.SelectedIndex = cbEstado.Items.IndexOf(usuario.nombreEstadoUsuario);

                dgvCarreras.Columns["nCarrera"].DataPropertyName = "IdCarrera";
                dgvCarreras.Columns["NombreC"].DataPropertyName = "NombreCarrera";
                dgvCarreras.DataSource = datatable();

            }
            else
            {
                MessageBox.Show("No se puede cargar la Informacion del estudiante", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private IEnumerable<dynamic> datatable()
        {
            var datosMostrar = _ul.listaCarrerasOBj().Select(m => new
            {
                m.IdCarrera,
                m.NombreCarrera,
            }).ToList();
            return datosMostrar;
        }

        private DTOUsuario constructorDTOUsuario()
        {
            DTOUsuario dTOUsuario = new DTOUsuario(
                tbCarnet.Text.ToUpper(),
                tbCedula.Text,
                tbNombre.Text,
                tbApellido.Text,
                tbTelefono.Text,
                tbEmail.Text,
                _ul.getIdCarrera(tbCarreraSeleccionada.Text),
                _ul.getIdSede(cbSede.SelectedValue.ToString()),
                _ul.getIdEstado(cbEstado.SelectedValue.ToString())
                );
            //agregar fechas
            dTOUsuario.fechaInicio = dtpFechaInicio.Value;
            dTOUsuario.fechaFin = dtpFechaFin.Value;

            return dTOUsuario;
        }

        private string verificadorCampos()
        {
            String aux = "";
            if (string.IsNullOrEmpty(tbCarnet.Text))
            {
                aux += "El carnet del estudiante es obligatorio.\n";
            }
            if (string.IsNullOrEmpty(tbNombre.Text))
            {
                aux += "El nombreadd del estudiante es obligatorio.\n";
            }
            if (string.IsNullOrEmpty(tbApellido.Text))
            {
                aux += "El apellido del estudiante es obligatorio.\n";
            }
            if (string.IsNullOrEmpty(tbTelefono.Text))
            {
                aux += "El telefono del estudiante es obligatorio.\n";
            }
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                aux += "El Email del estudiante es obligatorio.\n";
            }
            string patronCorreoElectronico = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (tbEmail.Text != string.Empty)
            {
                if (!Regex.IsMatch(tbEmail.Text, patronCorreoElectronico))
                {
                    aux += "El correo electronico del emprendedor posee caracteres no validos.\n";
                }
            }
            if (string.IsNullOrEmpty(tbCarreraSeleccionada.Text))
            {
                aux += "La carrera del estudiante es obligatorio.\n";
            }
            if (dtpFechaInicio.Value > dtpFechaFin.Value)
            {
                aux += "La fecha de finalización debe ser mayor a la fecha de incio.\n";
            }

            return aux;
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(verificadorCampos()))
            {
                MessageBox.Show(_ul.modificarBDUsuario(constructorDTOUsuario()));
                this.Close();
            }
            else
            {
                MessageBox.Show("El formulario contiene los siguientes errores:\n\n" + verificadorCampos() + "\n\n" + "Por favor corrija los errores para continuar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var datosMostrar = _ul.listaCarrerasOBjFiltrada(tbCarreraBuscar.Text).Select(m => new
            {
                m.IdCarrera,
                m.NombreCarrera,
            }).ToList();

            dgvCarreras.Columns["nCarrera"].DataPropertyName = "IdCarrera";
            dgvCarreras.Columns["NombreC"].DataPropertyName = "NombreCarrera";
            dgvCarreras.DataSource = datosMostrar;
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            dgvCarreras.Columns["nCarrera"].DataPropertyName = "IdCarrera";
            dgvCarreras.Columns["NombreC"].DataPropertyName = "NombreCarrera";
            dgvCarreras.DataSource = datatable();
            tbCarreraBuscar.Text = string.Empty;
        }

        private void dgvCarreras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCarreras.Rows[e.RowIndex];
                nombreCarrera = (string)selectedRow.Cells["NombreC"].Value;
                siglaCarrera = (string)selectedRow.Cells["nCarrera"].Value;

                tbCarreraSeleccionada.Text = nombreCarrera;
            }
        }
    }
}
