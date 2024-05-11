namespace WindowsFormsApp1.Reportes
{
    partial class frmMicroAtendidosPorZona
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.chrMicroLoc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvMicroXZona = new System.Windows.Forms.DataGridView();
            this.cbCanton = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.grpAtencion = new System.Windows.Forms.GroupBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiarFormulario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAgregarProyecto = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelDistrito = new System.Windows.Forms.Panel();
            this.lbAnuncio = new System.Windows.Forms.Label();
            this.chrInfoDistrito = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvMicroDist = new System.Windows.Forms.DataGridView();
            this.lbTotal2 = new System.Windows.Forms.Label();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadMicro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrMicroLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroXZona)).BeginInit();
            this.grpAtencion.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelDistrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrInfoDistrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroDist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelDistrito);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 580);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbTotal);
            this.panel3.Controls.Add(this.chrMicroLoc);
            this.panel3.Controls.Add(this.dgvMicroXZona);
            this.panel3.Controls.Add(this.cbCanton);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.dtpHasta);
            this.panel3.Controls.Add(this.grpAtencion);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dtpDe);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.btnLimpiarFormulario);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 1356);
            this.panel3.TabIndex = 34;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.lbTotal.Location = new System.Drawing.Point(15, 1285);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(451, 27);
            this.lbTotal.TabIndex = 90;
            this.lbTotal.Text = "Total de Microempresarios Atendidos: 0\r\n";
            // 
            // chrMicroLoc
            // 
            this.chrMicroLoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chrMicroLoc.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(175)))), ((int)(((byte)(230)))));
            this.chrMicroLoc.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.chrMicroLoc.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrMicroLoc.Legends.Add(legend2);
            this.chrMicroLoc.Location = new System.Drawing.Point(20, 448);
            this.chrMicroLoc.Name = "chrMicroLoc";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrMicroLoc.Series.Add(series2);
            this.chrMicroLoc.Size = new System.Drawing.Size(692, 384);
            this.chrMicroLoc.TabIndex = 89;
            // 
            // dgvMicroXZona
            // 
            this.dgvMicroXZona.AllowUserToAddRows = false;
            this.dgvMicroXZona.AllowUserToDeleteRows = false;
            this.dgvMicroXZona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMicroXZona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMicroXZona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Localidad,
            this.CantidadMicro});
            this.dgvMicroXZona.Location = new System.Drawing.Point(126, 861);
            this.dgvMicroXZona.Name = "dgvMicroXZona";
            this.dgvMicroXZona.ReadOnly = true;
            this.dgvMicroXZona.RowHeadersWidth = 51;
            this.dgvMicroXZona.RowTemplate.Height = 24;
            this.dgvMicroXZona.Size = new System.Drawing.Size(461, 404);
            this.dgvMicroXZona.TabIndex = 88;
            // 
            // cbCanton
            // 
            this.cbCanton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCanton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cbCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCanton.Enabled = false;
            this.cbCanton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCanton.FormattingEnabled = true;
            this.cbCanton.Location = new System.Drawing.Point(112, 273);
            this.cbCanton.Name = "cbCanton";
            this.cbCanton.Size = new System.Drawing.Size(221, 31);
            this.cbCanton.TabIndex = 86;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(34, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 23);
            this.label15.TabIndex = 85;
            this.label15.Text = "Cantón";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpHasta.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpHasta.Location = new System.Drawing.Point(112, 159);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(384, 30);
            this.dtpHasta.TabIndex = 84;
            // 
            // grpAtencion
            // 
            this.grpAtencion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpAtencion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpAtencion.Controls.Add(this.rbNo);
            this.grpAtencion.Controls.Add(this.rbSi);
            this.grpAtencion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpAtencion.Location = new System.Drawing.Point(290, 208);
            this.grpAtencion.Name = "grpAtencion";
            this.grpAtencion.Size = new System.Drawing.Size(137, 43);
            this.grpAtencion.TabIndex = 83;
            this.grpAtencion.TabStop = false;
            // 
            // rbNo
            // 
            this.rbNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbNo.AutoSize = true;
            this.rbNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNo.Location = new System.Drawing.Point(73, 9);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(55, 27);
            this.rbNo.TabIndex = 40;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // rbSi
            // 
            this.rbSi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbSi.AutoSize = true;
            this.rbSi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSi.Location = new System.Drawing.Point(9, 9);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(48, 27);
            this.rbSi.TabIndex = 39;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            this.rbSi.CheckedChanged += new System.EventHandler(this.rbSi_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(34, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 23);
            this.label9.TabIndex = 82;
            this.label9.Text = "¿Desea filtrar por canton?";
            // 
            // dtpDe
            // 
            this.dtpDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDe.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDe.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDe.Location = new System.Drawing.Point(112, 99);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(384, 30);
            this.dtpDe.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 23);
            this.label1.TabIndex = 80;
            this.label1.Text = "Por favor, seleccione entre cuales fechas desea consultar:\r\n";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(34, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 23);
            this.label11.TabIndex = 79;
            this.label11.Text = "Hasta";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(38, 336);
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
            this.btnLimpiarFormulario.Location = new System.Drawing.Point(199, 336);
            this.btnLimpiarFormulario.Name = "btnLimpiarFormulario";
            this.btnLimpiarFormulario.Size = new System.Drawing.Size(188, 38);
            this.btnLimpiarFormulario.TabIndex = 73;
            this.btnLimpiarFormulario.Text = "Limpiar Formulario";
            this.btnLimpiarFormulario.UseVisualStyleBackColor = false;
            this.btnLimpiarFormulario.Click += new System.EventHandler(this.btnLimpiarFormulario_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(15, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(458, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "Reporte de Microempresarios Atendidos\r\n";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "De";
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
            this.lblAgregarProyecto.Location = new System.Drawing.Point(155, 13);
            this.lblAgregarProyecto.Name = "lblAgregarProyecto";
            this.lblAgregarProyecto.Size = new System.Drawing.Size(401, 26);
            this.lblAgregarProyecto.TabIndex = 1;
            this.lblAgregarProyecto.Text = "Microempresarios Atendidos Por Zona";
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
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // panelDistrito
            // 
            this.panelDistrito.Controls.Add(this.lbTotal2);
            this.panelDistrito.Controls.Add(this.dgvMicroDist);
            this.panelDistrito.Controls.Add(this.chrInfoDistrito);
            this.panelDistrito.Controls.Add(this.lbAnuncio);
            this.panelDistrito.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDistrito.Location = new System.Drawing.Point(0, 1411);
            this.panelDistrito.Name = "panelDistrito";
            this.panelDistrito.Size = new System.Drawing.Size(738, 956);
            this.panelDistrito.TabIndex = 35;
            this.panelDistrito.Visible = false;
            // 
            // lbAnuncio
            // 
            this.lbAnuncio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAnuncio.AutoSize = true;
            this.lbAnuncio.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnuncio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.lbAnuncio.Location = new System.Drawing.Point(24, 9);
            this.lbAnuncio.Name = "lbAnuncio";
            this.lbAnuncio.Size = new System.Drawing.Size(249, 27);
            this.lbAnuncio.TabIndex = 50;
            this.lbAnuncio.Text = "Desglose Por Distrito";
            // 
            // chrInfoDistrito
            // 
            this.chrInfoDistrito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chrInfoDistrito.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(175)))), ((int)(((byte)(230)))));
            this.chrInfoDistrito.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chrInfoDistrito.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrInfoDistrito.Legends.Add(legend1);
            this.chrInfoDistrito.Location = new System.Drawing.Point(20, 46);
            this.chrInfoDistrito.Name = "chrInfoDistrito";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrInfoDistrito.Series.Add(series1);
            this.chrInfoDistrito.Size = new System.Drawing.Size(692, 384);
            this.chrInfoDistrito.TabIndex = 90;
            // 
            // dgvMicroDist
            // 
            this.dgvMicroDist.AllowUserToAddRows = false;
            this.dgvMicroDist.AllowUserToDeleteRows = false;
            this.dgvMicroDist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMicroDist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMicroDist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Distrito,
            this.CantidadDis});
            this.dgvMicroDist.Location = new System.Drawing.Point(112, 446);
            this.dgvMicroDist.Name = "dgvMicroDist";
            this.dgvMicroDist.ReadOnly = true;
            this.dgvMicroDist.RowHeadersWidth = 51;
            this.dgvMicroDist.RowTemplate.Height = 24;
            this.dgvMicroDist.Size = new System.Drawing.Size(461, 404);
            this.dgvMicroDist.TabIndex = 91;
            // 
            // lbTotal2
            // 
            this.lbTotal2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTotal2.AutoSize = true;
            this.lbTotal2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.lbTotal2.Location = new System.Drawing.Point(24, 876);
            this.lbTotal2.Name = "lbTotal2";
            this.lbTotal2.Size = new System.Drawing.Size(451, 27);
            this.lbTotal2.TabIndex = 92;
            this.lbTotal2.Text = "Total de Microempresarios Atendidos: 0\r\n";
            // 
            // Localidad
            // 
            this.Localidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Localidad.HeaderText = "Cantón";
            this.Localidad.MinimumWidth = 6;
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            // 
            // CantidadMicro
            // 
            this.CantidadMicro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CantidadMicro.HeaderText = "Cantidad Microempresarios";
            this.CantidadMicro.MinimumWidth = 6;
            this.CantidadMicro.Name = "CantidadMicro";
            this.CantidadMicro.ReadOnly = true;
            // 
            // Distrito
            // 
            this.Distrito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.MinimumWidth = 6;
            this.Distrito.Name = "Distrito";
            this.Distrito.ReadOnly = true;
            // 
            // CantidadDis
            // 
            this.CantidadDis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CantidadDis.HeaderText = "Cantidad";
            this.CantidadDis.MinimumWidth = 6;
            this.CantidadDis.Name = "CantidadDis";
            this.CantidadDis.ReadOnly = true;
            // 
            // frmMicroAtendidosPorZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 580);
            this.Controls.Add(this.panel1);
            this.Name = "frmMicroAtendidosPorZona";
            this.Text = "frmMicroAtendidosPorZona";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrMicroLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroXZona)).EndInit();
            this.grpAtencion.ResumeLayout(false);
            this.grpAtencion.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDistrito.ResumeLayout(false);
            this.panelDistrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrInfoDistrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroDist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAgregarProyecto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrMicroLoc;
        private System.Windows.Forms.DataGridView dgvMicroXZona;
        private System.Windows.Forms.ComboBox cbCanton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.GroupBox grpAtencion;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiarFormulario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Panel panelDistrito;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrInfoDistrito;
        private System.Windows.Forms.Label lbAnuncio;
        private System.Windows.Forms.DataGridView dgvMicroDist;
        private System.Windows.Forms.Label lbTotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadMicro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDis;
    }
}