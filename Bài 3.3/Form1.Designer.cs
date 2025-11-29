namespace Bài_3._3
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
            helpProvider1 = new HelpProvider();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNgay = new TextBox();
            txtThang = new TextBox();
            txtNam = new TextBox();
            btnKiemTra = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNam);
            groupBox1.Controls.Add(txtThang);
            groupBox1.Controls.Add(txtNgay);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 9F);
            groupBox1.Location = new Point(232, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 229);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(238, 38);
            label1.Name = "label1";
            label1.Size = new Size(294, 25);
            label1.TabIndex = 0;
            label1.Text = "KIỂM TRA NGÀY HỢP LỆ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 69);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 1;
            label2.Text = "Ngày: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 124);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 2;
            label3.Text = "Tháng: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 180);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 3;
            label4.Text = "Năm: ";
            // 
            // txtNgay
            // 
            txtNgay.Location = new Point(135, 62);
            txtNgay.Name = "txtNgay";
            txtNgay.Size = new Size(125, 25);
            txtNgay.TabIndex = 4;
            // 
            // txtThang
            // 
            txtThang.Location = new Point(135, 117);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(125, 25);
            txtThang.TabIndex = 5;
            // 
            // txtNam
            // 
            txtNam.Location = new Point(135, 173);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(125, 25);
            txtNam.TabIndex = 6;
            // 
            // btnKiemTra
            // 
            btnKiemTra.Font = new Font("Times New Roman", 9F);
            btnKiemTra.Location = new Point(341, 352);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(94, 29);
            btnKiemTra.TabIndex = 7;
            btnKiemTra.Text = "Kiểm Tra";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKiemTra);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bài 3.3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HelpProvider helpProvider1;
        private GroupBox groupBox1;
        private TextBox txtNam;
        private TextBox txtThang;
        private TextBox txtNgay;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnKiemTra;
    }
}
