namespace _8077_Grupo3_Moanso_Actividad
{
    partial class AvanceObra
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
            this.gbDatosAvance = new System.Windows.Forms.GroupBox();
            this.dtpFechaAvance = new System.Windows.Forms.DateTimePicker();
            this.lbEstadoObra = new System.Windows.Forms.Label();
            this.cbEstadoObra = new System.Windows.Forms.ComboBox();
            this.cbNivelPrioridad = new System.Windows.Forms.ComboBox();
            this.lblNivelPrioridad = new System.Windows.Forms.Label();
            this.btnBuscarObra = new System.Windows.Forms.Button();
            this.cbActividad = new System.Windows.Forms.ComboBox();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.txtCodObra = new System.Windows.Forms.TextBox();
            this.lbFechaAvance = new System.Windows.Forms.Label();
            this.btnRegistrarAvance = new System.Windows.Forms.Button();
            this.lbActividad = new System.Windows.Forms.Label();
            this.lbCodObra = new System.Windows.Forms.Label();
            this.lbTituloMat = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvMantenedorMat = new System.Windows.Forms.DataGridView();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.gbDatosAvance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenedorMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosAvance
            // 
            this.gbDatosAvance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbDatosAvance.Controls.Add(this.dtpFechaAvance);
            this.gbDatosAvance.Controls.Add(this.lbEstadoObra);
            this.gbDatosAvance.Controls.Add(this.cbEstadoObra);
            this.gbDatosAvance.Controls.Add(this.cbNivelPrioridad);
            this.gbDatosAvance.Controls.Add(this.lblNivelPrioridad);
            this.gbDatosAvance.Controls.Add(this.btnBuscarObra);
            this.gbDatosAvance.Controls.Add(this.cbActividad);
            this.gbDatosAvance.Controls.Add(this.btnLimpiarDatos);
            this.gbDatosAvance.Controls.Add(this.txtCodObra);
            this.gbDatosAvance.Controls.Add(this.lbFechaAvance);
            this.gbDatosAvance.Controls.Add(this.btnRegistrarAvance);
            this.gbDatosAvance.Controls.Add(this.lbActividad);
            this.gbDatosAvance.Controls.Add(this.lbCodObra);
            this.gbDatosAvance.Location = new System.Drawing.Point(22, 106);
            this.gbDatosAvance.Name = "gbDatosAvance";
            this.gbDatosAvance.Size = new System.Drawing.Size(516, 388);
            this.gbDatosAvance.TabIndex = 13;
            this.gbDatosAvance.TabStop = false;
            this.gbDatosAvance.Text = "Avance de Obra";
            // 
            // dtpFechaAvance
            // 
            this.dtpFechaAvance.Location = new System.Drawing.Point(171, 180);
            this.dtpFechaAvance.Name = "dtpFechaAvance";
            this.dtpFechaAvance.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaAvance.TabIndex = 21;
            // 
            // lbEstadoObra
            // 
            this.lbEstadoObra.AutoSize = true;
            this.lbEstadoObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstadoObra.Location = new System.Drawing.Point(18, 141);
            this.lbEstadoObra.Name = "lbEstadoObra";
            this.lbEstadoObra.Size = new System.Drawing.Size(99, 13);
            this.lbEstadoObra.TabIndex = 20;
            this.lbEstadoObra.Text = "Estado de Obra:";
            // 
            // cbEstadoObra
            // 
            this.cbEstadoObra.FormattingEnabled = true;
            this.cbEstadoObra.Items.AddRange(new object[] {
            "Pendiente",
            "En curso",
            "Pausado",
            "Finalizado"});
            this.cbEstadoObra.Location = new System.Drawing.Point(171, 141);
            this.cbEstadoObra.Name = "cbEstadoObra";
            this.cbEstadoObra.Size = new System.Drawing.Size(121, 21);
            this.cbEstadoObra.TabIndex = 19;
            // 
            // cbNivelPrioridad
            // 
            this.cbNivelPrioridad.FormattingEnabled = true;
            this.cbNivelPrioridad.Items.AddRange(new object[] {
            "Alto",
            "Medio",
            "Bajo"});
            this.cbNivelPrioridad.Location = new System.Drawing.Point(171, 97);
            this.cbNivelPrioridad.Name = "cbNivelPrioridad";
            this.cbNivelPrioridad.Size = new System.Drawing.Size(132, 21);
            this.cbNivelPrioridad.TabIndex = 18;
            // 
            // lblNivelPrioridad
            // 
            this.lblNivelPrioridad.AutoSize = true;
            this.lblNivelPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelPrioridad.Location = new System.Drawing.Point(18, 100);
            this.lblNivelPrioridad.Name = "lblNivelPrioridad";
            this.lblNivelPrioridad.Size = new System.Drawing.Size(112, 13);
            this.lblNivelPrioridad.TabIndex = 17;
            this.lblNivelPrioridad.Text = "Nivel de Prioridad:";
            // 
            // btnBuscarObra
            // 
            this.btnBuscarObra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarObra.Location = new System.Drawing.Point(160, 316);
            this.btnBuscarObra.Name = "btnBuscarObra";
            this.btnBuscarObra.Size = new System.Drawing.Size(186, 41);
            this.btnBuscarObra.TabIndex = 15;
            this.btnBuscarObra.Text = "Buscar Obra";
            this.btnBuscarObra.UseVisualStyleBackColor = false;
            // 
            // cbActividad
            // 
            this.cbActividad.FormattingEnabled = true;
            this.cbActividad.Location = new System.Drawing.Point(171, 57);
            this.cbActividad.Name = "cbActividad";
            this.cbActividad.Size = new System.Drawing.Size(319, 21);
            this.cbActividad.TabIndex = 16;
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiarDatos.Location = new System.Drawing.Point(160, 264);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(186, 41);
            this.btnLimpiarDatos.TabIndex = 15;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = false;
            // 
            // txtCodObra
            // 
            this.txtCodObra.Location = new System.Drawing.Point(171, 25);
            this.txtCodObra.Name = "txtCodObra";
            this.txtCodObra.Size = new System.Drawing.Size(148, 20);
            this.txtCodObra.TabIndex = 0;
            // 
            // lbFechaAvance
            // 
            this.lbFechaAvance.AutoSize = true;
            this.lbFechaAvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaAvance.Location = new System.Drawing.Point(18, 180);
            this.lbFechaAvance.Name = "lbFechaAvance";
            this.lbFechaAvance.Size = new System.Drawing.Size(46, 13);
            this.lbFechaAvance.TabIndex = 8;
            this.lbFechaAvance.Text = "Fecha:";
            // 
            // btnRegistrarAvance
            // 
            this.btnRegistrarAvance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrarAvance.Location = new System.Drawing.Point(160, 217);
            this.btnRegistrarAvance.Name = "btnRegistrarAvance";
            this.btnRegistrarAvance.Size = new System.Drawing.Size(186, 41);
            this.btnRegistrarAvance.TabIndex = 12;
            this.btnRegistrarAvance.Text = "Registrar";
            this.btnRegistrarAvance.UseVisualStyleBackColor = false;
            // 
            // lbActividad
            // 
            this.lbActividad.AutoSize = true;
            this.lbActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActividad.Location = new System.Drawing.Point(18, 60);
            this.lbActividad.Name = "lbActividad";
            this.lbActividad.Size = new System.Drawing.Size(64, 13);
            this.lbActividad.TabIndex = 7;
            this.lbActividad.Text = "Actividad:";
            // 
            // lbCodObra
            // 
            this.lbCodObra.AutoSize = true;
            this.lbCodObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodObra.Location = new System.Drawing.Point(18, 29);
            this.lbCodObra.Name = "lbCodObra";
            this.lbCodObra.Size = new System.Drawing.Size(81, 13);
            this.lbCodObra.TabIndex = 4;
            this.lbCodObra.Text = "Código Obra:";
            // 
            // lbTituloMat
            // 
            this.lbTituloMat.AutoSize = true;
            this.lbTituloMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloMat.Location = new System.Drawing.Point(517, 43);
            this.lbTituloMat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloMat.Name = "lbTituloMat";
            this.lbTituloMat.Size = new System.Drawing.Size(262, 37);
            this.lbTituloMat.TabIndex = 21;
            this.lbTituloMat.Text = "Avance de Obra";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolver.Location = new System.Drawing.Point(1177, 527);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 41);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // dgvMantenedorMat
            // 
            this.dgvMantenedorMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantenedorMat.Location = new System.Drawing.Point(553, 106);
            this.dgvMantenedorMat.Name = "dgvMantenedorMat";
            this.dgvMantenedorMat.Size = new System.Drawing.Size(731, 388);
            this.dgvMantenedorMat.TabIndex = 23;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::_8077_Grupo3_Moanso_Actividad.Properties.Resources.LogoEmpresa3;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(69, 68);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 12;
            this.pictureBoxLogo.TabStop = false;
            // 
            // AvanceObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 580);
            this.Controls.Add(this.dgvMantenedorMat);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lbTituloMat);
            this.Controls.Add(this.gbDatosAvance);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "AvanceObra";
            this.Text = "AvanceObra";
            this.gbDatosAvance.ResumeLayout(false);
            this.gbDatosAvance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenedorMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.GroupBox gbDatosAvance;
        private System.Windows.Forms.ComboBox cbActividad;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.TextBox txtCodObra;
        private System.Windows.Forms.Label lbFechaAvance;
        private System.Windows.Forms.Button btnRegistrarAvance;
        private System.Windows.Forms.Label lbActividad;
        private System.Windows.Forms.Label lbCodObra;
        private System.Windows.Forms.Label lbTituloMat;
        private System.Windows.Forms.Label lblNivelPrioridad;
        private System.Windows.Forms.ComboBox cbNivelPrioridad;
        private System.Windows.Forms.Label lbEstadoObra;
        private System.Windows.Forms.ComboBox cbEstadoObra;
        private System.Windows.Forms.DateTimePicker dtpFechaAvance;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvMantenedorMat;
        private System.Windows.Forms.Button btnBuscarObra;
    }
}