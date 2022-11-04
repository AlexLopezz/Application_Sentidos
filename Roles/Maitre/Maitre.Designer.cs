namespace Application_Sentidos.Roles
{
    partial class Maitre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maitre));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelLateralIzquierdo = new System.Windows.Forms.Panel();
            this.panelSalir = new System.Windows.Forms.Panel();
            this.bttSalir = new System.Windows.Forms.Button();
            this.bttReservas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLateralIzquierdo.SuspendLayout();
            this.panelSalir.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(266, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(825, 419);
            this.panelContenedor.TabIndex = 0;
            // 
<<<<<<< HEAD
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(198, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(586, 411);
            this.panel3.TabIndex = 1;
            // 
=======
>>>>>>> 16ed0ef5715b47e4749cfc13dadc5c1c70912d8a
            // panelLateralIzquierdo
            // 
            this.panelLateralIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLateralIzquierdo.Controls.Add(this.bttReservas);
            this.panelLateralIzquierdo.Controls.Add(this.panelSalir);
            this.panelLateralIzquierdo.Controls.Add(this.panel1);
            this.panelLateralIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateralIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelLateralIzquierdo.Name = "panelLateralIzquierdo";
            this.panelLateralIzquierdo.Size = new System.Drawing.Size(266, 419);
            this.panelLateralIzquierdo.TabIndex = 0;
            // 
            // panelSalir
            // 
            this.panelSalir.Controls.Add(this.bttSalir);
            this.panelSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSalir.Location = new System.Drawing.Point(0, 370);
            this.panelSalir.Name = "panelSalir";
            this.panelSalir.Size = new System.Drawing.Size(266, 49);
            this.panelSalir.TabIndex = 2;
            // 
            // bttSalir
            // 
            this.bttSalir.BackColor = System.Drawing.Color.Gray;
            this.bttSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttSalir.FlatAppearance.BorderSize = 0;
            this.bttSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSalir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttSalir.ForeColor = System.Drawing.Color.White;
            this.bttSalir.Image = ((System.Drawing.Image)(resources.GetObject("bttSalir.Image")));
            this.bttSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttSalir.Location = new System.Drawing.Point(0, 0);
            this.bttSalir.Name = "bttSalir";
            this.bttSalir.Size = new System.Drawing.Size(266, 49);
            this.bttSalir.TabIndex = 2;
            this.bttSalir.Text = "SALIR";
            this.bttSalir.UseVisualStyleBackColor = false;
            this.bttSalir.Click += new System.EventHandler(this.bttSalir_Click);
            // 
            // bttReservas
            // 
            this.bttReservas.BackColor = System.Drawing.Color.Gray;
            this.bttReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttReservas.FlatAppearance.BorderSize = 0;
            this.bttReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttReservas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttReservas.ForeColor = System.Drawing.Color.White;
            this.bttReservas.Image = ((System.Drawing.Image)(resources.GetObject("bttReservas.Image")));
            this.bttReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttReservas.Location = new System.Drawing.Point(0, 68);
            this.bttReservas.Name = "bttReservas";
            this.bttReservas.Size = new System.Drawing.Size(266, 72);
            this.bttReservas.TabIndex = 1;
            this.bttReservas.Text = "RESERVAS";
            this.bttReservas.UseVisualStyleBackColor = false;
            this.bttReservas.Click += new System.EventHandler(this.bttReservas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.lblBienvenido);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 68);
            this.panel1.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(88, 21);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(89, 21);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "*user here*";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(88, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(109, 21);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "BIENVENIDO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Maitre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 419);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelLateralIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Maitre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maitre";
            this.Load += new System.EventHandler(this.Maitre_Load);
            this.panelLateralIzquierdo.ResumeLayout(false);
            this.panelSalir.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContenedor;
        private Panel panelLateralIzquierdo;
        private Panel panelSalir;
        private Button bttSalir;
        private Button bttReservas;
        private Panel panel1;
        private Label lblUser;
        private Label lblBienvenido;
        private PictureBox pictureBox1;
    }
}