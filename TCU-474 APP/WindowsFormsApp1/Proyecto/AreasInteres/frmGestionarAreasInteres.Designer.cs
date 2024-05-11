namespace UCR_TCU_474.Proyecto.AreasInteres
{
    partial class frmGestionarAreasInteres
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
            System.Windows.Forms.Button btnLimpiarFormulario;
            System.Windows.Forms.Button btnModificarActividad;
            System.Windows.Forms.Label label2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblAgregarProyecto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.tbNombreArea = new System.Windows.Forms.TextBox();
            this.IdAreaInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnLimpiarFormulario = new System.Windows.Forms.Button();
            btnModificarActividad = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarFormulario
            // 
            btnLimpiarFormulario.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnLimpiarFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            btnLimpiarFormulario.FlatAppearance.BorderSize = 0;
            btnLimpiarFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiarFormulario.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLimpiarFormulario.ForeColor = System.Drawing.Color.White;
            btnLimpiarFormulario.Location = new System.Drawing.Point(172, 494);
            btnLimpiarFormulario.Name = "btnLimpiarFormulario";
            btnLimpiarFormulario.Size = new System.Drawing.Size(188, 38);
            btnLimpiarFormulario.TabIndex = 83;
            btnLimpiarFormulario.Text = "Limpiar Formulario";
            btnLimpiarFormulario.UseVisualStyleBackColor = false;
            btnLimpiarFormulario.Click += new System.EventHandler(this.btnLimpiarFormulario_Click);
            // 
            // btnModificarActividad
            // 
            btnModificarActividad.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnModificarActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            btnModificarActividad.FlatAppearance.BorderSize = 0;
            btnModificarActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnModificarActividad.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnModificarActividad.ForeColor = System.Drawing.Color.White;
            btnModificarActividad.Location = new System.Drawing.Point(381, 494);
            btnModificarActividad.Name = "btnModificarActividad";
            btnModificarActividad.Size = new System.Drawing.Size(231, 38);
            btnModificarActividad.TabIndex = 82;
            btnModificarActividad.Text = "Modificar Area Interés";
            btnModificarActividad.UseVisualStyleBackColor = false;
            btnModificarActividad.Click += new System.EventHandler(this.btnModificarActividad_Click);
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 12F);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(49, 439);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(229, 23);
            label2.TabIndex = 80;
            label2.Text = "Nombre Area de Interés*";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(175)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblAgregarProyecto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 55);
            this.panel1.TabIndex = 70;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(713, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(46, 55);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblAgregarProyecto
            // 
            this.lblAgregarProyecto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgregarProyecto.AutoSize = true;
            this.lblAgregarProyecto.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProyecto.ForeColor = System.Drawing.Color.White;
            this.lblAgregarProyecto.Location = new System.Drawing.Point(213, 13);
            this.lblAgregarProyecto.Name = "lblAgregarProyecto";
            this.lblAgregarProyecto.Size = new System.Drawing.Size(295, 26);
            this.lblAgregarProyecto.TabIndex = 1;
            this.lblAgregarProyecto.Text = "Gentión de Areas de Interés";
            this.lblAgregarProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(34, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 27);
            this.label1.TabIndex = 81;
            this.label1.Text = "Modificar Area de Interés";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.label17.Location = new System.Drawing.Point(34, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(192, 27);
            this.label17.TabIndex = 78;
            this.label17.Text = "Areas de Interés";
            // 
            // dgvActividades
            // 
            this.dgvActividades.AllowUserToAddRows = false;
            this.dgvActividades.AllowUserToDeleteRows = false;
            this.dgvActividades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAreaInteres,
            this.Nombre});
            this.dgvActividades.Location = new System.Drawing.Point(53, 112);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.ReadOnly = true;
            this.dgvActividades.RowHeadersWidth = 51;
            this.dgvActividades.RowTemplate.Height = 24;
            this.dgvActividades.Size = new System.Drawing.Size(672, 251);
            this.dgvActividades.TabIndex = 77;
            this.dgvActividades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActividades_CellClick);
            // 
            // tbNombreArea
            // 
            this.tbNombreArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombreArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbNombreArea.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreArea.ForeColor = System.Drawing.Color.Black;
            this.tbNombreArea.Location = new System.Drawing.Point(287, 436);
            this.tbNombreArea.Name = "tbNombreArea";
            this.tbNombreArea.Size = new System.Drawing.Size(438, 30);
            this.tbNombreArea.TabIndex = 84;
            // 
            // IdAreaInteres
            // 
            this.IdAreaInteres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdAreaInteres.HeaderText = "Núemro de Area Interés";
            this.IdAreaInteres.MinimumWidth = 6;
            this.IdAreaInteres.Name = "IdAreaInteres";
            this.IdAreaInteres.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre Actividad";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // frmGestionarAreasInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 580);
            this.Controls.Add(this.tbNombreArea);
            this.Controls.Add(btnLimpiarFormulario);
            this.Controls.Add(btnModificarActividad);
            this.Controls.Add(this.label1);
            this.Controls.Add(label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgvActividades);
            this.Controls.Add(this.panel1);
            this.Name = "frmGestionarAreasInteres";
            this.Text = "frmGestionarAreasInteres";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblAgregarProyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.TextBox tbNombreArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAreaInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}