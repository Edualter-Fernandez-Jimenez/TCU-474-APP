namespace WindowsFormsApp1.Proyecto
{
    partial class frmConsultarUnoProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarUnoProyecto));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvMicroAsignado = new System.Windows.Forms.DataGridView();
            this.IdMicroAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaMicroAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMicroAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMicroAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmprenAisg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantonAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistritoAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbBuscarDistrito = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnLimpiarFiltroMicro = new System.Windows.Forms.Button();
            this.btnBuscarMicro = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNombreEmprendimiento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbApellidoMicro = new System.Windows.Forms.TextBox();
            this.tbNombreMicro = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvUsuariosAsignados = new System.Windows.Forms.DataGridView();
            this.CarnetAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarreraAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoUsuarioAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.btnLimpiarFiltroUsuario = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCarnet = new System.Windows.Forms.TextBox();
            this.tbNombreEstudiante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbApellidoEstudiante = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.tbOtrasSenas = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbDistrito = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCanton = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbFechaFin = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbFechaInico = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAreaInteres = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbModalidad = new System.Windows.Forms.ComboBox();
            this.Modalidad = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.RichTextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIdProyecto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAgregarProyecto = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroAsignado)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosAsignados)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 1055);
            this.panel2.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvMicroAsignado);
            this.panel6.Controls.Add(this.btnSalir);
            this.panel6.Controls.Add(this.tbBuscarDistrito);
            this.panel6.Controls.Add(this.label25);
            this.panel6.Controls.Add(this.btnLimpiarFiltroMicro);
            this.panel6.Controls.Add(this.btnBuscarMicro);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.tbNombreEmprendimiento);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.tbApellidoMicro);
            this.panel6.Controls.Add(this.tbNombreMicro);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 1756);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(738, 718);
            this.panel6.TabIndex = 36;
            // 
            // dgvMicroAsignado
            // 
            this.dgvMicroAsignado.AllowUserToAddRows = false;
            this.dgvMicroAsignado.AllowUserToDeleteRows = false;
            this.dgvMicroAsignado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMicroAsignado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMicroAsignado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMicroAsig,
            this.CedulaMicroAsig,
            this.NombreMicroAsig,
            this.ApellidoMicroAsig,
            this.NombreEmprenAisg,
            this.CantonAsig,
            this.DistritoAsig});
            this.dgvMicroAsignado.Location = new System.Drawing.Point(33, 247);
            this.dgvMicroAsignado.Name = "dgvMicroAsignado";
            this.dgvMicroAsignado.ReadOnly = true;
            this.dgvMicroAsignado.RowHeadersWidth = 51;
            this.dgvMicroAsignado.RowTemplate.Height = 24;
            this.dgvMicroAsignado.Size = new System.Drawing.Size(672, 365);
            this.dgvMicroAsignado.TabIndex = 112;
            // 
            // IdMicroAsig
            // 
            this.IdMicroAsig.HeaderText = "Id Microempresario";
            this.IdMicroAsig.MinimumWidth = 6;
            this.IdMicroAsig.Name = "IdMicroAsig";
            this.IdMicroAsig.ReadOnly = true;
            this.IdMicroAsig.Width = 125;
            // 
            // CedulaMicroAsig
            // 
            this.CedulaMicroAsig.HeaderText = "Cedula";
            this.CedulaMicroAsig.MinimumWidth = 6;
            this.CedulaMicroAsig.Name = "CedulaMicroAsig";
            this.CedulaMicroAsig.ReadOnly = true;
            this.CedulaMicroAsig.Width = 125;
            // 
            // NombreMicroAsig
            // 
            this.NombreMicroAsig.HeaderText = "Nombre Microempresario";
            this.NombreMicroAsig.MinimumWidth = 6;
            this.NombreMicroAsig.Name = "NombreMicroAsig";
            this.NombreMicroAsig.ReadOnly = true;
            this.NombreMicroAsig.Width = 125;
            // 
            // ApellidoMicroAsig
            // 
            this.ApellidoMicroAsig.HeaderText = "Apellido Microempresario";
            this.ApellidoMicroAsig.MinimumWidth = 6;
            this.ApellidoMicroAsig.Name = "ApellidoMicroAsig";
            this.ApellidoMicroAsig.ReadOnly = true;
            this.ApellidoMicroAsig.Width = 125;
            // 
            // NombreEmprenAisg
            // 
            this.NombreEmprenAisg.HeaderText = "NombreEmprendimiento";
            this.NombreEmprenAisg.MinimumWidth = 6;
            this.NombreEmprenAisg.Name = "NombreEmprenAisg";
            this.NombreEmprenAisg.ReadOnly = true;
            this.NombreEmprenAisg.Width = 125;
            // 
            // CantonAsig
            // 
            this.CantonAsig.HeaderText = "Canton";
            this.CantonAsig.MinimumWidth = 6;
            this.CantonAsig.Name = "CantonAsig";
            this.CantonAsig.ReadOnly = true;
            this.CantonAsig.Width = 125;
            // 
            // DistritoAsig
            // 
            this.DistritoAsig.HeaderText = "Distrito";
            this.DistritoAsig.MinimumWidth = 6;
            this.DistritoAsig.Name = "DistritoAsig";
            this.DistritoAsig.ReadOnly = true;
            this.DistritoAsig.Width = 125;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(562, 642);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 38);
            this.btnSalir.TabIndex = 111;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tbBuscarDistrito
            // 
            this.tbBuscarDistrito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBuscarDistrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbBuscarDistrito.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarDistrito.ForeColor = System.Drawing.Color.Black;
            this.tbBuscarDistrito.Location = new System.Drawing.Point(112, 181);
            this.tbBuscarDistrito.Name = "tbBuscarDistrito";
            this.tbBuscarDistrito.Size = new System.Drawing.Size(277, 30);
            this.tbBuscarDistrito.TabIndex = 110;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 12F);
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(34, 184);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 23);
            this.label25.TabIndex = 109;
            this.label25.Text = "Distrito";
            // 
            // btnLimpiarFiltroMicro
            // 
            this.btnLimpiarFiltroMicro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiarFiltroMicro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnLimpiarFiltroMicro.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltroMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltroMicro.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltroMicro.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltroMicro.Location = new System.Drawing.Point(522, 169);
            this.btnLimpiarFiltroMicro.Name = "btnLimpiarFiltroMicro";
            this.btnLimpiarFiltroMicro.Size = new System.Drawing.Size(188, 38);
            this.btnLimpiarFiltroMicro.TabIndex = 99;
            this.btnLimpiarFiltroMicro.Text = "Limpiar Filtro";
            this.btnLimpiarFiltroMicro.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltroMicro.Click += new System.EventHandler(this.btnLimpiarFiltroMicro_Click);
            // 
            // btnBuscarMicro
            // 
            this.btnBuscarMicro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarMicro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.btnBuscarMicro.FlatAppearance.BorderSize = 0;
            this.btnBuscarMicro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMicro.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMicro.ForeColor = System.Drawing.Color.White;
            this.btnBuscarMicro.Location = new System.Drawing.Point(539, 125);
            this.btnBuscarMicro.Name = "btnBuscarMicro";
            this.btnBuscarMicro.Size = new System.Drawing.Size(148, 38);
            this.btnBuscarMicro.TabIndex = 98;
            this.btnBuscarMicro.Text = "Buscar";
            this.btnBuscarMicro.UseVisualStyleBackColor = false;
            this.btnBuscarMicro.Click += new System.EventHandler(this.btnBuscarMicro_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(29, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 23);
            this.label9.TabIndex = 96;
            this.label9.Text = "Nombre del Emprendimiento";
            // 
            // tbNombreEmprendimiento
            // 
            this.tbNombreEmprendimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombreEmprendimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbNombreEmprendimiento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreEmprendimiento.ForeColor = System.Drawing.Color.Black;
            this.tbNombreEmprendimiento.Location = new System.Drawing.Point(307, 129);
            this.tbNombreEmprendimiento.Name = "tbNombreEmprendimiento";
            this.tbNombreEmprendimiento.Size = new System.Drawing.Size(205, 30);
            this.tbNombreEmprendimiento.TabIndex = 95;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(373, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 23);
            this.label12.TabIndex = 94;
            this.label12.Text = "Apellidos";
            // 
            // tbApellidoMicro
            // 
            this.tbApellidoMicro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApellidoMicro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbApellidoMicro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidoMicro.ForeColor = System.Drawing.Color.Black;
            this.tbApellidoMicro.Location = new System.Drawing.Point(487, 69);
            this.tbApellidoMicro.Name = "tbApellidoMicro";
            this.tbApellidoMicro.Size = new System.Drawing.Size(229, 30);
            this.tbApellidoMicro.TabIndex = 93;
            // 
            // tbNombreMicro
            // 
            this.tbNombreMicro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombreMicro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbNombreMicro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreMicro.ForeColor = System.Drawing.Color.Black;
            this.tbNombreMicro.Location = new System.Drawing.Point(127, 69);
            this.tbNombreMicro.Name = "tbNombreMicro";
            this.tbNombreMicro.Size = new System.Drawing.Size(205, 30);
            this.tbNombreMicro.TabIndex = 92;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(29, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 23);
            this.label19.TabIndex = 91;
            this.label19.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.label10.Location = new System.Drawing.Point(24, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(378, 27);
            this.label10.TabIndex = 69;
            this.label10.Text = "Asignación de Microempresarios";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvUsuariosAsignados);
            this.panel4.Controls.Add(this.btnBuscarUsuario);
            this.panel4.Controls.Add(this.btnLimpiarFiltroUsuario);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.tbCarnet);
            this.panel4.Controls.Add(this.tbNombreEstudiante);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.tbApellidoEstudiante);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 1143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(738, 613);
            this.panel4.TabIndex = 35;
            // 
            // dgvUsuariosAsignados
            // 
            this.dgvUsuariosAsignados.AllowUserToAddRows = false;
            this.dgvUsuariosAsignados.AllowUserToDeleteRows = false;
            this.dgvUsuariosAsignados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUsuariosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosAsignados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarnetAsig,
            this.NombreAsig,
            this.ApellidoAsig,
            this.CarreraAsig,
            this.EstadoUsuarioAsig});
            this.dgvUsuariosAsignados.Location = new System.Drawing.Point(29, 186);
            this.dgvUsuariosAsignados.Name = "dgvUsuariosAsignados";
            this.dgvUsuariosAsignados.ReadOnly = true;
            this.dgvUsuariosAsignados.RowHeadersWidth = 51;
            this.dgvUsuariosAsignados.RowTemplate.Height = 24;
            this.dgvUsuariosAsignados.Size = new System.Drawing.Size(672, 365);
            this.dgvUsuariosAsignados.TabIndex = 91;
            // 
            // CarnetAsig
            // 
            this.CarnetAsig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarnetAsig.HeaderText = "Carnet";
            this.CarnetAsig.MinimumWidth = 6;
            this.CarnetAsig.Name = "CarnetAsig";
            this.CarnetAsig.ReadOnly = true;
            // 
            // NombreAsig
            // 
            this.NombreAsig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreAsig.HeaderText = "Nombre";
            this.NombreAsig.MinimumWidth = 6;
            this.NombreAsig.Name = "NombreAsig";
            this.NombreAsig.ReadOnly = true;
            // 
            // ApellidoAsig
            // 
            this.ApellidoAsig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ApellidoAsig.HeaderText = "Apellido";
            this.ApellidoAsig.MinimumWidth = 6;
            this.ApellidoAsig.Name = "ApellidoAsig";
            this.ApellidoAsig.ReadOnly = true;
            // 
            // CarreraAsig
            // 
            this.CarreraAsig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarreraAsig.HeaderText = "Carrera";
            this.CarreraAsig.MinimumWidth = 6;
            this.CarreraAsig.Name = "CarreraAsig";
            this.CarreraAsig.ReadOnly = true;
            // 
            // EstadoUsuarioAsig
            // 
            this.EstadoUsuarioAsig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EstadoUsuarioAsig.HeaderText = "Estado";
            this.EstadoUsuarioAsig.MinimumWidth = 6;
            this.EstadoUsuarioAsig.Name = "EstadoUsuarioAsig";
            this.EstadoUsuarioAsig.ReadOnly = true;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.btnBuscarUsuario.FlatAppearance.BorderSize = 0;
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(378, 130);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(148, 38);
            this.btnBuscarUsuario.TabIndex = 88;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // btnLimpiarFiltroUsuario
            // 
            this.btnLimpiarFiltroUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiarFiltroUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnLimpiarFiltroUsuario.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltroUsuario.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltroUsuario.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltroUsuario.Location = new System.Drawing.Point(539, 130);
            this.btnLimpiarFiltroUsuario.Name = "btnLimpiarFiltroUsuario";
            this.btnLimpiarFiltroUsuario.Size = new System.Drawing.Size(188, 38);
            this.btnLimpiarFiltroUsuario.TabIndex = 87;
            this.btnLimpiarFiltroUsuario.Text = "Limpiar Filtro";
            this.btnLimpiarFiltroUsuario.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltroUsuario.Click += new System.EventHandler(this.btnLimpiarFiltroUsuario_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(40, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 23);
            this.label11.TabIndex = 85;
            this.label11.Text = "Carnet";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.label7.Location = new System.Drawing.Point(24, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 27);
            this.label7.TabIndex = 69;
            this.label7.Text = "Asignación de Estudiantes";
            // 
            // tbCarnet
            // 
            this.tbCarnet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCarnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbCarnet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCarnet.ForeColor = System.Drawing.Color.Black;
            this.tbCarnet.Location = new System.Drawing.Point(138, 134);
            this.tbCarnet.Name = "tbCarnet";
            this.tbCarnet.Size = new System.Drawing.Size(205, 30);
            this.tbCarnet.TabIndex = 84;
            // 
            // tbNombreEstudiante
            // 
            this.tbNombreEstudiante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombreEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbNombreEstudiante.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreEstudiante.ForeColor = System.Drawing.Color.Black;
            this.tbNombreEstudiante.Location = new System.Drawing.Point(138, 74);
            this.tbNombreEstudiante.Name = "tbNombreEstudiante";
            this.tbNombreEstudiante.Size = new System.Drawing.Size(205, 30);
            this.tbNombreEstudiante.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(384, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 83;
            this.label6.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(40, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 23);
            this.label8.TabIndex = 80;
            this.label8.Text = "Nombre";
            // 
            // tbApellidoEstudiante
            // 
            this.tbApellidoEstudiante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApellidoEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbApellidoEstudiante.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidoEstudiante.ForeColor = System.Drawing.Color.Black;
            this.tbApellidoEstudiante.Location = new System.Drawing.Point(481, 74);
            this.tbApellidoEstudiante.Name = "tbApellidoEstudiante";
            this.tbApellidoEstudiante.Size = new System.Drawing.Size(229, 30);
            this.tbApellidoEstudiante.TabIndex = 82;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.tbOtrasSenas);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.cbDistrito);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.cbCanton);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.cbProvincia);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 751);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(738, 392);
            this.panel5.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(51, 227);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 23);
            this.label18.TabIndex = 71;
            this.label18.Text = "Otras Señas:";
            // 
            // tbOtrasSenas
            // 
            this.tbOtrasSenas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbOtrasSenas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbOtrasSenas.Enabled = false;
            this.tbOtrasSenas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOtrasSenas.Location = new System.Drawing.Point(42, 268);
            this.tbOtrasSenas.Name = "tbOtrasSenas";
            this.tbOtrasSenas.Size = new System.Drawing.Size(672, 96);
            this.tbOtrasSenas.TabIndex = 70;
            this.tbOtrasSenas.Text = "";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.label17.Location = new System.Drawing.Point(24, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 27);
            this.label17.TabIndex = 69;
            this.label17.Text = "Dirección";
            // 
            // cbDistrito
            // 
            this.cbDistrito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDistrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistrito.Enabled = false;
            this.cbDistrito.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDistrito.FormattingEnabled = true;
            this.cbDistrito.Location = new System.Drawing.Point(138, 159);
            this.cbDistrito.Name = "cbDistrito";
            this.cbDistrito.Size = new System.Drawing.Size(221, 31);
            this.cbDistrito.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(43, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 65;
            this.label5.Text = "Distrito";
            // 
            // cbCanton
            // 
            this.cbCanton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCanton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cbCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCanton.Enabled = false;
            this.cbCanton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCanton.FormattingEnabled = true;
            this.cbCanton.Location = new System.Drawing.Point(468, 82);
            this.cbCanton.Name = "cbCanton";
            this.cbCanton.Size = new System.Drawing.Size(221, 31);
            this.cbCanton.TabIndex = 64;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(390, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 23);
            this.label15.TabIndex = 63;
            this.label15.Text = "Cantón";
            // 
            // cbProvincia
            // 
            this.cbProvincia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.Enabled = false;
            this.cbProvincia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(138, 82);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(221, 31);
            this.cbProvincia.TabIndex = 62;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(43, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 23);
            this.label14.TabIndex = 61;
            this.label14.Text = "Provincia";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbFechaFin);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.tbFechaInico);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.cbEstado);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbAreaInteres);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.cbModalidad);
            this.panel3.Controls.Add(this.Modalidad);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.tbDescripcion);
            this.panel3.Controls.Add(this.tbNombre);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbIdProyecto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 696);
            this.panel3.TabIndex = 33;
            // 
            // tbFechaFin
            // 
            this.tbFechaFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFechaFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbFechaFin.Enabled = false;
            this.tbFechaFin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFechaFin.ForeColor = System.Drawing.Color.Black;
            this.tbFechaFin.Location = new System.Drawing.Point(168, 646);
            this.tbFechaFin.Name = "tbFechaFin";
            this.tbFechaFin.Size = new System.Drawing.Size(313, 30);
            this.tbFechaFin.TabIndex = 76;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(34, 649);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(98, 23);
            this.label21.TabIndex = 75;
            this.label21.Text = "Fecha FIn";
            // 
            // tbFechaInico
            // 
            this.tbFechaInico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFechaInico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbFechaInico.Enabled = false;
            this.tbFechaInico.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFechaInico.ForeColor = System.Drawing.Color.Black;
            this.tbFechaInico.Location = new System.Drawing.Point(168, 591);
            this.tbFechaInico.Name = "tbFechaInico";
            this.tbFechaInico.Size = new System.Drawing.Size(313, 30);
            this.tbFechaInico.TabIndex = 74;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(34, 594);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(115, 23);
            this.label20.TabIndex = 73;
            this.label20.Text = "Fecha Inicio";
            // 
            // cbEstado
            // 
            this.cbEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Enabled = false;
            this.cbEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(168, 528);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(221, 31);
            this.cbEstado.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 71;
            this.label3.Text = "Estado";
            // 
            // cbAreaInteres
            // 
            this.cbAreaInteres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAreaInteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cbAreaInteres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAreaInteres.Enabled = false;
            this.cbAreaInteres.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAreaInteres.FormattingEnabled = true;
            this.cbAreaInteres.Location = new System.Drawing.Point(168, 458);
            this.cbAreaInteres.Name = "cbAreaInteres";
            this.cbAreaInteres.Size = new System.Drawing.Size(221, 31);
            this.cbAreaInteres.TabIndex = 70;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(34, 461);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 23);
            this.label16.TabIndex = 69;
            this.label16.Text = "Area Interés";
            // 
            // cbModalidad
            // 
            this.cbModalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbModalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cbModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModalidad.Enabled = false;
            this.cbModalidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModalidad.FormattingEnabled = true;
            this.cbModalidad.Location = new System.Drawing.Point(168, 381);
            this.cbModalidad.Name = "cbModalidad";
            this.cbModalidad.Size = new System.Drawing.Size(221, 31);
            this.cbModalidad.TabIndex = 68;
            // 
            // Modalidad
            // 
            this.Modalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modalidad.AutoSize = true;
            this.Modalidad.Font = new System.Drawing.Font("Arial", 12F);
            this.Modalidad.ForeColor = System.Drawing.Color.Black;
            this.Modalidad.Location = new System.Drawing.Point(34, 384);
            this.Modalidad.Name = "Modalidad";
            this.Modalidad.Size = new System.Drawing.Size(101, 23);
            this.Modalidad.TabIndex = 67;
            this.Modalidad.Text = "Modalidad";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(34, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(243, 23);
            this.label13.TabIndex = 60;
            this.label13.Text = "Descripcion del Proyecto:*";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbDescripcion.Enabled = false;
            this.tbDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(25, 253);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(672, 96);
            this.tbDescripcion.TabIndex = 59;
            this.tbDescripcion.Text = "";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbNombre.Enabled = false;
            this.tbNombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.ForeColor = System.Drawing.Color.Black;
            this.tbNombre.Location = new System.Drawing.Point(127, 143);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(494, 30);
            this.tbNombre.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nombre*";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Código*";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Informacón del Proyecto";
            // 
            // tbIdProyecto
            // 
            this.tbIdProyecto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIdProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbIdProyecto.Enabled = false;
            this.tbIdProyecto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdProyecto.ForeColor = System.Drawing.Color.Black;
            this.tbIdProyecto.Location = new System.Drawing.Point(127, 70);
            this.tbIdProyecto.Name = "tbIdProyecto";
            this.tbIdProyecto.Size = new System.Drawing.Size(205, 30);
            this.tbIdProyecto.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(175)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.lblAgregarProyecto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 55);
            this.panel1.TabIndex = 1;
            // 
            // lblAgregarProyecto
            // 
            this.lblAgregarProyecto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgregarProyecto.AutoSize = true;
            this.lblAgregarProyecto.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProyecto.ForeColor = System.Drawing.Color.White;
            this.lblAgregarProyecto.Location = new System.Drawing.Point(265, 16);
            this.lblAgregarProyecto.Name = "lblAgregarProyecto";
            this.lblAgregarProyecto.Size = new System.Drawing.Size(198, 26);
            this.lblAgregarProyecto.TabIndex = 1;
            this.lblAgregarProyecto.Text = "Consulta Proyecto";
            this.lblAgregarProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmConsultarUnoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 1055);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarUnoProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Proyecto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroAsignado)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosAsignados)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAgregarProyecto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAreaInteres;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbModalidad;
        private System.Windows.Forms.Label Modalidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdProyecto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox tbOtrasSenas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbDistrito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCanton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnLimpiarFiltroUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCarnet;
        private System.Windows.Forms.TextBox tbNombreEstudiante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbApellidoEstudiante;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbBuscarDistrito;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnLimpiarFiltroMicro;
        private System.Windows.Forms.Button btnBuscarMicro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNombreEmprendimiento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbApellidoMicro;
        private System.Windows.Forms.TextBox tbNombreMicro;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvUsuariosAsignados;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarnetAsig;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAsig;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoAsig;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarreraAsig;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoUsuarioAsig;
        private System.Windows.Forms.DataGridView dgvMicroAsignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMicroAsig;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaMicroAsig;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMicroAsig;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMicroAsig;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmprenAisg;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantonAsig;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistritoAsig;
        private System.Windows.Forms.TextBox tbFechaFin;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbFechaInico;
        private System.Windows.Forms.Label label20;
    }
}