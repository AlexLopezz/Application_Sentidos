namespace Application_Sentidos.Resources.Administrador
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_Client = new System.Windows.Forms.RadioButton();
            this.rb_None = new System.Windows.Forms.RadioButton();
            this.rb_Caja = new System.Windows.Forms.RadioButton();
            this.rb_Mitre = new System.Windows.Forms.RadioButton();
            this.rb_Mozo = new System.Windows.Forms.RadioButton();
            this.rb_allUser = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttBuscar = new System.Windows.Forms.Button();
            this.bttModificar = new System.Windows.Forms.Button();
            this.bttRegistrar = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.lblAdminUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(43, 109);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowTemplate.Height = 25;
            this.dgvUsuarios.Size = new System.Drawing.Size(476, 262);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(659, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "FILTRAR POR";
            // 
            // rb_Client
            // 
            this.rb_Client.AutoSize = true;
            this.rb_Client.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_Client.Location = new System.Drawing.Point(0, 95);
            this.rb_Client.Name = "rb_Client";
            this.rb_Client.Size = new System.Drawing.Size(145, 19);
            this.rb_Client.TabIndex = 5;
            this.rb_Client.Text = "Usuarios - Sentidos";
            this.rb_Client.UseVisualStyleBackColor = true;
            this.rb_Client.CheckedChanged += new System.EventHandler(this.rb_Client_CheckedChanged);
            // 
            // rb_None
            // 
            this.rb_None.AutoSize = true;
            this.rb_None.Checked = true;
            this.rb_None.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_None.Location = new System.Drawing.Point(0, 0);
            this.rb_None.Name = "rb_None";
            this.rb_None.Size = new System.Drawing.Size(145, 19);
            this.rb_None.TabIndex = 4;
            this.rb_None.TabStop = true;
            this.rb_None.Text = "Ninguno";
            this.rb_None.UseVisualStyleBackColor = true;
            this.rb_None.CheckedChanged += new System.EventHandler(this.rb_None_CheckedChanged);
            // 
            // rb_Caja
            // 
            this.rb_Caja.AutoSize = true;
            this.rb_Caja.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_Caja.Location = new System.Drawing.Point(0, 19);
            this.rb_Caja.Name = "rb_Caja";
            this.rb_Caja.Size = new System.Drawing.Size(145, 19);
            this.rb_Caja.TabIndex = 3;
            this.rb_Caja.Text = "Caja - Sentidos";
            this.rb_Caja.UseVisualStyleBackColor = true;
            this.rb_Caja.CheckedChanged += new System.EventHandler(this.rb_Caja_CheckedChanged);
            // 
            // rb_Mitre
            // 
            this.rb_Mitre.AutoSize = true;
            this.rb_Mitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_Mitre.Location = new System.Drawing.Point(0, 38);
            this.rb_Mitre.Name = "rb_Mitre";

            this.rb_Mitre.Size = new System.Drawing.Size(145, 19);
            this.rb_Mitre.TabIndex = 2;
            this.rb_Mitre.Text = "Maitre  - Sentidos";

            this.rb_Mitre.UseVisualStyleBackColor = true;
            this.rb_Mitre.CheckedChanged += new System.EventHandler(this.rb_Mitre_CheckedChanged);
            // 
            // rb_Mozo
            // 
            this.rb_Mozo.AutoSize = true;
            this.rb_Mozo.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_Mozo.Location = new System.Drawing.Point(0, 57);
            this.rb_Mozo.Name = "rb_Mozo";
            this.rb_Mozo.Size = new System.Drawing.Size(145, 19);
            this.rb_Mozo.TabIndex = 1;
            this.rb_Mozo.Text = "Mozo - Sentidos";
            this.rb_Mozo.UseVisualStyleBackColor = true;
            this.rb_Mozo.CheckedChanged += new System.EventHandler(this.rb_Mozo_CheckedChanged);
            // 
            // rb_allUser
            // 
            this.rb_allUser.AutoSize = true;
            this.rb_allUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_allUser.Location = new System.Drawing.Point(0, 76);
            this.rb_allUser.Name = "rb_allUser";
            this.rb_allUser.Size = new System.Drawing.Size(145, 19);
            this.rb_allUser.TabIndex = 0;
            this.rb_allUser.Text = "Todos los Roles";
            this.rb_allUser.UseVisualStyleBackColor = true;
            this.rb_allUser.CheckedChanged += new System.EventHandler(this.rb_allUser_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bttBuscar
            // 
            this.bttBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bttBuscar.Image")));
            this.bttBuscar.Location = new System.Drawing.Point(480, 74);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(60, 29);
            this.bttBuscar.TabIndex = 5;
            this.bttBuscar.UseVisualStyleBackColor = true;
            this.bttBuscar.Click += new System.EventHandler(this.bttBuscar_Click);
            // 
            // bttModificar
            // 
            this.bttModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bttModificar.FlatAppearance.BorderSize = 0;
            this.bttModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttModificar.Image = ((System.Drawing.Image)(resources.GetObject("bttModificar.Image")));
            this.bttModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttModificar.Location = new System.Drawing.Point(525, 161);
            this.bttModificar.Name = "bttModificar";
            this.bttModificar.Size = new System.Drawing.Size(112, 41);
            this.bttModificar.TabIndex = 4;
            this.bttModificar.Text = "MODIFICAR";
            this.bttModificar.UseVisualStyleBackColor = false;
            this.bttModificar.Click += new System.EventHandler(this.bttModificar_Click);
            // 
            // bttRegistrar
            // 
            this.bttRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttRegistrar.FlatAppearance.BorderSize = 0;
            this.bttRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("bttRegistrar.Image")));
            this.bttRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttRegistrar.Location = new System.Drawing.Point(526, 109);
            this.bttRegistrar.Name = "bttRegistrar";
            this.bttRegistrar.Size = new System.Drawing.Size(111, 41);
            this.bttRegistrar.TabIndex = 2;
            this.bttRegistrar.Text = "REGISTRAR";
            this.bttRegistrar.UseVisualStyleBackColor = false;
            this.bttRegistrar.Click += new System.EventHandler(this.bttRegistrar_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttEliminar.BackColor = System.Drawing.Color.Red;
            this.bttEliminar.FlatAppearance.BorderSize = 0;
            this.bttEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttEliminar.ForeColor = System.Drawing.Color.White;
            this.bttEliminar.Image = ((System.Drawing.Image)(resources.GetObject("bttEliminar.Image")));
            this.bttEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttEliminar.Location = new System.Drawing.Point(525, 214);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(112, 41);
            this.bttEliminar.TabIndex = 3;
            this.bttEliminar.Text = "ELIMINAR";
            this.bttEliminar.UseVisualStyleBackColor = false;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // lblAdminUser
            // 
            this.lblAdminUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAdminUser.AutoSize = true;
            this.lblAdminUser.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdminUser.Location = new System.Drawing.Point(119, 9);
            this.lblAdminUser.Name = "lblAdminUser";
            this.lblAdminUser.Size = new System.Drawing.Size(355, 21);
            this.lblAdminUser.TabIndex = 1;
            this.lblAdminUser.Text = "ADMINISTRACION DE USUARIOS SENTIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(119, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "\"Ninguno de nosotros es tan bueno como todos nosotros juntos.\"";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_Client);
            this.panel1.Controls.Add(this.rb_allUser);
            this.panel1.Controls.Add(this.rb_Mozo);
            this.panel1.Controls.Add(this.rb_Mitre);
            this.panel1.Controls.Add(this.rb_Caja);
            this.panel1.Controls.Add(this.rb_None);
            this.panel1.Location = new System.Drawing.Point(659, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 116);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(94, 78);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(380, 23);
            this.txtSearchUser.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Usuario";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(825, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttModificar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttRegistrar);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.lblAdminUser);
            this.Controls.Add(this.bttBuscar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button bttRegistrar;
        private Button bttEliminar;
        public DataGridView dgvUsuarios;
        private RadioButton rb_Caja;
        private RadioButton rb_Mitre;
        private RadioButton rb_Mozo;
        private RadioButton rb_allUser;
        private RadioButton rb_None;
        private RadioButton rb_Client;
        private Label label1;
        private Button bttBuscar;
        private Button bttModificar;
        private Label lblAdminUser;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
        private TextBox txtSearchUser;
        private Label label3;
    }
}