using Datos.DTO;
using Datos.Models;
using Logica.MicroempresarioLogic;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1.Microempresario
{
    public partial class frmAgregarMicroempresario : Form
    {
        private readonly MicroempresarioLogic _ml;
        public frmAgregarMicroempresario()
        {
            InitializeComponent();
            _ml = new MicroempresarioLogic();
            cargaInicial();
        }

        #region handdlers
        private void limparForm()
        {
            tbNombreEmpresario.Text = string.Empty;
            tbApellidos.Text = string.Empty;
            tbCedula.Text = string.Empty;
            tbTelefono.Text = string.Empty;
            tbEmail.Text = string.Empty;
            rbNo.Checked = true;
            dtpUltFechaAtencion.Value = DateTime.Now;
            tbNombreEmprendimiento.Text = string.Empty;
            nudCantidadColaboradores.Value = 0;
            //cbx actividad
            tbDescripcion.Text = string.Empty;
            //cbx Direccion
            tbOtrasSenas.Text = string.Empty;
        }
        private bool contieneInformacion()
        {
            if (!string.IsNullOrEmpty(tbNombreEmpresario.Text) ||
       !string.IsNullOrEmpty(tbApellidos.Text) ||
       !string.IsNullOrEmpty(tbCedula.Text) ||
       !string.IsNullOrEmpty(tbTelefono.Text) ||
       !string.IsNullOrEmpty(tbEmail.Text) ||
       !string.IsNullOrEmpty(tbNombreEmprendimiento.Text) ||
       nudCantidadColaboradores.Value != 0 ||
       !string.IsNullOrEmpty(tbDescripcion.Text) ||
       !string.IsNullOrEmpty(tbOtrasSenas.Text))
            {
                return true;
            }

            return false;
        }
        private string verificadorCampos()
        {
            String aux = "";
            //Nombre Empresario
            if (string.IsNullOrEmpty(tbNombreEmpresario.Text))
            {
                aux += "El Nombre del emprendedor es obligatorio.\n";
            }
            if (tbNombreEmpresario.Text.Length > 50)
            {
                aux += "El Nombre del emprendedor no puede exceder los 50 caracteres..\n";
            }
            //Apellidos
            if (string.IsNullOrEmpty(tbApellidos.Text))
            {
                aux += "El apellido del emprendedor es obligatorio.\n";
            }
            if (tbApellidos.Text.Length > 50)
            {
                aux += "El apellido del emprendedor posee más de 50 caracteres.\n";
            }
            //cedula
            if (tbCedula.Text.Length > 50)
            {
                aux += "La cédula del emprendedor posee más de 50 caracteres.\n";
            }
            //telefono
            if (tbTelefono.Text.Length > 15)
            {
                aux += "El número de teléfono del emprendedor posee más de 15 caracteres.\n";
            }
            //correo
            if (tbEmail.Text.Length > 50)
            {
                aux += "El correo electronico del emprendedor posee más de 50 caracteres.\n";
            }
            string patronCorreoElectronico = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (tbEmail.Text != string.Empty)
            {
                if (!Regex.IsMatch(tbEmail.Text, patronCorreoElectronico))
                {
                    aux += "El correo electronico del emprendedor posee caracteres no validos.\n";
                }
            }
            //NombreEmprendimineto
            if (string.IsNullOrEmpty(tbNombreEmprendimiento.Text))
            {
                aux += "El Nombre del emprendimiento es obligatorio.\n";
            }
            if (tbNombreEmprendimiento.Text.Length > 50)
            {
                aux += "El Nombre del emprendimiento no puede exceder los 50 caracteres..\n";
            }
            //Cantidad de colaboradores
            if (nudCantidadColaboradores.Value == 0)
            {
                aux += "El número de colaboradores es obligatorio.\n";
            }

            return aux;
        }
        private void cargaInicial()
        {
            cbProvincia.DataSource = _ml.getListaProvincias();
            rbNo.Checked = true;
        }

        private DTOMicroempresario generarDTO()
        {
            DateTime dateTime = new DateTime();
            if (rbNo.Checked)
            {
                dateTime = DateTime.MinValue;
            }
            else
            {
                dateTime = dtpUltFechaAtencion.Value;
            }

            DTOMicroempresario microempresario = new DTOMicroempresario(
                tbNombreEmpresario.Text.Trim(),
                tbApellidos.Text.Trim(),
                tbCedula.Text.Trim(),
                tbTelefono.Text.Trim(),
                tbEmail.Text.Trim(),
                dateTime,
                tbNombreEmprendimiento.Text.Trim(),
                Convert.ToInt32(nudCantidadColaboradores.Value),
                tbDescripcion.Text.Trim(),
                cbProvincia.SelectedValue.ToString(),
                cbCanton.SelectedValue.ToString(),
                cbDistrito.SelectedValue.ToString(),
                tbOtrasSenas.Text.Trim()
                );

            return microempresario;
        }
        #endregion
        #region CheckboxFecha
        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            dtpUltFechaAtencion.Enabled = true;
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            dtpUltFechaAtencion.Enabled = false;
        }
        #endregion


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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(verificadorCampos()))
            {
                MessageBox.Show(_ml.InsertarBDMicroempresario(generarDTO()));
                limparForm();
            }
            else
            {
                MessageBox.Show("El formulario contiene los siguientes errores:\n\n" + verificadorCampos() + "\n\n" + "Por favor corrija los errores para continuar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region cargaDireccion
        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCanton.DataSource = _ml.getListaCantones(cbProvincia.SelectedItem.ToString());
        }

        private void cbCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDistrito.DataSource = _ml.getListaDistritos(cbCanton.SelectedItem.ToString());
        }
        #endregion

    }
}
