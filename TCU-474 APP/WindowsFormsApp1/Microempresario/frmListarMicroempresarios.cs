using Datos.DTO;
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
    public partial class frmListarMicroempresarios : Form
    {
        private readonly MicroempresarioLogic _ml;
        string nombre;
        string apellidos;
        string nombreEmprendimiento;
        int idMicroempresario;

        public frmListarMicroempresarios()
        {
            InitializeComponent();
            _ml = new MicroempresarioLogic();
            dgvMicroempresarios.Columns["Id_Microempresario"].DataPropertyName = "IdMicroempresario";
            dgvMicroempresarios.Columns["Cedula"].DataPropertyName = "Cedula";
            dgvMicroempresarios.Columns["NombreMicroempresario"].DataPropertyName = "NombreMicroempresario";
            dgvMicroempresarios.Columns["ApellidoMicroempresario"].DataPropertyName = "ApellidoMicroempresario";
            dgvMicroempresarios.Columns["NombreE"].DataPropertyName = "NombreEmprendimiento";
            dgvMicroempresarios.Columns["Canton"].DataPropertyName = "Canton";
            dgvMicroempresarios.Columns["Distrito"].DataPropertyName = "Distrito";
            dgvMicroempresarios.DataSource = datasourceHanddler();
        }
        private IEnumerable<dynamic> datasourceHanddler()
        {
            var datosMostrar = _ml.getAllMicroempresarios().Select(m => new
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            tbApellidos.Text = string.Empty;
            tbNombreEmprendimiento.Text = string.Empty;
            tbNombreEmpresario.Text = string.Empty;
            tbDistrito.Text = string.Empty;

            tbEmprendimientoholer.Text = string.Empty;
            tbNombreholder.Text = string.Empty;
            tbApellidosholder.Text = string.Empty;

            apellidos = string.Empty;
            nombre = string.Empty;
            nombreEmprendimiento = string.Empty;
            idMicroempresario = 0;

            dgvMicroempresarios.Columns["Id_Microempresario"].DataPropertyName = "IdMicroempresario";
            dgvMicroempresarios.Columns["Cedula"].DataPropertyName = "Cedula";
            dgvMicroempresarios.Columns["NombreMicroempresario"].DataPropertyName = "NombreMicroempresario";
            dgvMicroempresarios.Columns["ApellidoMicroempresario"].DataPropertyName = "ApellidoMicroempresario";
            dgvMicroempresarios.Columns["NombreE"].DataPropertyName = "NombreEmprendimiento";
            dgvMicroempresarios.Columns["Canton"].DataPropertyName = "Canton";
            dgvMicroempresarios.Columns["Distrito"].DataPropertyName = "Distrito";
            dgvMicroempresarios.DataSource = datasourceHanddler();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<DTOMicroempresario> listaFiltrada = null;
            if (tbNombreEmpresario.Text != string.Empty)
            {
                listaFiltrada = _ml.getListaMicroempresariosFiltrada("nombre", tbNombreEmpresario.Text);
            }
            else if (tbApellidos.Text != string.Empty)
            {
                listaFiltrada = _ml.getListaMicroempresariosFiltrada("apellido", tbApellidos.Text);

            }
            else if (tbNombreEmprendimiento.Text != string.Empty)
            {
                listaFiltrada = _ml.getListaMicroempresariosFiltrada("nombreemprendimiento", tbNombreEmprendimiento.Text);
            }
            else if (tbDistrito.Text != string.Empty)
            {
                listaFiltrada = _ml.getListaMicroempresariosFiltrada("distrito", tbDistrito.Text);
            }
            else
            {
                listaFiltrada = _ml.getListaMicroempresariosFiltrada("N/A", "N/A");
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

        private void dgvMicroempresarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvMicroempresarios.Rows[e.RowIndex];
                nombre = (string)selectedRow.Cells["NombreMicroempresario"].Value;
                apellidos = (string)selectedRow.Cells["ApellidoMicroempresario"].Value;
                nombreEmprendimiento = (string)selectedRow.Cells["NombreE"].Value;
                idMicroempresario = (int)selectedRow.Cells["Id_Microempresario"].Value;

                tbApellidosholder.Text = apellidos;
                tbNombreholder.Text = nombre;
                tbEmprendimientoholer.Text = nombreEmprendimiento;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (idMicroempresario != 0)
            {
                FrmConsultarUnoMicroempresario frmConsulta = new FrmConsultarUnoMicroempresario(idMicroempresario);
                frmConsulta.Show();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar algun elemento para poder realizar una modificación!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
