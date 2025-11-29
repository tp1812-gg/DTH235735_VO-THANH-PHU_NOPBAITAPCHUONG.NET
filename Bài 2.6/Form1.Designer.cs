namespace Bài_2._6
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txtA = new TextBox();
            txtB = new TextBox();
            btnTong = new Button();
            btnHieu = new Button();
            btnTich = new Button();
            btnThuong = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 131);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 0;
            label1.Text = "Nhập b:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 50);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 1;
            label2.Text = "Nhập a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(541, 38);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 2;
            label3.Text = "Phép toán ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(409, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 219);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // txtA
            // 
            txtA.Location = new Point(132, 50);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 25);
            txtA.TabIndex = 3;
            // 
            // txtB
            // 
            txtB.Location = new Point(132, 131);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 25);
            txtB.TabIndex = 2;
            // 
            // btnTong
            // 
            btnTong.Font = new Font("Times New Roman", 9F);
            btnTong.Location = new Point(311, 341);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(94, 29);
            btnTong.TabIndex = 0;
            btnTong.Text = "Tổng ";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnHieu
            // 
            btnHieu.Font = new Font("Times New Roman", 9F);
            btnHieu.Location = new Point(461, 341);
            btnHieu.Name = "btnHieu";
            btnHieu.Size = new Size(94, 29);
            btnHieu.TabIndex = 1;
            btnHieu.Text = "Hiệu";
            btnHieu.UseVisualStyleBackColor = true;
            btnHieu.Click += btnHieu_Click;
            // 
            // btnTich
            // 
            btnTich.Font = new Font("Times New Roman", 9F);
            btnTich.Location = new Point(620, 341);
            btnTich.Name = "btnTich";
            btnTich.Size = new Size(94, 29);
            btnTich.TabIndex = 2;
            btnTich.Text = "Tích ";
            btnTich.UseVisualStyleBackColor = true;
            btnTich.Click += btnTich_Click;
            // 
            // btnThuong
            // 
            btnThuong.Font = new Font("Times New Roman", 9F);
            btnThuong.Location = new Point(784, 341);
            btnThuong.Name = "btnThuong";
            btnThuong.Size = new Size(94, 29);
            btnThuong.TabIndex = 3;
            btnThuong.Text = "Thương";
            btnThuong.UseVisualStyleBackColor = true;
            btnThuong.Click += btnThuong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 450);
            Controls.Add(btnTong);
            Controls.Add(btnHieu);
            Controls.Add(btnTich);
            Controls.Add(btnThuong);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox txtA;
        private TextBox txtB;
        private Button btnTong;
        private Button btnHieu;
        private Button btnTich;
        private Button btnThuong;
    }
}
