namespace Bài_8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbKQ = new System.Windows.Forms.ComboBox();
            this.btnChao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(379, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên: ";
            // 
            // cbKQ
            // 
            this.cbKQ.FormattingEnabled = true;
            this.cbKQ.Items.AddRange(new object[] {
            "Trần Duy Khánh ",
            "Đỗ Thanh Vy",
            "Trần Thị Huyền Trân  "});
            this.cbKQ.Location = new System.Drawing.Point(498, 195);
            this.cbKQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKQ.Name = "cbKQ";
            this.cbKQ.Size = new System.Drawing.Size(268, 30);
            this.cbKQ.TabIndex = 1;
            // 
            // btnChao
            // 
            this.btnChao.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChao.Location = new System.Drawing.Point(483, 281);
            this.btnChao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChao.Name = "btnChao";
            this.btnChao.Size = new System.Drawing.Size(220, 57);
            this.btnChao.TabIndex = 2;
            this.btnChao.Text = "Hiện Lời Chào";
            this.btnChao.UseVisualStyleBackColor = true;
            this.btnChao.Click += new System.EventHandler(this.btnChao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.btnChao);
            this.Controls.Add(this.cbKQ);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Bài 8";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKQ;
        private System.Windows.Forms.Button btnChao;
    }
}

