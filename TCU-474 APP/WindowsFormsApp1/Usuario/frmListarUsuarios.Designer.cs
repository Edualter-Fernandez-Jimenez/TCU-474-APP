namespace WindowsFormsApp1.Usuario
{
    partial class frmListarUsuarios
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAgregarProyecto = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEstadoholder = new System.Windows.Forms.TextBox();
            this.tbCarreraholder = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCarneholer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbApellidosholder = new System.Windows.Forms.TextBox();
            this.tbNombreholder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCarne = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbNombreEmpresario = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiarFormulario = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.CarnetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarreraUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
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
            this.panel1.TabIndex = 2;
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
            this.lblAgregarProyecto.Location = new System.Drawing.Point(293, 13);
            this.lblAgregarProyecto.Name = "lblAgregarProyecto";
            this.lblAgregarProyecto.Size = new System.Drawing.Size(185, 26);
            this.lblAgregarProyecto.TabIndex = 1;
            this.lblAgregarProyecto.Text = "Lista Estudiantes";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.tbEstadoholder);
            this.panel3.Controls.Add(this.tbCarreraholder);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnRefrescar);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbCarneholer);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tbApellidosholder);
            this.panel3.Controls.Add(this.tbNombreholder);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.tbCarne);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbApellidos);
            this.panel3.Controls.Add(this.tbNombreEmpresario);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.btnLimpiarFormulario);
            this.panel3.Controls.Add(this.btnModificar);
            this.panel3.Controls.Add(this.dgvUsuarios);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 845);
            this.panel3.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(370, 674);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 23);
            this.label10.TabIndex = 90;
            this.label10.Text = "Estado";
            // 
            // tbEstadoholder
            // 
            this.tbEstadoholder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEstadoholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbEstadoholder.Enabled = false;
            this.tbEstadoholder.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEstadoholder.ForeColor = System.Drawing.Color.Black;
            this.tbEstadoholder.Location = new System.Drawing.Point(484, 671);
            this.tbEstadoholder.Name = "tbEstadoholder";
            this.tbEstadoholder.Size = new System.Drawing.Size(229, 30);
            this.tbEstadoholder.TabIndex = 89;
            // 
            // tbCarreraholder
            // 
            this.tbCarreraholder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCarreraholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbCarreraholder.Enabled = false;
            this.tbCarreraholder.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCarreraholder.ForeColor = System.Drawing.Color.Black;
            this.tbCarreraholder.Location = new System.Drawing.Point(124, 723);
            this.tbCarreraholder.Name = "tbCarreraholder";
            this.tbCarreraholder.Size = new System.Drawing.Size(341, 30);
            this.tbCarreraholder.TabIndex = 88;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(26, 726);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 23);
            this.label9.TabIndex = 87;
            this.label9.Text = "Carrera";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Location = new System.Drawing.Point(382, 768);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(138, 38);
            this.btnRefrescar.TabIndex = 86;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 674);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 85;
            this.label6.Text = "Carne";
            // 
            // tbCarneholer
            // 
            this.tbCarneholer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCarneholer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbCarneholer.Enabled = false;
            this.tbCarneholer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCarneholer.ForeColor = System.Drawing.Color.Black;
            this.tbCarneholer.Location = new System.Drawing.Point(124, 671);
            this.tbCarneholer.Name = "tbCarneholer";
            this.tbCarneholer.Size = new System.Drawing.Size(126, 30);
            this.tbCarneholer.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(370, 614);
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
            this.tbApellidosholder.Location = new System.Drawing.Point(484, 611);
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
            this.tbNombreholder.Location = new System.Drawing.Point(124, 611);
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
            this.label8.Location = new System.Drawing.Point(26, 614);
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
            this.label11.Location = new System.Drawing.Point(34, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 23);
            this.label11.TabIndex = 79;
            this.label11.Text = "Carne";
            // 
            // tbCarne
            // 
            this.tbCarne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCarne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbCarne.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCarne.ForeColor = System.Drawing.Color.Black;
            this.tbCarne.Location = new System.Drawing.Point(132, 145);
            this.tbCarne.Name = "tbCarne";
            this.tbCarne.Size = new System.Drawing.Size(205, 30);
            this.tbCarne.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(378, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 77;
            this.label5.Text = "Apellido";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbApellidos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidos.ForeColor = System.Drawing.Color.Black;
            this.tbApellidos.Location = new System.Drawing.Point(492, 85);
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
            this.tbNombreEmpresario.Location = new System.Drawing.Point(132, 85);
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
            this.btnBuscar.Location = new System.Drawing.Point(372, 141);
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
            this.btnLimpiarFormulario.Location = new System.Drawing.Point(533, 141);
            this.btnLimpiarFormulario.Name = "btnLimpiarFormulario";
            this.btnLimpiarFormulario.Size = new System.Drawing.Size(188, 38);
            this.btnLimpiarFormulario.TabIndex = 73;
            this.btnLimpiarFormulario.Text = "Limpiar Formulario";
            this.btnLimpiarFormulario.UseVisualStyleBackColor = false;
            this.btnLimpiarFormulario.Click += new System.EventHandler(this.btnLimpiarFormulario_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(557, 768);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 38);
            this.btnModificar.TabIndex = 72;
            this.btnModificar.Text = "Consultar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarnetId,
            this.NombreUsuario,
            this.ApellidoUsuario,
            this.CarreraUsuario,
            this.EstadoUsuario});
            this.dgvUsuarios.Location = new System.Drawing.Point(33, 306);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(672, 283);
            this.dgvUsuarios.TabIndex = 71;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // CarnetId
            // 
            this.CarnetId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarnetId.HeaderText = "Carnet";
            this.CarnetId.MinimumWidth = 6;
            this.CarnetId.Name = "CarnetId";
            this.CarnetId.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreUsuario.HeaderText = "Nombre";
            this.NombreUsuario.MinimumWidth = 6;
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            // 
            // ApellidoUsuario
            // 
            this.ApellidoUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ApellidoUsuario.HeaderText = "Apellido";
            this.ApellidoUsuario.MinimumWidth = 6;
            this.ApellidoUsuario.Name = "ApellidoUsuario";
            this.ApellidoUsuario.ReadOnly = true;
            // 
            // CarreraUsuario
            // 
            this.CarreraUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarreraUsuario.HeaderText = "Carrera";
            this.CarreraUsuario.MinimumWidth = 6;
            this.CarreraUsuario.Name = "CarreraUsuario";
            this.CarreraUsuario.ReadOnly = true;
            // 
            // EstadoUsuario
            // 
            this.EstadoUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EstadoUsuario.HeaderText = "Estado";
            this.EstadoUsuario.MinimumWidth = 6;
            this.EstadoUsuario.Name = "EstadoUsuario";
            this.EstadoUsuario.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(465, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Por favor, seleccione uno de los usuarios de la lista:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(15, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "Informacón de Estudiantes";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 88);
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
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Informacón del Estudiante";
            // 
            // frmListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 580);
            this.Controls.Add(this.panel1);
            this.Name = "frmListarUsuarios";
            this.Text = "frmListarUsuarios";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAgregarProyecto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEstadoholder;
        private System.Windows.Forms.TextBox tbCarreraholder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCarneholer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbApellidosholder;
        private System.Windows.Forms.TextBox tbNombreholder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCarne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbNombreEmpresario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiarFormulario;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarnetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarreraUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}