namespace Bài_4_3
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
            txtS = new TextBox();
            txtN = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnTinh = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtS);
            groupBox1.Controls.Add(txtN);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 9F);
            groupBox1.Location = new Point(244, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 201);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // txtS
            // 
            txtS.Location = new Point(129, 127);
            txtS.Name = "txtS";
            txtS.Size = new Size(125, 25);
            txtS.TabIndex = 4;
            // 
            // txtN
            // 
            txtN.Location = new Point(129, 59);
            txtN.Name = "txtN";
            txtN.Size = new Size(125, 25);
            txtN.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 134);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 1;
            label3.Text = "Kết quả s:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 66);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 0;
            label2.Text = "Nhập n:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(345, 83);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 6;
            label1.Text = "Cấu Trúc Lặp";
            // 
            // btnTinh
            // 
            btnTinh.Font = new Font("Times New Roman", 9F);
            btnTinh.Location = new Point(364, 338);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(94, 29);
            btnTinh.TabIndex = 8;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnTinh);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtS;
        private TextBox txtN;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnTinh;
    }
}
