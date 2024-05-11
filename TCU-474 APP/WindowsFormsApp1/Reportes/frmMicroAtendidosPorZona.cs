using Datos.Models;
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

namespace WindowsFormsApp1.Reportes
{
    public partial class frmMicroAtendidosPorZona : Form
    {
        private string defaultLb = "Total de Microempresarios Atendidos: ";
        private string infoDist = "Desglose Por el Cantón de: ";
        private readonly ReportLogic _rl;
        public frmMicroAtendidosPorZona()
        {
            InitializeComponent();
            _rl = new ReportLogic();
            cargaInicial();
        }

        private void cargaInicial()
        {
            rbNo.Checked = true;
            cbCanton.DataSource = _rl.getCantones();
           DateTime fechaInicio = DateTime.Now;
            DateTime fechaFin =  DateTime.Now;

            List<DTOMicroAtendZona> data = _rl.GetAtendZona(fechaInicio, fechaFin, "N/A");
            lbTotal.Text = defaultLb + total(data);
            cargaGrafico(data);
            var datosMostrar = data.Select(m => new
            {
                m.Ubicacion,
                m.Cantidad
            }).ToList();

            dgvMicroXZona.Columns["Localidad"].DataPropertyName = "Ubicacion";
            dgvMicroXZona.Columns["CantidadMicro"].DataPropertyName = "Cantidad";
            dgvMicroXZona.DataSource = datosMostrar;
        }
        private int  total(List<DTOMicroAtendZona> data)
        {
            int total = 0;  
            foreach (var item in data)
            {
                total += item.Cantidad;
            }
            return total;
        }

        private void cargaGrafico(List<DTOMicroAtendZona> datos)
        {
            chrMicroLoc.Series.Clear();
            Series serie = new Series("Microempresarios Atendidos Por Zona");
            serie.ChartType = SeriesChartType.Bar;
            foreach (var dato in datos)
            {
                serie.Points.AddXY(dato.Ubicacion, dato.Cantidad);
            }
            chrMicroLoc.Series.Add(serie);
            chrMicroLoc.ChartAreas[0].AxisY.Interval = 1;
            chrMicroLoc.ChartAreas[0].AxisY.IsStartedFromZero = true;
            chrMicroLoc.Update();

        }
        private void cargaGrafico2(List<DTOMicroAtendZona> datos)
        {
            chrInfoDistrito.Series.Clear();
            Series serie = new Series("Microempresarios Atendidos Por Zona");
            serie.ChartType = SeriesChartType.Bar;
            foreach (var dato in datos)
            {
                serie.Points.AddXY(dato.Ubicacion, dato.Cantidad);
            }
            chrInfoDistrito.Series.Add(serie);
            chrInfoDistrito.ChartAreas[0].AxisY.Interval = 1;
            chrInfoDistrito.ChartAreas[0].AxisY.IsStartedFromZero = true;
            chrInfoDistrito.Update();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpDe.Value;
            DateTime fechaFin = dtpHasta.Value;
            string aux = "";

            if (rbSi.Checked)
            {
                aux = cbCanton.SelectedValue.ToString();
            }
            else
            {
                aux = "N/A";
                panelDistrito.Visible = false;
            }

            List<DTOMicroAtendZona> data = _rl.GetAtendZona(fechaInicio, fechaFin, aux);
            cargaGrafico(data);
            lbTotal.Text = defaultLb + total(data);
            var datosMostrar = data.Select(m => new
            {
                m.Ubicacion,
                m.Cantidad
            }).ToList();

            dgvMicroXZona.Columns["Localidad"].DataPropertyName = "Ubicacion";
            dgvMicroXZona.Columns["CantidadMicro"].DataPropertyName = "Cantidad";
            dgvMicroXZona.DataSource = datosMostrar;

            cargarInfoDistrito(fechaInicio, fechaFin, aux);
        }

        private void cargarInfoDistrito(DateTime fechaInicio, DateTime fechaFin , string aux)
        {
            if (rbSi.Checked)
            {
                lbTotal.Visible = false;
                lbAnuncio.Text = infoDist + aux;
                List<DTOMicroAtendZona> data = _rl.GetAtendZonaDist(fechaInicio, fechaFin, aux);
                cargaGrafico2(data);
                lbTotal2.Text = defaultLb + total(data);
                var datosMostrar = data.Select(m => new
                {
                    m.Ubicacion,
                    m.Cantidad
                }).ToList();

                dgvMicroDist.Columns["Distrito"].DataPropertyName = "Ubicacion";
                dgvMicroDist.Columns["CantidadDis"].DataPropertyName = "Cantidad";
                dgvMicroDist.DataSource = datosMostrar;

                panelDistrito.Visible = true;
            }
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
           cbCanton.SelectedIndex = 0;
            rbNo.Checked = true;
            panelDistrito.Visible = false;
            lbTotal.Visible = true;
            string aux = "N/A";
            

            List<DTOMicroAtendZona> data = _rl.GetAtendZona(dtpDe.Value, dtpHasta.Value, aux);
            cargaGrafico(data);
            lbTotal.Text = defaultLb + total(data);
            var datosMostrar = data.Select(m => new
            {
                m.Ubicacion,
                m.Cantidad
            }).ToList();

            dgvMicroXZona.Columns["Localidad"].DataPropertyName = "Ubicacion";
            dgvMicroXZona.Columns["CantidadMicro"].DataPropertyName = "Cantidad";
            dgvMicroXZona.DataSource = datosMostrar;
        }
    }
}
