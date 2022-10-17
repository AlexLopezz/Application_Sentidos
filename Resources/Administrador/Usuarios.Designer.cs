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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panel_User = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_None = new System.Windows.Forms.RadioButton();
            this.rb_Caja = new System.Windows.Forms.RadioButton();
            this.rb_Mitre = new System.Windows.Forms.RadioButton();
            this.rb_Mozo = new System.Windows.Forms.RadioButton();
            this.rb_allUser = new System.Windows.Forms.RadioButton();
            this.panelDgv = new System.Windows.Forms.Panel();
            this.bttRegistrar = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.bttModificar = new System.Windows.Forms.Button();
            this.panelLateralIzquierdo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panel_User.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDgv.SuspendLayout();
            this.panelLateralIzquierdo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowTemplate.Height = 25;
            this.dgvUsuarios.Size = new System.Drawing.Size(503, 350);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // panel_User
            // 
            this.panel_User.Controls.Add(this.panel1);
            this.panel_User.Controls.Add(this.panelDgv);
            this.panel_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_User.Location = new System.Drawing.Point(0, 0);
            this.panel_User.Name = "panel_User";
            this.panel_User.Size = new System.Drawing.Size(634, 350);
            this.panel_User.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_None);
            this.panel1.Controls.Add(this.rb_Caja);
            this.panel1.Controls.Add(this.rb_Mitre);
            this.panel1.Controls.Add(this.rb_Mozo);
            this.panel1.Controls.Add(this.rb_allUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(503, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 135);
            this.panel1.TabIndex = 2;
            // 
            // rb_None
            // 
            this.rb_None.AutoSize = true;
            this.rb_None.Checked = true;
            this.rb_None.Location = new System.Drawing.Point(6, 111);
            this.rb_None.Name = "rb_None";
            this.rb_None.Size = new System.Drawing.Size(72, 19);
            this.rb_None.TabIndex = 4;
            this.rb_None.TabStop = true;
            this.rb_None.Text = "Ninguno";
            this.rb_None.UseVisualStyleBackColor = true;
            this.rb_None.CheckedChanged += new System.EventHandler(this.rb_None_CheckedChanged);
            // 
            // rb_Caja
            // 
            this.rb_Caja.AutoSize = true;
            this.rb_Caja.Location = new System.Drawing.Point(6, 83);
            this.rb_Caja.Name = "rb_Caja";
            this.rb_Caja.Size = new System.Drawing.Size(48, 19);
            this.rb_Caja.TabIndex = 3;
            this.rb_Caja.Text = "Caja";
            this.rb_Caja.UseVisualStyleBackColor = true;
            this.rb_Caja.CheckedChanged += new System.EventHandler(this.rb_Caja_CheckedChanged);
            // 
            // rb_Mitre
            // 
            this.rb_Mitre.AutoSize = true;
            this.rb_Mitre.Location = new System.Drawing.Point(6, 58);
            this.rb_Mitre.Name = "rb_Mitre";
            this.rb_Mitre.Size = new System.Drawing.Size(53, 19);
            this.rb_Mitre.TabIndex = 2;
            this.rb_Mitre.Text = "Mitre";
            this.rb_Mitre.UseVisualStyleBackColor = true;
            this.rb_Mitre.CheckedChanged += new System.EventHandler(this.rb_Mitre_CheckedChanged);
            // 
            // rb_Mozo
            // 
            this.rb_Mozo.AutoSize = true;
            this.rb_Mozo.Location = new System.Drawing.Point(6, 33);
            this.rb_Mozo.Name = "rb_Mozo";
            this.rb_Mozo.Size = new System.Drawing.Size(55, 19);
            this.rb_Mozo.TabIndex = 1;
            this.rb_Mozo.Text = "Mozo";
            this.rb_Mozo.UseVisualStyleBackColor = true;
            this.rb_Mozo.CheckedChanged += new System.EventHandler(this.rb_Mozo_CheckedChanged);
            // 
            // rb_allUser
            // 
            this.rb_allUser.AutoSize = true;
            this.rb_allUser.Location = new System.Drawing.Point(6, 8);
            this.rb_allUser.Name = "rb_allUser";
            this.rb_allUser.Size = new System.Drawing.Size(121, 19);
            this.rb_allUser.TabIndex = 0;
            this.rb_allUser.Text = "Todos los usuarios";
            this.rb_allUser.UseVisualStyleBackColor = true;
            this.rb_allUser.CheckedChanged += new System.EventHandler(this.rb_allUser_CheckedChanged);
            // 
            // panelDgv
            // 
            this.panelDgv.Controls.Add(this.dgvUsuarios);
            this.panelDgv.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDgv.Location = new System.Drawing.Point(0, 0);
            this.panelDgv.Name = "panelDgv";
            this.panelDgv.Size = new System.Drawing.Size(503, 350);
            this.panelDgv.TabIndex = 1;
            // 
            // bttRegistrar
            // 
            this.bttRegistrar.Location = new System.Drawing.Point(3, 3);
            this.bttRegistrar.Name = "bttRegistrar";
            this.bttRegistrar.Size = new System.Drawing.Size(111, 41);
            this.bttRegistrar.TabIndex = 2;
            this.bttRegistrar.Text = "REGISTRAR";
            this.bttRegistrar.UseVisualStyleBackColor = true;
            this.bttRegistrar.Click += new System.EventHandler(this.bttRegistrar_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.Location = new System.Drawing.Point(120, 3);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(112, 41);
            this.bttEliminar.TabIndex = 3;
            this.bttEliminar.Text = "ELIMINAR";
            this.bttEliminar.UseVisualStyleBackColor = true;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // bttModificar
            // 
            this.bttModificar.Location = new System.Drawing.Point(240, 3);
            this.bttModificar.Name = "bttModificar";
            this.bttModificar.Size = new System.Drawing.Size(112, 41);
            this.bttModificar.TabIndex = 4;
            this.bttModificar.Text = "MODIFICAR";
            this.bttModificar.UseVisualStyleBackColor = true;
            this.bttModificar.Click += new System.EventHandler(this.bttModificar_Click);
            // 
            // panelLateralIzquierdo
            // 
            this.panelLateralIzquierdo.Controls.Add(this.tableLayoutPanel1);
            this.panelLateralIzquierdo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLateralIzquierdo.Location = new System.Drawing.Point(0, 350);
            this.panelLateralIzquierdo.Name = "panelLateralIzquierdo";
            this.panelLateralIzquierdo.Size = new System.Drawing.Size(634, 57);
            this.panelLateralIzquierdo.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.61199F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.08517F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.08517F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.53312F));
            this.tableLayoutPanel1.Controls.Add(this.bttModificar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttRegistrar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttEliminar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 57);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(634, 407);
            this.Controls.Add(this.panel_User);
            this.Controls.Add(this.panelLateralIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panel_User.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDgv.ResumeLayout(false);
            this.panelLateralIzquierdo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel_User;
        private Button bttRegistrar;
        private Button bttEliminar;
        private Button bttModificar;
        private Panel panelLateralIzquierdo;
        private TableLayoutPanel tableLayoutPanel1;
        public DataGridView dgvUsuarios;
        private Panel panel1;
        private RadioButton rb_Caja;
        private RadioButton rb_Mitre;
        private RadioButton rb_Mozo;
        private RadioButton rb_allUser;
        private Panel panelDgv;
        private RadioButton rb_None;
    }
}