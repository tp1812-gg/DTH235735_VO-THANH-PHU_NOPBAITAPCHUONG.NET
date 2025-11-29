namespace Bai_2
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
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(275, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Số Phân Tử Mảng: ";
            // 
            // txtKQ
            // 
            this.txtKQ.BackColor = System.Drawing.Color.PeachPuff;
            this.txtKQ.Location = new System.Drawing.Point(279, 141);
            this.txtKQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(568, 99);
            this.txtKQ.TabIndex = 1;
            // 
            // txtNhap
            // 
            this.txtNhap.BackColor = System.Drawing.SystemColors.Info;
            this.txtNhap.Location = new System.Drawing.Point(505, 90);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(105, 30);
            this.txtNhap.TabIndex = 2;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(326, 269);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(103, 32);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In Mảng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(687, 269);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 32);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(637, 88);
            this.btnTao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(210, 32);
            this.btnTao.TabIndex = 5;
            this.btnTao.Text = "Tạo Mảng RANDOM";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(505, 269);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(105, 34);
            this.btnMax.TabIndex = 6;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnMax;
    }
}

