namespace UCR_TCU_474.Reportes
{
    partial class frmMicroUltFechAten
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAgregarProyecto = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chrMicroLoc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvMicroempresarios = new System.Windows.Forms.DataGridView();
            this.grpAtencion = new System.Windows.Forms.GroupBox();
            this.rbAntiguo = new System.Windows.Forms.RadioButton();
            this.rbReciente = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiarFormulario = new System.Windows.Forms.Button();
            this.lbanuncio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDistrito = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNombreEmprendimiento = new System.Windows.Forms.TextBox();
            this.tbNombreEmpresario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreMicro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmpre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrMicroLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroempresarios)).BeginInit();
            this.grpAtencion.SuspendLayout();
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
            this.panel1.TabIndex = 4;
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
            this.panel2.TabIndex = 6;
            // 
            // lblAgregarProyecto
            // 
            this.lblAgregarProyecto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgregarProyecto.AutoSize = true;
            this.lblAgregarProyecto.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProyecto.ForeColor = System.Drawing.Color.White;
            this.lblAgregarProyecto.Location = new System.Drawing.Point(81, 13);
            this.lblAgregarProyecto.Name = "lblAgregarProyecto";
            this.lblAgregarProyecto.Size = new System.Drawing.Size(547, 26);
            this.lblAgregarProyecto.TabIndex = 1;
            this.lblAgregarProyecto.Text = "Reporte de Última Fecha Atención Microempresarios";
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
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbDistrito);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.tbNombreEmprendimiento);
            this.panel3.Controls.Add(this.tbNombreEmpresario);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.chrMicroLoc);
            this.panel3.Controls.Add(this.dgvMicroempresarios);
            this.panel3.Controls.Add(this.grpAtencion);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.btnLimpiarFormulario);
            this.panel3.Controls.Add(this.lbanuncio);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 1491);
            this.panel3.TabIndex = 36;
            // 
            // chrMicroLoc
            // 
            this.chrMicroLoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chrMicroLoc.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(175)))), ((int)(((byte)(230)))));
            this.chrMicroLoc.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chrMicroLoc.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrMicroLoc.Legends.Add(legend1);
            this.chrMicroLoc.Location = new System.Drawing.Point(20, 1061);
            this.chrMicroLoc.Name = "chrMicroLoc";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrMicroLoc.Series.Add(series1);
            this.chrMicroLoc.Size = new System.Drawing.Size(692, 384);
            this.chrMicroLoc.TabIndex = 89;
            // 
            // dgvMicroempresarios
            // 
            this.dgvMicroempresarios.AllowUserToAddRows = false;
            this.dgvMicroempresarios.AllowUserToDeleteRows = false;
            this.dgvMicroempresarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMicroempresarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMicroempresarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreMicro,
            this.NombreEmpre,
            this.Fecha,
            this.Telefono,
            this.Ubicacion});
            this.dgvMicroempresarios.Location = new System.Drawing.Point(20, 441);
            this.dgvMicroempresarios.Name = "dgvMicroempresarios";
            this.dgvMicroempresarios.ReadOnly = true;
            this.dgvMicroempresarios.RowHeadersWidth = 51;
            this.dgvMicroempresarios.RowTemplate.Height = 24;
            this.dgvMicroempresarios.Size = new System.Drawing.Size(685, 521);
            this.dgvMicroempresarios.TabIndex = 88;
            this.dgvMicroempresarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMicroempresarios_CellFormatting);
            // 
            // grpAtencion
            // 
            this.grpAtencion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpAtencion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpAtencion.Controls.Add(this.rbAntiguo);
            this.grpAtencion.Controls.Add(this.rbReciente);
            this.grpAtencion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpAtencion.Location = new System.Drawing.Point(324, 186);
            this.grpAtencion.Name = "grpAtencion";
            this.grpAtencion.Size = new System.Drawing.Size(343, 43);
            this.grpAtencion.TabIndex = 83;
            this.grpAtencion.TabStop = false;
            // 
            // rbAntiguo
            // 
            this.rbAntiguo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAntiguo.AutoSize = true;
            this.rbAntiguo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAntiguo.Location = new System.Drawing.Point(191, 10);
            this.rbAntiguo.Name = "rbAntiguo";
            this.rbAntiguo.Size = new System.Drawing.Size(139, 27);
            this.rbAntiguo.TabIndex = 40;
            this.rbAntiguo.TabStop = true;
            this.rbAntiguo.Text = "Más Antiguo";
            this.rbAntiguo.UseVisualStyleBackColor = true;
            this.rbAntiguo.CheckedChanged += new System.EventHandler(this.rbAntiguo_CheckedChanged);
            // 
            // rbReciente
            // 
            this.rbReciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbReciente.AutoSize = true;
            this.rbReciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReciente.Location = new System.Drawing.Point(23, 10);
            this.rbReciente.Name = "rbReciente";
            this.rbReciente.Size = new System.Drawing.Size(152, 27);
            this.rbReciente.TabIndex = 39;
            this.rbReciente.TabStop = true;
            this.rbReciente.Text = "Más Reciente";
            this.rbReciente.UseVisualStyleBackColor = true;
            this.rbReciente.CheckedChanged += new System.EventHandler(this.rbReciente_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(34, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 23);
            this.label9.TabIndex = 82;
            this.label9.Text = "Seleccione la razón de orden:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(38, 248);
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
            this.btnLimpiarFormulario.Location = new System.Drawing.Point(199, 248);
            this.btnLimpiarFormulario.Name = "btnLimpiarFormulario";
            this.btnLimpiarFormulario.Size = new System.Drawing.Size(188, 38);
            this.btnLimpiarFormulario.TabIndex = 73;
            this.btnLimpiarFormulario.Text = "Limpiar Formulario";
            this.btnLimpiarFormulario.UseVisualStyleBackColor = false;
            this.btnLimpiarFormulario.Click += new System.EventHandler(this.btnLimpiarFormulario_Click);
            // 
            // lbanuncio
            // 
            this.lbanuncio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbanuncio.AutoSize = true;
            this.lbanuncio.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbanuncio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.lbanuncio.Location = new System.Drawing.Point(15, 322);
            this.lbanuncio.Name = "lbanuncio";
            this.lbanuncio.Size = new System.Drawing.Size(458, 27);
            this.lbanuncio.TabIndex = 22;
            this.lbanuncio.Text = "Reporte de Microempresarios Atendidos";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(15, 996);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 27);
            this.label3.TabIndex = 90;
            this.label3.Text = "Reporte de Atención Anual";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(376, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 99;
            this.label1.Text = "Distrito";
            // 
            // tbDistrito
            // 
            this.tbDistrito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDistrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbDistrito.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDistrito.ForeColor = System.Drawing.Color.Black;
            this.tbDistrito.Location = new System.Drawing.Point(474, 70);
            this.tbDistrito.Name = "tbDistrito";
            this.tbDistrito.Size = new System.Drawing.Size(205, 30);
            this.tbDistrito.TabIndex = 98;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(35, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(258, 23);
            this.label11.TabIndex = 97;
            this.label11.Text = "Nombre del Emprendimiento";
            // 
            // tbNombreEmprendimiento
            // 
            this.tbNombreEmprendimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombreEmprendimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbNombreEmprendimiento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreEmprendimiento.ForeColor = System.Drawing.Color.Black;
            this.tbNombreEmprendimiento.Location = new System.Drawing.Point(313, 130);
            this.tbNombreEmprendimiento.Name = "tbNombreEmprendimiento";
            this.tbNombreEmprendimiento.Size = new System.Drawing.Size(205, 30);
            this.tbNombreEmprendimiento.TabIndex = 96;
            // 
            // tbNombreEmpresario
            // 
            this.tbNombreEmpresario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombreEmpresario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbNombreEmpresario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreEmpresario.ForeColor = System.Drawing.Color.Black;
            this.tbNombreEmpresario.Location = new System.Drawing.Point(133, 70);
            this.tbNombreEmpresario.Name = "tbNombreEmpresario";
            this.tbNombreEmpresario.Size = new System.Drawing.Size(205, 30);
            this.tbNombreEmpresario.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 92;
            this.label2.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 27);
            this.label4.TabIndex = 91;
            this.label4.Text = "Informacón del Microempresario";
            // 
            // NombreMicro
            // 
            this.NombreMicro.HeaderText = "Nombre Microempresario";
            this.NombreMicro.MinimumWidth = 6;
            this.NombreMicro.Name = "NombreMicro";
            this.NombreMicro.ReadOnly = true;
            this.NombreMicro.Width = 129;
            // 
            // NombreEmpre
            // 
            this.NombreEmpre.HeaderText = "Nombre Emprendimiento";
            this.NombreEmpre.MinimumWidth = 6;
            this.NombreEmpre.Name = "NombreEmpre";
            this.NombreEmpre.ReadOnly = true;
            this.NombreEmpre.Width = 128;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Ult.Fecha Atención";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // Ubicacion
            // 
            this.Ubicacion.HeaderText = "Ubicación";
            this.Ubicacion.MinimumWidth = 6;
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            this.Ubicacion.Width = 125;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(62, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 23);
            this.label5.TabIndex = 100;
            this.label5.Text = "Atendido hace más de un año";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(62, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 23);
            this.label6.TabIndex = 101;
            this.label6.Text = "Atendido hace menos de 6 meses ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(456, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 46);
            this.label7.TabIndex = 102;
            this.label7.Text = "Atendido entre 6 mes \r\ny un año atras";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(39, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 23);
            this.button1.TabIndex = 103;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(39, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 23);
            this.button2.TabIndex = 104;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(429, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(18, 23);
            this.button3.TabIndex = 105;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // frmMicroUltFechAten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 580);
            this.Controls.Add(this.panel1);
            this.Name = "frmMicroUltFechAten";
            this.Text = "Reporte de Última Fecha Atención Microempresarios";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrMicroLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroempresarios)).EndInit();
            this.grpAtencion.ResumeLayout(false);
            this.grpAtencion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAgregarProyecto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrMicroLoc;
        private System.Windows.Forms.DataGridView dgvMicroempresarios;
        private System.Windows.Forms.GroupBox grpAtencion;
        private System.Windows.Forms.RadioButton rbAntiguo;
        private System.Windows.Forms.RadioButton rbReciente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiarFormulario;
        private System.Windows.Forms.Label lbanuncio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDistrito;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNombreEmprendimiento;
        private System.Windows.Forms.TextBox tbNombreEmpresario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMicro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}