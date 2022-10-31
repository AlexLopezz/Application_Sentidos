namespace Application_Sentidos.Resources
{
    partial class Reserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserva));
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MESAS_SELECCIONADAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bttMesa20 = new System.Windows.Forms.Button();
            this.bttMesa19 = new System.Windows.Forms.Button();
            this.bttMesa18 = new System.Windows.Forms.Button();
            this.bttMesa17 = new System.Windows.Forms.Button();
            this.bttMesa16 = new System.Windows.Forms.Button();
            this.bttMesa15 = new System.Windows.Forms.Button();
            this.bttMesa14 = new System.Windows.Forms.Button();
            this.bttMesa13 = new System.Windows.Forms.Button();
            this.bttMesa12 = new System.Windows.Forms.Button();
            this.bttMesa11 = new System.Windows.Forms.Button();
            this.bttMesa10 = new System.Windows.Forms.Button();
            this.bttMesa9 = new System.Windows.Forms.Button();
            this.bttMesa8 = new System.Windows.Forms.Button();
            this.bttMesa6 = new System.Windows.Forms.Button();
            this.bttMesa4 = new System.Windows.Forms.Button();
            this.bttMesa3 = new System.Windows.Forms.Button();
            this.bttMesa2 = new System.Windows.Forms.Button();
            this.bttMesa1 = new System.Windows.Forms.Button();
            this.bttMesa7 = new System.Windows.Forms.Button();
            this.bttMesa5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSchedule = new System.Windows.Forms.ComboBox();
            this.DateFecha = new System.Windows.Forms.DateTimePicker();
            this.bttShowReserva = new System.Windows.Forms.Button();
            this.bttAddReserva = new System.Windows.Forms.Button();
            this.bttDeleteReserva = new System.Windows.Forms.Button();
            this.bttRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panelCartel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblReservadas = new System.Windows.Forms.Label();
            this.lblResultadoDisponibles = new System.Windows.Forms.Label();
            this.lblResultadoReservadas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelCartel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReserva
            // 
            this.dgvReserva.AllowUserToAddRows = false;
            this.dgvReserva.AllowUserToDeleteRows = false;
            this.dgvReserva.AllowUserToResizeColumns = false;
            this.dgvReserva.AllowUserToResizeRows = false;
            this.dgvReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReserva.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvReserva.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReserva.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MESAS_SELECCIONADAS,
            this.FECHA,
            this.HORARIO,
            this.USUARIO});
            this.dgvReserva.EnableHeadersVisualStyles = false;
            this.dgvReserva.GridColor = System.Drawing.Color.Black;
            this.dgvReserva.Location = new System.Drawing.Point(359, 12);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReserva.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReserva.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReserva.RowTemplate.Height = 25;
            this.dgvReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReserva.Size = new System.Drawing.Size(378, 246);
            this.dgvReserva.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // MESAS_SELECCIONADAS
            // 
            this.MESAS_SELECCIONADAS.HeaderText = "Mesas";
            this.MESAS_SELECCIONADAS.Name = "MESAS_SELECCIONADAS";
            this.MESAS_SELECCIONADAS.ReadOnly = true;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "Fecha";
            this.FECHA.Name = "FECHA";
            // 
            // HORARIO
            // 
            this.HORARIO.HeaderText = "Horario";
            this.HORARIO.Name = "HORARIO";
            this.HORARIO.ReadOnly = true;
            // 
            // USUARIO
            // 
            this.USUARIO.HeaderText = "Usuario";
            this.USUARIO.Name = "USUARIO";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.bttMesa20, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa19, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa18, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa17, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa16, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa15, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa14, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa13, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa12, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa10, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa9, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa8, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa7, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.bttMesa5, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(337, 243);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // bttMesa20
            // 
            this.bttMesa20.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa20.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa20.Image")));
            this.bttMesa20.Location = new System.Drawing.Point(271, 183);
            this.bttMesa20.Name = "bttMesa20";
            this.bttMesa20.Size = new System.Drawing.Size(61, 57);
            this.bttMesa20.TabIndex = 19;
            this.bttMesa20.Text = "20";
            this.bttMesa20.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa20.UseVisualStyleBackColor = true;
            // 
            // bttMesa19
            // 
            this.bttMesa19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa19.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa19.Image")));
            this.bttMesa19.Location = new System.Drawing.Point(204, 183);
            this.bttMesa19.Name = "bttMesa19";
            this.bttMesa19.Size = new System.Drawing.Size(61, 57);
            this.bttMesa19.TabIndex = 18;
            this.bttMesa19.Text = "19";
            this.bttMesa19.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa19.UseVisualStyleBackColor = true;
            // 
            // bttMesa18
            // 
            this.bttMesa18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa18.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa18.Image")));
            this.bttMesa18.Location = new System.Drawing.Point(137, 183);
            this.bttMesa18.Name = "bttMesa18";
            this.bttMesa18.Size = new System.Drawing.Size(61, 57);
            this.bttMesa18.TabIndex = 17;
            this.bttMesa18.Text = "18";
            this.bttMesa18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa18.UseVisualStyleBackColor = true;
            // 
            // bttMesa17
            // 
            this.bttMesa17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa17.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa17.Image")));
            this.bttMesa17.Location = new System.Drawing.Point(70, 183);
            this.bttMesa17.Name = "bttMesa17";
            this.bttMesa17.Size = new System.Drawing.Size(61, 57);
            this.bttMesa17.TabIndex = 16;
            this.bttMesa17.Text = "17";
            this.bttMesa17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa17.UseVisualStyleBackColor = true;
            // 
            // bttMesa16
            // 
            this.bttMesa16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa16.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa16.Image")));
            this.bttMesa16.Location = new System.Drawing.Point(3, 183);
            this.bttMesa16.Name = "bttMesa16";
            this.bttMesa16.Size = new System.Drawing.Size(61, 57);
            this.bttMesa16.TabIndex = 15;
            this.bttMesa16.Text = "16";
            this.bttMesa16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa16.UseVisualStyleBackColor = true;
            // 
            // bttMesa15
            // 
            this.bttMesa15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa15.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa15.Image")));
            this.bttMesa15.Location = new System.Drawing.Point(271, 123);
            this.bttMesa15.Name = "bttMesa15";
            this.bttMesa15.Size = new System.Drawing.Size(61, 54);
            this.bttMesa15.TabIndex = 14;
            this.bttMesa15.Text = "15";
            this.bttMesa15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa15.UseVisualStyleBackColor = true;
            // 
            // bttMesa14
            // 
            this.bttMesa14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa14.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa14.Image")));
            this.bttMesa14.Location = new System.Drawing.Point(204, 123);
            this.bttMesa14.Name = "bttMesa14";
            this.bttMesa14.Size = new System.Drawing.Size(61, 54);
            this.bttMesa14.TabIndex = 13;
            this.bttMesa14.Text = "14";
            this.bttMesa14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa14.UseVisualStyleBackColor = true;
            // 
            // bttMesa13
            // 
            this.bttMesa13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa13.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa13.Image")));
            this.bttMesa13.Location = new System.Drawing.Point(137, 123);
            this.bttMesa13.Name = "bttMesa13";
            this.bttMesa13.Size = new System.Drawing.Size(61, 54);
            this.bttMesa13.TabIndex = 12;
            this.bttMesa13.Text = "13";
            this.bttMesa13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa13.UseVisualStyleBackColor = true;
            // 
            // bttMesa12
            // 
            this.bttMesa12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa12.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa12.Image")));
            this.bttMesa12.Location = new System.Drawing.Point(70, 123);
            this.bttMesa12.Name = "bttMesa12";
            this.bttMesa12.Size = new System.Drawing.Size(61, 54);
            this.bttMesa12.TabIndex = 11;
            this.bttMesa12.Text = "12";
            this.bttMesa12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa12.UseVisualStyleBackColor = true;
            // 
            // bttMesa11
            // 
            this.bttMesa11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa11.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa11.Image")));
            this.bttMesa11.Location = new System.Drawing.Point(3, 123);
            this.bttMesa11.Name = "bttMesa11";
            this.bttMesa11.Size = new System.Drawing.Size(61, 54);
            this.bttMesa11.TabIndex = 10;
            this.bttMesa11.Text = "11";
            this.bttMesa11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa11.UseVisualStyleBackColor = true;
            // 
            // bttMesa10
            // 
            this.bttMesa10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa10.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa10.Image")));
            this.bttMesa10.Location = new System.Drawing.Point(271, 63);
            this.bttMesa10.Name = "bttMesa10";
            this.bttMesa10.Size = new System.Drawing.Size(61, 54);
            this.bttMesa10.TabIndex = 9;
            this.bttMesa10.Text = "10";
            this.bttMesa10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa10.UseVisualStyleBackColor = true;
            // 
            // bttMesa9
            // 
            this.bttMesa9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa9.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa9.Image")));
            this.bttMesa9.Location = new System.Drawing.Point(204, 63);
            this.bttMesa9.Name = "bttMesa9";
            this.bttMesa9.Size = new System.Drawing.Size(61, 54);
            this.bttMesa9.TabIndex = 8;
            this.bttMesa9.Text = "9";
            this.bttMesa9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa9.UseVisualStyleBackColor = true;
            // 
            // bttMesa8
            // 
            this.bttMesa8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa8.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa8.Image")));
            this.bttMesa8.Location = new System.Drawing.Point(137, 63);
            this.bttMesa8.Name = "bttMesa8";
            this.bttMesa8.Size = new System.Drawing.Size(61, 54);
            this.bttMesa8.TabIndex = 7;
            this.bttMesa8.Text = "8";
            this.bttMesa8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa8.UseVisualStyleBackColor = true;
            // 
            // bttMesa6
            // 
            this.bttMesa6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa6.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa6.Image")));
            this.bttMesa6.Location = new System.Drawing.Point(3, 63);
            this.bttMesa6.Name = "bttMesa6";
            this.bttMesa6.Size = new System.Drawing.Size(61, 54);
            this.bttMesa6.TabIndex = 5;
            this.bttMesa6.Text = "6";
            this.bttMesa6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa6.UseVisualStyleBackColor = true;
            // 
            // bttMesa4
            // 
            this.bttMesa4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa4.ForeColor = System.Drawing.Color.Black;
            this.bttMesa4.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa4.Image")));
            this.bttMesa4.Location = new System.Drawing.Point(204, 3);
            this.bttMesa4.Name = "bttMesa4";
            this.bttMesa4.Size = new System.Drawing.Size(61, 54);
            this.bttMesa4.TabIndex = 3;
            this.bttMesa4.Text = "4";
            this.bttMesa4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa4.UseVisualStyleBackColor = true;
            // 
            // bttMesa3
            // 
            this.bttMesa3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa3.ForeColor = System.Drawing.Color.Black;
            this.bttMesa3.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa3.Image")));
            this.bttMesa3.Location = new System.Drawing.Point(137, 3);
            this.bttMesa3.Name = "bttMesa3";
            this.bttMesa3.Size = new System.Drawing.Size(61, 54);
            this.bttMesa3.TabIndex = 2;
            this.bttMesa3.Text = "3";
            this.bttMesa3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa3.UseVisualStyleBackColor = true;
            // 
            // bttMesa2
            // 
            this.bttMesa2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa2.ForeColor = System.Drawing.Color.Black;
            this.bttMesa2.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa2.Image")));
            this.bttMesa2.Location = new System.Drawing.Point(70, 3);
            this.bttMesa2.Name = "bttMesa2";
            this.bttMesa2.Size = new System.Drawing.Size(61, 54);
            this.bttMesa2.TabIndex = 1;
            this.bttMesa2.Text = "2";
            this.bttMesa2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa2.UseVisualStyleBackColor = true;
            // 
            // bttMesa1
            // 
            this.bttMesa1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa1.ForeColor = System.Drawing.Color.Black;
            this.bttMesa1.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa1.Image")));
            this.bttMesa1.Location = new System.Drawing.Point(3, 3);
            this.bttMesa1.Name = "bttMesa1";
            this.bttMesa1.Size = new System.Drawing.Size(61, 54);
            this.bttMesa1.TabIndex = 0;
            this.bttMesa1.Text = "1";
            this.bttMesa1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa1.UseVisualStyleBackColor = true;
            // 
            // bttMesa7
            // 
            this.bttMesa7.BackColor = System.Drawing.Color.Transparent;
            this.bttMesa7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa7.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa7.Image")));
            this.bttMesa7.Location = new System.Drawing.Point(70, 63);
            this.bttMesa7.Name = "bttMesa7";
            this.bttMesa7.Size = new System.Drawing.Size(61, 54);
            this.bttMesa7.TabIndex = 6;
            this.bttMesa7.Text = "7";
            this.bttMesa7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa7.UseVisualStyleBackColor = false;
            // 
            // bttMesa5
            // 
            this.bttMesa5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttMesa5.ForeColor = System.Drawing.Color.Black;
            this.bttMesa5.Image = ((System.Drawing.Image)(resources.GetObject("bttMesa5.Image")));
            this.bttMesa5.Location = new System.Drawing.Point(271, 3);
            this.bttMesa5.Name = "bttMesa5";
            this.bttMesa5.Size = new System.Drawing.Size(61, 54);
            this.bttMesa5.TabIndex = 4;
            this.bttMesa5.Text = "5";
            this.bttMesa5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMesa5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(475, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "FECHA";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(281, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "HORARIO";
            // 
            // cboSchedule
            // 
            this.cboSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboSchedule.FormattingEnabled = true;
            this.cboSchedule.Items.AddRange(new object[] {
            "Desayuno",
            "Almuerzo",
            "Merienda",
            "Cena"});
            this.cboSchedule.Location = new System.Drawing.Point(341, 267);
            this.cboSchedule.Name = "cboSchedule";
            this.cboSchedule.Size = new System.Drawing.Size(128, 23);
            this.cboSchedule.TabIndex = 5;
            // 
            // DateFecha
            // 
            this.DateFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateFecha.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateFecha.CustomFormat = "yyyy-MM-dd";
            this.DateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateFecha.Location = new System.Drawing.Point(525, 267);
            this.DateFecha.Name = "DateFecha";
            this.DateFecha.Size = new System.Drawing.Size(113, 23);
            this.DateFecha.TabIndex = 6;
            // 
            // bttShowReserva
            // 
            this.bttShowReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttShowReserva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttShowReserva.Location = new System.Drawing.Point(644, 261);
            this.bttShowReserva.Name = "bttShowReserva";
            this.bttShowReserva.Size = new System.Drawing.Size(93, 39);
            this.bttShowReserva.TabIndex = 7;
            this.bttShowReserva.Text = "VER\r\nRESERVAS";
            this.bttShowReserva.UseVisualStyleBackColor = true;
            this.bttShowReserva.Click += new System.EventHandler(this.bttShowReserva_Click);
            // 
            // bttAddReserva
            // 
            this.bttAddReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttAddReserva.BackColor = System.Drawing.Color.Lime;
            this.bttAddReserva.FlatAppearance.BorderSize = 0;
            this.bttAddReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAddReserva.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttAddReserva.Location = new System.Drawing.Point(743, 12);
            this.bttAddReserva.Name = "bttAddReserva";
            this.bttAddReserva.Size = new System.Drawing.Size(77, 42);
            this.bttAddReserva.TabIndex = 8;
            this.bttAddReserva.Text = "Agregar reserva";
            this.bttAddReserva.UseVisualStyleBackColor = false;
            this.bttAddReserva.Click += new System.EventHandler(this.bttAddReserva_Click);
            // 
            // bttDeleteReserva
            // 
            this.bttDeleteReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttDeleteReserva.BackColor = System.Drawing.Color.Red;
            this.bttDeleteReserva.FlatAppearance.BorderSize = 0;
            this.bttDeleteReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDeleteReserva.ForeColor = System.Drawing.Color.White;
            this.bttDeleteReserva.Location = new System.Drawing.Point(743, 60);
            this.bttDeleteReserva.Name = "bttDeleteReserva";
            this.bttDeleteReserva.Size = new System.Drawing.Size(75, 39);
            this.bttDeleteReserva.TabIndex = 9;
            this.bttDeleteReserva.Text = "Eliminar reserva";
            this.bttDeleteReserva.UseVisualStyleBackColor = false;
            this.bttDeleteReserva.Click += new System.EventHandler(this.bttDeleteReserva_Click);
            // 
            // bttRefresh
            // 
            this.bttRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttRefresh.Image = ((System.Drawing.Image)(resources.GetObject("bttRefresh.Image")));
            this.bttRefresh.Location = new System.Drawing.Point(743, 231);
            this.bttRefresh.Name = "bttRefresh";
            this.bttRefresh.Size = new System.Drawing.Size(41, 27);
            this.bttRefresh.TabIndex = 10;
            this.bttRefresh.UseVisualStyleBackColor = true;
            this.bttRefresh.Click += new System.EventHandler(this.bttRefresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(399, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 14;
            // 
            // panelCartel
            // 
            this.panelCartel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCartel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelCartel.Controls.Add(this.label6);
            this.panelCartel.Controls.Add(this.lblReservadas);
            this.panelCartel.Controls.Add(this.lblResultadoDisponibles);
            this.panelCartel.Controls.Add(this.lblResultadoReservadas);
            this.panelCartel.Location = new System.Drawing.Point(144, 306);
            this.panelCartel.Name = "panelCartel";
            this.panelCartel.Size = new System.Drawing.Size(211, 111);
            this.panelCartel.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mesas disponibles";
            // 
            // lblReservadas
            // 
            this.lblReservadas.AutoSize = true;
            this.lblReservadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReservadas.Location = new System.Drawing.Point(8, 12);
            this.lblReservadas.Name = "lblReservadas";
            this.lblReservadas.Size = new System.Drawing.Size(133, 21);
            this.lblReservadas.TabIndex = 3;
            this.lblReservadas.Text = "Mesas reservadas";
            // 
            // lblResultadoDisponibles
            // 
            this.lblResultadoDisponibles.AutoSize = true;
            this.lblResultadoDisponibles.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultadoDisponibles.Location = new System.Drawing.Point(147, 45);
            this.lblResultadoDisponibles.Name = "lblResultadoDisponibles";
            this.lblResultadoDisponibles.Size = new System.Drawing.Size(39, 47);
            this.lblResultadoDisponibles.TabIndex = 2;
            this.lblResultadoDisponibles.Text = "0";
            // 
            // lblResultadoReservadas
            // 
            this.lblResultadoReservadas.AutoSize = true;
            this.lblResultadoReservadas.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultadoReservadas.Location = new System.Drawing.Point(147, 0);
            this.lblResultadoReservadas.Name = "lblResultadoReservadas";
            this.lblResultadoReservadas.Size = new System.Drawing.Size(39, 47);
            this.lblResultadoReservadas.TabIndex = 1;
            this.lblResultadoReservadas.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(10, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 30);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(10, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 30);
            this.panel2.TabIndex = 17;
            // 
            // lblDisponible
            // 
            this.lblDisponible.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDisponible.Location = new System.Drawing.Point(55, 281);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(76, 15);
            this.lblDisponible.TabIndex = 18;
            this.lblDisponible.Text = "DISPONIBLE";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "RESERVADA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(673, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(399, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "\"Los sabores que te haran sentir bien\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(458, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "RESTAURANTE SENTIDOS Y CASA DE TE";
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(825, 420);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCartel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttRefresh);
            this.Controls.Add(this.bttDeleteReserva);
            this.Controls.Add(this.bttAddReserva);
            this.Controls.Add(this.bttShowReserva);
            this.Controls.Add(this.DateFecha);
            this.Controls.Add(this.cboSchedule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dgvReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reserva";
            this.Text = "Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelCartel.ResumeLayout(false);
            this.panelCartel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvReserva;
        private TableLayoutPanel tableLayoutPanel2;
        private Button bttMesa20;
        private Button bttMesa19;
        private Button bttMesa18;
        private Button bttMesa17;
        private Button bttMesa16;
        private Button bttMesa15;
        private Button bttMesa14;
        private Button bttMesa13;
        private Button bttMesa12;
        private Button bttMesa11;
        private Button bttMesa10;
        private Button bttMesa9;
        private Button bttMesa8;
        private Button bttMesa6;
        private Button bttMesa5;
        private Button bttMesa4;
        private Button bttMesa3;
        private Button bttMesa2;
        private Button bttMesa1;
        private Button bttMesa7;
        private Label label1;
        private Label label2;
        private ComboBox cboSchedule;
        private DateTimePicker DateFecha;
        private Button bttShowReserva;
        private Button bttAddReserva;
        private Button bttDeleteReserva;
        private Button bttRefresh;
        private Label label5;
        private Panel panelCartel;
        private Label label6;
        private Label lblReservadas;
        private Label lblResultadoDisponibles;
        private Label lblResultadoReservadas;
        private Panel panel1;
        private Panel panel2;
        private Label lblDisponible;
        private Label label3;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MESAS_SELECCIONADAS;
        private DataGridViewTextBoxColumn FECHA;
        private DataGridViewTextBoxColumn HORARIO;
        private DataGridViewTextBoxColumn USUARIO;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label7;
    }
}