namespace WindowsFormsApp1.Proyecto
{
    partial class frmModificarEstado
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
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDistritoHolder = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNombreholder = new System.Windows.Forms.TextBox();
            this.tbIdProyectoholder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tdistri = new System.Windows.Forms.Label();
            this.tbDistrito = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbIdProyecto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiarFormulario = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvProyectos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAgregarProyecto = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.IdProyecto3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canton3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
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
            this.panel3.Controls.Add(this.tbDistritoHolder);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnRefrescar);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tbNombreholder);
            this.panel3.Controls.Add(this.tbIdProyectoholder);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.tdistri);
            this.panel3.Controls.Add(this.tbDistrito);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbNombre);
            this.panel3.Controls.Add(this.tbIdProyecto);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.btnLimpiarFormulario);
            this.panel3.Controls.Add(this.btnModificar);
            this.panel3.Controls.Add(this.dgvProyectos);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 845);
            this.panel3.TabIndex = 35;
            // 
            // cbEstado
            // 
            this.cbEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(142, 694);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(206, 31);
            this.cbEstado.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(372, 696);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 92;
            this.label6.Text = "Distrito";
            // 
            // tbDistritoHolder
            // 
            this.tbDistritoHolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDistritoHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbDistritoHolder.Enabled = false;
            this.tbDistritoHolder.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDistritoHolder.ForeColor = System.Drawing.Color.Black;
            this.tbDistritoHolder.Location = new System.Drawing.Point(486, 693);
            this.tbDistritoHolder.Name = "tbDistritoHolder";
            this.tbDistritoHolder.Size = new System.Drawing.Size(219, 30);
            this.tbDistritoHolder.TabIndex = 91;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(29, 695);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 23);
            this.label10.TabIndex = 90;
            this.label10.Text = "Estado";
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
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(370, 641);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 83;
            this.label7.Text = "Nombre";
            // 
            // tbNombreholder
            // 
            this.tbNombreholder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombreholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbNombreholder.Enabled = false;
            this.tbNombreholder.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreholder.ForeColor = System.Drawing.Color.Black;
            this.tbNombreholder.Location = new System.Drawing.Point(484, 638);
            this.tbNombreholder.Name = "tbNombreholder";
            this.tbNombreholder.Size = new System.Drawing.Size(221, 30);
            this.tbNombreholder.TabIndex = 82;
            // 
            // tbIdProyectoholder
            // 
            this.tbIdProyectoholder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIdProyectoholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbIdProyectoholder.Enabled = false;
            this.tbIdProyectoholder.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdProyectoholder.ForeColor = System.Drawing.Color.Black;
            this.tbIdProyectoholder.Location = new System.Drawing.Point(143, 638);
            this.tbIdProyectoholder.Name = "tbIdProyectoholder";
            this.tbIdProyectoholder.Size = new System.Drawing.Size(205, 30);
            this.tbIdProyectoholder.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(26, 641);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 23);
            this.label8.TabIndex = 80;
            this.label8.Text = "Id Proyecto";
            // 
            // tdistri
            // 
            this.tdistri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tdistri.AutoSize = true;
            this.tdistri.Font = new System.Drawing.Font("Arial", 12F);
            this.tdistri.ForeColor = System.Drawing.Color.Black;
            this.tdistri.Location = new System.Drawing.Point(34, 148);
            this.tdistri.Name = "tdistri";
            this.tdistri.Size = new System.Drawing.Size(72, 23);
            this.tdistri.TabIndex = 79;
            this.tdistri.Text = "Distrito";
            // 
            // tbDistrito
            // 
            this.tbDistrito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDistrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbDistrito.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDistrito.ForeColor = System.Drawing.Color.Black;
            this.tbDistrito.Location = new System.Drawing.Point(132, 145);
            this.tbDistrito.Name = "tbDistrito";
            this.tbDistrito.Size = new System.Drawing.Size(205, 30);
            this.tbDistrito.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(387, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 77;
            this.label5.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbNombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.ForeColor = System.Drawing.Color.Black;
            this.tbNombre.Location = new System.Drawing.Point(472, 85);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(250, 30);
            this.tbNombre.TabIndex = 76;
            // 
            // tbIdProyecto
            // 
            this.tbIdProyecto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIdProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbIdProyecto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdProyecto.ForeColor = System.Drawing.Color.Black;
            this.tbIdProyecto.Location = new System.Drawing.Point(161, 85);
            this.tbIdProyecto.Name = "tbIdProyecto";
            this.tbIdProyecto.Size = new System.Drawing.Size(176, 30);
            this.tbIdProyecto.TabIndex = 75;
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
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.AllowUserToAddRows = false;
            this.dgvProyectos.AllowUserToDeleteRows = false;
            this.dgvProyectos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProyecto3,
            this.Nombre3,
            this.Fecha3,
            this.Estado3,
            this.Canton3,
            this.Distrito3});
            this.dgvProyectos.Location = new System.Drawing.Point(33, 306);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.ReadOnly = true;
            this.dgvProyectos.RowHeadersWidth = 51;
            this.dgvProyectos.RowTemplate.Height = 24;
            this.dgvProyectos.Size = new System.Drawing.Size(672, 283);
            this.dgvProyectos.TabIndex = 71;
            this.dgvProyectos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProyectos_CellClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(479, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Por favor, seleccione uno de los proyectos de la lista:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(15, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "Informacón de Proyectos";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Id Proyecto";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Informacón del Proyecto";
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
            this.lblAgregarProyecto.Location = new System.Drawing.Point(209, 13);
            this.lblAgregarProyecto.Name = "lblAgregarProyecto";
            this.lblAgregarProyecto.Size = new System.Drawing.Size(315, 26);
            this.lblAgregarProyecto.TabIndex = 1;
            this.lblAgregarProyecto.Text = "Modificar Estado del Proyecto";
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
            // IdProyecto3
            // 
            this.IdProyecto3.HeaderText = "Id Proyecto";
            this.IdProyecto3.MinimumWidth = 6;
            this.IdProyecto3.Name = "IdProyecto3";
            this.IdProyecto3.ReadOnly = true;
            this.IdProyecto3.Width = 125;
            // 
            // Nombre3
            // 
            this.Nombre3.HeaderText = "Nombre";
            this.Nombre3.MinimumWidth = 6;
            this.Nombre3.Name = "Nombre3";
            this.Nombre3.ReadOnly = true;
            this.Nombre3.Width = 125;
            // 
            // Fecha3
            // 
            this.Fecha3.HeaderText = "Fecha de Creación";
            this.Fecha3.MinimumWidth = 6;
            this.Fecha3.Name = "Fecha3";
            this.Fecha3.ReadOnly = true;
            this.Fecha3.Width = 125;
            // 
            // Estado3
            // 
            this.Estado3.HeaderText = "Estado";
            this.Estado3.MinimumWidth = 6;
            this.Estado3.Name = "Estado3";
            this.Estado3.ReadOnly = true;
            this.Estado3.Width = 125;
            // 
            // Canton3
            // 
            this.Canton3.HeaderText = "Canton";
            this.Canton3.MinimumWidth = 6;
            this.Canton3.Name = "Canton3";
            this.Canton3.ReadOnly = true;
            this.Canton3.Width = 125;
            // 
            // Distrito3
            // 
            this.Distrito3.HeaderText = "Distrito";
            this.Distrito3.MinimumWidth = 6;
            this.Distrito3.Name = "Distrito3";
            this.Distrito3.ReadOnly = true;
            this.Distrito3.Width = 125;
            // 
            // frmModificarEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 580);
            this.Controls.Add(this.panel1);
            this.Name = "frmModificarEstado";
            this.Text = "frmModificarEstado";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
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
        private System.Windows.Forms.TextBox tbDistritoHolder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNombreholder;
        private System.Windows.Forms.TextBox tbIdProyectoholder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label tdistri;
        private System.Windows.Forms.TextBox tbDistrito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbIdProyecto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiarFormulario;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvProyectos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProyecto3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito3;
    }
}