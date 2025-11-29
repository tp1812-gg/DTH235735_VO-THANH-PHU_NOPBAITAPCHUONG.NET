namespace Bài_2._9
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
            txtKetQua = new TextBox();
            label4 = new Label();
            label1 = new Label();
            btnDienTich = new Button();
            btnChuVi = new Button();
            btnDuongCheo = new Button();
            btnThoat = new Button();
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
            groupBox1.Location = new Point(375, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 192);
            groupBox1.TabIndex = 20;
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
            // txtKetQua
            // 
            txtKetQua.Font = new Font("Times New Roman", 9F);
            txtKetQua.Location = new Point(569, 289);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(125, 25);
            txtKetQua.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F);
            label4.Location = new Point(474, 296);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 18;
            label4.Text = "Kết quả: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(516, 29);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 17;
            label1.Text = "Phép toán";
            // 
            // btnDienTich
            // 
            btnDienTich.Location = new Point(438, 352);
            btnDienTich.Name = "btnDienTich";
            btnDienTich.Size = new Size(94, 29);
            btnDienTich.TabIndex = 21;
            btnDienTich.Text = "Diện tích ";
            btnDienTich.UseVisualStyleBackColor = true;
            btnDienTich.Click += btnDienTich_Click;
            // 
            // btnChuVi
            // 
            btnChuVi.Location = new Point(278, 352);
            btnChuVi.Name = "btnChuVi";
            btnChuVi.Size = new Size(94, 29);
            btnChuVi.TabIndex = 22;
            btnChuVi.Text = "Chu vi ";
            btnChuVi.UseVisualStyleBackColor = true;
            btnChuVi.Click += btnChuVi_Click;
            // 
            // btnDuongCheo
            // 
            btnDuongCheo.Location = new Point(600, 352);
            btnDuongCheo.Name = "btnDuongCheo";
            btnDuongCheo.Size = new Size(109, 29);
            btnDuongCheo.TabIndex = 23;
            btnDuongCheo.Text = "Đường chéo ";
            btnDuongCheo.UseVisualStyleBackColor = true;
            btnDuongCheo.Click += btnDuongCheo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(768, 352);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 24;
            btnThoat.Text = "Thoát ";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnDuongCheo);
            Controls.Add(btnChuVi);
            Controls.Add(btnDienTich);
            Controls.Add(groupBox1);
            Controls.Add(txtKetQua);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bài 2.9";
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
        private TextBox txtKetQua;
        private Label label4;
        private Label label1;
        private Button btnDienTich;
        private Button btnChuVi;
        private Button btnDuongCheo;
        private Button btnThoat;
    }
}
