using Datos.Models;
using Logica.MicroempresarioLogic;
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

namespace UCR_TCU_474.Proyecto.AreasInteres
{
    public partial class frmGestionarAreasInteres : Form
    {
        private readonly ProyectoLogic _pl;
        AreaInteres actividadSeleccionada = null;
        string nombreActividadAntiguo = "";
        public frmGestionarAreasInteres()
        {
            InitializeComponent();
            _pl = new ProyectoLogic();
            dgvActividades.Columns["IdAreaInteres"].DataPropertyName = "IdAreaInteres";
            dgvActividades.Columns["Nombre"].DataPropertyName = "Nombre";
            dgvActividades.DataSource = _pl.getListaAreaInteresObj();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (tbNombreArea.Text != string.Empty)
            {
                DialogResult resultado = MessageBox.Show("Te encuentras modificando una actividad\n\n" + "¿Estás seguro de que deseas salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            tbNombreArea.Text = string.Empty;
            actividadSeleccionada = null;
            nombreActividadAntiguo = "";
        }

        private void dgvActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvActividades.Rows[e.RowIndex];
                int idActividad = (int)selectedRow.Cells["IdAreaInteres"].Value;
                string nombreActividad = (string)selectedRow.Cells["Nombre"].Value;
                nombreActividadAntiguo = nombreActividad;

                actividadSeleccionada = new AreaInteres
                (
                    idActividad,
                    nombreActividad
                );

                tbNombreArea.Text = actividadSeleccionada.Nombre;
            }
        }

        private void btnModificarActividad_Click(object sender, EventArgs e)
        {
            if (actividadSeleccionada != null)
            {
                actividadSeleccionada.Nombre = tbNombreArea.Text.Trim();
                if (tbNombreArea.Text != string.Empty)
                {
                    DialogResult resultado = MessageBox.Show("Estas por modificar el nombreadd de la actividad\n" + nombreActividadAntiguo + " por " + actividadSeleccionada.Nombre + "\n" + "¿Quieres continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        if (_pl.modificarAreaInteres(actividadSeleccionada))
                        {
                            MessageBox.Show("Se actualizó actividad seleccionada", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbNombreArea.Text = string.Empty;
                            actividadSeleccionada = null;
                            nombreActividadAntiguo = "";

                            dgvActividades.Columns["IdAreaInteres"].DataPropertyName = "IdAreaInteres";
                            dgvActividades.Columns["Nombre"].DataPropertyName = "Nombre";
                            dgvActividades.DataSource = _pl.getListaAreaInteresObj();
                            dgvActividades.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("ERROR\nNo se pudo actualizar la actividad seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    actividadSeleccionada = null;
                    nombreActividadAntiguo = "";
                }
            }
            else
            {
                MessageBox.Show("ERROR\nDebe seleccionar la actividad por modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
