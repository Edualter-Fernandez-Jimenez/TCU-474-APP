using Carga_Microempresarios_1.Logic;
using Carga_Microempresarios_1.Models;
using OfficeOpenXml;
using System.IO;
using System.Linq;

namespace Carga_Microempresarios_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del control OpenFileDialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Configurar las propiedades del control OpenFileDialog
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            // Mostrar el cuadro de diálogo para seleccionar archivos
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string filePath = openFileDialog1.FileName;
                Logica l = new Logica();

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                // Lista para almacenar los datos del archivo Excel
                List<DTOMicroempresario> microempresarios = new List<DTOMicroempresario>();

                // Verificar si el archivo existe
                if (File.Exists(filePath))
                {
                    // Leer el archivo Excel
                    using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        // Obtener la hoja de trabajo (worksheet) predeterminada
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                        // Obtener el número de filas y columnas en la hoja de trabajo
                        int rowCount = worksheet.Dimension.Rows;
                        int colCount = worksheet.Dimension.Columns;

                        // Iterar sobre las filas (suponiendo que la primera fila son los encabezados)rowCount
                        for (int row = 2; row <= rowCount; row++) // Comenzamos desde la fila 2 para evitar los encabezados
                        {
                            // Crear un nuevo objeto DTOMicroempresario
                            DTOMicroempresario microempresario = new DTOMicroempresario();

                            // Asignar los valores de las celdas a las propiedades del objeto microempresario
                            microempresario.NombreMicroempresario = l.revisardatos(worksheet.Cells[row, 1].Value?.ToString());
                            microempresario.ApellidoMicroempresario = l.revisardatos(worksheet.Cells[row, 2].Value?.ToString());
                            microempresario.Cedula = l.revisardatos(worksheet.Cells[row, 3].Value?.ToString());
                            microempresario.Telefono = l.revisardatos(worksheet.Cells[row, 4].Value?.ToString());
                            microempresario.CorreoElectronico = l.revisardatos(worksheet.Cells[row, 5].Value?.ToString());
                            microempresario.NombreEmprendimiento = l.revisardatos(worksheet.Cells[row, 6].Value?.ToString());
                            // Convertir el valor de cantidad de colaboradores a entero
                            int cantidadColaboradores;
                            if (int.TryParse(worksheet.Cells[row, 7].Value?.ToString(), out cantidadColaboradores))
                            {
                                microempresario.CantidadColaboradores = cantidadColaboradores;
                            }
                            microempresario.DescripcionEmprendimiento = l.revisardatos(worksheet.Cells[row, 8].Value?.ToString());
                            microempresario.Provincia = l.revisardatos(worksheet.Cells[row, 9].Value?.ToString());
                            microempresario.Canton = l.revisardatos(worksheet.Cells[row, 10].Value?.ToString());
                            microempresario.Distrito = l.revisardatos(worksheet.Cells[row, 11].Value?.ToString());
                            microempresario.OtrasSenas = l.revisardatos(worksheet.Cells[row, 12].Value?.ToString());
                            microempresario.UltimaFechaAtencion = DateTime.MinValue;

                            // Agregar el objeto microempresario a la lista
                            microempresarios.Add(microempresario);
                            if (!microempresarios.Any(m => m.NombreMicroempresario == microempresario.NombreMicroempresario))
                            {
                                textBox2.AppendText("ERROR AL INSERTAR A: " + microempresario.NombreMicroempresario + Environment.NewLine);
                            }
                        }
                    }
                }

                if (microempresarios != null)
                {
                    MicroempresarioLogic ml =  new MicroempresarioLogic();
                    foreach (var micro in microempresarios)
                    {
                        bool aux = ml.InsertarBDMicroempresario(micro);
                        if (aux)
                        {
                            textBox1.AppendText("EXITO AL INSERTAR A: " + micro.NombreMicroempresario + Environment.NewLine);


                        }
                        else
                        {
                            textBox2.AppendText("ERROR AL INSERTAR A: " + micro.NombreMicroempresario + Environment.NewLine);
                        }
                    }
                }

            }
        }
    }
}