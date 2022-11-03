namespace Application_Sentidos.Roles.Chef
{
    partial class Menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.dgvMenuName = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMisMenus = new System.Windows.Forms.Label();
            this.dgvDetalleMenu = new System.Windows.Forms.DataGridView();
            this.Imagen_Producto = new System.Windows.Forms.DataGridViewImageColumn();
            this.DescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDetalleMenu = new System.Windows.Forms.Label();
            this.bttNuevoMenu = new System.Windows.Forms.Button();
            this.bttModificarMenu = new System.Windows.Forms.Button();
            this.bttEliminarMenu = new System.Windows.Forms.Button();
            this.bttRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMenuName
            // 
            this.dgvMenuName.AllowUserToAddRows = false;
            this.dgvMenuName.AllowUserToDeleteRows = false;
            this.dgvMenuName.AllowUserToResizeColumns = false;
            this.dgvMenuName.AllowUserToResizeRows = false;
            this.dgvMenuName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenuName.BackgroundColor = System.Drawing.Color.Plum;
            this.dgvMenuName.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMenuName.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenuName.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenuName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenuName.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMenuName.Location = new System.Drawing.Point(93, 75);
            this.dgvMenuName.Name = "dgvMenuName";
            this.dgvMenuName.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenuName.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMenuName.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMenuName.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMenuName.RowTemplate.Height = 25;
            this.dgvMenuName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenuName.Size = new System.Drawing.Size(188, 278);
            this.dgvMenuName.TabIndex = 0;
            this.dgvMenuName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenuName_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // lblMisMenus
            // 
            this.lblMisMenus.AutoSize = true;
            this.lblMisMenus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMisMenus.Location = new System.Drawing.Point(117, 52);
            this.lblMisMenus.Name = "lblMisMenus";
            this.lblMisMenus.Size = new System.Drawing.Size(68, 21);
            this.lblMisMenus.TabIndex = 1;
            this.lblMisMenus.Text = "MENUS";
            // 
            // dgvDetalleMenu
            // 
            this.dgvDetalleMenu.AllowUserToAddRows = false;
            this.dgvDetalleMenu.AllowUserToDeleteRows = false;
            this.dgvDetalleMenu.AllowUserToOrderColumns = true;
            this.dgvDetalleMenu.AllowUserToResizeColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDetalleMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetalleMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleMenu.BackgroundColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetalleMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imagen_Producto,
            this.DescripcionProducto,
            this.PriceProduct,
            this.NombreProducto});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleMenu.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetalleMenu.Location = new System.Drawing.Point(287, 75);
            this.dgvDetalleMenu.Name = "dgvDetalleMenu";
            this.dgvDetalleMenu.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(350);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDetalleMenu.RowHeadersVisible = false;
            this.dgvDetalleMenu.RowHeadersWidth = 100;
            this.dgvDetalleMenu.RowTemplate.Height = 75;
            this.dgvDetalleMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleMenu.Size = new System.Drawing.Size(457, 278);
            this.dgvDetalleMenu.TabIndex = 2;
            // 
            // Imagen_Producto
            // 
            this.Imagen_Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            this.Imagen_Producto.DefaultCellStyle = dataGridViewCellStyle7;
            this.Imagen_Producto.FillWeight = 231.4721F;
            this.Imagen_Producto.HeaderText = "Imagen";
            this.Imagen_Producto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Imagen_Producto.Name = "Imagen_Producto";
            this.Imagen_Producto.ReadOnly = true;
            this.Imagen_Producto.Width = 115;
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.FillWeight = 56.17598F;
            this.DescripcionProducto.HeaderText = "Descripcion";
            this.DescripcionProducto.Name = "DescripcionProducto";
            this.DescripcionProducto.ReadOnly = true;
            // 
            // PriceProduct
            // 
            this.PriceProduct.FillWeight = 56.17598F;
            this.PriceProduct.HeaderText = "Precio unitario";
            this.PriceProduct.Name = "PriceProduct";
            this.PriceProduct.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.FillWeight = 56.17598F;
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // lblDetalleMenu
            // 
            this.lblDetalleMenu.AutoSize = true;
            this.lblDetalleMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetalleMenu.Location = new System.Drawing.Point(287, 57);
            this.lblDetalleMenu.Name = "lblDetalleMenu";
            this.lblDetalleMenu.Size = new System.Drawing.Size(82, 15);
            this.lblDetalleMenu.TabIndex = 3;
            this.lblDetalleMenu.Text = "DETALLES DE ";
            // 
            // bttNuevoMenu
            // 
            this.bttNuevoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttNuevoMenu.FlatAppearance.BorderSize = 0;
            this.bttNuevoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttNuevoMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttNuevoMenu.Location = new System.Drawing.Point(12, 75);
            this.bttNuevoMenu.Name = "bttNuevoMenu";
            this.bttNuevoMenu.Size = new System.Drawing.Size(75, 38);
            this.bttNuevoMenu.TabIndex = 4;
            this.bttNuevoMenu.Text = "Nuevo menu";
            this.bttNuevoMenu.UseVisualStyleBackColor = false;
            // 
            // bttModificarMenu
            // 
            this.bttModificarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bttModificarMenu.FlatAppearance.BorderSize = 0;
            this.bttModificarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttModificarMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttModificarMenu.Location = new System.Drawing.Point(12, 119);
            this.bttModificarMenu.Name = "bttModificarMenu";
            this.bttModificarMenu.Size = new System.Drawing.Size(75, 36);
            this.bttModificarMenu.TabIndex = 5;
            this.bttModificarMenu.Text = "Modificar menu";
            this.bttModificarMenu.UseVisualStyleBackColor = false;
            // 
            // bttEliminarMenu
            // 
            this.bttEliminarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttEliminarMenu.FlatAppearance.BorderSize = 0;
            this.bttEliminarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEliminarMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttEliminarMenu.Location = new System.Drawing.Point(12, 161);
            this.bttEliminarMenu.Name = "bttEliminarMenu";
            this.bttEliminarMenu.Size = new System.Drawing.Size(75, 36);
            this.bttEliminarMenu.TabIndex = 6;
            this.bttEliminarMenu.Text = "Eliminar menu";
            this.bttEliminarMenu.UseVisualStyleBackColor = false;
            this.bttEliminarMenu.Click += new System.EventHandler(this.bttEliminarMenu_Click);
            // 
            // bttRefrescar
            // 
            this.bttRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("bttRefrescar.Image")));
            this.bttRefrescar.Location = new System.Drawing.Point(62, 203);
            this.bttRefrescar.Name = "bttRefrescar";
            this.bttRefrescar.Size = new System.Drawing.Size(25, 23);
            this.bttRefrescar.TabIndex = 7;
            this.bttRefrescar.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(809, 381);
            this.Controls.Add(this.bttRefrescar);
            this.Controls.Add(this.bttEliminarMenu);
            this.Controls.Add(this.bttModificarMenu);
            this.Controls.Add(this.bttNuevoMenu);
            this.Controls.Add(this.lblDetalleMenu);
            this.Controls.Add(this.dgvDetalleMenu);
            this.Controls.Add(this.lblMisMenus);
            this.Controls.Add(this.dgvMenuName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvMenuName;
        private Label lblMisMenus;
        private DataGridView dgvDetalleMenu;
        private Label lblDetalleMenu;
        private DataGridViewImageColumn Imagen_Producto;
        private DataGridViewTextBoxColumn DescripcionProducto;
        private DataGridViewTextBoxColumn PriceProduct;
        private DataGridViewTextBoxColumn NombreProducto;
        private Button bttNuevoMenu;
        private Button bttModificarMenu;
        private Button bttEliminarMenu;
        private Button bttRefrescar;
        private DataGridViewTextBoxColumn Nombre;
    }
}