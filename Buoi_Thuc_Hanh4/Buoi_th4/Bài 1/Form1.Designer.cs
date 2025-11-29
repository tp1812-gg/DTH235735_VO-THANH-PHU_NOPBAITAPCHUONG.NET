namespace Bài_1
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
            this.lblKQ = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnChan = new System.Windows.Forms.Button();
            this.btnLe = new System.Windows.Forms.Button();
            this.btnUCLN = new System.Windows.Forms.Button();
            this.btnTo = new System.Windows.Forms.Button();
            this.btnTrungBinh = new System.Windows.Forms.Button();
            this.btnHao = new System.Windows.Forms.Button();
            this.btnNho = new System.Windows.Forms.Button();
            this.btnLon = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKQ
            // 
            this.lblKQ.BackColor = System.Drawing.Color.LightYellow;
            this.lblKQ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKQ.Location = new System.Drawing.Point(34, 106);
            this.lblKQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(625, 100);
            this.lblKQ.TabIndex = 0;
            this.lblKQ.Text = "label1";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(214, 51);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(142, 30);
            this.txtNhap.TabIndex = 1;
            // 
            // btnChan
            // 
            this.btnChan.Location = new System.Drawing.Point(34, 218);
            this.btnChan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(146, 46);
            this.btnChan.TabIndex = 2;
            this.btnChan.Text = "Đếm Số Chẳn ";
            this.btnChan.UseVisualStyleBackColor = true;
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            // 
            // btnLe
            // 
            this.btnLe.Location = new System.Drawing.Point(191, 218);
            this.btnLe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLe.Name = "btnLe";
            this.btnLe.Size = new System.Drawing.Size(146, 46);
            this.btnLe.TabIndex = 3;
            this.btnLe.Text = "Đếm Số Lẻ ";
            this.btnLe.UseVisualStyleBackColor = true;
            this.btnLe.Click += new System.EventHandler(this.btnLe_Click);
            // 
            // btnUCLN
            // 
            this.btnUCLN.Location = new System.Drawing.Point(34, 287);
            this.btnUCLN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUCLN.Name = "btnUCLN";
            this.btnUCLN.Size = new System.Drawing.Size(300, 46);
            this.btnUCLN.TabIndex = 4;
            this.btnUCLN.Text = "UCLN 2 Phần Tử Đầu Tiên ";
            this.btnUCLN.UseVisualStyleBackColor = true;
            this.btnUCLN.Click += new System.EventHandler(this.btnUCLN_Click);
            // 
            // btnTo
            // 
            this.btnTo.Location = new System.Drawing.Point(358, 218);
            this.btnTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(146, 46);
            this.btnTo.TabIndex = 5;
            this.btnTo.Text = "Số Nguyên Tố ";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // btnTrungBinh
            // 
            this.btnTrungBinh.Location = new System.Drawing.Point(343, 287);
            this.btnTrungBinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTrungBinh.Name = "btnTrungBinh";
            this.btnTrungBinh.Size = new System.Drawing.Size(167, 46);
            this.btnTrungBinh.TabIndex = 6;
            this.btnTrungBinh.Text = "Trung Bình Mảng ";
            this.btnTrungBinh.UseVisualStyleBackColor = true;
            this.btnTrungBinh.Click += new System.EventHandler(this.btnTrungBinh_Click);
            // 
            // btnHao
            // 
            this.btnHao.Location = new System.Drawing.Point(515, 218);
            this.btnHao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHao.Name = "btnHao";
            this.btnHao.Size = new System.Drawing.Size(146, 46);
            this.btnHao.TabIndex = 7;
            this.btnHao.Text = "Số Hoàn Hảo ";
            this.btnHao.UseVisualStyleBackColor = true;
            this.btnHao.Click += new System.EventHandler(this.btnHao_Click);
            // 
            // btnNho
            // 
            this.btnNho.Location = new System.Drawing.Point(518, 287);
            this.btnNho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNho.Name = "btnNho";
            this.btnNho.Size = new System.Drawing.Size(146, 46);
            this.btnNho.TabIndex = 8;
            this.btnNho.Text = "Số Nhỏ Nhất ";
            this.btnNho.UseVisualStyleBackColor = true;
            this.btnNho.Click += new System.EventHandler(this.btnNho_Click);
            // 
            // btnLon
            // 
            this.btnLon.Location = new System.Drawing.Point(667, 287);
            this.btnLon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLon.Name = "btnLon";
            this.btnLon.Size = new System.Drawing.Size(146, 46);
            this.btnLon.TabIndex = 9;
            this.btnLon.Text = "Số Lớn Nhất";
            this.btnLon.UseVisualStyleBackColor = true;
            this.btnLon.Click += new System.EventHandler(this.btnLon_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(667, 218);
            this.btnTong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(146, 46);
            this.btnTong.TabIndex = 10;
            this.btnTong.Text = "Tổng Mảng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnTang
            // 
            this.btnTang.Location = new System.Drawing.Point(667, 160);
            this.btnTang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(146, 46);
            this.btnTang.TabIndex = 11;
            this.btnTang.Text = "Xắp Sếp Tăng";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Location = new System.Drawing.Point(667, 106);
            this.btnGiam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(146, 46);
            this.btnGiam.TabIndex = 12;
            this.btnGiam.Text = "Xắp Sếp Giảm ";
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(667, 42);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(146, 46);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(515, 42);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(146, 46);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(364, 42);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(140, 46);
            this.btnIn.TabIndex = 15;
            this.btnIn.Text = "In Mảng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(34, 42);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(167, 46);
            this.btnNhap.TabIndex = 16;
            this.btnNhap.Text = "Nhập 1 Phân Tử: ";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(836, 381);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.btnTang);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnLon);
            this.Controls.Add(this.btnNho);
            this.Controls.Add(this.btnHao);
            this.Controls.Add(this.btnTrungBinh);
            this.Controls.Add(this.btnTo);
            this.Controls.Add(this.btnUCLN);
            this.Controls.Add(this.btnLe);
            this.Controls.Add(this.btnChan);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lblKQ);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Mảng số nguyên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.Button btnLe;
        private System.Windows.Forms.Button btnUCLN;
        private System.Windows.Forms.Button btnTo;
        private System.Windows.Forms.Button btnTrungBinh;
        private System.Windows.Forms.Button btnHao;
        private System.Windows.Forms.Button btnNho;
        private System.Windows.Forms.Button btnLon;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnNhap;
    }
}

