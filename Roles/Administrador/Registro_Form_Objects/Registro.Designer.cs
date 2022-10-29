namespace Application_Sentidos.Resources.Administrador
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttRegistrar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.txtVerifyPassword = new System.Windows.Forms.TextBox();
            this.lblVerifyPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.bttRegistrar);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblRol);
            this.panel1.Controls.Add(this.cboRoles);
            this.panel1.Controls.Add(this.txtVerifyPassword);
            this.panel1.Controls.Add(this.lblVerifyPassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.txtDNI);
            this.panel1.Controls.Add(this.lblDNI);
            this.panel1.Controls.Add(this.txtFullname);
            this.panel1.Controls.Add(this.lblFullname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 428);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bttRegistrar
            // 
            this.bttRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("bttRegistrar.Image")));
            this.bttRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttRegistrar.Location = new System.Drawing.Point(111, 368);
            this.bttRegistrar.Name = "bttRegistrar";
            this.bttRegistrar.Size = new System.Drawing.Size(139, 54);
            this.bttRegistrar.TabIndex = 15;
            this.bttRegistrar.Text = "REGISTRAR";
            this.bttRegistrar.UseVisualStyleBackColor = false;
            this.bttRegistrar.Click += new System.EventHandler(this.bttRegistrar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(111, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 21);
            this.txtEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(12, 136);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 15);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRol.Location = new System.Drawing.Point(12, 316);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(35, 15);
            this.lblRol.TabIndex = 14;
            this.lblRol.Text = "ROL";
            // 
            // cboRoles
            // 
            this.cboRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Items.AddRange(new object[] {
            "Administrador",
            "Maitre",
            "Mozo",
            "Caja",
            "Usuario"});
            this.cboRoles.Location = new System.Drawing.Point(111, 313);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(160, 23);
            this.cboRoles.TabIndex = 13;
            // 
            // txtVerifyPassword
            // 
            this.txtVerifyPassword.Location = new System.Drawing.Point(111, 268);
            this.txtVerifyPassword.Name = "txtVerifyPassword";
            this.txtVerifyPassword.PasswordChar = '*';
            this.txtVerifyPassword.Size = new System.Drawing.Size(160, 21);
            this.txtVerifyPassword.TabIndex = 12;
            // 
            // lblVerifyPassword
            // 
            this.lblVerifyPassword.AutoSize = true;
            this.lblVerifyPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblVerifyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVerifyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVerifyPassword.Location = new System.Drawing.Point(12, 259);
            this.lblVerifyPassword.Name = "lblVerifyPassword";
            this.lblVerifyPassword.Size = new System.Drawing.Size(80, 30);
            this.lblVerifyPassword.TabIndex = 11;
            this.lblVerifyPassword.Text = "Verificar\r\nContraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(111, 223);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(160, 21);
            this.txtPassword.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(12, 226);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 15);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(111, 178);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(160, 21);
            this.txtUsername.TabIndex = 8;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(12, 181);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 15);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(111, 88);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(160, 21);
            this.txtDNI.TabIndex = 6;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDNI.Location = new System.Drawing.Point(12, 91);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(31, 15);
            this.lblDNI.TabIndex = 5;
            this.lblDNI.Text = "DNI";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(111, 43);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(160, 21);
            this.txtFullname.TabIndex = 4;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFullname.Location = new System.Drawing.Point(12, 46);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(58, 15);
            this.lblFullname.TabIndex = 3;
            this.lblFullname.Text = "Nombre";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 428);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Registro";
            this.Text = "Registro de Usuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button bttRegistrar;
        private Label lblRol;
        private ComboBox cboRoles;
        private TextBox txtVerifyPassword;
        private Label lblVerifyPassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblUsuario;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtFullname;
        private Label lblFullname;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtUsername;
    }
}