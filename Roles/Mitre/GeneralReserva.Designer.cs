﻿namespace Application_Sentidos.Resources.Mitre
{
    partial class GeneralReserva
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
            this.lblReservaciones = new System.Windows.Forms.Label();
            this.bttCancelReserva = new System.Windows.Forms.Button();
            this.bttRefrescar = new System.Windows.Forms.Button();
            this.bttCreate_Reserva = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReservaciones
            // 
            this.lblReservaciones.AutoSize = true;
            this.lblReservaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReservaciones.ForeColor = System.Drawing.Color.Black;
            this.lblReservaciones.Location = new System.Drawing.Point(38, 37);
            this.lblReservaciones.Name = "lblReservaciones";
            this.lblReservaciones.Size = new System.Drawing.Size(129, 21);
            this.lblReservaciones.TabIndex = 9;
            this.lblReservaciones.Text = "RESERVACIONES";
            // 
            // bttCancelReserva
            // 
            this.bttCancelReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttCancelReserva.FlatAppearance.BorderSize = 0;
            this.bttCancelReserva.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttCancelReserva.Location = new System.Drawing.Point(135, 303);
            this.bttCancelReserva.Name = "bttCancelReserva";
            this.bttCancelReserva.Size = new System.Drawing.Size(91, 47);
            this.bttCancelReserva.TabIndex = 8;
            this.bttCancelReserva.Text = "CANCELAR\r\nRESERVACION";
            this.bttCancelReserva.UseVisualStyleBackColor = true;
            this.bttCancelReserva.Click += new System.EventHandler(this.bttCancelReserva_Click);
            // 
            // bttRefrescar
            // 
            this.bttRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttRefrescar.FlatAppearance.BorderSize = 0;
            this.bttRefrescar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttRefrescar.Location = new System.Drawing.Point(450, 303);
            this.bttRefrescar.Name = "bttRefrescar";
            this.bttRefrescar.Size = new System.Drawing.Size(71, 29);
            this.bttRefrescar.TabIndex = 7;
            this.bttRefrescar.Text = "Refrescar";
            this.bttRefrescar.UseVisualStyleBackColor = true;
            this.bttRefrescar.Click += new System.EventHandler(this.bttRefrescar_Click);
            // 
            // bttCreate_Reserva
            // 
            this.bttCreate_Reserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttCreate_Reserva.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttCreate_Reserva.FlatAppearance.BorderSize = 0;
            this.bttCreate_Reserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttCreate_Reserva.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttCreate_Reserva.Location = new System.Drawing.Point(38, 303);
            this.bttCreate_Reserva.Name = "bttCreate_Reserva";
            this.bttCreate_Reserva.Size = new System.Drawing.Size(91, 47);
            this.bttCreate_Reserva.TabIndex = 6;
            this.bttCreate_Reserva.Text = "REGISTRAR\r\nRESERVACION";
            this.bttCreate_Reserva.UseVisualStyleBackColor = true;
            this.bttCreate_Reserva.Click += new System.EventHandler(this.bttCreate_Reserva_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvReserva);
            this.panel1.Location = new System.Drawing.Point(38, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 236);
            this.panel1.TabIndex = 10;
            // 
            // dgvReserva
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReserva.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReserva.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvReserva.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReserva.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReserva.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReserva.EnableHeadersVisualStyles = false;
            this.dgvReserva.Location = new System.Drawing.Point(0, 0);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.ReadOnly = true;
            this.dgvReserva.RowHeadersVisible = false;
            this.dgvReserva.RowHeadersWidth = 50;
            this.dgvReserva.RowTemplate.Height = 25;
            this.dgvReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReserva.Size = new System.Drawing.Size(483, 236);
            this.dgvReserva.TabIndex = 0;
            // 
            // GeneralReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(586, 411);
            this.ControlBox = false;
            this.Controls.Add(this.lblReservaciones);
            this.Controls.Add(this.bttCancelReserva);
            this.Controls.Add(this.bttRefrescar);
            this.Controls.Add(this.bttCreate_Reserva);
            this.Controls.Add(this.panel1);
            this.Name = "GeneralReserva";
            this.Text = "UI_RESERVA";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblReservaciones;
        private Button bttCancelReserva;
        private Button bttRefrescar;
        private Button bttCreate_Reserva;
        private Panel panel1;
        private DataGridView dgvReserva;
    }
}