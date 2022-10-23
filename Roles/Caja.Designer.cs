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
<<<<<<< HEAD
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridDetalleCajaPedidos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.metodoDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efectivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjDebitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditoPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalleCajaPedidos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 121);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridDetalleCajaPedidos
            // 
            this.dataGridDetalleCajaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetalleCajaPedidos.Location = new System.Drawing.Point(168, 186);
            this.dataGridDetalleCajaPedidos.Name = "dataGridDetalleCajaPedidos";
            this.dataGridDetalleCajaPedidos.RowTemplate.Height = 25;
            this.dataGridDetalleCajaPedidos.Size = new System.Drawing.Size(240, 150);
            this.dataGridDetalleCajaPedidos.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metodoDePagoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // metodoDePagoToolStripMenuItem
            // 
            this.metodoDePagoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.efectivoToolStripMenuItem,
            this.tarjCreditoToolStripMenuItem,
            this.tarjDebitoToolStripMenuItem,
            this.creditoPersonalToolStripMenuItem,
            this.chequeToolStripMenuItem});
            this.metodoDePagoToolStripMenuItem.Name = "metodoDePagoToolStripMenuItem";
            this.metodoDePagoToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.metodoDePagoToolStripMenuItem.Text = "Metodo de Pago";
            // 
            // efectivoToolStripMenuItem
            // 
            this.efectivoToolStripMenuItem.Name = "efectivoToolStripMenuItem";
            this.efectivoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.efectivoToolStripMenuItem.Text = "Efectivo";
            // 
            // tarjCreditoToolStripMenuItem
            // 
            this.tarjCreditoToolStripMenuItem.Name = "tarjCreditoToolStripMenuItem";
            this.tarjCreditoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.tarjCreditoToolStripMenuItem.Text = "Tarj. Credito";
            // 
            // tarjDebitoToolStripMenuItem
            // 
            this.tarjDebitoToolStripMenuItem.Name = "tarjDebitoToolStripMenuItem";
            this.tarjDebitoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.tarjDebitoToolStripMenuItem.Text = "Tarj. Debito";
            // 
            // creditoPersonalToolStripMenuItem
            // 
            this.creditoPersonalToolStripMenuItem.Name = "creditoPersonalToolStripMenuItem";
            this.creditoPersonalToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.creditoPersonalToolStripMenuItem.Text = "Credito Personal";
            // 
            // chequeToolStripMenuItem
            // 
            this.chequeToolStripMenuItem.Name = "chequeToolStripMenuItem";
            this.chequeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.chequeToolStripMenuItem.Text = "Cheque";
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridDetalleCajaPedidos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Caja";
            this.Text = "Caja";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalleCajaPedidos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
=======
            this.SuspendLayout();
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Caja";
            this.Text = "Caja";
            this.ResumeLayout(false);
>>>>>>> master

        }

        #endregion

        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridDetalleCajaPedidos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem metodoDePagoToolStripMenuItem;
        private ToolStripMenuItem efectivoToolStripMenuItem;
        private ToolStripMenuItem tarjCreditoToolStripMenuItem;
        private ToolStripMenuItem tarjDebitoToolStripMenuItem;
        private ToolStripMenuItem creditoPersonalToolStripMenuItem;
        private ToolStripMenuItem chequeToolStripMenuItem;
    }
}