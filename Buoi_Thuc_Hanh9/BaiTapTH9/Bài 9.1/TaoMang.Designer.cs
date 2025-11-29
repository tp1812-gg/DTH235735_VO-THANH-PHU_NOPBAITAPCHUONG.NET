namespace Bài_9._1
{
    partial class TaoMang
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
            this.lblMang = new System.Windows.Forms.Label();
            this.lblChan = new System.Windows.Forms.Label();
            this.txtChan = new System.Windows.Forms.TextBox();
            this.txtMang = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMang
            // 
            this.lblMang.AutoSize = true;
            this.lblMang.Location = new System.Drawing.Point(389, 56);
            this.lblMang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMang.Name = "lblMang";
            this.lblMang.Size = new System.Drawing.Size(169, 19);
            this.lblMang.TabIndex = 0;
            this.lblMang.Text = "Các phần tử của mảng";
            // 
            // lblChan
            // 
            this.lblChan.AutoSize = true;
            this.lblChan.Location = new System.Drawing.Point(374, 152);
            this.lblChan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChan.Name = "lblChan";
            this.lblChan.Size = new System.Drawing.Size(184, 19);
            this.lblChan.TabIndex = 1;
            this.lblChan.Text = "Các số chẵn trong mảng";
            // 
            // txtChan
            // 
            this.txtChan.Location = new System.Drawing.Point(320, 189);
            this.txtChan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChan.Name = "txtChan";
            this.txtChan.ReadOnly = true;
            this.txtChan.Size = new System.Drawing.Size(289, 27);
            this.txtChan.TabIndex = 2;
            // 
            // txtMang
            // 
            this.txtMang.Location = new System.Drawing.Point(270, 90);
            this.txtMang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMang.Multiline = true;
            this.txtMang.Name = "txtMang";
            this.txtMang.ReadOnly = true;
            this.txtMang.Size = new System.Drawing.Size(386, 42);
            this.txtMang.TabIndex = 3;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(409, 258);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(94, 27);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // TaoMang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 534);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.txtMang);
            this.Controls.Add(this.txtChan);
            this.Controls.Add(this.lblChan);
            this.Controls.Add(this.lblMang);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TaoMang";
            this.Text = "Tạo mảng";
            this.Load += new System.EventHandler(this.TaoMang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMang;
        private System.Windows.Forms.Label lblChan;
        private System.Windows.Forms.TextBox txtChan;
        private System.Windows.Forms.TextBox txtMang;
        private System.Windows.Forms.Button btnDong;
    }
}