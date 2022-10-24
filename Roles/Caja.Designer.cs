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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.metodoDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efectivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjDebitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditoPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSeleccionMesa = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionMesa)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metodoDePagoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 28);
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
            this.metodoDePagoToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.metodoDePagoToolStripMenuItem.Text = "Metodo de Pago";
            // 
            // efectivoToolStripMenuItem
            // 
            this.efectivoToolStripMenuItem.Name = "efectivoToolStripMenuItem";
            this.efectivoToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.efectivoToolStripMenuItem.Text = "Efectivo";
            this.efectivoToolStripMenuItem.Click += new System.EventHandler(this.efectivoToolStripMenuItem_Click);
            // 
            // tarjCreditoToolStripMenuItem
            // 
            this.tarjCreditoToolStripMenuItem.Name = "tarjCreditoToolStripMenuItem";
            this.tarjCreditoToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.tarjCreditoToolStripMenuItem.Text = "Tarj. Credito";
            this.tarjCreditoToolStripMenuItem.Click += new System.EventHandler(this.tarjCreditoToolStripMenuItem_Click);
            // 
            // tarjDebitoToolStripMenuItem
            // 
            this.tarjDebitoToolStripMenuItem.Name = "tarjDebitoToolStripMenuItem";
            this.tarjDebitoToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.tarjDebitoToolStripMenuItem.Text = "Tarj. Debito";
            this.tarjDebitoToolStripMenuItem.Click += new System.EventHandler(this.tarjDebitoToolStripMenuItem_Click);
            // 
            // creditoPersonalToolStripMenuItem
            // 
            this.creditoPersonalToolStripMenuItem.Name = "creditoPersonalToolStripMenuItem";
            this.creditoPersonalToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.creditoPersonalToolStripMenuItem.Text = "Mercado Pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "PEDIDOS";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mozo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° Mesa";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dgvSeleccionMesa
            // 
            this.dgvSeleccionMesa.AllowUserToAddRows = false;
            this.dgvSeleccionMesa.AllowUserToDeleteRows = false;
            this.dgvSeleccionMesa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeleccionMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionMesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvSeleccionMesa.Location = new System.Drawing.Point(12, 93);
            this.dgvSeleccionMesa.Name = "dgvSeleccionMesa";
            this.dgvSeleccionMesa.ReadOnly = true;
            this.dgvSeleccionMesa.RowHeadersVisible = false;
            this.dgvSeleccionMesa.RowTemplate.Height = 25;
            this.dgvSeleccionMesa.Size = new System.Drawing.Size(541, 375);
            this.dgvSeleccionMesa.TabIndex = 3;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(460, 31);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 60);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(565, 480);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvSeleccionMesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Caja";
            this.Text = "Caja";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionMesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem metodoDePagoToolStripMenuItem;
        private ToolStripMenuItem efectivoToolStripMenuItem;
        private ToolStripMenuItem tarjCreditoToolStripMenuItem;
        private ToolStripMenuItem tarjDebitoToolStripMenuItem;
        private ToolStripMenuItem creditoPersonalToolStripMenuItem;
        private Label label1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dgvSeleccionMesa;
        private Button btnActualizar;
    }
}