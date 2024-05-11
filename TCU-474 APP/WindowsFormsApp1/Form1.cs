using Datos.Models;
using Logica.MicroempresarioLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCR_TCU_474.Proyecto.AreasInteres;
using UCR_TCU_474.Reportes;
using WindowsFormsApp1.Microempresario;
using WindowsFormsApp1.Proyecto;
using WindowsFormsApp1.Reportes;
using WindowsFormsApp1.Usuario;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }



        private void customizeDesign()
        {
           panelMediaSubmenu.Visible = false;
           paneMicroempresarioslSubMenu.Visible = false;
           panelProyectoSubmenu.Visible = false;
           panelActividadesSubmenu.Visible = false;
           panelReportesSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false;
            if (paneMicroempresarioslSubMenu.Visible == true)
                paneMicroempresarioslSubMenu.Visible = false;
            if (panelProyectoSubmenu.Visible == true)
                panelProyectoSubmenu.Visible = false;
            if (panelActividadesSubmenu.Visible == true)
                panelActividadesSubmenu.Visible = false;
            if (panelReportesSubmenu.Visible == true)
                panelReportesSubmenu.Visible = false;


        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;

            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {

            if (activeForm != null)
            {

                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        #region Usuarios
        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmNuevoUsuario());
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBuscarModificarUsuario());
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new frmListarUsuarios());
            hideSubMenu();
        }
        #endregion

        #region Proyecto
        private void btnProyectos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProyectoSubmenu);
        }
        #region SubMenuProyecto
        private void btnAgregarProyecto_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAgregarProyecto());
            hideSubMenu();
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            openChildForm(new frmModificarEstado());
            hideSubMenu();
        }

        private void btnModificarProyecto_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBuscarModificarProyecto());
            hideSubMenu();
        }

        private void btnConsultaProyectos_Click(object sender, EventArgs e)
        {
            openChildForm(new frmListarProyectos());
            hideSubMenu();
        }

        private void btnEliminarProyectos_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEliminarProyecto());
            hideSubMenu();
        }
        #endregion

        #endregion

        #region Microempresarios

        private void btnMicroempresarios_Click(object sender, EventArgs e)
        {
            showSubMenu(paneMicroempresarioslSubMenu);
        }

        private void btnAgregarMicroempresario_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAgregarMicroempresario());
            hideSubMenu();
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            showSubMenu(panelActividadesSubmenu);
        }

        private void btnAgregarActividad_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAgregarAreaInteres());
            hideSubMenu();
        }

        private void btnModificarActividad_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGestionarAreasInteres());
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBuscarModificarMicroempresario());
            hideSubMenu();
        }

        private void btnListarMicroempresarios_Click(object sender, EventArgs e)
        {
            openChildForm(new frmListarMicroempresarios());
            hideSubMenu();
        }
        #endregion

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReportesSubmenu);
        }

        private void btnMicroAtendidos_Click(object sender, EventArgs e)
        {
            openChildForm(new frmMicroAtendidosPorZona());
            hideSubMenu();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmProyectosPorAreaInteres());
            hideSubMenu();
        }

        private void btnRepMicroUltFechAten_Click(object sender, EventArgs e)
        {
            openChildForm(new frmMicroUltFechAten());
            hideSubMenu();
        }
    }
}
