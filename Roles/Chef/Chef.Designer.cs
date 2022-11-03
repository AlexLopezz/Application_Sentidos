namespace Application_Sentidos.Roles.Chef
{
    partial class Chef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chef));
            this.panelLateralIzquierdo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.bttMenu = new System.Windows.Forms.Button();
            this.bttProductos = new System.Windows.Forms.Button();
            this.bttCategorias = new System.Windows.Forms.Button();
            this.bttSalir = new System.Windows.Forms.Button();
            this.panelLateralIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateralIzquierdo
            // 
            this.panelLateralIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLateralIzquierdo.Controls.Add(this.bttSalir);
            this.panelLateralIzquierdo.Controls.Add(this.bttCategorias);
            this.panelLateralIzquierdo.Controls.Add(this.bttProductos);
            this.panelLateralIzquierdo.Controls.Add(this.bttMenu);
            this.panelLateralIzquierdo.Controls.Add(this.lblUser);
            this.panelLateralIzquierdo.Controls.Add(this.lblBienvenida);
            this.panelLateralIzquierdo.Controls.Add(this.pictureBox1);
            this.panelLateralIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateralIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelLateralIzquierdo.Name = "panelLateralIzquierdo";
            this.panelLateralIzquierdo.Size = new System.Drawing.Size(266, 420);
            this.panelLateralIzquierdo.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(266, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(825, 420);
            this.panelContenedor.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(111, 9);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(127, 21);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "BIENVENIDO/A";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(111, 30);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(78, 19);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "*user here*";
            // 
            // bttMenu
            // 
            this.bttMenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.bttMenu.FlatAppearance.BorderSize = 0;
            this.bttMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttMenu.ForeColor = System.Drawing.Color.Transparent;
            this.bttMenu.Image = ((System.Drawing.Image)(resources.GetObject("bttMenu.Image")));
            this.bttMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttMenu.Location = new System.Drawing.Point(3, 93);
            this.bttMenu.Name = "bttMenu";
            this.bttMenu.Size = new System.Drawing.Size(263, 53);
            this.bttMenu.TabIndex = 0;
            this.bttMenu.Text = "MENU";
            this.bttMenu.UseVisualStyleBackColor = false;
            this.bttMenu.Click += new System.EventHandler(this.bttMenu_Click);
            // 
            // bttProductos
            // 
            this.bttProductos.BackColor = System.Drawing.SystemColors.GrayText;
            this.bttProductos.FlatAppearance.BorderSize = 0;
            this.bttProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttProductos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttProductos.ForeColor = System.Drawing.Color.Transparent;
            this.bttProductos.Image = ((System.Drawing.Image)(resources.GetObject("bttProductos.Image")));
            this.bttProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttProductos.Location = new System.Drawing.Point(3, 152);
            this.bttProductos.Name = "bttProductos";
            this.bttProductos.Size = new System.Drawing.Size(263, 53);
            this.bttProductos.TabIndex = 2;
            this.bttProductos.Text = "PRODUCTOS";
            this.bttProductos.UseVisualStyleBackColor = false;
            this.bttProductos.Click += new System.EventHandler(this.bttProductos_Click);
            // 
            // bttCategorias
            // 
            this.bttCategorias.BackColor = System.Drawing.SystemColors.GrayText;
            this.bttCategorias.FlatAppearance.BorderSize = 0;
            this.bttCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCategorias.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttCategorias.ForeColor = System.Drawing.Color.Transparent;
            this.bttCategorias.Image = ((System.Drawing.Image)(resources.GetObject("bttCategorias.Image")));
            this.bttCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttCategorias.Location = new System.Drawing.Point(3, 211);
            this.bttCategorias.Name = "bttCategorias";
            this.bttCategorias.Size = new System.Drawing.Size(263, 53);
            this.bttCategorias.TabIndex = 3;
            this.bttCategorias.Text = "CATEGORIAS";
            this.bttCategorias.UseVisualStyleBackColor = false;
            this.bttCategorias.Click += new System.EventHandler(this.bttCategorias_Click);
            // 
            // bttSalir
            // 
            this.bttSalir.BackColor = System.Drawing.SystemColors.GrayText;
            this.bttSalir.FlatAppearance.BorderSize = 0;
            this.bttSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSalir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttSalir.ForeColor = System.Drawing.Color.Transparent;
            this.bttSalir.Image = ((System.Drawing.Image)(resources.GetObject("bttSalir.Image")));
            this.bttSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttSalir.Location = new System.Drawing.Point(3, 364);
            this.bttSalir.Name = "bttSalir";
            this.bttSalir.Size = new System.Drawing.Size(263, 53);
            this.bttSalir.TabIndex = 4;
            this.bttSalir.Text = "SALIR";
            this.bttSalir.UseVisualStyleBackColor = false;
            this.bttSalir.Click += new System.EventHandler(this.bttSalir_Click);
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 420);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelLateralIzquierdo);
            this.Name = "Chef";
            this.Text = "Chef";
            this.panelLateralIzquierdo.ResumeLayout(false);
            this.panelLateralIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLateralIzquierdo;
        private Panel panelContenedor;
        private Label lblUser;
        private Label lblBienvenida;
        private PictureBox pictureBox1;
        private Button bttMenu;
        private Button bttCategorias;
        private Button bttProductos;
        private Button bttSalir;
    }
}