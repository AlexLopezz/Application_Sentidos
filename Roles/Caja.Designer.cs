namespace Application_Sentidos.Roles
{
    partial class Caja
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
            this.dataGridDetalleCajaPedidos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.metodoDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efectivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjDebitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditoPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalleCajaPedidos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(383, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "PEDIDOS";
            // 
            // dataGridDetalleCajaPedidos
            // 
            this.dataGridDetalleCajaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetalleCajaPedidos.Location = new System.Drawing.Point(383, 93);
            this.dataGridDetalleCajaPedidos.Name = "dataGridDetalleCajaPedidos";
            this.dataGridDetalleCajaPedidos.RowTemplate.Height = 25;
            this.dataGridDetalleCajaPedidos.Size = new System.Drawing.Size(240, 375);
            this.dataGridDetalleCajaPedidos.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metodoDePagoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // metodoDePagoToolStripMenuItem
            // 
            this.metodoDePagoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.efectivoToolStripMenuItem,
            this.tarjCreditoToolStripMenuItem,
            this.tarjDebitoToolStripMenuItem,
            this.creditoPersonalToolStripMenuItem});
            this.metodoDePagoToolStripMenuItem.Name = "metodoDePagoToolStripMenuItem";
            this.metodoDePagoToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.metodoDePagoToolStripMenuItem.Text = "Metodo de Pago";
            // 
            // efectivoToolStripMenuItem
            // 
            this.efectivoToolStripMenuItem.Name = "efectivoToolStripMenuItem";
            this.efectivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.efectivoToolStripMenuItem.Text = "Efectivo";
            this.efectivoToolStripMenuItem.Click += new System.EventHandler(this.efectivoToolStripMenuItem_Click);
            // 
            // tarjCreditoToolStripMenuItem
            // 
            this.tarjCreditoToolStripMenuItem.Name = "tarjCreditoToolStripMenuItem";
            this.tarjCreditoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tarjCreditoToolStripMenuItem.Text = "Tarj. Credito";
            this.tarjCreditoToolStripMenuItem.Click += new System.EventHandler(this.tarjCreditoToolStripMenuItem_Click);
            // 
            // tarjDebitoToolStripMenuItem
            // 
            this.tarjDebitoToolStripMenuItem.Name = "tarjDebitoToolStripMenuItem";
            this.tarjDebitoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tarjDebitoToolStripMenuItem.Text = "Tarj. Debito";
            this.tarjDebitoToolStripMenuItem.Click += new System.EventHandler(this.tarjDebitoToolStripMenuItem_Click);
            // 
            // creditoPersonalToolStripMenuItem
            // 
            this.creditoPersonalToolStripMenuItem.Name = "creditoPersonalToolStripMenuItem";
            this.creditoPersonalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creditoPersonalToolStripMenuItem.Text = "Mercado Pago";
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 480);
            this.Controls.Add(this.dataGridDetalleCajaPedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Caja";
            this.Text = "Caja";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalleCajaPedidos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private DataGridView dataGridDetalleCajaPedidos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem metodoDePagoToolStripMenuItem;
        private ToolStripMenuItem efectivoToolStripMenuItem;
        private ToolStripMenuItem tarjCreditoToolStripMenuItem;
        private ToolStripMenuItem tarjDebitoToolStripMenuItem;
        private ToolStripMenuItem creditoPersonalToolStripMenuItem;
    }
}