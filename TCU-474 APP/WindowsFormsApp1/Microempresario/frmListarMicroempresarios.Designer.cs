namespace WindowsFormsApp1.Microempresario
{
    partial class frmListarMicroempresarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDistrito = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmprendimientoholer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbApellidosholder = new System.Windows.Forms.TextBox();
            this.tbNombreholder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNombreEmprendimiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbNombreEmpresario = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiarFormulario = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvMicroempresarios = new System.Windows.Forms.DataGridView();
            this.Id_Microempresario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMicroempresario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMicroempresario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAgregarProyecto = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroempresarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 580);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.tbDistrito);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbEmprendimientoholer);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tbApellidosholder);
            this.panel3.Controls.Add(this.tbNombreholder);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.tbNombreEmprendimiento);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbApellidos);
            this.panel3.Controls.Add(this.tbNombreEmpresario);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.btnLimpiarFormulario);
            this.panel3.Controls.Add(this.btnConsultar);
            this.panel3.Controls.Add(this.dgvMicroempresarios);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 784);
            this.panel3.TabIndex = 33;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(34, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 23);
            this.label9.TabIndex = 87;
            this.label9.Text = "Distrito";
            // 
            // tbDistrito
            // 
            this.tbDistrito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDistrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbDistrito.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDistrito.ForeColor = System.Drawing.Color.Black;
            this.tbDistrito.Location = new System.Drawing.Point(132, 172);
            this.tbDistrito.Name = "tbDistrito";
            this.tbDistrito.Size = new System.Drawing.Size(205, 30);
            this.tbDistrito.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 685);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 23);
            this.label6.TabIndex = 85;
            this.label6.Text = "Nombre del Emprendimiento";
            // 
            // tbEmprendimientoholer
            // 
            this.tbEmprendimientoholer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmprendimientoholer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbEmprendimientoholer.Enabled = false;
            this.tbEmprendimientoholer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmprendimientoholer.ForeColor = System.Drawing.Color.Black;
            this.tbEmprendimientoholer.Location = new System.Drawing.Point(304, 682);
            this.tbEmprendimientoholer.Name = "tbEmprendimientoholer";
            this.tbEmprendimientoholer.Size = new System.Drawing.Size(205, 30);
            this.tbEmprendimientoholer.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(370, 625);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 23);
            this.label7.TabIndex = 83;
            this.label7.Text = "Apellidos";
            // 
            // tbApellidosholder
            // 
            this.tbApellidosholder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApellidosholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbApellidosholder.Enabled = false;
            this.tbApellidosholder.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidosholder.ForeColor = System.Drawing.Color.Black;
            this.tbApellidosholder.Location = new System.Drawing.Point(484, 622);
            this.tbApellidosholder.Name = "tbApellidosholder";
            this.tbApellidosholder.Size = new System.Drawing.Size(229, 30);
            this.tbApellidosholder.TabIndex = 82;
            // 
            // tbNombreholder
            // 
            this.tbNombreholder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombreholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbNombreholder.Enabled = false;
            this.tbNombreholder.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreholder.ForeColor = System.Drawing.Color.Black;
            this.tbNombreholder.Location = new System.Drawing.Point(124, 622);
            this.tbNombreholder.Name = "tbNombreholder";
            this.tbNombreholder.Size = new System.Drawing.Size(205, 30);
            this.tbNombreholder.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(26, 625);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 23);
            this.label8.TabIndex = 80;
            this.label8.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(34, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(258, 23);
            this.label11.TabIndex = 79;
            this.label11.Text = "Nombre del Emprendimiento";
            // 
            // tbNombreEmprendimiento
            // 
            this.tbNombreEmprendimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombreEmprendimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbNombreEmprendimiento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreEmprendimiento.ForeColor = System.Drawing.Color.Black;
            this.tbNombreEmprendimiento.Location = new System.Drawing.Point(312, 122);
            this.tbNombreEmprendimiento.Name = "tbNombreEmprendimiento";
            this.tbNombreEmprendimiento.Size = new System.Drawing.Size(205, 30);
            this.tbNombreEmprendimiento.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(378, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 77;
            this.label5.Text = "Apellidos";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbApellidos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidos.ForeColor = System.Drawing.Color.Black;
            this.tbApellidos.Location = new System.Drawing.Point(492, 62);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(229, 30);
            this.tbApellidos.TabIndex = 76;
            // 
            // tbNombreEmpresario
            // 
            this.tbNombreEmpresario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombreEmpresario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbNombreEmpresario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreEmpresario.ForeColor = System.Drawing.Color.Black;
            this.tbNombreEmpresario.Location = new System.Drawing.Point(132, 62);
            this.tbNombreEmpresario.Name = "tbNombreEmpresario";
            this.tbNombreEmpresario.Size = new System.Drawing.Size(205, 30);
            this.tbNombreEmpresario.TabIndex = 75;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(557, 118);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(148, 38);
            this.btnBuscar.TabIndex = 74;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiarFormulario
            // 
            this.btnLimpiarFormulario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiarFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnLimpiarFormulario.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFormulario.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFormulario.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFormulario.Location = new System.Drawing.Point(533, 168);
            this.btnLimpiarFormulario.Name = "btnLimpiarFormulario";
            this.btnLimpiarFormulario.Size = new System.Drawing.Size(188, 38);
            this.btnLimpiarFormulario.TabIndex = 73;
            this.btnLimpiarFormulario.Text = "Limpiar Formulario";
            this.btnLimpiarFormulario.UseVisualStyleBackColor = false;
            this.btnLimpiarFormulario.Click += new System.EventHandler(this.btnLimpiarFormulario_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(557, 722);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(148, 38);
            this.btnConsultar.TabIndex = 72;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvMicroempresarios
            // 
            this.dgvMicroempresarios.AllowUserToAddRows = false;
            this.dgvMicroempresarios.AllowUserToDeleteRows = false;
            this.dgvMicroempresarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMicroempresarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMicroempresarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Microempresario,
            this.Cedula,
            this.NombreMicroempresario,
            this.ApellidoMicroempresario,
            this.NombreE,
            this.Canton,
            this.Distrito});
            this.dgvMicroempresarios.Location = new System.Drawing.Point(33, 317);
            this.dgvMicroempresarios.Name = "dgvMicroempresarios";
            this.dgvMicroempresarios.ReadOnly = true;
            this.dgvMicroempresarios.RowHeadersWidth = 51;
            this.dgvMicroempresarios.RowTemplate.Height = 24;
            this.dgvMicroempresarios.Size = new System.Drawing.Size(672, 283);
            this.dgvMicroempresarios.TabIndex = 71;
            this.dgvMicroempresarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMicroempresarios_CellClick);
            // 
            // Id_Microempresario
            // 
            this.Id_Microempresario.HeaderText = "Id Microempresario";
            this.Id_Microempresario.MinimumWidth = 6;
            this.Id_Microempresario.Name = "Id_Microempresario";
            this.Id_Microempresario.ReadOnly = true;
            this.Id_Microempresario.Width = 125;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.MinimumWidth = 6;
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.Width = 125;
            // 
            // NombreMicroempresario
            // 
            this.NombreMicroempresario.HeaderText = "Nombre Microempresario";
            this.NombreMicroempresario.MinimumWidth = 6;
            this.NombreMicroempresario.Name = "NombreMicroempresario";
            this.NombreMicroempresario.ReadOnly = true;
            this.NombreMicroempresario.Width = 125;
            // 
            // ApellidoMicroempresario
            // 
            this.ApellidoMicroempresario.HeaderText = "Apellido Microempresario";
            this.ApellidoMicroempresario.MinimumWidth = 6;
            this.ApellidoMicroempresario.Name = "ApellidoMicroempresario";
            this.ApellidoMicroempresario.ReadOnly = true;
            this.ApellidoMicroempresario.Width = 125;
            // 
            // NombreE
            // 
            this.NombreE.HeaderText = "NombreEmprendimiento";
            this.NombreE.MinimumWidth = 6;
            this.NombreE.Name = "NombreE";
            this.NombreE.ReadOnly = true;
            this.NombreE.Width = 125;
            // 
            // Canton
            // 
            this.Canton.HeaderText = "Canton";
            this.Canton.MinimumWidth = 6;
            this.Canton.Name = "Canton";
            this.Canton.ReadOnly = true;
            this.Canton.Width = 125;
            // 
            // Distrito
            // 
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.MinimumWidth = 6;
            this.Distrito.Name = "Distrito";
            this.Distrito.ReadOnly = true;
            this.Distrito.Width = 125;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(549, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Por favor, seleccione uno de los micromepresarios de la lista:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(15, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "Informacón del Microempresario";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Informacón del Microempresario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(175)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.lblAgregarProyecto);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 55);
            this.panel2.TabIndex = 4;
            // 
            // lblAgregarProyecto
            // 
            this.lblAgregarProyecto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgregarProyecto.AutoSize = true;
            this.lblAgregarProyecto.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProyecto.ForeColor = System.Drawing.Color.White;
            this.lblAgregarProyecto.Location = new System.Drawing.Point(249, 13);
            this.lblAgregarProyecto.Name = "lblAgregarProyecto";
            this.lblAgregarProyecto.Size = new System.Drawing.Size(247, 26);
            this.lblAgregarProyecto.TabIndex = 1;
            this.lblAgregarProyecto.Text = "Listar Microempresario";
            this.lblAgregarProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(692, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(46, 55);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmListarMicroempresarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 580);
            this.Controls.Add(this.panel1);
            this.Name = "frmListarMicroempresarios";
            this.Text = "frmListarMicroempresarios";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroempresarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAgregarProyecto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmprendimientoholer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbApellidosholder;
        private System.Windows.Forms.TextBox tbNombreholder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNombreEmprendimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbNombreEmpresario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiarFormulario;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMicroempresarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Microempresario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMicroempresario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMicroempresario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDistrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
    }
}