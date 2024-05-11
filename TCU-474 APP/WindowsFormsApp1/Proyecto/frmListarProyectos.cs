﻿using Datos.DTO;
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
    public partial class frmListarProyectos : Form
    {
        private readonly ProyectoLogic _pl;
        string idProyecto;
        string nombre;
        string estado;
        string distrito;
        public frmListarProyectos()
        {
            InitializeComponent();
            _pl = new ProyectoLogic();
            dgvProyectos.Columns["IdProyecto1"].DataPropertyName = "idProyecto";
            dgvProyectos.Columns["Nombre1"].DataPropertyName = "nombre";
            dgvProyectos.Columns["Fecha1"].DataPropertyName = "fechaCreacion";
            dgvProyectos.Columns["Estado1"].DataPropertyName = "nombreEstadoProyecto";
            dgvProyectos.Columns["Canton1"].DataPropertyName = "canton";
            dgvProyectos.Columns["Distrito1"].DataPropertyName = "distrito";
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

            dgvProyectos.Columns["IdProyecto1"].DataPropertyName = "idProyecto";
            dgvProyectos.Columns["Nombre1"].DataPropertyName = "nombre";
            dgvProyectos.Columns["Fecha1"].DataPropertyName = "fechaCreacion";
            dgvProyectos.Columns["Estado1"].DataPropertyName = "nombreEstadoProyecto";
            dgvProyectos.Columns["Canton1"].DataPropertyName = "canton";
            dgvProyectos.Columns["Distrito1"].DataPropertyName = "distrito";
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

            dgvProyectos.Columns["IdProyecto1"].DataPropertyName = "idProyecto";
            dgvProyectos.Columns["Nombre1"].DataPropertyName = "nombre";
            dgvProyectos.Columns["Fecha1"].DataPropertyName = "fechaCreacion";
            dgvProyectos.Columns["Estado1"].DataPropertyName = "nombreEstadoProyecto";
            dgvProyectos.Columns["Canton1"].DataPropertyName = "canton";
            dgvProyectos.Columns["Distrito1"].DataPropertyName = "distrito";
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idProyecto))
            {
                frmConsultarUnoProyecto frmConsultar = new frmConsultarUnoProyecto(idProyecto);
                frmConsultar.Show();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar algun elemento para poder realizar una consulta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvProyectos.Rows[e.RowIndex];
                idProyecto = (string)selectedRow.Cells["IdProyecto1"].Value;
                nombre = (string)selectedRow.Cells["Nombre1"].Value;
                estado = (string)selectedRow.Cells["Estado1"].Value;
                distrito = (string)selectedRow.Cells["Distrito1"].Value;

                tbIdProyectoholder.Text = idProyecto;
                tbNombreholder.Text = nombre;
                tbEstadoholder.Text = estado;
                tbDistritoHolder.Text = distrito;
            }
        }
    }
}
