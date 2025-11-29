namespace Bài_6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnMauChu = new System.Windows.Forms.Button();
            this.btnMauNen = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(68, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(416, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập chuỗi ";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(98, 217);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(333, 217);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnMauChu
            // 
            this.btnMauChu.Location = new System.Drawing.Point(524, 301);
            this.btnMauChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMauChu.Name = "btnMauChu";
            this.btnMauChu.Size = new System.Drawing.Size(170, 46);
            this.btnMauChu.TabIndex = 2;
            this.btnMauChu.Text = "Chọn màu  chữ ";
            this.btnMauChu.UseVisualStyleBackColor = true;
            this.btnMauChu.Click += new System.EventHandler(this.btnMauChu_Click);
            // 
            // btnMauNen
            // 
            this.btnMauNen.Location = new System.Drawing.Point(756, 301);
            this.btnMauNen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMauNen.Name = "btnMauNen";
            this.btnMauNen.Size = new System.Drawing.Size(170, 46);
            this.btnMauNen.TabIndex = 3;
            this.btnMauNen.Text = "Chọn màu nền ";
            this.btnMauNen.UseVisualStyleBackColor = true;
            this.btnMauNen.Click += new System.EventHandler(this.btnMauNen_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(990, 301);
            this.btnFont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(166, 46);
            this.btnFont.TabIndex = 4;
            this.btnFont.Text = "Chọn font ";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(756, 376);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(170, 46);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng ";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "Trần Duy Khánh ",
            "Đỗ Thanh Vy ",
            "Trần Thị Huyền Trân",
            "Trần Thị Thị ",
            "Trần Văn Trần"});
            this.listBox1.Location = new System.Drawing.Point(98, 276);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(368, 136);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtKQ
            // 
            this.txtKQ.BackColor = System.Drawing.Color.MediumPurple;
            this.txtKQ.ForeColor = System.Drawing.Color.Red;
            this.txtKQ.Location = new System.Drawing.Point(524, 94);
            this.txtKQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(632, 172);
            this.txtKQ.TabIndex = 7;
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(30, 47);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(368, 30);
            this.txtNhap.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 647);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnMauChu);
            this.Controls.Add(this.btnMauNen);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Controls";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMauChu;
        private System.Windows.Forms.Button btnMauNen;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtKQ;
    }
}

