namespace Bài_3._1
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
            txtX = new TextBox();
            txtF = new TextBox();
            btnTinh = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F);
            label1.Location = new Point(247, 280);
            label1.Name = "label1";
            label1.Size = new Size(28, 17);
            label1.TabIndex = 0;
            label1.Text = "F =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F);
            label2.Location = new Point(247, 209);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 1;
            label2.Text = "X = ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(247, 133);
            label3.Name = "label3";
            label3.Size = new Size(200, 25);
            label3.TabIndex = 2;
            label3.Text = "Tính giá trị hàm số";
            // 
            // txtX
            // 
            txtX.Font = new Font("Times New Roman", 9F);
            txtX.Location = new Point(286, 201);
            txtX.Name = "txtX";
            txtX.Size = new Size(125, 25);
            txtX.TabIndex = 3;
            // 
            // txtF
            // 
            txtF.Font = new Font("Times New Roman", 9F);
            txtF.Location = new Point(286, 272);
            txtF.Name = "txtF";
            txtF.Size = new Size(125, 25);
            txtF.TabIndex = 4;
            // 
            // btnTinh
            // 
            btnTinh.Font = new Font("Times New Roman", 9F);
            btnTinh.Location = new Point(300, 329);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(94, 29);
            btnTinh.TabIndex = 5;
            btnTinh.Text = "Tính ";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 450);
            Controls.Add(btnTinh);
            Controls.Add(txtF);
            Controls.Add(txtX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bài 3.1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtX;
        private TextBox txtF;
        private Button btnTinh;
    }
}
