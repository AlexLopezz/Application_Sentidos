namespace Application_Sentidos.Roles.Chef
{
    partial class ProductosCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosCategorias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bttAgregarCategoria = new System.Windows.Forms.Button();
            this.bttEliminarCategoria = new System.Windows.Forms.Button();
            this.lblListadoCategorias = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttAgregarProducto = new System.Windows.Forms.Button();
            this.bttModificarProducto = new System.Windows.Forms.Button();
            this.bttEliminarProducto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.COD_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGEN = new System.Windows.Forms.DataGridViewImageColumn();
            this.bttModificarCategoria = new System.Windows.Forms.Button();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductoNombre = new System.Windows.Forms.TextBox();
            this.bttBuscarNombreProducto = new System.Windows.Forms.Button();
            this.bttRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // bttAgregarCategoria
            // 
            this.bttAgregarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttAgregarCategoria.FlatAppearance.BorderSize = 0;
            this.bttAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAgregarCategoria.Location = new System.Drawing.Point(713, 76);
            this.bttAgregarCategoria.Name = "bttAgregarCategoria";
            this.bttAgregarCategoria.Size = new System.Drawing.Size(75, 39);
            this.bttAgregarCategoria.TabIndex = 2;
            this.bttAgregarCategoria.Text = "Agregar Categoria";
            this.bttAgregarCategoria.UseVisualStyleBackColor = false;
            this.bttAgregarCategoria.Click += new System.EventHandler(this.bttAgregarCategoria_Click);
            // 
            // bttEliminarCategoria
            // 
            this.bttEliminarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttEliminarCategoria.FlatAppearance.BorderSize = 0;
            this.bttEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEliminarCategoria.Location = new System.Drawing.Point(713, 166);
            this.bttEliminarCategoria.Name = "bttEliminarCategoria";
            this.bttEliminarCategoria.Size = new System.Drawing.Size(75, 39);
            this.bttEliminarCategoria.TabIndex = 3;
            this.bttEliminarCategoria.Text = "Eliminar Categoria";
            this.bttEliminarCategoria.UseVisualStyleBackColor = false;
            this.bttEliminarCategoria.Click += new System.EventHandler(this.bttEliminarCategoria_Click);
            // 
            // lblListadoCategorias
            // 
            this.lblListadoCategorias.AutoSize = true;
            this.lblListadoCategorias.Location = new System.Drawing.Point(560, 58);
            this.lblListadoCategorias.Name = "lblListadoCategorias";
            this.lblListadoCategorias.Size = new System.Drawing.Size(120, 15);
            this.lblListadoCategorias.TabIndex = 4;
            this.lblListadoCategorias.Text = "Listado de Categorias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Listado de productos";
            // 
            // bttAgregarProducto
            // 
            this.bttAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttAgregarProducto.FlatAppearance.BorderSize = 0;
            this.bttAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAgregarProducto.Location = new System.Drawing.Point(34, 94);
            this.bttAgregarProducto.Name = "bttAgregarProducto";
            this.bttAgregarProducto.Size = new System.Drawing.Size(75, 39);
            this.bttAgregarProducto.TabIndex = 6;
            this.bttAgregarProducto.Text = "Agregar Producto";
            this.bttAgregarProducto.UseVisualStyleBackColor = false;
            this.bttAgregarProducto.Click += new System.EventHandler(this.bttAgregarProducto_Click);
            // 
            // bttModificarProducto
            // 
            this.bttModificarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bttModificarProducto.FlatAppearance.BorderSize = 0;
            this.bttModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttModificarProducto.Location = new System.Drawing.Point(34, 139);
            this.bttModificarProducto.Name = "bttModificarProducto";
            this.bttModificarProducto.Size = new System.Drawing.Size(75, 39);
            this.bttModificarProducto.TabIndex = 7;
            this.bttModificarProducto.Text = "Modificar Producto";
            this.bttModificarProducto.UseVisualStyleBackColor = false;
            this.bttModificarProducto.Click += new System.EventHandler(this.bttModificarProducto_Click);
            // 
            // bttEliminarProducto
            // 
            this.bttEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttEliminarProducto.FlatAppearance.BorderSize = 0;
            this.bttEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEliminarProducto.Location = new System.Drawing.Point(34, 184);
            this.bttEliminarProducto.Name = "bttEliminarProducto";
            this.bttEliminarProducto.Size = new System.Drawing.Size(75, 39);
            this.bttEliminarProducto.TabIndex = 8;
            this.bttEliminarProducto.Text = "Eliminar Producto";
            this.bttEliminarProducto.UseVisualStyleBackColor = false;
            this.bttEliminarProducto.Click += new System.EventHandler(this.bttEliminarProducto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(576, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "ADMINISTRACION DE PRODUCTOS Y CATEGORIAS - RESTAURANTE SENTIDOS Y CASA DE TE";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.Plum;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_PRODUCTO,
            this.NOMBRE,
            this.IMAGEN});
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.Plum;
            this.dgvProductos.Location = new System.Drawing.Point(115, 90);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(407, 235);
            this.dgvProductos.TabIndex = 11;
            // 
            // COD_PRODUCTO
            // 
            this.COD_PRODUCTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.COD_PRODUCTO.FillWeight = 91.37056F;
            this.COD_PRODUCTO.HeaderText = "Cod. Producto";
            this.COD_PRODUCTO.Name = "COD_PRODUCTO";
            this.COD_PRODUCTO.ReadOnly = true;
            this.COD_PRODUCTO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.COD_PRODUCTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COD_PRODUCTO.Width = 70;
            // 
            // NOMBRE
            // 
            this.NOMBRE.FillWeight = 108.6294F;
            this.NOMBRE.HeaderText = "Nombre";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // IMAGEN
            // 
            this.IMAGEN.HeaderText = "Imagen";
            this.IMAGEN.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.IMAGEN.Name = "IMAGEN";
            this.IMAGEN.ReadOnly = true;
            // 
            // bttModificarCategoria
            // 
            this.bttModificarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bttModificarCategoria.FlatAppearance.BorderSize = 0;
            this.bttModificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttModificarCategoria.Location = new System.Drawing.Point(713, 121);
            this.bttModificarCategoria.Name = "bttModificarCategoria";
            this.bttModificarCategoria.Size = new System.Drawing.Size(75, 39);
            this.bttModificarCategoria.TabIndex = 12;
            this.bttModificarCategoria.Text = "Modificar Categoria";
            this.bttModificarCategoria.UseVisualStyleBackColor = false;
            this.bttModificarCategoria.Click += new System.EventHandler(this.bttModificarCategoria_Click);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.AllowUserToResizeColumns = false;
            this.dgvCategoria.AllowUserToResizeRows = false;
            this.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoria.BackgroundColor = System.Drawing.Color.Plum;
            this.dgvCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategoria.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCategoria.Location = new System.Drawing.Point(543, 76);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCategoria.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCategoria.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCategoria.RowTemplate.Height = 25;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(151, 278);
            this.dgvCategoria.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Producto";
            // 
            // txtProductoNombre
            // 
            this.txtProductoNombre.Location = new System.Drawing.Point(354, 61);
            this.txtProductoNombre.Name = "txtProductoNombre";
            this.txtProductoNombre.Size = new System.Drawing.Size(121, 23);
            this.txtProductoNombre.TabIndex = 16;
            // 
            // bttBuscarNombreProducto
            // 
            this.bttBuscarNombreProducto.Image = ((System.Drawing.Image)(resources.GetObject("bttBuscarNombreProducto.Image")));
            this.bttBuscarNombreProducto.Location = new System.Drawing.Point(481, 55);
            this.bttBuscarNombreProducto.Name = "bttBuscarNombreProducto";
            this.bttBuscarNombreProducto.Size = new System.Drawing.Size(41, 32);
            this.bttBuscarNombreProducto.TabIndex = 19;
            this.bttBuscarNombreProducto.UseVisualStyleBackColor = true;
            this.bttBuscarNombreProducto.Click += new System.EventHandler(this.bttBuscarNombreProducto_Click);
            // 
            // bttRefresh
            // 
            this.bttRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttRefresh.Image = ((System.Drawing.Image)(resources.GetObject("bttRefresh.Image")));
            this.bttRefresh.Location = new System.Drawing.Point(34, 229);
            this.bttRefresh.Name = "bttRefresh";
            this.bttRefresh.Size = new System.Drawing.Size(41, 27);
            this.bttRefresh.TabIndex = 20;
            this.bttRefresh.UseVisualStyleBackColor = true;
            this.bttRefresh.Click += new System.EventHandler(this.bttRefresh_Click);
            // 
            // ProductosCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(809, 381);
            this.Controls.Add(this.bttRefresh);
            this.Controls.Add(this.bttBuscarNombreProducto);
            this.Controls.Add(this.txtProductoNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.bttModificarCategoria);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttEliminarProducto);
            this.Controls.Add(this.bttModificarProducto);
            this.Controls.Add(this.bttAgregarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblListadoCategorias);
            this.Controls.Add(this.bttEliminarCategoria);
            this.Controls.Add(this.bttAgregarCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductosCategorias";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button bttAgregarCategoria;
        private Button bttEliminarCategoria;
        private Label lblListadoCategorias;
        private Label label1;
        private Button bttAgregarProducto;
        private Button bttModificarProducto;
        private Button bttEliminarProducto;
        private PictureBox pictureBox1;
        private Label label2;
        private DataGridView dgvProductos;
        private Button bttModificarCategoria;
        private DataGridView dgvCategoria;
        private Label label3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TextBox txtProductoNombre;
        private Button bttBuscarNombreProducto;
        private DataGridViewTextBoxColumn COD_PRODUCTO;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewImageColumn IMAGEN;
        private Button bttRefresh;
    }
}