namespace UCR_TCU_474.Reportes
{
    partial class frmProyectosPorAreaInteres
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chrMicroLoc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvMicroXZona = new System.Windows.Forms.DataGridView();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lbanuncio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAgregarProyecto = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrMicroLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroXZona)).BeginInit();
            this.grpAtencion.SuspendLayout();
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
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbEstado);
            this.panel3.Controls.Add(this.label6);
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
            this.panel3.Controls.Add(this.lbanuncio);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 1491);
            this.panel3.TabIndex = 35;
            // 
            // cbEstado
            // 
            this.cbEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(112, 339);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(221, 31);
            this.cbEstado.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(34, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 94;
            this.label6.Text = "Estado";
            // 
            // chrMicroLoc
            // 
            this.chrMicroLoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chrMicroLoc.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(175)))), ((int)(((byte)(230)))));
            this.chrMicroLoc.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.Name = "ChartArea1";
            this.chrMicroLoc.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chrMicroLoc.Legends.Add(legend4);
            this.chrMicroLoc.Location = new System.Drawing.Point(20, 521);
            this.chrMicroLoc.Name = "chrMicroLoc";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chrMicroLoc.Series.Add(series4);
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
            this.Area,
            this.CantidadPro});
            this.dgvMicroXZona.Location = new System.Drawing.Point(126, 1026);
            this.dgvMicroXZona.Name = "dgvMicroXZona";
            this.dgvMicroXZona.ReadOnly = true;
            this.dgvMicroXZona.RowHeadersWidth = 51;
            this.dgvMicroXZona.RowTemplate.Height = 24;
            this.dgvMicroXZona.Size = new System.Drawing.Size(461, 404);
            this.dgvMicroXZona.TabIndex = 88;
            // 
            // Area
            // 
            this.Area.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Area.HeaderText = "Area de Interés";
            this.Area.MinimumWidth = 6;
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // CantidadPro
            // 
            this.CantidadPro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CantidadPro.HeaderText = "Cantidad Proyectos";
            this.CantidadPro.MinimumWidth = 6;
            this.CantidadPro.Name = "CantidadPro";
            this.CantidadPro.ReadOnly = true;
            // 
            // cbCanton
            // 
            this.cbCanton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCanton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cbCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCanton.Enabled = false;
            this.cbCanton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCanton.FormattingEnabled = true;
            this.cbCanton.Location = new System.Drawing.Point(112, 262);
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
            this.label15.Location = new System.Drawing.Point(34, 270);
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
            this.dtpHasta.Location = new System.Drawing.Point(112, 148);
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
            this.grpAtencion.Location = new System.Drawing.Point(290, 197);
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
            this.label9.Location = new System.Drawing.Point(34, 211);
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
            this.dtpDe.Location = new System.Drawing.Point(112, 88);
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
            this.label1.Location = new System.Drawing.Point(16, 25);
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
            this.label11.Location = new System.Drawing.Point(34, 154);
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
            this.btnBuscar.Location = new System.Drawing.Point(38, 409);
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
            this.btnLimpiarFormulario.Location = new System.Drawing.Point(199, 409);
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
            this.lbanuncio.Location = new System.Drawing.Point(15, 466);
            this.lbanuncio.Name = "lbanuncio";
            this.lbanuncio.Size = new System.Drawing.Size(467, 27);
            this.lbanuncio.TabIndex = 22;
            this.lbanuncio.Text = "Reporte de Proyectos por Área de interés";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 94);
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
            this.panel2.TabIndex = 5;
            // 
            // lblAgregarProyecto
            // 
            this.lblAgregarProyecto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgregarProyecto.AutoSize = true;
            this.lblAgregarProyecto.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProyecto.ForeColor = System.Drawing.Color.White;
            this.lblAgregarProyecto.Location = new System.Drawing.Point(117, 13);
            this.lblAgregarProyecto.Name = "lblAgregarProyecto";
            this.lblAgregarProyecto.Size = new System.Drawing.Size(452, 26);
            this.lblAgregarProyecto.TabIndex = 1;
            this.lblAgregarProyecto.Text = "Desgloce de Proyectos Por Área de Interés";
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
            // lbTotal
            // 
            this.lbTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.lbTotal.Location = new System.Drawing.Point(129, 952);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(222, 27);
            this.lbTotal.TabIndex = 90;
            this.lbTotal.Text = "Total de proyectos:";
            // 
            // frmProyectosPorAreaInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 580);
            this.Controls.Add(this.panel1);
            this.Name = "frmProyectosPorAreaInteres";
            this.Text = "frmProyectosPorAreaInteres";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrMicroLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroXZona)).EndInit();
            this.grpAtencion.ResumeLayout(false);
            this.grpAtencion.PerformLayout();
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
        private System.Windows.Forms.Label lbanuncio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPro;
        private System.Windows.Forms.Label lbTotal;
    }
}