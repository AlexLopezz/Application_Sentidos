namespace Application_Sentidos.Roles
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelContenedorOpciones = new System.Windows.Forms.Panel();
            this.bttConsultas = new System.Windows.Forms.Button();
            this.bttReservas = new System.Windows.Forms.Button();
            this.bttMisDatos = new System.Windows.Forms.Button();
            this.bttUsuarios = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bttSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.panelMenuLateral.SuspendLayout();
            this.panelContenedorOpciones.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMenu
            // 
            this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
            this.picMenu.Location = new System.Drawing.Point(0, 0);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(33, 36);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenu.TabIndex = 3;
            this.picMenu.TabStop = false;
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(39)))), ((int)(((byte)(56)))));
            this.panelMenuLateral.Controls.Add(this.panelContenedorOpciones);
            this.panelMenuLateral.Controls.Add(this.panel2);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.ForeColor = System.Drawing.Color.White;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(266, 513);
            this.panelMenuLateral.TabIndex = 3;
            // 
            // panelContenedorOpciones
            // 
            this.panelContenedorOpciones.Controls.Add(this.bttConsultas);
            this.panelContenedorOpciones.Controls.Add(this.bttReservas);
            this.panelContenedorOpciones.Controls.Add(this.bttMisDatos);
            this.panelContenedorOpciones.Controls.Add(this.bttUsuarios);
            this.panelContenedorOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContenedorOpciones.Location = new System.Drawing.Point(0, 87);
            this.panelContenedorOpciones.Name = "panelContenedorOpciones";
            this.panelContenedorOpciones.Size = new System.Drawing.Size(266, 253);
            this.panelContenedorOpciones.TabIndex = 7;
            // 
            // bttConsultas
            // 
            this.bttConsultas.BackColor = System.Drawing.SystemColors.GrayText;
            this.bttConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttConsultas.FlatAppearance.BorderSize = 0;
            this.bttConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.bttConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttConsultas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttConsultas.Image = ((System.Drawing.Image)(resources.GetObject("bttConsultas.Image")));
            this.bttConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttConsultas.Location = new System.Drawing.Point(0, 193);
            this.bttConsultas.Name = "bttConsultas";
            this.bttConsultas.Size = new System.Drawing.Size(266, 58);
            this.bttConsultas.TabIndex = 6;
            this.bttConsultas.Text = "   CONSULTAS";
            this.bttConsultas.UseVisualStyleBackColor = false;
            // 
            // bttReservas
            // 
            this.bttReservas.BackColor = System.Drawing.SystemColors.GrayText;
            this.bttReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttReservas.FlatAppearance.BorderSize = 0;
            this.bttReservas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttReservas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.bttReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttReservas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttReservas.ForeColor = System.Drawing.Color.White;
            this.bttReservas.Image = ((System.Drawing.Image)(resources.GetObject("bttReservas.Image")));
            this.bttReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttReservas.Location = new System.Drawing.Point(3, 130);
            this.bttReservas.Name = "bttReservas";
            this.bttReservas.Size = new System.Drawing.Size(263, 57);
            this.bttReservas.TabIndex = 3;
            this.bttReservas.Text = "RESERVAS";
            this.bttReservas.UseVisualStyleBackColor = false;
            this.bttReservas.Click += new System.EventHandler(this.bttReservas_Click);
            // 
            // bttMisDatos
            // 
            this.bttMisDatos.BackColor = System.Drawing.SystemColors.GrayText;
            this.bttMisDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttMisDatos.FlatAppearance.BorderSize = 0;
            this.bttMisDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttMisDatos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.bttMisDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttMisDatos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttMisDatos.ForeColor = System.Drawing.Color.Transparent;
            this.bttMisDatos.Image = ((System.Drawing.Image)(resources.GetObject("bttMisDatos.Image")));
            this.bttMisDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttMisDatos.Location = new System.Drawing.Point(3, 7);
            this.bttMisDatos.Name = "bttMisDatos";
            this.bttMisDatos.Size = new System.Drawing.Size(263, 53);
            this.bttMisDatos.TabIndex = 3;
            this.bttMisDatos.Text = "  MIS DATOS";
            this.bttMisDatos.UseVisualStyleBackColor = false;
            // 
            // bttUsuarios
            // 
            this.bttUsuarios.BackColor = System.Drawing.SystemColors.GrayText;
            this.bttUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttUsuarios.FlatAppearance.BorderSize = 0;
            this.bttUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.bttUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttUsuarios.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttUsuarios.ForeColor = System.Drawing.Color.Transparent;
            this.bttUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("bttUsuarios.Image")));
            this.bttUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttUsuarios.Location = new System.Drawing.Point(3, 67);
            this.bttUsuarios.Name = "bttUsuarios";
            this.bttUsuarios.Size = new System.Drawing.Size(263, 57);
            this.bttUsuarios.TabIndex = 5;
            this.bttUsuarios.Text = "USUARIOS";
            this.bttUsuarios.UseVisualStyleBackColor = false;
            this.bttUsuarios.Click += new System.EventHandler(this.bttUsuarios_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 464);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 49);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bttSalir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(75, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 49);
            this.panel3.TabIndex = 3;
            // 
            // bttSalir
            // 
            this.bttSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttSalir.FlatAppearance.BorderSize = 0;
            this.bttSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttSalir.Location = new System.Drawing.Point(0, 0);
            this.bttSalir.Name = "bttSalir";
            this.bttSalir.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bttSalir.Size = new System.Drawing.Size(191, 49);
            this.bttSalir.TabIndex = 3;
            this.bttSalir.Text = "SALIR";
            this.bttSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttSalir.UseVisualStyleBackColor = true;
            this.bttSalir.Click += new System.EventHandler(this.bttSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblUser);
            this.panelLogo.Controls.Add(this.lblBienvenida);
            this.panelLogo.Controls.Add(this.pictureBoxAdmin);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(266, 87);
            this.panelLogo.TabIndex = 6;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(124, 36);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(142, 32);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "*user here*";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenida.Location = new System.Drawing.Point(105, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(161, 32);
            this.lblBienvenida.TabIndex = 4;
            this.lblBienvenida.Text = "BIENVENIDO";
            // 
            // pictureBoxAdmin
            // 
            this.pictureBoxAdmin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdmin.Image")));
            this.pictureBoxAdmin.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAdmin.Name = "pictureBoxAdmin";
            this.pictureBoxAdmin.Size = new System.Drawing.Size(75, 87);
            this.pictureBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdmin.TabIndex = 3;
            this.pictureBoxAdmin.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.picMenu);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(266, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(634, 513);
            this.panelContenedor.TabIndex = 4;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 513);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenuLateral);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Administrador";
            this.Text = "ADMINISTRADOR";
            this.Load += new System.EventHandler(this.Administrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.panelMenuLateral.ResumeLayout(false);
            this.panelContenedorOpciones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picMenu;
        private Panel panelMenuLateral;
        private Button bttConsultas;
        private Button bttReservas;
        private Button bttUsuarios;
        private Button bttMisDatos;
        private Panel panel2;
        private Panel panel3;
        private Button bttSalir;
        private PictureBox pictureBox1;
        private Panel panelContenedorOpciones;
        private Panel panelLogo;
        private Label lblUser;
        private Label lblBienvenida;
        private PictureBox pictureBoxAdmin;
        private Panel panelContenedor;
    }
}