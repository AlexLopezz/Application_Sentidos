namespace Application_Sentidos.Roles
{
    partial class Mozo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCargarMesa = new System.Windows.Forms.Button();
            this.btnModificarPedido = new System.Windows.Forms.Button();
            this.lblNumeroMesa = new System.Windows.Forms.Label();
            this.cboBoxMesas = new System.Windows.Forms.ComboBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPedidoMesa = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPedidosACerrar = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.btnCerrarMesa = new System.Windows.Forms.Button();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoMesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosACerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° de Meza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categorias";
            // 
            // cboBoxCategorias
            // 
            this.cboBoxCategorias.FormattingEnabled = true;
            this.cboBoxCategorias.Items.AddRange(new object[] {
            "Bebidas sin alcohol",
            "Bebidas con alcohol",
            "Hamburguesas",
            "Lomitos",
            "Pastas",
            "Pescados",
            "Pizzas",
            "Snacks"});
            this.cboBoxCategorias.Location = new System.Drawing.Point(120, 38);
            this.cboBoxCategorias.Name = "cboBoxCategorias";
            this.cboBoxCategorias.Size = new System.Drawing.Size(121, 23);
            this.cboBoxCategorias.TabIndex = 3;
            this.cboBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.cboBoxCategorias_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(247, 260);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(247, 309);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pedido de Mesa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(698, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pedidos en Espera";
            // 
            // btnCargarMesa
            // 
            this.btnCargarMesa.Location = new System.Drawing.Point(537, 21);
            this.btnCargarMesa.Name = "btnCargarMesa";
            this.btnCargarMesa.Size = new System.Drawing.Size(103, 61);
            this.btnCargarMesa.TabIndex = 14;
            this.btnCargarMesa.Text = "Cargar Mesa";
            this.btnCargarMesa.UseVisualStyleBackColor = true;
            this.btnCargarMesa.Click += new System.EventHandler(this.btnCargarMesa_Click);
            // 
            // btnModificarPedido
            // 
            this.btnModificarPedido.Location = new System.Drawing.Point(698, 21);
            this.btnModificarPedido.Name = "btnModificarPedido";
            this.btnModificarPedido.Size = new System.Drawing.Size(103, 61);
            this.btnModificarPedido.TabIndex = 15;
            this.btnModificarPedido.Text = "Modificar Mesa";
            this.btnModificarPedido.UseVisualStyleBackColor = true;
            this.btnModificarPedido.Click += new System.EventHandler(this.btnModificarPedido_Click);
            // 
            // lblNumeroMesa
            // 
            this.lblNumeroMesa.AutoSize = true;
            this.lblNumeroMesa.Location = new System.Drawing.Point(444, 111);
            this.lblNumeroMesa.Name = "lblNumeroMesa";
            this.lblNumeroMesa.Size = new System.Drawing.Size(12, 15);
            this.lblNumeroMesa.TabIndex = 16;
            this.lblNumeroMesa.Text = "-";
            // 
            // cboBoxMesas
            // 
            this.cboBoxMesas.FormattingEnabled = true;
            this.cboBoxMesas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cboBoxMesas.Location = new System.Drawing.Point(120, 6);
            this.cboBoxMesas.Name = "cboBoxMesas";
            this.cboBoxMesas.Size = new System.Drawing.Size(121, 23);
            this.cboBoxMesas.TabIndex = 17;
            this.cboBoxMesas.SelectedIndexChanged += new System.EventHandler(this.cboBoxMesas_SelectedIndexChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvProductos.Location = new System.Drawing.Point(12, 141);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(229, 304);
            this.dgvProductos.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dgvPedidoMesa
            // 
            this.dgvPedidoMesa.AllowUserToAddRows = false;
            this.dgvPedidoMesa.AllowUserToDeleteRows = false;
            this.dgvPedidoMesa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidoMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoMesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvPedidoMesa.Location = new System.Drawing.Point(328, 141);
            this.dgvPedidoMesa.Name = "dgvPedidoMesa";
            this.dgvPedidoMesa.ReadOnly = true;
            this.dgvPedidoMesa.RowHeadersVisible = false;
            this.dgvPedidoMesa.RowTemplate.Height = 25;
            this.dgvPedidoMesa.Size = new System.Drawing.Size(329, 304);
            this.dgvPedidoMesa.TabIndex = 19;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Producto";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // dgvPedidosACerrar
            // 
            this.dgvPedidosACerrar.AllowUserToAddRows = false;
            this.dgvPedidosACerrar.AllowUserToDeleteRows = false;
            this.dgvPedidosACerrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidosACerrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosACerrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8});
            this.dgvPedidosACerrar.Location = new System.Drawing.Point(663, 141);
            this.dgvPedidosACerrar.Name = "dgvPedidosACerrar";
            this.dgvPedidosACerrar.ReadOnly = true;
            this.dgvPedidosACerrar.RowHeadersVisible = false;
            this.dgvPedidosACerrar.RowTemplate.Height = 25;
            this.dgvPedidosACerrar.Size = new System.Drawing.Size(287, 304);
            this.dgvPedidosACerrar.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cantidad";
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Location = new System.Drawing.Point(120, 72);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(121, 23);
            this.txtBoxCantidad.TabIndex = 22;
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.Location = new System.Drawing.Point(379, 21);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(103, 61);
            this.btnNuevoPedido.TabIndex = 23;
            this.btnNuevoPedido.Text = "Nuevo";
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // btnCerrarMesa
            // 
            this.btnCerrarMesa.Location = new System.Drawing.Point(847, 21);
            this.btnCerrarMesa.Name = "btnCerrarMesa";
            this.btnCerrarMesa.Size = new System.Drawing.Size(103, 61);
            this.btnCerrarMesa.TabIndex = 24;
            this.btnCerrarMesa.Text = "Cerrar Mesa";
            this.btnCerrarMesa.UseVisualStyleBackColor = true;
            this.btnCerrarMesa.Click += new System.EventHandler(this.btnCerrarMesa_Click_1);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "N° Mesa";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Total";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Mozo
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(962, 457);
            this.Controls.Add(this.btnCerrarMesa);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.txtBoxCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvPedidosACerrar);
            this.Controls.Add(this.dgvPedidoMesa);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.cboBoxMesas);
            this.Controls.Add(this.lblNumeroMesa);
            this.Controls.Add(this.btnModificarPedido);
            this.Controls.Add(this.btnCargarMesa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboBoxCategorias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Mozo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Mozo";
            this.Load += new System.EventHandler(this.Mozo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoMesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosACerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboBoxCategorias;
        private Button btnAgregar;
        private Button btnBorrar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCargarMesa;
        private Button btnModificarPedido;
        private Label lblNumeroMesa;
        private ComboBox cboBoxMesas;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridView dgvPedidoMesa;
        private DataGridView dgvPedidosACerrar;
        private Label label7;
        private TextBox txtBoxCantidad;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button btnNuevoPedido;
        private Button btnCerrarMesa;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}