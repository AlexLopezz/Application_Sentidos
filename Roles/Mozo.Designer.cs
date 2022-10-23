namespace Application_Sentidos.Roles
{
    partial class Mozo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public EventHandler Mozo_Load { get; private set; }

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
            this.listBoxItemsMenu = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.listBoxPedido = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.listBoxPedidosAConfirmar = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnModificarPedido = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBoxMesas = new System.Windows.Forms.ComboBox();
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
            this.cboBoxCategorias.Location = new System.Drawing.Point(136, 41);
            this.cboBoxCategorias.Name = "cboBoxCategorias";
            this.cboBoxCategorias.Size = new System.Drawing.Size(121, 23);
            this.cboBoxCategorias.TabIndex = 3;
            // 
            // listBoxItemsMenu
            // 
            this.listBoxItemsMenu.FormattingEnabled = true;
            this.listBoxItemsMenu.ItemHeight = 15;
            this.listBoxItemsMenu.Location = new System.Drawing.Point(28, 111);
            this.listBoxItemsMenu.Name = "listBoxItemsMenu";
            this.listBoxItemsMenu.Size = new System.Drawing.Size(229, 319);
            this.listBoxItemsMenu.TabIndex = 4;
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
            // listBoxPedido
            // 
            this.listBoxPedido.FormattingEnabled = true;
            this.listBoxPedido.ItemHeight = 15;
            this.listBoxPedido.Location = new System.Drawing.Point(344, 111);
            this.listBoxPedido.Name = "listBoxPedido";
            this.listBoxPedido.Size = new System.Drawing.Size(229, 319);
            this.listBoxPedido.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pedido de Mesa:";
            // 
            // listBoxPedidosAConfirmar
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(660, 111);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(207, 319);
            this.listBox3.TabIndex = 9;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(579, 263);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 10;
            this.btnPagar.Text = "Finalizar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            this.listBoxPedidosAConfirmar.FormattingEnabled = true;
            this.listBoxPedidosAConfirmar.ItemHeight = 15;
            this.listBoxPedidosAConfirmar.Location = new System.Drawing.Point(585, 111);
            this.listBoxPedidosAConfirmar.Name = "listBoxPedidosAConfirmar";
            this.listBoxPedidosAConfirmar.Size = new System.Drawing.Size(207, 319);
            this.listBoxPedidosAConfirmar.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pedidos en Espera";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(579, 214);
            this.btnConfirmar.Location = new System.Drawing.Point(810, 111);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 39);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Cerrar Mesa";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnModificarPedido
            // 
            this.btnModificarPedido.Location = new System.Drawing.Point(810, 156);
            this.btnModificarPedido.Name = "btnModificarPedido";
            this.btnModificarPedido.Size = new System.Drawing.Size(75, 39);
            this.btnModificarPedido.TabIndex = 15;
            this.btnModificarPedido.Text = "Modificar Mesa";
            this.btnModificarPedido.UseVisualStyleBackColor = true;
            this.btnModificarPedido.Click += new System.EventHandler(this.btnModificarPedido_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "N°";
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
            // 
            // Mozo
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(897, 457);
            this.Controls.Add(this.cboBoxMesas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnModificarPedido);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBoxPedidosAConfirmar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxPedido);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listBoxItemsMenu);
            this.Controls.Add(this.cboBoxCategorias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Mozo";
            this.Opacity = 0.2D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Mozo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboBoxCategorias;
        private ListBox listBoxItemsMenu;
        private Button btnAgregar;
        private Button btnBorrar;
        private ListBox listBoxPedido;
        private Label label3;
        private ListBox listBox3;
        private Button btnPagar;
        private ListBox listBoxPedidosAConfirmar;
        private Label label4;
        private Label label5;
        private Button btnConfirmar;
        private Button btnModificarPedido;
        private Label label6;
        private ComboBox cboBoxMesas;
    }
}