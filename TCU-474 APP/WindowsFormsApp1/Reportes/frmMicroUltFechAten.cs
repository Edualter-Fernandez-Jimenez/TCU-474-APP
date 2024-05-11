using Datos.DTO;
using Logica.MicroempresarioLogic;
using Logica.ReportLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UCR_TCU_474.Reportes
{
    public partial class frmMicroUltFechAten : Form
    {
        private readonly MicroempresarioLogic _ml;
        public frmMicroUltFechAten()
        {
            InitializeComponent();
            _ml = new MicroempresarioLogic();
            dgvMicroempresarios.Columns["NombreMicro"].DataPropertyName = "NombreMicroempresario";
            dgvMicroempresarios.Columns["NombreEmpre"].DataPropertyName = "NombreEmprendimiento";
            dgvMicroempresarios.Columns["Fecha"].DataPropertyName = "UltimaFechaAtencion";
            dgvMicroempresarios.Columns["Telefono"].DataPropertyName = "Telefono";
            dgvMicroempresarios.Columns["Ubicacion"].DataPropertyName = "Ubicacion";
            dgvMicroempresarios.DataSource = DataSourceHandler();
            rbAntiguo.Checked = true;
            cargaGrafico();
        }
        private IEnumerable<dynamic> DataSourceHandler()
        {
            var datosMostrar = _ml.getAllMicroempresarios().Select(m => new
            {
                m.NombreMicroempresario,
                m.NombreEmprendimiento,
                UltimaFechaAtencion = m.UltimaFechaAtencion.ToString("dd/MM/yyyy"),
                m.Telefono,
                Ubicacion = m.Canton + " (" + m.Distrito + ")"
            }).ToList();

            return datosMostrar;
        }

        private IEnumerable<dynamic> ObtenerDatosDelDGV(int orden)
        {
            List<DTOFiltroMicro> datos = new List<DTOFiltroMicro>();

            // Itera a través de las filas del DataGridView
            foreach (DataGridViewRow fila in dgvMicroempresarios.Rows)
            {
                // Crea una instancia de DTOFiltroMicro para almacenar los datos de cada fila
                DTOFiltroMicro filaDatos = new DTOFiltroMicro();

                // Itera a través de las columnas del DataGridView
                foreach (DataGridViewColumn columna in dgvMicroempresarios.Columns)
                {
                    // Obtiene el nombre de la propiedad de la columna correspondiente a DataPropertyName
                    string nombrePropiedad = columna.DataPropertyName;

                    // Asigna el valor de la celda en la fila actual y columna correspondiente al atributo correspondiente en DTOFiltroMicro
                    switch (nombrePropiedad)
                    {
                        case nameof(DTOFiltroMicro.NombreMicroempresario):
                            filaDatos.NombreMicroempresario = (string)fila.Cells[columna.Index].Value;
                            break;
                        case nameof(DTOFiltroMicro.NombreEmprendimiento):
                            filaDatos.NombreEmprendimiento = (string)fila.Cells[columna.Index].Value;
                            break;
                        case nameof(DTOFiltroMicro.UltimaFechaAtencion):
                            string valorCeldaString = fila.Cells[columna.Index].Value?.ToString();
                            DateTime valorFecha;
                            if (DateTime.TryParse(valorCeldaString, out valorFecha))
                            {
                                filaDatos.UltimaFechaAtencion = valorFecha;
                            }
                            else
                            {
                                MessageBox.Show("FF");
                            }
                            break;
                        case nameof(DTOFiltroMicro.Telefono):
                            filaDatos.Telefono = (string)fila.Cells[columna.Index].Value;
                            break;
                        case nameof(DTOFiltroMicro.Ubicacion):
                            filaDatos.Ubicacion = (string)fila.Cells[columna.Index].Value;
                            break;
                    }
                }

                // Agrega la instancia de DTOFiltroMicro que representa una fila de datos a la lista de datos
                datos.Add(filaDatos);
            }
            List<DTOFiltroMicro> datosOrdenados;

            if (orden == 1)
            {
                // Ordenar de más reciente a más antiguo
                datosOrdenados = datos.OrderByDescending(x => x.UltimaFechaAtencion).ToList();
            }
            else
            {
                // Ordenar de más antiguo a más reciente
                datosOrdenados = datos.OrderBy(x => x.UltimaFechaAtencion).ToList();
            }

            var datosMostrar = datosOrdenados.Select(m => new
            {
                m.NombreMicroempresario,
                m.NombreEmprendimiento,
                UltimaFechaAtencion = m.UltimaFechaAtencion.ToString("dd/MM/yyyy"),
                m.Telefono,
                m.Ubicacion
            }).ToList();

            return datosMostrar;
        }

        private void cargaGrafico()
        {
            //la consulta no es la correcta
            ReportLogic _rl = new ReportLogic();
            List<DTOFechasAtencion> datos = _rl.GetFechasAtencion();
            chrMicroLoc.Series.Clear();
            Series serie = new Series("Microempresarios Atendidos Por Año");
            serie.ChartType = SeriesChartType.Column;
            foreach (var dato in datos)
            {
                serie.Points.AddXY(dato.anio, dato.cantidad);
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
            List<DTOMicroempresario> listaFiltrada = null;
            if (tbNombreEmpresario.Text != string.Empty)
            {
                listaFiltrada = _ml.getListaMicroempresariosFiltrada("nombre", tbNombreEmpresario.Text);
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
                m.NombreMicroempresario,
                m.NombreEmprendimiento,
                UltimaFechaAtencion = m.UltimaFechaAtencion.ToString("dd/MM/yyyy"),
                m.Telefono,
                Ubicacion = m.Canton + " (" + m.Distrito + ")"
            }).ToList();

            dgvMicroempresarios.Columns["NombreMicro"].DataPropertyName = "NombreMicroempresario";
            dgvMicroempresarios.Columns["NombreEmpre"].DataPropertyName = "NombreEmprendimiento";
            dgvMicroempresarios.Columns["Fecha"].DataPropertyName = "UltimaFechaAtencion";
            dgvMicroempresarios.Columns["Telefono"].DataPropertyName = "Telefono";
            dgvMicroempresarios.Columns["Ubicacion"].DataPropertyName = "Ubicacion";
            dgvMicroempresarios.DataSource = datosMostrar;
        }

        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            tbNombreEmprendimiento.Text = string.Empty;
            tbNombreEmpresario.Text = string.Empty;
            tbDistrito.Text = string.Empty;

            rbAntiguo.Checked = true;
            dgvMicroempresarios.Columns["NombreMicro"].DataPropertyName = "NombreMicroempresario";
            dgvMicroempresarios.Columns["NombreEmpre"].DataPropertyName = "NombreEmprendimiento";
            dgvMicroempresarios.Columns["Fecha"].DataPropertyName = "UltimaFechaAtencion";
            dgvMicroempresarios.Columns["Telefono"].DataPropertyName = "Telefono";
            dgvMicroempresarios.Columns["Ubicacion"].DataPropertyName = "Ubicacion";
            dgvMicroempresarios.DataSource = DataSourceHandler();
        }

        private void rbReciente_CheckedChanged(object sender, EventArgs e)
        {
            dgvMicroempresarios.Columns["NombreMicro"].DataPropertyName = "NombreMicroempresario";
            dgvMicroempresarios.Columns["NombreEmpre"].DataPropertyName = "NombreEmprendimiento";
            dgvMicroempresarios.Columns["Fecha"].DataPropertyName = "UltimaFechaAtencion";
            dgvMicroempresarios.Columns["Telefono"].DataPropertyName = "Telefono";
            dgvMicroempresarios.Columns["Ubicacion"].DataPropertyName = "Ubicacion";
            dgvMicroempresarios.DataSource = ObtenerDatosDelDGV(1);

        }

        private void rbAntiguo_CheckedChanged(object sender, EventArgs e)
        {
            dgvMicroempresarios.Columns["NombreMicro"].DataPropertyName = "NombreMicroempresario";
            dgvMicroempresarios.Columns["NombreEmpre"].DataPropertyName = "NombreEmprendimiento";
            dgvMicroempresarios.Columns["Fecha"].DataPropertyName = "UltimaFechaAtencion";
            dgvMicroempresarios.Columns["Telefono"].DataPropertyName = "Telefono";
            dgvMicroempresarios.Columns["Ubicacion"].DataPropertyName = "Ubicacion";
            dgvMicroempresarios.DataSource = ObtenerDatosDelDGV(-1);
        }

        private void dgvMicroempresarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DateTime haceSeisMeses = DateTime.Now.AddMonths(-6);
            DateTime haceUnAnio = DateTime.Now.AddYears(-1);

            // Verifica si es la columna que deseas resaltar
            if (dgvMicroempresarios.Columns[e.ColumnIndex].Name == "Fecha")
            {

                // Intenta convertir el valor de la celda a DateTime
                DateTime fecha;
                if (DateTime.TryParse(e.Value?.ToString(), out fecha))
                {
                    // Verifica la condición para cambiar el color
                    if (fecha >= haceSeisMeses && fecha <= DateTime.Now)
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(30, 75, 110);
                    }
                    else if (fecha >= haceUnAnio && fecha <= haceSeisMeses)
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(255, 205, 0);
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    //e.CellStyle.BackColor = Color.FromArgb(255, 0, 0);
                }
            }
        }
    }
}
