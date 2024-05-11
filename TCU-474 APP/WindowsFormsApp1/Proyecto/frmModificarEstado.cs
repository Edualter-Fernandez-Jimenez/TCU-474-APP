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
    public partial class frmModificarEstado : Form
    {
        private readonly ProyectoLogic _pl;
        string idProyecto;
        string nombre;
        string estado;
        string distrito;
        public frmModificarEstado()
        {
            InitializeComponent();
            _pl = new ProyectoLogic();
            dgvProyectos.Columns["IdProyecto3"].DataPropertyName = "idProyecto";
            dgvProyectos.Columns["Nombre3"].DataPropertyName = "nombre";
            dgvProyectos.Columns["Fecha3"].DataPropertyName = "fechaCreacion";
            dgvProyectos.Columns["Estado3"].DataPropertyName = "nombreEstadoProyecto";
            dgvProyectos.Columns["Canton3"].DataPropertyName = "canton";
            dgvProyectos.Columns["Distrito3"].DataPropertyName = "distrito";
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
            tbDistritoHolder.Text = string.Empty;

            idProyecto = string.Empty;
            nombre = string.Empty;
            estado = string.Empty;
            distrito = string.Empty;

            dgvProyectos.Columns["IdProyecto3"].DataPropertyName = "idProyecto";
            dgvProyectos.Columns["Nombre3"].DataPropertyName = "nombre";
            dgvProyectos.Columns["Fecha3"].DataPropertyName = "fechaCreacion";
            dgvProyectos.Columns["Estado3"].DataPropertyName = "nombreEstadoProyecto";
            dgvProyectos.Columns["Canton3"].DataPropertyName = "canton";
            dgvProyectos.Columns["Distrito3"].DataPropertyName = "distrito";
            dgvProyectos.DataSource = datasourceHanddler();
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

            dgvProyectos.Columns["IdProyecto3"].DataPropertyName = "idProyecto";
            dgvProyectos.Columns["Nombre3"].DataPropertyName = "nombre";
            dgvProyectos.Columns["Fecha3"].DataPropertyName = "fechaCreacion";
            dgvProyectos.Columns["Estado3"].DataPropertyName = "nombreEstadoProyecto";
            dgvProyectos.Columns["Canton3"].DataPropertyName = "canton";
            dgvProyectos.Columns["Distrito3"].DataPropertyName = "distrito";
            dgvProyectos.DataSource = datosMostrar;
        }

        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            refreshandclean();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            refreshandclean();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idProyecto))
            {
                DTOProyecto proyectoUpdated = _pl.getOneProyecto(idProyecto);
                if (proyectoUpdated != null)
                {

                    if (cbEstado.SelectedValue.ToString().Equals("Generado"))
                    {
                        if (proyectoUpdated.fechaIncio != DateTime.MinValue && proyectoUpdated.fechaFin != DateTime.MinValue)
                        {
                            DialogResult resultado = MessageBox.Show("Estas por reiniciar el proyecto.\nSe restableceran la fecha de inicio y de finalizacion.\n¿Quieres continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (resultado == DialogResult.Yes)
                            {
                                proyectoUpdated.fechaIncio = DateTime.MinValue;
                                proyectoUpdated.fechaFin = DateTime.MinValue;
                                proyectoUpdated.nombreEstadoProyecto = cbEstado.SelectedValue.ToString();
                                MessageBox.Show(_pl.UpdateEstado(proyectoUpdated)+ "Generado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                refreshandclean();
                            }
                        }
                        else if (proyectoUpdated.fechaIncio != DateTime.MinValue)
                        {
                            DialogResult resultado = MessageBox.Show("Estas por reiniciar el proyecto.\nSe restableceran la fecha de inicio.\n¿Quieres continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (resultado == DialogResult.Yes)
                            {
                                proyectoUpdated.fechaIncio = DateTime.MinValue;
                                proyectoUpdated.nombreEstadoProyecto = cbEstado.SelectedValue.ToString();
                                MessageBox.Show(_pl.UpdateEstado(proyectoUpdated) + "Generado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                refreshandclean();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El proyecto ya se enucuentra en el estado de Generado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            refreshandclean();
                        }
                    }

                    if (cbEstado.SelectedValue.ToString().Equals("En Ejecución"))
                    {
                        if (proyectoUpdated.fechaIncio == DateTime.MinValue && proyectoUpdated.fechaFin == DateTime.MinValue)
                        {
                            proyectoUpdated.fechaIncio = DateTime.Now;
                            proyectoUpdated.nombreEstadoProyecto = cbEstado.SelectedValue.ToString();
                            MessageBox.Show(_pl.UpdateEstado(proyectoUpdated) + "En Ejecución", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshandclean();
                        }
                        else if (proyectoUpdated.fechaIncio != DateTime.MinValue && proyectoUpdated.fechaFin != DateTime.MinValue)
                        {
                            DialogResult resultado = MessageBox.Show("Estas por reiniciar el proyecto.\nSe restablecera la fecha de finalizacion.\n¿Quieres continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (resultado == DialogResult.Yes)
                            {
                                proyectoUpdated.fechaIncio = DateTime.Now;
                                proyectoUpdated.fechaFin = DateTime.MinValue;
                                proyectoUpdated.nombreEstadoProyecto = cbEstado.SelectedValue.ToString();
                                MessageBox.Show(_pl.UpdateEstado(proyectoUpdated) + "En Ejecución", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                refreshandclean();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El proyecto ya se enucuentra en el estado de En Ejecución", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            refreshandclean();
                        }
                    }

                    if (cbEstado.SelectedValue.ToString().Equals("Finalizado")) {
                        if (proyectoUpdated.fechaIncio == DateTime.MinValue && proyectoUpdated.fechaFin == DateTime.MinValue) {
                            MessageBox.Show("El proyecto debe encontrarse en la fase de En Ejecución para poder ser finalizado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            refreshandclean();
                        }
                        else if (proyectoUpdated.fechaIncio != DateTime.MinValue && proyectoUpdated.fechaFin != DateTime.MinValue)
                        {
                            MessageBox.Show("El proyecto ya se enucuentra en el estado de Finalizado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            refreshandclean();
                        }
                        else
                        {
                            proyectoUpdated.fechaFin = DateTime.Now;
                            proyectoUpdated.nombreEstadoProyecto = cbEstado.SelectedValue.ToString();
                            MessageBox.Show(_pl.UpdateEstado(proyectoUpdated) + "Finalizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshandclean();
                        }
                    }

                }
                cbEstado.DataSource= null;
                cbEstado.Refresh();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar algun elemento para poder realizar una consulta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvProyectos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvProyectos.Rows[e.RowIndex];
                idProyecto = (string)selectedRow.Cells["IdProyecto3"].Value;
                nombre = (string)selectedRow.Cells["Nombre3"].Value;
                estado = (string)selectedRow.Cells["Estado3"].Value;
                distrito = (string)selectedRow.Cells["Distrito3"].Value;
                cbEstado.DataSource = _pl.listaEstadoString();
                cbEstado.Refresh();
                cbEstado.SelectedIndex = cbEstado.Items.IndexOf((string)selectedRow.Cells["Estado3"].Value);

                tbIdProyectoholder.Text = idProyecto;
                tbNombreholder.Text = nombre;
                tbDistritoHolder.Text = distrito;

                if (cbEstado.SelectedValue.ToString().Equals("Finalizado"))
                {
                    cbEstado.Enabled = false;
                    btnModificar.Enabled = false;
                }
                else
                {
                    cbEstado.Enabled = true;
                    btnModificar .Enabled = true;
                }

            }
        }
    }
}
