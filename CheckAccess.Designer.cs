namespace Application_Sentidos
{
    partial class CheckAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckAccess));
            this.lblCodeAccess = new System.Windows.Forms.Label();
            this.bttCodeAccess = new System.Windows.Forms.Button();
            this.txtCodeAccess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCodeAccess
            // 
            this.lblCodeAccess.AutoSize = true;
            this.lblCodeAccess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodeAccess.Location = new System.Drawing.Point(77, 22);
            this.lblCodeAccess.Name = "lblCodeAccess";
            this.lblCodeAccess.Size = new System.Drawing.Size(211, 15);
            this.lblCodeAccess.TabIndex = 0;
            this.lblCodeAccess.Text = "INGRESE EL CODIGO DE SEGURIDAD";
            // 
            // bttCodeAccess
            // 
            this.bttCodeAccess.Location = new System.Drawing.Point(135, 69);
            this.bttCodeAccess.Name = "bttCodeAccess";
            this.bttCodeAccess.Size = new System.Drawing.Size(75, 23);
            this.bttCodeAccess.TabIndex = 1;
            this.bttCodeAccess.Text = "OK";
            this.bttCodeAccess.UseVisualStyleBackColor = true;
            this.bttCodeAccess.Click += new System.EventHandler(this.bttCodeAccess_Click);
            // 
            // txtCodeAccess
            // 
            this.txtCodeAccess.Location = new System.Drawing.Point(106, 40);
            this.txtCodeAccess.Name = "txtCodeAccess";
            this.txtCodeAccess.PasswordChar = '*';
            this.txtCodeAccess.Size = new System.Drawing.Size(131, 23);
            this.txtCodeAccess.TabIndex = 2;
            // 
            // CheckAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 102);
            this.Controls.Add(this.txtCodeAccess);
            this.Controls.Add(this.bttCodeAccess);
            this.Controls.Add(this.lblCodeAccess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckAccess";
            this.Text = "Verificar Acceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCodeAccess;
        private Button bttCodeAccess;
        private TextBox txtCodeAccess;
    }
}