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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnModificarPedido = new System.Windows.Forms.Button();
            this.lblNumeroMesa = new System.Windows.Forms.Label();
            this.cboBoxMesas = new System.Windows.Forms.ComboBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPedidoMesa = new System.Windows.Forms.DataGridView();
            this.dgvPedidosACerrar = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.listBoxProductos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoMesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosACerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° de Meza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 44);
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
            this.cboBoxCategorias.Location = new System.Drawing.Point(136, 41);
            this.cboBoxCategorias.Name = "cboBoxCategorias";
            this.cboBoxCategorias.Size = new System.Drawing.Size(121, 23);
            this.cboBoxCategorias.TabIndex = 3;
            this.cboBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.cboBoxCategorias_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(263, 214);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(263, 263);
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
            this.label5.Location = new System.Drawing.Point(618, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pedidos en Espera";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(875, 111);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 39);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Cerrar Mesa";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnModificarPedido
            // 
            this.btnModificarPedido.Location = new System.Drawing.Point(875, 156);
            this.btnModificarPedido.Name = "btnModificarPedido";
            this.btnModificarPedido.Size = new System.Drawing.Size(75, 39);
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
            this.cboBoxMesas.Location = new System.Drawing.Point(136, 9);
            this.cboBoxMesas.Name = "cboBoxMesas";
            this.cboBoxMesas.Size = new System.Drawing.Size(121, 23);
            this.cboBoxMesas.TabIndex = 17;
            this.cboBoxMesas.SelectedIndexChanged += new System.EventHandler(this.cboBoxMesas_SelectedIndexChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvProductos.Location = new System.Drawing.Point(473, 29);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(111, 97);
            this.dgvProductos.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio";
            this.Column2.Name = "Column2";
            // 
            // dgvPedidoMesa
            // 
            this.dgvPedidoMesa.AllowUserToAddRows = false;
            this.dgvPedidoMesa.AllowUserToDeleteRows = false;
            this.dgvPedidoMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoMesa.Location = new System.Drawing.Point(344, 141);
            this.dgvPedidoMesa.Name = "dgvPedidoMesa";
            this.dgvPedidoMesa.ReadOnly = true;
            this.dgvPedidoMesa.RowTemplate.Height = 25;
            this.dgvPedidoMesa.Size = new System.Drawing.Size(240, 304);
            this.dgvPedidoMesa.TabIndex = 19;
            // 
            // dgvPedidosACerrar
            // 
            this.dgvPedidosACerrar.AllowUserToAddRows = false;
            this.dgvPedidosACerrar.AllowUserToDeleteRows = false;
            this.dgvPedidosACerrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosACerrar.Location = new System.Drawing.Point(618, 141);
            this.dgvPedidosACerrar.Name = "dgvPedidosACerrar";
            this.dgvPedidosACerrar.ReadOnly = true;
            this.dgvPedidosACerrar.RowTemplate.Height = 25;
            this.dgvPedidosACerrar.Size = new System.Drawing.Size(240, 304);
            this.dgvPedidosACerrar.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cantidad";
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Location = new System.Drawing.Point(136, 75);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(121, 23);
            this.txtBoxCantidad.TabIndex = 22;
            // 
            // listBoxProductos
            // 
            this.listBoxProductos.FormattingEnabled = true;
            this.listBoxProductos.ItemHeight = 15;
            this.listBoxProductos.Location = new System.Drawing.Point(12, 143);
            this.listBoxProductos.Name = "listBoxProductos";
            this.listBoxProductos.Size = new System.Drawing.Size(245, 304);
            this.listBoxProductos.TabIndex = 23;
            // 
            // Mozo
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(962, 457);
            this.Controls.Add(this.listBoxProductos);
            this.Controls.Add(this.txtBoxCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvPedidosACerrar);
            this.Controls.Add(this.dgvPedidoMesa);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.cboBoxMesas);
            this.Controls.Add(this.lblNumeroMesa);
            this.Controls.Add(this.btnModificarPedido);
            this.Controls.Add(this.btnConfirmar);
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
        private Button btnConfirmar;
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
        private ListBox listBoxProductos;
    }
}