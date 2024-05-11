using Datos.DTO;
using Datos.Models;
using Logica.ProyectoLogic;
using Logica.ReportLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace UCR_TCU_474.Reportes
{
    public partial class frmProyectosPorAreaInteres : Form
    {
        private readonly ReportLogic _rl;
        string totaltxt = "Total de proyectos: ";
        public frmProyectosPorAreaInteres()
        {
            InitializeComponent();
            _rl = new ReportLogic();
            cargaInicial();
        }

        private void cargaInicial()
        {
            ProyectoLogic pl =  new ProyectoLogic();
            rbNo.Checked = true;
            cbCanton.DataSource = _rl.getCantones();

            List<string> estadoList = pl.listaEstadoString();
            estadoList.Add("Todo");
            cbEstado.DataSource = estadoList;
            cbEstado.SelectedIndex = cbEstado.Items.IndexOf("Todo"); 

            DateTime fechaInicio = DateTime.Now;
            DateTime fechaFin = DateTime.Now;

            List<DTOProyAreaRepo> data = _rl.GetProyectosRealizados(fechaInicio, fechaFin, "N/A", cbEstado.SelectedValue.ToString());
            cargaGrafico(data);

            var datosMostrar = data.Select(m => new
            {
                m.nombreAreaInteres,
                m.cantidad
            }).ToList();

            dgvMicroXZona.Columns["Area"].DataPropertyName = "nombreAreaInteres";
            dgvMicroXZona.Columns["CantidadPro"].DataPropertyName = "Cantidad";
            dgvMicroXZona.DataSource = datosMostrar;

            lbTotal.Text = totaltxt + datosMostrar.Sum(m => m.cantidad).ToString();
        }


        private void cargaGrafico(List<DTOProyAreaRepo> datos)
        {
            chrMicroLoc.Series.Clear();
            Series serie = new Series("Proyectos Realizados Por Área de Interés");
            serie.ChartType = SeriesChartType.Bar;
            foreach (var dato in datos)
            {
                serie.Points.AddXY(dato.nombreAreaInteres, dato.cantidad);
            }
            chrMicroLoc.Series.Add(serie);
            chrMicroLoc.ChartAreas[0].AxisY.Interval = 1;
            chrMicroLoc.ChartAreas[0].AxisY.IsStartedFromZero = true;
            chrMicroLoc.Update();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpDe.Value;
            DateTime fechaFin = dtpHasta.Value;
            string canton = "";
            lbanuncio.Text = "Reporte de Proyectos por Área de interés";

            if (rbSi.Checked)
            {
                canton = cbCanton.SelectedValue.ToString();
                lbanuncio.Text = lbanuncio.Text+": "+canton;
            }
            else
            {
                canton = "N/A";
                lbanuncio.Text = "Reporte de Proyectos por Área de interés";
            }

            List<DTOProyAreaRepo> data = _rl.GetProyectosRealizados(fechaInicio, fechaFin, canton, cbEstado.SelectedValue.ToString());
            cargaGrafico(data);

            var datosMostrar = data.Select(m => new
            {
                m.nombreAreaInteres,
                m.cantidad
            }).ToList();

            dgvMicroXZona.Columns["Area"].DataPropertyName = "nombreAreaInteres";
            dgvMicroXZona.Columns["CantidadPro"].DataPropertyName = "Cantidad";
            dgvMicroXZona.DataSource = datosMostrar;
            lbTotal.Text = totaltxt + datosMostrar.Sum(m => m.cantidad).ToString();
        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            cbCanton.Enabled = true;
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            cbCanton.Enabled = false;
        }

        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            dtpDe.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now;
            rbNo.Checked = true;
            cbCanton.SelectedIndex = 0;
            cbEstado.SelectedIndex = cbEstado.Items.IndexOf("Todo");
            lbanuncio.Text = "Reporte de Proyectos por Área de interés";

            List<DTOProyAreaRepo> data = _rl.GetProyectosRealizados(dtpDe.Value, dtpHasta.Value, "N/A", cbEstado.SelectedValue.ToString());
            cargaGrafico(data);

            var datosMostrar = data.Select(m => new
            {
                m.nombreAreaInteres,
                m.cantidad
            }).ToList();

            dgvMicroXZona.Columns["Area"].DataPropertyName = "nombreAreaInteres";
            dgvMicroXZona.Columns["CantidadPro"].DataPropertyName = "Cantidad";
            dgvMicroXZona.DataSource = datosMostrar;
            lbTotal.Text = totaltxt + datosMostrar.Sum(m => m.cantidad).ToString();
        }
    }
}
