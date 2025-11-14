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
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.btnInhabilitarCrono = new System.Windows.Forms.Button();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.btnModificarCrono = new System.Windows.Forms.Button();
            this.lbStock = new System.Windows.Forms.Label();
            this.btnNuevoCrono = new System.Windows.Forms.Button();
            this.lbFecFin = new System.Windows.Forms.Label();
            this.lbActividad = new System.Windows.Forms.Label();
            this.lbFecIn = new System.Windows.Forms.Label();
            this.dgvCronograma = new System.Windows.Forms.DataGridView();
            this.txtObra = new System.Windows.Forms.TextBox();
            this.btnBuscarObra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.gbDatosMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCronograma)).BeginInit();
            this.SuspendLayout();
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
            // lbTituloCro
            // 
            this.lbTituloCro.AutoSize = true;
            this.lbTituloCro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloCro.Location = new System.Drawing.Point(182, 43);
            this.lbTituloCro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloCro.Name = "lbTituloCro";
            this.lbTituloCro.Size = new System.Drawing.Size(516, 37);
            this.lbTituloCro.TabIndex = 21;
            this.lbTituloCro.Text = "Registro de Cronograma de obra";
            // 
            // gbDatosMaterial
            // 
            this.gbDatosMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbDatosMaterial.Controls.Add(this.dtpFin);
            this.gbDatosMaterial.Controls.Add(this.txtResponsable);
            this.gbDatosMaterial.Controls.Add(this.dtpInicio);
            this.gbDatosMaterial.Controls.Add(this.btnInhabilitarCrono);
            this.gbDatosMaterial.Controls.Add(this.txtActividad);
            this.gbDatosMaterial.Controls.Add(this.btnModificarCrono);
            this.gbDatosMaterial.Controls.Add(this.lbStock);
            this.gbDatosMaterial.Controls.Add(this.btnNuevoCrono);
            this.gbDatosMaterial.Controls.Add(this.lbActividad);
            this.gbDatosMaterial.Controls.Add(this.lbFecIn);
            this.gbDatosMaterial.Controls.Add(this.lbFecFin);
            this.gbDatosMaterial.Location = new System.Drawing.Point(78, 354);
            this.gbDatosMaterial.Name = "gbDatosMaterial";
            this.gbDatosMaterial.Size = new System.Drawing.Size(757, 204);
            this.gbDatosMaterial.TabIndex = 22;
            this.gbDatosMaterial.TabStop = false;
            this.gbDatosMaterial.Text = "Datos del Cronograma Obra";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(171, 62);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(402, 20);
            this.txtResponsable.TabIndex = 9;
            // 
            // btnInhabilitarCrono
            // 
            this.btnInhabilitarCrono.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInhabilitarCrono.Location = new System.Drawing.Point(620, 143);
            this.btnInhabilitarCrono.Name = "btnInhabilitarCrono";
            this.btnInhabilitarCrono.Size = new System.Drawing.Size(107, 41);
            this.btnInhabilitarCrono.TabIndex = 15;
            this.btnInhabilitarCrono.Text = "Inhabilitar Cronograma";
            this.btnInhabilitarCrono.UseVisualStyleBackColor = false;
            // 
            // txtActividad
            // 
            this.txtActividad.Location = new System.Drawing.Point(171, 25);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(402, 20);
            this.txtActividad.TabIndex = 0;
            // 
            // btnModificarCrono
            // 
            this.btnModificarCrono.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificarCrono.Location = new System.Drawing.Point(620, 86);
            this.btnModificarCrono.Name = "btnModificarCrono";
            this.btnModificarCrono.Size = new System.Drawing.Size(107, 41);
            this.btnModificarCrono.TabIndex = 13;
            this.btnModificarCrono.Text = "Modificar";
            this.btnModificarCrono.UseVisualStyleBackColor = false;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.Location = new System.Drawing.Point(18, 62);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(84, 13);
            this.lbStock.TabIndex = 8;
            this.lbStock.Text = "Responsable:";
            // 
            // btnNuevoCrono
            // 
            this.btnNuevoCrono.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevoCrono.Location = new System.Drawing.Point(620, 29);
            this.btnNuevoCrono.Name = "btnNuevoCrono";
            this.btnNuevoCrono.Size = new System.Drawing.Size(107, 41);
            this.btnNuevoCrono.TabIndex = 12;
            this.btnNuevoCrono.Text = "Nuevo";
            this.btnNuevoCrono.UseVisualStyleBackColor = false;
            // 
            // lbFecFin
            // 
            this.lbFecFin.AutoSize = true;
            this.lbFecFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecFin.Location = new System.Drawing.Point(18, 151);
            this.lbFecFin.Name = "lbFecFin";
            this.lbFecFin.Size = new System.Drawing.Size(67, 13);
            this.lbFecFin.TabIndex = 7;
            this.lbFecFin.Text = "Fecha Fin:";
            // 
            // lbActividad
            // 
            this.lbActividad.AutoSize = true;
            this.lbActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActividad.Location = new System.Drawing.Point(18, 29);
            this.lbActividad.Name = "lbActividad";
            this.lbActividad.Size = new System.Drawing.Size(64, 13);
            this.lbActividad.TabIndex = 4;
            this.lbActividad.Text = "Actividad:";
            // 
            // lbFecIn
            // 
            this.lbFecIn.AutoSize = true;
            this.lbFecIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecIn.Location = new System.Drawing.Point(18, 105);
            this.lbFecIn.Name = "lbFecIn";
            this.lbFecIn.Size = new System.Drawing.Size(81, 13);
            this.lbFecIn.TabIndex = 5;
            this.lbFecIn.Text = "Fecha Inicio:";
            // 
            // dgvCronograma
            // 
            this.dgvCronograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCronograma.Location = new System.Drawing.Point(78, 174);
            this.dgvCronograma.Name = "dgvCronograma";
            this.dgvCronograma.Size = new System.Drawing.Size(761, 150);
            this.dgvCronograma.TabIndex = 23;
            // 
            // txtObra
            // 
            this.txtObra.Location = new System.Drawing.Point(239, 122);
            this.txtObra.Name = "txtObra";
            this.txtObra.Size = new System.Drawing.Size(402, 20);
            this.txtObra.TabIndex = 0;
            // 
            // btnBuscarObra
            // 
            this.btnBuscarObra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarObra.Location = new System.Drawing.Point(694, 111);
            this.btnBuscarObra.Name = "btnBuscarObra";
            this.btnBuscarObra.Size = new System.Drawing.Size(107, 41);
            this.btnBuscarObra.TabIndex = 12;
            this.btnBuscarObra.Text = "Buscar";
            this.btnBuscarObra.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Obra:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(171, 99);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 16;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(171, 151);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 17;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolver.Location = new System.Drawing.Point(765, 583);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 41);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // Mantenedor_CronogramaObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 636);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtObra);
            this.Controls.Add(this.btnBuscarObra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCronograma);
            this.Controls.Add(this.gbDatosMaterial);
            this.Controls.Add(this.lbTituloCro);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "Mantenedor_CronogramaObra";
            this.Text = "Mantenedor CronogramaObra";
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
        private System.Windows.Forms.Button btnInhabilitarCrono;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.Button btnModificarCrono;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Button btnNuevoCrono;
        private System.Windows.Forms.Label lbFecFin;
        private System.Windows.Forms.Label lbActividad;
        private System.Windows.Forms.Label lbFecIn;
        private System.Windows.Forms.DataGridView dgvCronograma;
        private System.Windows.Forms.TextBox txtObra;
        private System.Windows.Forms.Button btnBuscarObra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Button btnVolver;
    }
}