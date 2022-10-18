namespace Application_Sentidos.Resources
{
    partial class Reserva
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelReserva = new System.Windows.Forms.Panel();
            this.panelLateralDerecho = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelReservasRealizadas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantidadReservas = new System.Windows.Forms.Label();
            this.lblReservasRealizadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelReserva.SuspendLayout();
            this.panelLateralDerecho.SuspendLayout();
            this.panelReservasRealizadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(417, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelReserva
            // 
            this.panelReserva.BackColor = System.Drawing.Color.SlateBlue;
            this.panelReserva.Controls.Add(this.panelLateralDerecho);
            this.panelReserva.Controls.Add(this.dataGridView1);
            this.panelReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReserva.Location = new System.Drawing.Point(0, 0);
            this.panelReserva.Name = "panelReserva";
            this.panelReserva.Size = new System.Drawing.Size(722, 432);
            this.panelReserva.TabIndex = 1;
            // 
            // panelLateralDerecho
            // 
            this.panelLateralDerecho.Controls.Add(this.panel2);
            this.panelLateralDerecho.Controls.Add(this.panelReservasRealizadas);
            this.panelLateralDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLateralDerecho.Location = new System.Drawing.Point(512, 0);
            this.panelLateralDerecho.Name = "panelLateralDerecho";
            this.panelLateralDerecho.Size = new System.Drawing.Size(210, 432);
            this.panelLateralDerecho.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 128);
            this.panel2.TabIndex = 1;
            // 
            // panelReservasRealizadas
            // 
            this.panelReservasRealizadas.BackColor = System.Drawing.Color.White;
            this.panelReservasRealizadas.Controls.Add(this.label1);
            this.panelReservasRealizadas.Controls.Add(this.lblCantidadReservas);
            this.panelReservasRealizadas.Controls.Add(this.lblReservasRealizadas);
            this.panelReservasRealizadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReservasRealizadas.Location = new System.Drawing.Point(0, 0);
            this.panelReservasRealizadas.Name = "panelReservasRealizadas";
            this.panelReservasRealizadas.Size = new System.Drawing.Size(210, 124);
            this.panelReservasRealizadas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "EN EL DIA DE HOY";
            // 
            // lblCantidadReservas
            // 
            this.lblCantidadReservas.AutoSize = true;
            this.lblCantidadReservas.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadReservas.Location = new System.Drawing.Point(90, 56);
            this.lblCantidadReservas.Name = "lblCantidadReservas";
            this.lblCantidadReservas.Size = new System.Drawing.Size(38, 45);
            this.lblCantidadReservas.TabIndex = 1;
            this.lblCantidadReservas.Text = "0";
            // 
            // lblReservasRealizadas
            // 
            this.lblReservasRealizadas.AutoSize = true;
            this.lblReservasRealizadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReservasRealizadas.Location = new System.Drawing.Point(11, 9);
            this.lblReservasRealizadas.Name = "lblReservasRealizadas";
            this.lblReservasRealizadas.Size = new System.Drawing.Size(187, 21);
            this.lblReservasRealizadas.TabIndex = 0;
            this.lblReservasRealizadas.Text = "RESERVAS REALIZADAS";
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 432);
            this.Controls.Add(this.panelReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reserva";
            this.Text = "Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelReserva.ResumeLayout(false);
            this.panelLateralDerecho.ResumeLayout(false);
            this.panelReservasRealizadas.ResumeLayout(false);
            this.panelReservasRealizadas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panelReserva;
        private Panel panelLateralDerecho;
        private Panel panel2;
        private Panel panelReservasRealizadas;
        private Label lblCantidadReservas;
        private Label lblReservasRealizadas;
        private Label label1;
    }
}