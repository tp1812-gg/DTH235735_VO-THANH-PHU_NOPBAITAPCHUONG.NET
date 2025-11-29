namespace Bài_4
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
            this.rdoThuong = new System.Windows.Forms.RadioButton();
            this.rdoHoa = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoThuong
            // 
            this.rdoThuong.AutoSize = true;
            this.rdoThuong.Location = new System.Drawing.Point(48, 81);
            this.rdoThuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoThuong.Name = "rdoThuong";
            this.rdoThuong.Size = new System.Drawing.Size(128, 26);
            this.rdoThuong.TabIndex = 0;
            this.rdoThuong.TabStop = true;
            this.rdoThuong.Text = "Chữ thường ";
            this.rdoThuong.UseVisualStyleBackColor = true;
            // 
            // rdoHoa
            // 
            this.rdoHoa.AutoSize = true;
            this.rdoHoa.Location = new System.Drawing.Point(48, 148);
            this.rdoHoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoHoa.Name = "rdoHoa";
            this.rdoHoa.Size = new System.Drawing.Size(146, 26);
            this.rdoHoa.TabIndex = 1;
            this.rdoHoa.TabStop = true;
            this.rdoHoa.Text = "CHỮ IN HOA";
            this.rdoHoa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.rdoThuong);
            this.groupBox1.Controls.Add(this.rdoHoa);
            this.groupBox1.Location = new System.Drawing.Point(315, 121);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(425, 213);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn kiểu chữ ";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(236, 77);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 32);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(236, 142);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 32);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(341, 373);
            this.btnKetQua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(103, 32);
            this.btnKetQua.TabIndex = 2;
            this.btnKetQua.Text = "Kết quả ";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(470, 72);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(236, 30);
            this.txtHoTen.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(337, 72);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 22);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nhập họ tên: ";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(470, 374);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(236, 30);
            this.txtKetQua.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Đổi kiểu chữ ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoThuong;
        private System.Windows.Forms.RadioButton rdoHoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}

