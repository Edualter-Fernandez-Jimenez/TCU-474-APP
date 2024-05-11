using Datos.Models;
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
    public partial class frmAgregarAreaInteres : Form
    {
        private readonly ProyectoLogic _pl;
        public frmAgregarAreaInteres()
        {
            this._pl = new ProyectoLogic();
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            tbNombreArea.Text = string.Empty;
        }

        private void btnAgregarArea_Click(object sender, EventArgs e)
        {
            bool existe = false;
            List<string> aux = _pl.listaAreasInteresString();
            foreach (string item in aux)
            {
                if (item == tbNombreArea.Text.Trim())
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                if (tbNombreArea.Text.Trim() != "")
                {
                    AreaInteres areaInteres = new AreaInteres(
                        0,
                        tbNombreArea.Text.Trim()
                        );
                    if (_pl.InsertarBDAreInteres(areaInteres))
                    {
                        MessageBox.Show("Se insertó una nueva Area de Interés.\nAhora el Area de Interés se encuentra disponible en el selector de Areas de Interés", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbNombreArea.Text= string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("ERROR\nNo se pudo insertar la nueva Area de Interés", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR\nEl nombreadd de el Area de Interés ya se encuentra registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
