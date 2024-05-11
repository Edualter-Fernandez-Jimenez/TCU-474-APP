using Datos.DTO;
using Datos.Models;
using Logica.EstudianteLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Usuario
{
    public partial class frmConsultarUnoUsuario : Form
    {
        private readonly UsuarioLogic _ul;
        public frmConsultarUnoUsuario(string carnet)
        {
            InitializeComponent();
            _ul = new UsuarioLogic();
            cargaInicial(carnet);
        }
        private void cargaInicial(string carne)
        {
            DTOUsuario usuario = _ul.getOneUsuario(carne);
            if (usuario != null)
            {

                tbCarnet.Text = usuario.carnet;
                tbCedula.Text = usuario.cedula;
                tbNombre.Text = usuario.nombre;
                tbApellido.Text = usuario.apellido;
                tbTelefono.Text = usuario.numeroTelefono;
                tbEmail.Text = usuario.correoElectronico;
                tbCarrera.Text = usuario.nombreCarrera;
                tbSede.Text = usuario.nombreSede;
                tbEstado.Text = usuario.nombreEstadoUsuario;
                dtpFechaInicio.Value = usuario.fechaInicio;
                dtpFechaFin.Value = usuario.fechaFin;
            }
            else
            {
                MessageBox.Show("No se puede cargar la Informacion del estudiante", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
