using Datos.DTO;
using Datos.Models;
using Logica.MicroempresarioLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Microempresario
{
    public partial class FrmConsultarUnoMicroempresario : Form
    {
        private readonly MicroempresarioLogic _ml;
        DTOMicroempresario microempresario = null;
        public FrmConsultarUnoMicroempresario(int idMicroempresario)
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

            if (microempresario.UltimaFechaAtencion != DateTime.MinValue)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
