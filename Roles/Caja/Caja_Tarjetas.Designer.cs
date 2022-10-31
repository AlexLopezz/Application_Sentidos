namespace Application_Sentidos.Roles
{
    partial class Caja_Tarjetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja_Tarjetas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.txtNumTarjeta = new System.Windows.Forms.TextBox();
            this.txtBoxCodTarjeta = new System.Windows.Forms.TextBox();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.cboBoxTipoFatura = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvDetalleCaja = new System.Windows.Forms.DataGridView();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtBoxNombre
            // 
            resources.ApplyResources(this.txtBoxNombre, "txtBoxNombre");
            this.txtBoxNombre.Name = "txtBoxNombre";
            // 
            // txtBoxApellido
            // 
            resources.ApplyResources(this.txtBoxApellido, "txtBoxApellido");
            this.txtBoxApellido.Name = "txtBoxApellido";
            // 
            // txtNumTarjeta
            // 
            resources.ApplyResources(this.txtNumTarjeta, "txtNumTarjeta");
            this.txtNumTarjeta.Name = "txtNumTarjeta";
            // 
            // txtBoxCodTarjeta
            // 
            resources.ApplyResources(this.txtBoxCodTarjeta, "txtBoxCodTarjeta");
            this.txtBoxCodTarjeta.Name = "txtBoxCodTarjeta";
            // 
            // txtBoxTelefono
            // 
            resources.ApplyResources(this.txtBoxTelefono, "txtBoxTelefono");
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            // 
            // txtBoxDireccion
            // 
            resources.ApplyResources(this.txtBoxDireccion, "txtBoxDireccion");
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.TextChanged += new System.EventHandler(this.txtBoxDireccion_TextChanged);
            // 
            // cboBoxTipoFatura
            // 
            this.cboBoxTipoFatura.FormattingEnabled = true;
            this.cboBoxTipoFatura.Items.AddRange(new object[] {
            resources.GetString("cboBoxTipoFatura.Items"),
            resources.GetString("cboBoxTipoFatura.Items1"),
            resources.GetString("cboBoxTipoFatura.Items2")});
            resources.ApplyResources(this.cboBoxTipoFatura, "cboBoxTipoFatura");
            this.cboBoxTipoFatura.Name = "cboBoxTipoFatura";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // btnPagar
            // 
            resources.ApplyResources(this.btnPagar, "btnPagar");
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvDetalleCaja
            // 
            this.dgvDetalleCaja.AllowUserToAddRows = false;
            this.dgvDetalleCaja.AllowUserToDeleteRows = false;
            this.dgvDetalleCaja.AllowUserToResizeColumns = false;
            this.dgvDetalleCaja.AllowUserToResizeRows = false;
            this.dgvDetalleCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            resources.ApplyResources(this.dgvDetalleCaja, "dgvDetalleCaja");
            this.dgvDetalleCaja.Name = "dgvDetalleCaja";
            this.dgvDetalleCaja.ReadOnly = true;
            this.dgvDetalleCaja.RowHeadersVisible = false;
            this.dgvDetalleCaja.RowTemplate.Height = 25;
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxTotal.ForeColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.txtBoxTotal, "txtBoxTotal");
            this.txtBoxTotal.Name = "txtBoxTotal";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Caja_Tarjetas
            // 
            this.AcceptButton = this.btnPagar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvDetalleCaja);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboBoxTipoFatura);
            this.Controls.Add(this.txtBoxDireccion);
            this.Controls.Add(this.txtBoxTelefono);
            this.Controls.Add(this.txtBoxCodTarjeta);
            this.Controls.Add(this.txtNumTarjeta);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Caja_Tarjetas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtBoxNombre;
        private TextBox txtBoxApellido;
        private TextBox txtNumTarjeta;
        private TextBox txtBoxCodTarjeta;
        private TextBox txtBoxTelefono;
        private TextBox txtBoxDireccion;
        private ComboBox cboBoxTipoFatura;
        private Label label8;
        private Button btnPagar;
        private Button btnCancelar;
        private DataGridView dgvDetalleCaja;
        private TextBox txtBoxTotal;
        private Label label9;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}