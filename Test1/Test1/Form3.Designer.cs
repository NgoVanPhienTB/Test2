namespace Test1
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TietSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Tus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Wed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Thu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Fri = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TietSo,
            this.Mon,
            this.Tus,
            this.Wed,
            this.Thu,
            this.Fri});
            this.dataGridView1.Location = new System.Drawing.Point(74, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 341);
            this.dataGridView1.TabIndex = 0;
            // 
            // TietSo
            // 
            this.TietSo.HeaderText = "Tiết Số ";
            this.TietSo.Name = "TietSo";
            // 
            // Mon
            // 
            this.Mon.HeaderText = "Thứ Hai";
            this.Mon.Name = "Mon";
            // 
            // Tus
            // 
            this.Tus.HeaderText = "Thứ Ba";
            this.Tus.Name = "Tus";
            // 
            // Wed
            // 
            this.Wed.HeaderText = "Thứ Tư";
            this.Wed.Name = "Wed";
            // 
            // Thu
            // 
            this.Thu.HeaderText = "Thứ Năm";
            this.Thu.Name = "Thu";
            // 
            // Fri
            // 
            this.Fri.HeaderText = "Thứ Sáu";
            this.Fri.Name = "Fri";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(312, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tạo TKB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TietSo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Mon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Tus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Wed;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Thu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Fri;
        private System.Windows.Forms.Button button1;
    }
}