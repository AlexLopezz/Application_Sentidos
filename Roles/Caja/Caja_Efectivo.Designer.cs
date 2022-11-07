namespace Application_Sentidos.Roles
{
    partial class Caja_Efectivo
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
            this.dgvDetallesPedidoIndividual = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxTotalItems = new System.Windows.Forms.TextBox();
            this.txtBoxIngreso = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBoxVuelto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipoFactura = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesPedidoIndividual)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetallesPedidoIndividual
            // 
            this.dgvDetallesPedidoIndividual.AllowUserToAddRows = false;
            this.dgvDetallesPedidoIndividual.AllowUserToDeleteRows = false;
            this.dgvDetallesPedidoIndividual.AllowUserToResizeColumns = false;
            this.dgvDetallesPedidoIndividual.AllowUserToResizeRows = false;
            this.dgvDetallesPedidoIndividual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallesPedidoIndividual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesPedidoIndividual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDetallesPedidoIndividual.Location = new System.Drawing.Point(12, 67);
            this.dgvDetallesPedidoIndividual.Name = "dgvDetallesPedidoIndividual";
            this.dgvDetallesPedidoIndividual.ReadOnly = true;
            this.dgvDetallesPedidoIndividual.RowHeadersVisible = false;
            this.dgvDetallesPedidoIndividual.RowTemplate.Height = 25;
            this.dgvDetallesPedidoIndividual.Size = new System.Drawing.Size(300, 322);
            this.dgvDetallesPedidoIndividual.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DETALLES DE LA MESA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(318, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGRESO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(318, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "VUELTO $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(56, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "TOTAL $";
            // 
            // txtBoxTotalItems
            // 
            this.txtBoxTotalItems.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxTotalItems.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTotalItems.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtBoxTotalItems.Location = new System.Drawing.Point(142, 409);
            this.txtBoxTotalItems.Name = "txtBoxTotalItems";
            this.txtBoxTotalItems.Size = new System.Drawing.Size(112, 33);
            this.txtBoxTotalItems.TabIndex = 5;
            this.txtBoxTotalItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxIngreso
            // 
            this.txtBoxIngreso.Location = new System.Drawing.Point(442, 149);
            this.txtBoxIngreso.Name = "txtBoxIngreso";
            this.txtBoxIngreso.Size = new System.Drawing.Size(112, 22);
            this.txtBoxIngreso.TabIndex = 3;
            this.txtBoxIngreso.TextChanged += new System.EventHandler(this.txtBoxIngreso_TextChanged);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(442, 339);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(112, 44);
            this.btnPagar.TabIndex = 1;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(442, 405);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 44);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBoxVuelto
            // 
            this.txtBoxVuelto.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxVuelto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxVuelto.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtBoxVuelto.Location = new System.Drawing.Point(442, 195);
            this.txtBoxVuelto.Name = "txtBoxVuelto";
            this.txtBoxVuelto.Size = new System.Drawing.Size(112, 33);
            this.txtBoxVuelto.TabIndex = 10;
            this.txtBoxVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(318, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "TIPO FACTURA";
            // 
            // cboTipoFactura
            // 
            this.cboTipoFactura.FormattingEnabled = true;
            this.cboTipoFactura.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cboTipoFactura.Location = new System.Drawing.Point(442, 99);
            this.cboTipoFactura.Name = "cboTipoFactura";
            this.cboTipoFactura.Size = new System.Drawing.Size(112, 25);
            this.cboTipoFactura.TabIndex = 12;
            // 
            // Caja_Efectivo
            // 
            this.AcceptButton = this.btnPagar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(566, 461);
            this.Controls.Add(this.cboTipoFactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxVuelto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtBoxIngreso);
            this.Controls.Add(this.txtBoxTotalItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetallesPedidoIndividual);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Caja_Efectivo";
            this.Text = "CAJA EFECTIVO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesPedidoIndividual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvDetallesPedidoIndividual;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBoxTotalItems;
        private TextBox txtBoxIngreso;
        private Button btnPagar;
        private Button btnCancelar;
        private TextBox txtBoxVuelto;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label5;
        private ComboBox cboTipoFactura;
    }
}