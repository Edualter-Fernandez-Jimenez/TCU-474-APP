using Datos.DTO;
using Datos.Models;
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
    public partial class frmNuevoUsuario : Form
    {
        string nombreCarrera;
        string siglaCarrera;
        private readonly UsuarioLogic _ul;
        public frmNuevoUsuario()
        {
            InitializeComponent();
            _ul = new UsuarioLogic();
            cargaInicial();
        }

        public void cargaInicial() {
            cbSede.DataSource = _ul.listaSedesString();
            cbEstado.DataSource = _ul.listaEstadoUsuariosString();

            dgvCarreras.Columns["nCarrera"].DataPropertyName = "IdCarrera";
            dgvCarreras.Columns["NombreC"].DataPropertyName = "NombreCarrera";
            dgvCarreras.DataSource = datatable();
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

        private void limparForm() { 
            tbCarnet.Text = string.Empty;
            tbCedula.Text = string.Empty;
            tbNombre.Text = string.Empty;
            tbApellido.Text = string.Empty;
            tbTelefono.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbCarreraBuscar.Text = string.Empty;
            tbCarreraSeleccionada.Text = string.Empty;

            cargaInicial();
        }

        private bool contieneInformacion()
        {
            if (!string.IsNullOrEmpty(tbCarnet.Text) ||
                !string.IsNullOrEmpty(tbCedula.Text) ||
                !string.IsNullOrEmpty(tbNombre.Text) ||
                !string.IsNullOrEmpty(tbApellido.Text) ||
                !string.IsNullOrEmpty(tbTelefono.Text) ||
                !string.IsNullOrEmpty(tbEmail.Text) ||
                !string.IsNullOrEmpty(tbCarreraSeleccionada.Text))
            {
                return true;
            }

            return false;
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
       private void btnCerrar_Click(object sender, EventArgs e)
       {
            if (contieneInformacion())
            {
                DialogResult resultado = MessageBox.Show("Estas por cerrar un formulario que contiene información\n¿Quieres continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(verificadorCampos()))
            {
                MessageBox.Show(_ul.InsertarBDUsuario(constructorDTOUsuario()));
                limparForm();
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

        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            if (contieneInformacion())
            {
                DialogResult resultado = MessageBox.Show("Estas por limpiar un formulario que contiene información\n¿Quieres continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    limparForm();
                }
            }
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
