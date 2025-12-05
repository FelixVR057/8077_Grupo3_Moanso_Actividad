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
            this.gbDatosMaterial = new System.Windows.Forms.GroupBox();
            this.cbUndMed = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtDescMaterial = new System.Windows.Forms.TextBox();
            this.btnInhabilitarMat = new System.Windows.Forms.Button();
            this.txtCodMat = new System.Windows.Forms.TextBox();
            this.btnModificarMat = new System.Windows.Forms.Button();
            this.lbStock = new System.Windows.Forms.Label();
            this.btnNuevoMat = new System.Windows.Forms.Button();
            this.lbUni = new System.Windows.Forms.Label();
            this.lbCodMat = new System.Windows.Forms.Label();
            this.lbDescMat = new System.Windows.Forms.Label();
            this.dgvMantenedorMat = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBuscarMat = new System.Windows.Forms.Button();
            this.lbTituloMat = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lbCategoriaMat = new System.Windows.Forms.Label();
            this.btnGuardarMat = new System.Windows.Forms.Button();
            this.gbDatosMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenedorMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosMaterial
            // 
            this.gbDatosMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbDatosMaterial.Controls.Add(this.cbUndMed);
            this.gbDatosMaterial.Controls.Add(this.lbCategoriaMat);
            this.gbDatosMaterial.Controls.Add(this.txtStock);
            this.gbDatosMaterial.Controls.Add(this.txtDescMaterial);
            this.gbDatosMaterial.Controls.Add(this.txtCodMat);
            this.gbDatosMaterial.Controls.Add(this.lbStock);
            this.gbDatosMaterial.Controls.Add(this.lbUni);
            this.gbDatosMaterial.Controls.Add(this.lbCodMat);
            this.gbDatosMaterial.Controls.Add(this.lbDescMat);
            this.gbDatosMaterial.Location = new System.Drawing.Point(35, 115);
            this.gbDatosMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatosMaterial.Name = "gbDatosMaterial";
            this.gbDatosMaterial.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatosMaterial.Size = new System.Drawing.Size(504, 198);
            this.gbDatosMaterial.TabIndex = 12;
            this.gbDatosMaterial.TabStop = false;
            this.gbDatosMaterial.Text = "Datos del Material";
            // 
            // cbUndMed
            // 
            this.cbUndMed.FormattingEnabled = true;
            this.cbUndMed.Items.AddRange(new object[] {
            "Kg",
            "m",
            "l",
            "Unidad"});
            this.cbUndMed.Location = new System.Drawing.Point(171, 118);
            this.cbUndMed.Margin = new System.Windows.Forms.Padding(2);
            this.cbUndMed.Name = "cbUndMed";
            this.cbUndMed.Size = new System.Drawing.Size(182, 21);
            this.cbUndMed.TabIndex = 19;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(171, 150);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 9;
            // 
            // txtDescMaterial
            // 
            this.txtDescMaterial.Location = new System.Drawing.Point(171, 59);
            this.txtDescMaterial.Name = "txtDescMaterial";
            this.txtDescMaterial.Size = new System.Drawing.Size(302, 20);
            this.txtDescMaterial.TabIndex = 1;
            // 
            // btnInhabilitarMat
            // 
            this.btnInhabilitarMat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInhabilitarMat.Location = new System.Drawing.Point(566, 211);
            this.btnInhabilitarMat.Margin = new System.Windows.Forms.Padding(2);
            this.btnInhabilitarMat.Name = "btnInhabilitarMat";
            this.btnInhabilitarMat.Size = new System.Drawing.Size(107, 41);
            this.btnInhabilitarMat.TabIndex = 15;
            this.btnInhabilitarMat.Text = "Inhabilitar Material";
            this.btnInhabilitarMat.UseVisualStyleBackColor = false;
            // 
            // txtCodMat
            // 
            this.txtCodMat.Location = new System.Drawing.Point(171, 25);
            this.txtCodMat.Name = "txtCodMat";
            this.txtCodMat.Size = new System.Drawing.Size(148, 20);
            this.txtCodMat.TabIndex = 0;
            // 
            // btnModificarMat
            // 
            this.btnModificarMat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificarMat.Location = new System.Drawing.Point(566, 160);
            this.btnModificarMat.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarMat.Name = "btnModificarMat";
            this.btnModificarMat.Size = new System.Drawing.Size(107, 41);
            this.btnModificarMat.TabIndex = 13;
            this.btnModificarMat.Text = "Modificar";
            this.btnModificarMat.UseVisualStyleBackColor = false;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.Location = new System.Drawing.Point(18, 153);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(44, 13);
            this.lbStock.TabIndex = 8;
            this.lbStock.Text = "Stock:";
            // 
            // btnNuevoMat
            // 
            this.btnNuevoMat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevoMat.Location = new System.Drawing.Point(566, 115);
            this.btnNuevoMat.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoMat.Name = "btnNuevoMat";
            this.btnNuevoMat.Size = new System.Drawing.Size(107, 41);
            this.btnNuevoMat.TabIndex = 12;
            this.btnNuevoMat.Text = "Nuevo";
            this.btnNuevoMat.UseVisualStyleBackColor = false;
            this.btnNuevoMat.Click += new System.EventHandler(this.btnNuevoMat_Click);
            // 
            // lbUni
            // 
            this.lbUni.AutoSize = true;
            this.lbUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUni.Location = new System.Drawing.Point(18, 124);
            this.lbUni.Name = "lbUni";
            this.lbUni.Size = new System.Drawing.Size(113, 13);
            this.lbUni.TabIndex = 7;
            this.lbUni.Text = "Unidad de medida:";
            // 
            // lbCodMat
            // 
            this.lbCodMat.AutoSize = true;
            this.lbCodMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodMat.Location = new System.Drawing.Point(18, 32);
            this.lbCodMat.Name = "lbCodMat";
            this.lbCodMat.Size = new System.Drawing.Size(99, 13);
            this.lbCodMat.TabIndex = 4;
            this.lbCodMat.Text = "Código Material:";
            // 
            // lbDescMat
            // 
            this.lbDescMat.AutoSize = true;
            this.lbDescMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescMat.Location = new System.Drawing.Point(18, 62);
            this.lbDescMat.Name = "lbDescMat";
            this.lbDescMat.Size = new System.Drawing.Size(147, 13);
            this.lbDescMat.TabIndex = 5;
            this.lbDescMat.Text = "Descripción del material:";
            // 
            // dgvMantenedorMat
            // 
            this.dgvMantenedorMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantenedorMat.Location = new System.Drawing.Point(35, 332);
            this.dgvMantenedorMat.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMantenedorMat.Name = "dgvMantenedorMat";
            this.dgvMantenedorMat.RowHeadersWidth = 51;
            this.dgvMantenedorMat.Size = new System.Drawing.Size(638, 277);
            this.dgvMantenedorMat.TabIndex = 17;
            this.dgvMantenedorMat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMantenedorMat_CellClick);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolver.Location = new System.Drawing.Point(35, 627);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 41);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnBuscarMat
            // 
            this.btnBuscarMat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarMat.Location = new System.Drawing.Point(573, 36);
            this.btnBuscarMat.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarMat.Name = "btnBuscarMat";
            this.btnBuscarMat.Size = new System.Drawing.Size(85, 47);
            this.btnBuscarMat.TabIndex = 18;
            this.btnBuscarMat.Text = "Buscar Material";
            this.btnBuscarMat.UseVisualStyleBackColor = false;
            // 
            // lbTituloMat
            // 
            this.lbTituloMat.AutoSize = true;
            this.lbTituloMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloMat.Location = new System.Drawing.Point(174, 35);
            this.lbTituloMat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloMat.Name = "lbTituloMat";
            this.lbTituloMat.Size = new System.Drawing.Size(356, 37);
            this.lbTituloMat.TabIndex = 20;
            this.lbTituloMat.Text = "Registro de Materiales";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::_8077_Grupo3_Moanso_Actividad.Properties.Resources.LogoEmpresa3;
            this.pictureBoxLogo.Location = new System.Drawing.Point(9, 10);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(52, 55);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 11;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lbCategoriaMat
            // 
            this.lbCategoriaMat.AutoSize = true;
            this.lbCategoriaMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoriaMat.Location = new System.Drawing.Point(18, 95);
            this.lbCategoriaMat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCategoriaMat.Name = "lbCategoriaMat";
            this.lbCategoriaMat.Size = new System.Drawing.Size(114, 13);
            this.lbCategoriaMat.TabIndex = 18;
            this.lbCategoriaMat.Text = "Categoria Material:";
            // 
            // btnGuardarMat
            // 
            this.btnGuardarMat.Location = new System.Drawing.Point(573, 290);
            this.btnGuardarMat.Name = "btnGuardarMat";
            this.btnGuardarMat.Size = new System.Drawing.Size(100, 23);
            this.btnGuardarMat.TabIndex = 20;
            this.btnGuardarMat.Text = "Guardar";
            this.btnGuardarMat.UseVisualStyleBackColor = true;
            this.btnGuardarMat.Click += new System.EventHandler(this.btnGuardarMat_Click);
            // 
            // MantenedorMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(712, 674);
            this.Controls.Add(this.btnGuardarMat);
            this.Controls.Add(this.lbTituloMat);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvMantenedorMat);
            this.Controls.Add(this.btnBuscarMat);
            this.Controls.Add(this.btnInhabilitarMat);
            this.Controls.Add(this.gbDatosMaterial);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.btnModificarMat);
            this.Controls.Add(this.btnNuevoMat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MantenedorMaterial";
            this.Text = "Mantenedor Material";
            this.gbDatosMaterial.ResumeLayout(false);
            this.gbDatosMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenedorMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.GroupBox gbDatosMaterial;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnInhabilitarMat;
        private System.Windows.Forms.TextBox txtCodMat;
        private System.Windows.Forms.TextBox txtDescMaterial;
        private System.Windows.Forms.Button btnModificarMat;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Button btnNuevoMat;
        private System.Windows.Forms.Label lbUni;
        private System.Windows.Forms.Label lbCodMat;
        private System.Windows.Forms.Label lbDescMat;
        private System.Windows.Forms.DataGridView dgvMantenedorMat;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBuscarMat;
        private System.Windows.Forms.Label lbTituloMat;
        private System.Windows.Forms.ComboBox cbUndMed;
        private System.Windows.Forms.Label lbCategoriaMat;
        private System.Windows.Forms.Button btnGuardarMat;
    }
}