namespace _8077_Grupo3_Moanso_Actividad
{
    partial class MantenedorMaterial
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
            this.lbTituloMat = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBuscarMat = new System.Windows.Forms.Button();
            this.dgvMantenedorMat = new System.Windows.Forms.DataGridView();
            this.lbDescMat = new System.Windows.Forms.Label();
            this.lbCodMat = new System.Windows.Forms.Label();
            this.lbUni = new System.Windows.Forms.Label();
            this.btnNuevoProv = new System.Windows.Forms.Button();
            this.lbStock = new System.Windows.Forms.Label();
            this.btnModificarProv = new System.Windows.Forms.Button();
            this.txtCodMat = new System.Windows.Forms.TextBox();
            this.btnInhabilitarMat = new System.Windows.Forms.Button();
            this.txtDescMaterial = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.cbUndMed = new System.Windows.Forms.ComboBox();
            this.lbCategoriaMat = new System.Windows.Forms.Label();
            this.cbCategoriaMat = new System.Windows.Forms.ComboBox();
            this.gbDatosMaterial = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenedorMat)).BeginInit();
            this.gbDatosMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTituloMat
            // 
            this.lbTituloMat.AutoSize = true;
            this.lbTituloMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloMat.Location = new System.Drawing.Point(232, 43);
            this.lbTituloMat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloMat.Name = "lbTituloMat";
            this.lbTituloMat.Size = new System.Drawing.Size(356, 37);
            this.lbTituloMat.TabIndex = 20;
            this.lbTituloMat.Text = "Registro de Materiales";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::_8077_Grupo3_Moanso_Actividad.Properties.Resources.LogoEmpresa3;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(69, 68);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 11;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolver.Location = new System.Drawing.Point(735, 581);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 41);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnBuscarMat
            // 
            this.btnBuscarMat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarMat.Location = new System.Drawing.Point(710, 417);
            this.btnBuscarMat.Name = "btnBuscarMat";
            this.btnBuscarMat.Size = new System.Drawing.Size(107, 71);
            this.btnBuscarMat.TabIndex = 18;
            this.btnBuscarMat.Text = "Buscar Material";
            this.btnBuscarMat.UseVisualStyleBackColor = false;
            // 
            // dgvMantenedorMat
            // 
            this.dgvMantenedorMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantenedorMat.Location = new System.Drawing.Point(47, 331);
            this.dgvMantenedorMat.Name = "dgvMantenedorMat";
            this.dgvMantenedorMat.Size = new System.Drawing.Size(638, 277);
            this.dgvMantenedorMat.TabIndex = 17;
            // 
            // lbDescMat
            // 
            this.lbDescMat.AutoSize = true;
            this.lbDescMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescMat.Location = new System.Drawing.Point(18, 58);
            this.lbDescMat.Name = "lbDescMat";
            this.lbDescMat.Size = new System.Drawing.Size(147, 13);
            this.lbDescMat.TabIndex = 5;
            this.lbDescMat.Text = "Descripción del material:";
            // 
            // lbCodMat
            // 
            this.lbCodMat.AutoSize = true;
            this.lbCodMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodMat.Location = new System.Drawing.Point(18, 29);
            this.lbCodMat.Name = "lbCodMat";
            this.lbCodMat.Size = new System.Drawing.Size(99, 13);
            this.lbCodMat.TabIndex = 4;
            this.lbCodMat.Text = "Código Material:";
            // 
            // lbUni
            // 
            this.lbUni.AutoSize = true;
            this.lbUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUni.Location = new System.Drawing.Point(18, 89);
            this.lbUni.Name = "lbUni";
            this.lbUni.Size = new System.Drawing.Size(113, 13);
            this.lbUni.TabIndex = 7;
            this.lbUni.Text = "Unidad de medida:";
            // 
            // btnNuevoProv
            // 
            this.btnNuevoProv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevoProv.Location = new System.Drawing.Point(620, 19);
            this.btnNuevoProv.Name = "btnNuevoProv";
            this.btnNuevoProv.Size = new System.Drawing.Size(107, 41);
            this.btnNuevoProv.TabIndex = 12;
            this.btnNuevoProv.Text = "Nuevo";
            this.btnNuevoProv.UseVisualStyleBackColor = false;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.Location = new System.Drawing.Point(18, 146);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(44, 13);
            this.lbStock.TabIndex = 8;
            this.lbStock.Text = "Stock:";
            // 
            // btnModificarProv
            // 
            this.btnModificarProv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificarProv.Location = new System.Drawing.Point(620, 75);
            this.btnModificarProv.Name = "btnModificarProv";
            this.btnModificarProv.Size = new System.Drawing.Size(107, 41);
            this.btnModificarProv.TabIndex = 13;
            this.btnModificarProv.Text = "Modificar";
            this.btnModificarProv.UseVisualStyleBackColor = false;
            // 
            // txtCodMat
            // 
            this.txtCodMat.Location = new System.Drawing.Point(171, 25);
            this.txtCodMat.Name = "txtCodMat";
            this.txtCodMat.Size = new System.Drawing.Size(148, 20);
            this.txtCodMat.TabIndex = 0;
            // 
            // btnInhabilitarMat
            // 
            this.btnInhabilitarMat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInhabilitarMat.Location = new System.Drawing.Point(620, 132);
            this.btnInhabilitarMat.Name = "btnInhabilitarMat";
            this.btnInhabilitarMat.Size = new System.Drawing.Size(107, 41);
            this.btnInhabilitarMat.TabIndex = 15;
            this.btnInhabilitarMat.Text = "Inhabilitar Material";
            this.btnInhabilitarMat.UseVisualStyleBackColor = false;
            // 
            // txtDescMaterial
            // 
            this.txtDescMaterial.Location = new System.Drawing.Point(171, 55);
            this.txtDescMaterial.Name = "txtDescMaterial";
            this.txtDescMaterial.Size = new System.Drawing.Size(402, 20);
            this.txtDescMaterial.TabIndex = 1;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(171, 143);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(132, 20);
            this.txtStock.TabIndex = 9;
            // 
            // cbUndMed
            // 
            this.cbUndMed.FormattingEnabled = true;
            this.cbUndMed.Location = new System.Drawing.Point(171, 86);
            this.cbUndMed.Name = "cbUndMed";
            this.cbUndMed.Size = new System.Drawing.Size(132, 21);
            this.cbUndMed.TabIndex = 16;
            // 
            // lbCategoriaMat
            // 
            this.lbCategoriaMat.AutoSize = true;
            this.lbCategoriaMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoriaMat.Location = new System.Drawing.Point(18, 117);
            this.lbCategoriaMat.Name = "lbCategoriaMat";
            this.lbCategoriaMat.Size = new System.Drawing.Size(114, 13);
            this.lbCategoriaMat.TabIndex = 18;
            this.lbCategoriaMat.Text = "Categoria Material:";
            // 
            // cbCategoriaMat
            // 
            this.cbCategoriaMat.FormattingEnabled = true;
            this.cbCategoriaMat.Location = new System.Drawing.Point(171, 114);
            this.cbCategoriaMat.Name = "cbCategoriaMat";
            this.cbCategoriaMat.Size = new System.Drawing.Size(241, 21);
            this.cbCategoriaMat.TabIndex = 19;
            // 
            // gbDatosMaterial
            // 
            this.gbDatosMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbDatosMaterial.Controls.Add(this.cbCategoriaMat);
            this.gbDatosMaterial.Controls.Add(this.lbCategoriaMat);
            this.gbDatosMaterial.Controls.Add(this.cbUndMed);
            this.gbDatosMaterial.Controls.Add(this.txtStock);
            this.gbDatosMaterial.Controls.Add(this.txtDescMaterial);
            this.gbDatosMaterial.Controls.Add(this.btnInhabilitarMat);
            this.gbDatosMaterial.Controls.Add(this.txtCodMat);
            this.gbDatosMaterial.Controls.Add(this.btnModificarProv);
            this.gbDatosMaterial.Controls.Add(this.lbStock);
            this.gbDatosMaterial.Controls.Add(this.btnNuevoProv);
            this.gbDatosMaterial.Controls.Add(this.lbUni);
            this.gbDatosMaterial.Controls.Add(this.lbCodMat);
            this.gbDatosMaterial.Controls.Add(this.lbDescMat);
            this.gbDatosMaterial.Location = new System.Drawing.Point(47, 104);
            this.gbDatosMaterial.Name = "gbDatosMaterial";
            this.gbDatosMaterial.Size = new System.Drawing.Size(757, 191);
            this.gbDatosMaterial.TabIndex = 12;
            this.gbDatosMaterial.TabStop = false;
            this.gbDatosMaterial.Text = "Datos del Material";
            // 
            // MantenedorMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(854, 634);
            this.Controls.Add(this.lbTituloMat);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvMantenedorMat);
            this.Controls.Add(this.btnBuscarMat);
            this.Controls.Add(this.gbDatosMaterial);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "MantenedorMaterial";
            this.Text = "Mantenedor Material";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenedorMat)).EndInit();
            this.gbDatosMaterial.ResumeLayout(false);
            this.gbDatosMaterial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lbTituloMat;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBuscarMat;
        private System.Windows.Forms.DataGridView dgvMantenedorMat;
        private System.Windows.Forms.Label lbDescMat;
        private System.Windows.Forms.Label lbCodMat;
        private System.Windows.Forms.Label lbUni;
        private System.Windows.Forms.Button btnNuevoProv;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Button btnModificarProv;
        private System.Windows.Forms.TextBox txtCodMat;
        private System.Windows.Forms.Button btnInhabilitarMat;
        private System.Windows.Forms.TextBox txtDescMaterial;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.ComboBox cbUndMed;
        private System.Windows.Forms.Label lbCategoriaMat;
        private System.Windows.Forms.ComboBox cbCategoriaMat;
        private System.Windows.Forms.GroupBox gbDatosMaterial;
    }
}