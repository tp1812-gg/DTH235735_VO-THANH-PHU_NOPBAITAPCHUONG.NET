namespace Bài_2._8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtA = new TextBox();
            txtB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnTong = new Button();
            txtKetQua = new TextBox();
            label4 = new Label();
            label1 = new Label();
            btnThuong = new Button();
            btnTich = new Button();
            btnHieu = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 9F);
            groupBox1.Location = new Point(466, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 192);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // txtA
            // 
            txtA.Location = new Point(194, 51);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 25);
            txtA.TabIndex = 6;
            // 
            // txtB
            // 
            txtB.Location = new Point(194, 137);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 25);
            txtB.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 58);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 2;
            label3.Text = "Nhập a:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 144);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 1;
            label2.Text = "Nhập b: ";
            // 
            // btnTong
            // 
            btnTong.Font = new Font("Times New Roman", 9F);
            btnTong.Location = new Point(357, 360);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(94, 29);
            btnTong.TabIndex = 15;
            btnTong.Text = "Tổng";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Font = new Font("Times New Roman", 9F);
            txtKetQua.Location = new Point(660, 305);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(125, 25);
            txtKetQua.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F);
            label4.Location = new Point(565, 312);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 13;
            label4.Text = "Kết quả: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(607, 45);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 12;
            label1.Text = "Phép toán";
            // 
            // btnThuong
            // 
            btnThuong.Location = new Point(858, 360);
            btnThuong.Name = "btnThuong";
            btnThuong.Size = new Size(94, 29);
            btnThuong.TabIndex = 17;
            btnThuong.Text = "Thương";
            btnThuong.UseVisualStyleBackColor = true;
            btnThuong.Click += btnThuong_Click;
            // 
            // btnTich
            // 
            btnTich.Location = new Point(691, 360);
            btnTich.Name = "btnTich";
            btnTich.Size = new Size(94, 29);
            btnTich.TabIndex = 18;
            btnTich.Text = "Tích";
            btnTich.UseVisualStyleBackColor = true;
            btnTich.Click += btnTich_Click;
            // 
            // btnHieu
            // 
            btnHieu.Location = new Point(529, 360);
            btnHieu.Name = "btnHieu";
            btnHieu.Size = new Size(94, 29);
            btnHieu.TabIndex = 19;
            btnHieu.Text = "Hiệu";
            btnHieu.UseVisualStyleBackColor = true;
            btnHieu.Click += btnHieu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 450);
            Controls.Add(btnHieu);
            Controls.Add(btnTich);
            Controls.Add(btnThuong);
            Controls.Add(groupBox1);
            Controls.Add(btnTong);
            Controls.Add(txtKetQua);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bài 2.8";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtA;
        private TextBox txtB;
        private Label label3;
        private Label label2;
        private Button btnTong;
        private TextBox txtKetQua;
        private Label label4;
        private Label label1;
        private Button btnThuong;
        private Button btnTich;
        private Button btnHieu;
    }
}
