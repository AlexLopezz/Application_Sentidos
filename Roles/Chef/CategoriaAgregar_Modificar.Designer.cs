namespace Application_Sentidos.Roles.Chef
{
    partial class CategoriaAgregar_Modificar
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
            this.bttCategoria = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttCategoria
            // 
            this.bttCategoria.Location = new System.Drawing.Point(193, 33);
            this.bttCategoria.Name = "bttCategoria";
            this.bttCategoria.Size = new System.Drawing.Size(75, 39);
            this.bttCategoria.TabIndex = 0;
            this.bttCategoria.UseVisualStyleBackColor = true;
            this.bttCategoria.Click += new System.EventHandler(this.bttCategoria_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoria.Location = new System.Drawing.Point(12, 19);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(113, 15);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "*Nombre categoria";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 23);
            this.textBox1.TabIndex = 2;
            // 
            // CategoriaAgregar_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(280, 87);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.bttCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoriaAgregar_Modificar";
            this.Text = "Administracion Categorias - Restaurante Sentidos & Casa de Te";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bttCategoria;
        private Label lblCategoria;
        private TextBox textBox1;
    }
}