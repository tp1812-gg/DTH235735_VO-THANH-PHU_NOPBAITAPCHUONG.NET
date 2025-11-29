namespace Bài_2._7
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
            label4 = new Label();
            txtKetQua = new TextBox();
            txtB = new TextBox();
            txtA = new TextBox();
            btnTong = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(501, 33);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Phép toán";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 58);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 2;
            label3.Text = "Nhập a:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F);
            label4.Location = new Point(459, 300);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 3;
            label4.Text = "Kết quả: ";
            // 
            // txtKetQua
            // 
            txtKetQua.Font = new Font("Times New Roman", 9F);
            txtKetQua.Location = new Point(554, 293);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(125, 25);
            txtKetQua.TabIndex = 4;
            // 
            // txtB
            // 
            txtB.Location = new Point(194, 137);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 25);
            txtB.TabIndex = 5;
            // 
            // txtA
            // 
            txtA.Location = new Point(194, 51);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 25);
            txtA.TabIndex = 6;
            // 
            // btnTong
            // 
            btnTong.Font = new Font("Times New Roman", 9F);
            btnTong.Location = new Point(501, 364);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(94, 29);
            btnTong.TabIndex = 7;
            btnTong.Text = "Tổng";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 9F);
            groupBox1.Location = new Point(360, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 192);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnTong);
            Controls.Add(txtKetQua);
            Controls.Add(label4);
            Controls.Add(label1);
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
        private Label label4;
        private TextBox txtKetQua;
        private TextBox txtB;
        private TextBox txtA;
        private Button btnTong;
        private GroupBox groupBox1;
    }
}
