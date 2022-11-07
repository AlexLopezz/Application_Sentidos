namespace Application_Sentidos.Resources.Administrador
{
    partial class Modificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar));
            this.bttModificar = new System.Windows.Forms.Button();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.lblRoles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttModificar
            // 
            this.bttModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bttModificar.FlatAppearance.BorderSize = 0;
            this.bttModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttModificar.Location = new System.Drawing.Point(164, 253);
            this.bttModificar.Name = "bttModificar";
            this.bttModificar.Size = new System.Drawing.Size(124, 55);
            this.bttModificar.TabIndex = 7;
            this.bttModificar.Text = "MODIFICAR";
            this.bttModificar.UseVisualStyleBackColor = false;
            this.bttModificar.Click += new System.EventHandler(this.bttModificar_Click);
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(105, 25);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(167, 21);
            this.txtFullname.TabIndex = 1;
            this.txtFullname.Leave += new System.EventHandler(this.txtFullname_Leave);
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFullname.Location = new System.Drawing.Point(12, 28);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(58, 15);
            this.lblFullname.TabIndex = 5;
            this.lblFullname.Text = "Nombre\r\n";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDNI.Location = new System.Drawing.Point(18, 74);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(31, 15);
            this.lblDNI.TabIndex = 7;
            this.lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(105, 68);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(167, 21);
            this.txtDNI.TabIndex = 2;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(18, 117);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 15);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 21);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(18, 161);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(57, 15);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Usuario";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(105, 158);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(167, 21);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // cboRoles
            // 
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Items.AddRange(new object[] {
            "Administrador",
            "Mitre",
            "Mozo",
            "Caja"});
            this.cboRoles.Location = new System.Drawing.Point(105, 208);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(167, 23);
            this.cboRoles.TabIndex = 6;
            this.cboRoles.Leave += new System.EventHandler(this.cboRoles_Leave);
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoles.Location = new System.Drawing.Point(18, 211);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(35, 15);
            this.lblRoles.TabIndex = 15;
            this.lblRoles.Text = "ROL";
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(300, 320);
            this.Controls.Add(this.lblRoles);
            this.Controls.Add(this.cboRoles);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.bttModificar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modificar";
            this.Text = "Modificar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bttModificar;
        private TextBox txtFullname;
        private Label lblFullname;
        private Label lblDNI;
        private TextBox txtDNI;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblUsername;
        private TextBox txtUsername;
        private ComboBox cboRoles;
        private Label lblRoles;
    }
}