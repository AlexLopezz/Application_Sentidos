namespace Application_Sentidos.Roles.Chef
{
    partial class Modificar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductoMenu = new System.Windows.Forms.DataGridView();
            this.IMAGEN = new System.Windows.Forms.DataGridViewImageColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttAgregarProducto = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreMenu = new System.Windows.Forms.TextBox();
            this.lblDetalleProducto = new System.Windows.Forms.Label();
            this.bttEliminarProducto = new System.Windows.Forms.Button();
            this.bttModificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttLimpiar = new System.Windows.Forms.Button();
            this.bttBuscarNombreProducto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategories = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.COD_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoMenu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductoMenu
            // 
            this.dgvProductoMenu.AllowUserToAddRows = false;
            this.dgvProductoMenu.AllowUserToDeleteRows = false;
            this.dgvProductoMenu.AllowUserToResizeColumns = false;
            this.dgvProductoMenu.AllowUserToResizeRows = false;
            this.dgvProductoMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductoMenu.BackgroundColor = System.Drawing.Color.Plum;
            this.dgvProductoMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductoMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductoMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IMAGEN,
            this.DESCRIPCION,
            this.NOMBRE,
            this.ID});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductoMenu.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductoMenu.GridColor = System.Drawing.Color.Plum;
            this.dgvProductoMenu.Location = new System.Drawing.Point(37, 84);
            this.dgvProductoMenu.Name = "dgvProductoMenu";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductoMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProductoMenu.RowHeadersVisible = false;
            this.dgvProductoMenu.RowTemplate.Height = 75;
            this.dgvProductoMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductoMenu.Size = new System.Drawing.Size(351, 303);
            this.dgvProductoMenu.TabIndex = 1;
            // 
            // IMAGEN
            // 
            this.IMAGEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IMAGEN.FillWeight = 84.00114F;
            this.IMAGEN.HeaderText = "Imagen";
            this.IMAGEN.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.IMAGEN.Name = "IMAGEN";
            this.IMAGEN.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.FillWeight = 123.4817F;
            this.DESCRIPCION.HeaderText = "Descripcion";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.FillWeight = 123.4817F;
            this.NOMBRE.HeaderText = "Nombre";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "Cod Producto";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // bttAgregarProducto
            // 
            this.bttAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttAgregarProducto.FlatAppearance.BorderSize = 0;
            this.bttAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttAgregarProducto.Location = new System.Drawing.Point(401, 86);
            this.bttAgregarProducto.Name = "bttAgregarProducto";
            this.bttAgregarProducto.Size = new System.Drawing.Size(79, 45);
            this.bttAgregarProducto.TabIndex = 2;
            this.bttAgregarProducto.Text = "Agregar producto";
            this.bttAgregarProducto.UseVisualStyleBackColor = false;
            this.bttAgregarProducto.Click += new System.EventHandler(this.bttAgregarProducto_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(37, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "*Nombre";
            // 
            // txtNombreMenu
            // 
            this.txtNombreMenu.Location = new System.Drawing.Point(101, 32);
            this.txtNombreMenu.Name = "txtNombreMenu";
            this.txtNombreMenu.Size = new System.Drawing.Size(168, 23);
            this.txtNombreMenu.TabIndex = 4;
            this.txtNombreMenu.TextChanged += new System.EventHandler(this.txtNombreMenu_TextChanged);
            // 
            // lblDetalleProducto
            // 
            this.lblDetalleProducto.AutoSize = true;
            this.lblDetalleProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblDetalleProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetalleProducto.Location = new System.Drawing.Point(37, 66);
            this.lblDetalleProducto.Name = "lblDetalleProducto";
            this.lblDetalleProducto.Size = new System.Drawing.Size(123, 15);
            this.lblDetalleProducto.TabIndex = 5;
            this.lblDetalleProducto.Text = "*Detalle de producto";
            // 
            // bttEliminarProducto
            // 
            this.bttEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttEliminarProducto.FlatAppearance.BorderSize = 0;
            this.bttEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEliminarProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttEliminarProducto.Location = new System.Drawing.Point(401, 137);
            this.bttEliminarProducto.Name = "bttEliminarProducto";
            this.bttEliminarProducto.Size = new System.Drawing.Size(79, 41);
            this.bttEliminarProducto.TabIndex = 6;
            this.bttEliminarProducto.Text = "Eliminar producto";
            this.bttEliminarProducto.UseVisualStyleBackColor = false;
            this.bttEliminarProducto.Click += new System.EventHandler(this.bttEliminarProducto_Click);
            // 
            // bttModificar
            // 
            this.bttModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bttModificar.FlatAppearance.BorderSize = 0;
            this.bttModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttModificar.Location = new System.Drawing.Point(394, 348);
            this.bttModificar.Name = "bttModificar";
            this.bttModificar.Size = new System.Drawing.Size(105, 39);
            this.bttModificar.TabIndex = 7;
            this.bttModificar.Text = "Modificar menu";
            this.bttModificar.UseVisualStyleBackColor = false;
            this.bttModificar.Click += new System.EventHandler(this.bttModificar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.bttModificar);
            this.panel1.Controls.Add(this.dgvProductoMenu);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtNombreMenu);
            this.panel1.Controls.Add(this.lblDetalleProducto);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 411);
            this.panel1.TabIndex = 8;
            // 
            // bttLimpiar
            // 
            this.bttLimpiar.Location = new System.Drawing.Point(816, 44);
            this.bttLimpiar.Name = "bttLimpiar";
            this.bttLimpiar.Size = new System.Drawing.Size(59, 23);
            this.bttLimpiar.TabIndex = 31;
            this.bttLimpiar.Text = "Limpiar";
            this.bttLimpiar.UseVisualStyleBackColor = true;
            this.bttLimpiar.Click += new System.EventHandler(this.bttLimpiar_Click);
            // 
            // bttBuscarNombreProducto
            // 
            this.bttBuscarNombreProducto.Image = ((System.Drawing.Image)(resources.GetObject("bttBuscarNombreProducto.Image")));
            this.bttBuscarNombreProducto.Location = new System.Drawing.Point(769, 44);
            this.bttBuscarNombreProducto.Name = "bttBuscarNombreProducto";
            this.bttBuscarNombreProducto.Size = new System.Drawing.Size(41, 32);
            this.bttBuscarNombreProducto.TabIndex = 30;
            this.bttBuscarNombreProducto.UseVisualStyleBackColor = true;
            this.bttBuscarNombreProducto.Click += new System.EventHandler(this.bttBuscarNombreProducto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(580, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre\r\nProducto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(642, 47);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(121, 23);
            this.txtNombreProducto.TabIndex = 28;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoria.Location = new System.Drawing.Point(578, 21);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(60, 15);
            this.lblCategoria.TabIndex = 27;
            this.lblCategoria.Text = "Categoria";
            // 
            // cboCategories
            // 
            this.cboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategories.FormattingEnabled = true;
            this.cboCategories.Location = new System.Drawing.Point(642, 18);
            this.cboCategories.Name = "cboCategories";
            this.cboCategories.Size = new System.Drawing.Size(121, 23);
            this.cboCategories.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(793, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 38);
            this.button1.TabIndex = 25;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_PRODUCTO,
            this.dataGridViewTextBoxColumn1});
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.Plum;
            this.dgvProductos.Location = new System.Drawing.Point(578, 92);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(295, 277);
            this.dgvProductos.TabIndex = 24;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 108.6294F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(514, 411);
            this.Controls.Add(this.bttLimpiar);
            this.Controls.Add(this.bttBuscarNombreProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cboCategories);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.bttEliminarProducto);
            this.Controls.Add(this.bttAgregarProducto);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modificar";
            this.Text = "Modificar menu - Sentidos & Casa da Te";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button bttAgregarProducto;
        private Label lblNombre;
        private TextBox txtNombreMenu;
        private Label lblDetalleProducto;
        private Button bttEliminarProducto;
        private Button bttModificar;
        private Panel panel1;
        public DataGridView dgvProductoMenu;
        private Button bttLimpiar;
        private Button bttBuscarNombreProducto;
        private Label label2;
        private TextBox txtNombreProducto;
        private Label lblCategoria;
        private ComboBox cboCategories;
        private Button button1;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn COD_PRODUCTO;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewImageColumn IMAGEN;
        private DataGridViewTextBoxColumn DESCRIPCION;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn ID;
    }
}