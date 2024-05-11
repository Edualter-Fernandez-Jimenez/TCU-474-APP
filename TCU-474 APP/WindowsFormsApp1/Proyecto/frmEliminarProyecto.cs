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
    public partial class frmEliminarProyecto : Form
    {
        private readonly ProyectoLogic _pl;
        string idProyecto;
        string nombre;
        string estado;
        string distrito;
        public frmEliminarProyecto()
        {
            InitializeComponent();
            _pl = new ProyectoLogic();
            dgvProyectos.Columns["IdProyecto2"].DataPropertyName = "idProyecto";
            dgvProyectos.Columns["Nombre2"].DataPropertyName = "nombre";
            dgvProyectos.Columns["Fecha2"].DataPropertyName = "fechaCreacion";
            dgvProyectos.Columns["Estado2"].DataPropertyName = "nombreEstadoProyecto";
            dgvProyectos.Columns["Canton2"].DataPropertyName = "canton";
            dgvProyectos.Columns["Distrito2"].DataPropertyName = "distrito";
            dgvProyectos.DataSource = datasourceHanddler();
        }
        private IEnumerable<dynamic> datasourceHanddler()
        {
            var datosMostrar = _pl.getAllProyctos().Select(m => new
            {
                m.idProyecto,
                m.nombre,
                fechaCreacion = m.fechaCreacion.Date,
                m.nombreEstadoProyecto,
                m.canton,
                m.distrito
            }).ToList();
            return datosMostrar;
        }
        private void refreshandclean()
        {
            tbIdProyecto.Text = string.Empty;
            tbNombre.Text = string.Empty;
            tbDistrito.Text = string.Empty;

            tbNombreholder.Text = string.Empty;
            tbIdProyectoholder.Text = string.Empty;
            tbEstadoholder.Text = string.Empty;
            tbDistritoHolder.Text = string.Empty;

            idProyecto = string.Empty;
            nombre = string.Empty;
            estado = string.Empty;
            distrito = string.Empty;

            dgvProyectos.Columns["IdProyecto2"].DataPropertyName = "idProyecto";
            dgvProyectos.Columns["Nombre2"].DataPropertyName = "nombre";
            dgvProyectos.Columns["Fecha2"].DataPropertyName = "fechaCreacion";
            dgvProyectos.Columns["Estado2"].DataPropertyName = "nombreEstadoProyecto";
            dgvProyectos.Columns["Canton2"].DataPropertyName = "canton";
            dgvProyectos.Columns["Distrito2"].DataPropertyName = "distrito";
            dgvProyectos.DataSource = datasourceHanddler();
        }
        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            refreshandclean();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<DTOProyecto> listaFiltrada = null;
            if (tbIdProyecto.Text != string.Empty)
            {
                listaFiltrada = _pl.getListaProyectosFiltrada("idproyecto", tbIdProyecto.Text);
            }
            else if (tbNombre.Text != string.Empty)
            {
                listaFiltrada = _pl.getListaProyectosFiltrada("nombre", tbNombre.Text);

            }
            else if (tbDistrito.Text != string.Empty)
            {
                listaFiltrada = _pl.getListaProyectosFiltrada("distrito", tbDistrito.Text);
            }
            else
            {
                listaFiltrada = _pl.getListaProyectosFiltrada("N/A", "N/A");
            }
            var datosMostrar = listaFiltrada.Select(m => new
            {
                m.idProyecto,
                m.nombre,
                fechaCreacion = m.fechaCreacion.Date,
                m.nombreEstadoProyecto,
                m.canton,
                m.distrito
            }).ToList();

            dgvProyectos.Columns["IdProyecto2"].DataPropertyName = "idProyecto";
            dgvProyectos.Columns["Nombre2"].DataPropertyName = "nombre";
            dgvProyectos.Columns["Fecha2"].DataPropertyName = "fechaCreacion";
            dgvProyectos.Columns["Estado2"].DataPropertyName = "nombreEstadoProyecto";
            dgvProyectos.Columns["Canton2"].DataPropertyName = "canton";
            dgvProyectos.Columns["Distrito2"].DataPropertyName = "distrito";
            dgvProyectos.DataSource = datosMostrar;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            refreshandclean();
        }

        private void dgvProyectos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvProyectos.Rows[e.RowIndex];
                idProyecto = (string)selectedRow.Cells["IdProyecto2"].Value;
                nombre = (string)selectedRow.Cells["Nombre2"].Value;
                estado = (string)selectedRow.Cells["Estado2"].Value;
                distrito = (string)selectedRow.Cells["Distrito2"].Value;

                tbIdProyectoholder.Text = idProyecto;
                tbNombreholder.Text = nombre;
                tbEstadoholder.Text = estado;
                tbDistritoHolder.Text = distrito;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idProyecto))
            {
                DialogResult resultado = MessageBox.Show("Estas por eliminar un proyecto.\n¿Quieres continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    if (_pl.elimiarProyecto(idProyecto))
                    {
                        MessageBox.Show("Se ha eliminado con éxito el proyecto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshandclean();
                    }
                }
            }
            else
            {
                MessageBox.Show("Se debe seleccionar algun elemento para poder realizar una modificación!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
