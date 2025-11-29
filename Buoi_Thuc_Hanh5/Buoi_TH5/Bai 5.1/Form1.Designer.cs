namespace Bai_5._1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txtKT = new System.Windows.Forms.TextBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(385, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiểm tra và tìm số nguyên tố";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập N:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kiểm tra SNT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tìm SNT nhỏ nhất N:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(457, 157);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(348, 30);
            this.txtNhap.TabIndex = 4;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // txtKT
            // 
            this.txtKT.Location = new System.Drawing.Point(457, 223);
            this.txtKT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKT.Name = "txtKT";
            this.txtKT.Size = new System.Drawing.Size(348, 30);
            this.txtKT.TabIndex = 5;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(457, 296);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(348, 30);
            this.txtTim.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(635, 374);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 33);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(409, 374);
            this.btnLamLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(112, 33);
            this.btnLamLai.TabIndex = 8;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 647);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.txtKT);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Kiểm Tra Số Nguyên Tố";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtKT;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamLai;
    }
}

