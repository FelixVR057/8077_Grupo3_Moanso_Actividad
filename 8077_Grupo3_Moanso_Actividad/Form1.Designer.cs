namespace _8077_Grupo3_Moanso_Actividad
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.lbRuc = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lbProducto = new System.Windows.Forms.Label();
            this.lbPrecioUnitario = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbProveedor = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompra
            // 
            this.dgvCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Location = new System.Drawing.Point(38, 329);
            this.dgvCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.RowHeadersWidth = 62;
            this.dgvCompra.RowTemplate.Height = 28;
            this.dgvCompra.Size = new System.Drawing.Size(784, 198);
            this.dgvCompra.TabIndex = 1;
            this.dgvCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompra_CellClick);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(38, 547);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(145, 42);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lbFecha);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtRuc);
            this.groupBox1.Controls.Add(this.lbRuc);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.txtProveedor);
            this.groupBox1.Controls.Add(this.lbProducto);
            this.groupBox1.Controls.Add(this.lbPrecioUnitario);
            this.groupBox1.Controls.Add(this.lbCantidad);
            this.groupBox1.Controls.Add(this.lbProveedor);
            this.groupBox1.Location = new System.Drawing.Point(38, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(784, 215);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compra";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(353, 120);
            this.lbFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(46, 13);
            this.lbFecha.TabIndex = 18;
            this.lbFecha.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(403, 120);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(400, 32);
            this.txtRuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(105, 20);
            this.txtRuc.TabIndex = 16;
            // 
            // lbRuc
            // 
            this.lbRuc.AutoSize = true;
            this.lbRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRuc.Location = new System.Drawing.Point(362, 34);
            this.lbRuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRuc.Name = "lbRuc";
            this.lbRuc.Size = new System.Drawing.Size(37, 13);
            this.lbRuc.TabIndex = 15;
            this.lbRuc.Text = "RUC:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(128, 143);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(152, 20);
            this.txtPrecio.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(640, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(94, 106);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(186, 20);
            this.txtCantidad.TabIndex = 13;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(95, 70);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(452, 20);
            this.txtProducto.TabIndex = 13;
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.Color.White;
            this.txtProveedor.Location = new System.Drawing.Point(95, 32);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(262, 20);
            this.txtProveedor.TabIndex = 13;
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducto.Location = new System.Drawing.Point(28, 70);
            this.lbProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(62, 13);
            this.lbProducto.TabIndex = 12;
            this.lbProducto.Text = "Producto:";
            // 
            // lbPrecioUnitario
            // 
            this.lbPrecioUnitario.AutoSize = true;
            this.lbPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioUnitario.Location = new System.Drawing.Point(28, 146);
            this.lbPrecioUnitario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrecioUnitario.Name = "lbPrecioUnitario";
            this.lbPrecioUnitario.Size = new System.Drawing.Size(95, 13);
            this.lbPrecioUnitario.TabIndex = 11;
            this.lbPrecioUnitario.Text = "Precio Unitario:";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(28, 109);
            this.lbCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(61, 13);
            this.lbCantidad.TabIndex = 10;
            this.lbCantidad.Text = "Cantidad:";
            // 
            // lbProveedor
            // 
            this.lbProveedor.AutoSize = true;
            this.lbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProveedor.Location = new System.Drawing.Point(24, 32);
            this.lbProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProveedor.Name = "lbProveedor";
            this.lbProveedor.Size = new System.Drawing.Size(69, 13);
            this.lbProveedor.TabIndex = 9;
            this.lbProveedor.Text = "Proveedor:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(599, 106);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 42);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Anular";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(667, 28);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(145, 42);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(190, 38);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(469, 37);
            this.lbTitulo.TabIndex = 8;
            this.lbTitulo.Text = "Registrar Compra De Material";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::_8077_Grupo3_Moanso_Actividad.Properties.Resources.LogoEmpresa3;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 28);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(69, 68);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 614);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "Form1";
            this.Text = "Registro de Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.Label lbPrecioUnitario;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbProveedor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label lbRuc;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Button button1;
    }
}

