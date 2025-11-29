namespace Bài_2._10
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
            btnThoat = new Button();
            btnDuongCheo = new Button();
            btnChuVi = new Button();
            btnDienTich = new Button();
            groupBox1 = new GroupBox();
            txtA = new TextBox();
            txtB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(598, 335);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 32;
            btnThoat.Text = "Thoát ";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDuongCheo
            // 
            btnDuongCheo.Location = new Point(430, 335);
            btnDuongCheo.Name = "btnDuongCheo";
            btnDuongCheo.Size = new Size(109, 29);
            btnDuongCheo.TabIndex = 31;
            btnDuongCheo.Text = "Đường chéo ";
            btnDuongCheo.UseVisualStyleBackColor = true;
            btnDuongCheo.Click += btnDuongCheo_Click;
            // 
            // btnChuVi
            // 
            btnChuVi.Location = new Point(108, 335);
            btnChuVi.Name = "btnChuVi";
            btnChuVi.Size = new Size(94, 29);
            btnChuVi.TabIndex = 30;
            btnChuVi.Text = "Chu vi ";
            btnChuVi.UseVisualStyleBackColor = true;
            btnChuVi.Click += btnChuVi_Click;
            // 
            // btnDienTich
            // 
            btnDienTich.Location = new Point(268, 335);
            btnDienTich.Name = "btnDienTich";
            btnDienTich.Size = new Size(94, 29);
            btnDienTich.TabIndex = 29;
            btnDienTich.Text = "Diện tích ";
            btnDienTich.UseVisualStyleBackColor = true;
            btnDienTich.Click += btnDienTich_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 9F);
            groupBox1.Location = new Point(205, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 192);
            groupBox1.TabIndex = 28;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(346, 49);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 25;
            label1.Text = "Phép toán";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnDuongCheo);
            Controls.Add(btnChuVi);
            Controls.Add(btnDienTich);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bài 2.10";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Button btnDuongCheo;
        private Button btnChuVi;
        private Button btnDienTich;
        private GroupBox groupBox1;
        private TextBox txtA;
        private TextBox txtB;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
