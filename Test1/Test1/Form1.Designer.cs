namespace Test1
{
    partial class Form1
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
            this.Them_MonHoc = new System.Windows.Forms.Button();
            this.textBox_MonHoc = new System.Windows.Forms.TextBox();
            this.SoTinChi = new System.Windows.Forms.NumericUpDown();
            this.MonHoc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TaoThoiKhoaBieu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Sum_MonHoc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Sum_TinChi = new System.Windows.Forms.Label();
            this.TietHoc = new System.Windows.Forms.Label();
            this.So_Tiet = new System.Windows.Forms.NumericUpDown();
            this.DanhSachMonHoc = new System.Windows.Forms.DataGridView();
            this.Mon_Hoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_Tin_Chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_Tiet_Hoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKB_Cus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SoTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.So_Tiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // Them_MonHoc
            // 
            this.Them_MonHoc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them_MonHoc.Location = new System.Drawing.Point(105, 259);
            this.Them_MonHoc.Name = "Them_MonHoc";
            this.Them_MonHoc.Size = new System.Drawing.Size(205, 28);
            this.Them_MonHoc.TabIndex = 1;
            this.Them_MonHoc.Text = "Thêm Vào Danh Sách -->";
            this.Them_MonHoc.UseVisualStyleBackColor = true;
            this.Them_MonHoc.Click += new System.EventHandler(this.Them_MonHoc_Click);
            // 
            // textBox_MonHoc
            // 
            this.textBox_MonHoc.Location = new System.Drawing.Point(105, 128);
            this.textBox_MonHoc.Multiline = true;
            this.textBox_MonHoc.Name = "textBox_MonHoc";
            this.textBox_MonHoc.Size = new System.Drawing.Size(250, 25);
            this.textBox_MonHoc.TabIndex = 2;
            // 
            // SoTinChi
            // 
            this.SoTinChi.Location = new System.Drawing.Point(105, 177);
            this.SoTinChi.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.SoTinChi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SoTinChi.Name = "SoTinChi";
            this.SoTinChi.Size = new System.Drawing.Size(50, 20);
            this.SoTinChi.TabIndex = 3;
            this.SoTinChi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MonHoc
            // 
            this.MonHoc.AutoSize = true;
            this.MonHoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonHoc.Location = new System.Drawing.Point(0, 129);
            this.MonHoc.Name = "MonHoc";
            this.MonHoc.Size = new System.Drawing.Size(99, 16);
            this.MonHoc.TabIndex = 4;
            this.MonHoc.Text = "Tên Môn Học :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số Tiết Học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Danh Sách Môn Học ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lên Lịch Thời Khóa Biểu";
            // 
            // TaoThoiKhoaBieu
            // 
            this.TaoThoiKhoaBieu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaoThoiKhoaBieu.Location = new System.Drawing.Point(8, 408);
            this.TaoThoiKhoaBieu.Name = "TaoThoiKhoaBieu";
            this.TaoThoiKhoaBieu.Size = new System.Drawing.Size(347, 36);
            this.TaoThoiKhoaBieu.TabIndex = 9;
            this.TaoThoiKhoaBieu.Text = "Tạo Thời Khóa Biểu";
            this.TaoThoiKhoaBieu.UseVisualStyleBackColor = true;
            this.TaoThoiKhoaBieu.Click += new System.EventHandler(this.TaoThoiKhoaBieu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số Môn Học :";
            // 
            // Sum_MonHoc
            // 
            this.Sum_MonHoc.AutoSize = true;
            this.Sum_MonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum_MonHoc.Location = new System.Drawing.Point(533, 132);
            this.Sum_MonHoc.Name = "Sum_MonHoc";
            this.Sum_MonHoc.Size = new System.Drawing.Size(16, 16);
            this.Sum_MonHoc.TabIndex = 12;
            this.Sum_MonHoc.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(611, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tổng Số Tín Chỉ :\r\n";
            // 
            // Sum_TinChi
            // 
            this.Sum_TinChi.AutoSize = true;
            this.Sum_TinChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum_TinChi.Location = new System.Drawing.Point(735, 132);
            this.Sum_TinChi.Name = "Sum_TinChi";
            this.Sum_TinChi.Size = new System.Drawing.Size(16, 16);
            this.Sum_TinChi.TabIndex = 14;
            this.Sum_TinChi.Text = "0";
            // 
            // TietHoc
            // 
            this.TietHoc.AutoSize = true;
            this.TietHoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TietHoc.Location = new System.Drawing.Point(5, 218);
            this.TietHoc.Name = "TietHoc";
            this.TietHoc.Size = new System.Drawing.Size(82, 16);
            this.TietHoc.TabIndex = 15;
            this.TietHoc.Text = "Số Tín Chỉ :";
            // 
            // So_Tiet
            // 
            this.So_Tiet.Location = new System.Drawing.Point(105, 218);
            this.So_Tiet.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.So_Tiet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.So_Tiet.Name = "So_Tiet";
            this.So_Tiet.Size = new System.Drawing.Size(50, 20);
            this.So_Tiet.TabIndex = 16;
            this.So_Tiet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DanhSachMonHoc
            // 
            this.DanhSachMonHoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DanhSachMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mon_Hoc,
            this.so_Tin_Chi,
            this.So_Tiet_Hoc});
            this.DanhSachMonHoc.Location = new System.Drawing.Point(365, 164);
            this.DanhSachMonHoc.Name = "DanhSachMonHoc";
            this.DanhSachMonHoc.Size = new System.Drawing.Size(461, 220);
            this.DanhSachMonHoc.TabIndex = 17;
            // 
            // Mon_Hoc
            // 
            this.Mon_Hoc.HeaderText = "Môn Học";
            this.Mon_Hoc.Name = "Mon_Hoc";
            this.Mon_Hoc.Width = 270;
            // 
            // so_Tin_Chi
            // 
            this.so_Tin_Chi.HeaderText = "Số Tín Chỉ";
            this.so_Tin_Chi.Name = "so_Tin_Chi";
            this.so_Tin_Chi.Width = 70;
            // 
            // So_Tiet_Hoc
            // 
            this.So_Tiet_Hoc.HeaderText = "Số Tiết Học";
            this.So_Tiet_Hoc.Name = "So_Tiet_Hoc";
            // 
            // TKB_Cus
            // 
            this.TKB_Cus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TKB_Cus.Location = new System.Drawing.Point(474, 408);
            this.TKB_Cus.Name = "TKB_Cus";
            this.TKB_Cus.Size = new System.Drawing.Size(352, 36);
            this.TKB_Cus.TabIndex = 18;
            this.TKB_Cus.Text = "Tạo Thời Khóa Biểu Tùy Chọn\r\n";
            this.TKB_Cus.UseVisualStyleBackColor = true;
            this.TKB_Cus.Click += new System.EventHandler(this.TKB_Cus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 456);
            this.Controls.Add(this.TKB_Cus);
            this.Controls.Add(this.DanhSachMonHoc);
            this.Controls.Add(this.So_Tiet);
            this.Controls.Add(this.TietHoc);
            this.Controls.Add(this.Sum_TinChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Sum_MonHoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TaoThoiKhoaBieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MonHoc);
            this.Controls.Add(this.SoTinChi);
            this.Controls.Add(this.textBox_MonHoc);
            this.Controls.Add(this.Them_MonHoc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SoTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.So_Tiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Them_MonHoc;
        private System.Windows.Forms.TextBox textBox_MonHoc;
        private System.Windows.Forms.NumericUpDown SoTinChi;
        private System.Windows.Forms.Label MonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TaoThoiKhoaBieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Sum_MonHoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Sum_TinChi;
        private System.Windows.Forms.Label TietHoc;
        private System.Windows.Forms.NumericUpDown So_Tiet;
        private System.Windows.Forms.DataGridView DanhSachMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mon_Hoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_Tin_Chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Tiet_Hoc;
        private System.Windows.Forms.Button TKB_Cus;
    }
}

