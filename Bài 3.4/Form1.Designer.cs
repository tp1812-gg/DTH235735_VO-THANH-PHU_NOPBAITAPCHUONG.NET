namespace Bài_3._4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            btnGiai = new Button();
            label5 = new Label();
            txtKetQua = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtKetQua);
            groupBox1.Controls.Add(txtC);
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 9F);
            groupBox1.Location = new Point(203, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 257);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 44);
            label1.Name = "label1";
            label1.Size = new Size(22, 17);
            label1.TabIndex = 0;
            label1.Text = "a: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 85);
            label2.Name = "label2";
            label2.Size = new Size(18, 17);
            label2.TabIndex = 1;
            label2.Text = "b:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 133);
            label3.Name = "label3";
            label3.Size = new Size(18, 17);
            label3.TabIndex = 2;
            label3.Text = "c:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(207, 37);
            label4.Name = "label4";
            label4.Size = new Size(360, 25);
            label4.TabIndex = 3;
            label4.Text = "GIẢI PHƯƠNG TRÌNH BẬC HAI";
            // 
            // txtA
            // 
            txtA.Location = new Point(141, 37);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 25);
            txtA.TabIndex = 4;
            // 
            // txtB
            // 
            txtB.Location = new Point(141, 82);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 25);
            txtB.TabIndex = 5;
            // 
            // txtC
            // 
            txtC.Location = new Point(141, 126);
            txtC.Name = "txtC";
            txtC.Size = new Size(125, 25);
            txtC.TabIndex = 6;
            // 
            // btnGiai
            // 
            btnGiai.Font = new Font("Times New Roman", 9F);
            btnGiai.Location = new Point(337, 381);
            btnGiai.Name = "btnGiai";
            btnGiai.Size = new Size(94, 29);
            btnGiai.TabIndex = 7;
            btnGiai.Text = "Giải";
            btnGiai.UseVisualStyleBackColor = true;
            btnGiai.Click += btnGiai_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 202);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 8;
            label5.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(169, 195);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(125, 25);
            txtKetQua.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGiai);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtC;
        private TextBox txtB;
        private TextBox txtA;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button btnGiai;
        private Label label5;
        private TextBox txtKetQua;
    }
}
