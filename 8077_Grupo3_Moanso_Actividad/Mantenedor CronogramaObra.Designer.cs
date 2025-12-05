namespace _8077_Grupo3_Moanso_Actividad
{
    partial class Mantenedor_CronogramaObra
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lbTituloCro = new System.Windows.Forms.Label();
            this.gbDatosMaterial = new System.Windows.Forms.GroupBox();
            this.cboObra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.lbStock = new System.Windows.Forms.Label();
            this.btnNuevoCrono = new System.Windows.Forms.Button();
            this.lbActividad = new System.Windows.Forms.Label();
            this.lbFecIn = new System.Windows.Forms.Label();
            this.lbFecFin = new System.Windows.Forms.Label();
            this.dgvCronograma = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.gbDatosMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCronograma)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::_8077_Grupo3_Moanso_Actividad.Properties.Resources.LogoEmpresa3;
            this.pictureBoxLogo.Location = new System.Drawing.Point(16, 15);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(92, 84);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 12;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lbTituloCro
            // 
            this.lbTituloCro.AutoSize = true;
            this.lbTituloCro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloCro.Location = new System.Drawing.Point(243, 53);
            this.lbTituloCro.Name = "lbTituloCro";
            this.lbTituloCro.Size = new System.Drawing.Size(633, 46);
            this.lbTituloCro.TabIndex = 21;
            this.lbTituloCro.Text = "Registro de Cronograma de obra";
            // 
            // gbDatosMaterial
            // 
            this.gbDatosMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbDatosMaterial.Controls.Add(this.cboObra);
            this.gbDatosMaterial.Controls.Add(this.label1);
            this.gbDatosMaterial.Controls.Add(this.dtpFechaFin);
            this.gbDatosMaterial.Controls.Add(this.txtResponsable);
            this.gbDatosMaterial.Controls.Add(this.dtpFechaInicio);
            this.gbDatosMaterial.Controls.Add(this.txtActividad);
            this.gbDatosMaterial.Controls.Add(this.lbStock);
            this.gbDatosMaterial.Controls.Add(this.btnNuevoCrono);
            this.gbDatosMaterial.Controls.Add(this.lbActividad);
            this.gbDatosMaterial.Controls.Add(this.lbFecIn);
            this.gbDatosMaterial.Controls.Add(this.lbFecFin);
            this.gbDatosMaterial.Location = new System.Drawing.Point(104, 373);
            this.gbDatosMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosMaterial.Name = "gbDatosMaterial";
            this.gbDatosMaterial.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosMaterial.Size = new System.Drawing.Size(1009, 314);
            this.gbDatosMaterial.TabIndex = 22;
            this.gbDatosMaterial.TabStop = false;
            this.gbDatosMaterial.Text = "Datos del Cronograma Obra";
            // 
            // cboObra
            // 
            this.cboObra.FormattingEnabled = true;
            this.cboObra.Location = new System.Drawing.Point(235, 62);
            this.cboObra.Margin = new System.Windows.Forms.Padding(4);
            this.cboObra.Name = "cboObra";
            this.cboObra.Size = new System.Drawing.Size(223, 24);
            this.cboObra.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Seleccionar Obra:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(235, 261);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaFin.TabIndex = 17;
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(235, 151);
            this.txtResponsable.Margin = new System.Windows.Forms.Padding(4);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(535, 22);
            this.txtResponsable.TabIndex = 9;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(235, 197);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaInicio.TabIndex = 16;
            // 
            // txtActividad
            // 
            this.txtActividad.Location = new System.Drawing.Point(235, 106);
            this.txtActividad.Margin = new System.Windows.Forms.Padding(4);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(535, 22);
            this.txtActividad.TabIndex = 0;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.Location = new System.Drawing.Point(31, 151);
            this.lbStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(107, 17);
            this.lbStock.TabIndex = 8;
            this.lbStock.Text = "Responsable:";
            // 
            // btnNuevoCrono
            // 
            this.btnNuevoCrono.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevoCrono.Location = new System.Drawing.Point(833, 31);
            this.btnNuevoCrono.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoCrono.Name = "btnNuevoCrono";
            this.btnNuevoCrono.Size = new System.Drawing.Size(143, 50);
            this.btnNuevoCrono.TabIndex = 12;
            this.btnNuevoCrono.Text = "Registrar";
            this.btnNuevoCrono.UseVisualStyleBackColor = false;
            this.btnNuevoCrono.Click += new System.EventHandler(this.btnNuevoCrono_Click);
            // 
            // lbActividad
            // 
            this.lbActividad.AutoSize = true;
            this.lbActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActividad.Location = new System.Drawing.Point(31, 111);
            this.lbActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbActividad.Name = "lbActividad";
            this.lbActividad.Size = new System.Drawing.Size(79, 17);
            this.lbActividad.TabIndex = 4;
            this.lbActividad.Text = "Actividad:";
            // 
            // lbFecIn
            // 
            this.lbFecIn.AutoSize = true;
            this.lbFecIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecIn.Location = new System.Drawing.Point(31, 204);
            this.lbFecIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFecIn.Name = "lbFecIn";
            this.lbFecIn.Size = new System.Drawing.Size(100, 17);
            this.lbFecIn.TabIndex = 5;
            this.lbFecIn.Text = "Fecha Inicio:";
            // 
            // lbFecFin
            // 
            this.lbFecFin.AutoSize = true;
            this.lbFecFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecFin.Location = new System.Drawing.Point(31, 261);
            this.lbFecFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFecFin.Name = "lbFecFin";
            this.lbFecFin.Size = new System.Drawing.Size(84, 17);
            this.lbFecFin.TabIndex = 7;
            this.lbFecFin.Text = "Fecha Fin:";
            // 
            // dgvCronograma
            // 
            this.dgvCronograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCronograma.Location = new System.Drawing.Point(99, 144);
            this.dgvCronograma.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCronograma.Name = "dgvCronograma";
            this.dgvCronograma.RowHeadersWidth = 51;
            this.dgvCronograma.Size = new System.Drawing.Size(1015, 185);
            this.dgvCronograma.TabIndex = 23;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolver.Location = new System.Drawing.Point(1004, 706);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(143, 50);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // Mantenedor_CronogramaObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1179, 783);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvCronograma);
            this.Controls.Add(this.gbDatosMaterial);
            this.Controls.Add(this.lbTituloCro);
            this.Controls.Add(this.pictureBoxLogo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mantenedor_CronogramaObra";
            this.Text = "Mantenedor CronogramaObra";
            this.Load += new System.EventHandler(this.Mantenedor_CronogramaObra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.gbDatosMaterial.ResumeLayout(false);
            this.gbDatosMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCronograma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lbTituloCro;
        private System.Windows.Forms.GroupBox gbDatosMaterial;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Button btnNuevoCrono;
        private System.Windows.Forms.Label lbFecFin;
        private System.Windows.Forms.Label lbActividad;
        private System.Windows.Forms.Label lbFecIn;
        private System.Windows.Forms.DataGridView dgvCronograma;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboObra;
    }
}