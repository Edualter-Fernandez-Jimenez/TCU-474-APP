using Datos.DTO;
using Datos.Models;
using Logica.MicroempresarioLogic;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1.Microempresario
{
    public partial class frmModificarMicroempresario : Form
    {
        private readonly MicroempresarioLogic _ml;
        DTOMicroempresario microempresario = null;
        public frmModificarMicroempresario(int idMicroempresario)
        {
            InitializeComponent();
            _ml = new MicroempresarioLogic();
            this.microempresario = _ml.getOneMicroempresario(idMicroempresario);
            cargaInicial();
        }

        private void cargaInicial()
        {
            cbProvincia.DataSource = _ml.getListaProvincias();
            
            tbNombreEmpresario.Text = microempresario.NombreMicroempresario;
            tbApellidos.Text = microempresario.ApellidoMicroempresario;
            tbCedula.Text = microempresario.Cedula;
            tbTelefono.Text = microempresario.Telefono;
            tbEmail.Text = microempresario.CorreoElectronico;
            //if para la fecha
           
            if (microempresario.UltimaFechaAtencion!= DateTime.MinValue)
            {
                dtpUltFechaAtencion.Value = microempresario.UltimaFechaAtencion;
                rbSi.Checked = true;
            }
            else
            {
                rbNo.Checked = true;
            }

            tbNombreEmprendimiento.Text = microempresario.NombreEmprendimiento;
            nudCantidadColaboradores.Value = microempresario.CantidadColaboradores;
            tbDescripcion.Text = microempresario.DescripcionEmprendimiento;
            
            //direccion
            cbProvincia.SelectedIndex = cbProvincia.Items.IndexOf(microempresario.Provincia);

            cbCanton.DataSource = _ml.getListaCantones(cbProvincia.SelectedItem.ToString());
            cbCanton.SelectedIndex = cbCanton.Items.IndexOf(microempresario.Canton);

            cbDistrito.DataSource = _ml.getListaDistritos(cbCanton.SelectedItem.ToString());
            cbDistrito.SelectedIndex = cbDistrito.Items.IndexOf(microempresario.Distrito);

            tbOtrasSenas.Text = microempresario.OtrasSenas;


        }

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

            DTOMicroempresario auxMicroempresario = new DTOMicroempresario(
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
            auxMicroempresario.IdMicroempresario = microempresario.IdMicroempresario;

            return auxMicroempresario;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(verificadorCampos()))
            {
                MessageBox.Show(_ml.ModificarBDMicroempresario(generarDTO()));
                this.Close();
            }
            else
            {
                MessageBox.Show("El formulario contiene los siguientes errores:\n\n" + verificadorCampos() + "\n\n" + "Por favor corrija los errores para continuar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDistrito.DataSource = _ml.getListaDistritos(cbCanton.SelectedItem.ToString());
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCanton.DataSource = _ml.getListaCantones(cbProvincia.SelectedItem.ToString());
        }
    }
}
