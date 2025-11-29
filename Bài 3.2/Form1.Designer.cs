namespace Bài_3._2
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
            btnThongBao = new Button();
            txtThang = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F);
            label1.Location = new Point(276, 206);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 0;
            label1.Text = "Tháng: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(264, 115);
            label2.Name = "label2";
            label2.Size = new Size(220, 25);
            label2.TabIndex = 1;
            label2.Text = "MÙA TRONG NĂM";
            // 
            // btnThongBao
            // 
            btnThongBao.Font = new Font("Times New Roman", 9F);
            btnThongBao.Location = new Point(334, 262);
            btnThongBao.Name = "btnThongBao";
            btnThongBao.Size = new Size(94, 29);
            btnThongBao.TabIndex = 2;
            btnThongBao.Text = "Thông báo ";
            btnThongBao.UseVisualStyleBackColor = true;
            btnThongBao.Click += btnThongBao_Click;
            // 
            // txtThang
            // 
            txtThang.Font = new Font("Times New Roman", 9F);
            txtThang.Location = new Point(344, 198);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(125, 25);
            txtThang.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtThang);
            Controls.Add(btnThongBao);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bài 3.2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnThongBao;
        private TextBox txtThang;
    }
}
