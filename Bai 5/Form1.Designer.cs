namespace Bai_5
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
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoUCLN = new System.Windows.Forms.RadioButton();
            this.rdoBCLN = new System.Windows.Forms.RadioButton();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kết quả là: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập n:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập m:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(316, 311);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(560, 30);
            this.txtKetQua.TabIndex = 3;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(399, 208);
            this.txtM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(69, 30);
            this.txtM.TabIndex = 4;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(399, 129);
            this.txtN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(69, 30);
            this.txtN.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBCLN);
            this.groupBox1.Controls.Add(this.rdoUCLN);
            this.groupBox1.Location = new System.Drawing.Point(484, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(393, 224);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn ";
            // 
            // rdoUCLN
            // 
            this.rdoUCLN.AutoSize = true;
            this.rdoUCLN.Location = new System.Drawing.Point(43, 56);
            this.rdoUCLN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoUCLN.Name = "rdoUCLN";
            this.rdoUCLN.Size = new System.Drawing.Size(265, 26);
            this.rdoUCLN.TabIndex = 0;
            this.rdoUCLN.TabStop = true;
            this.rdoUCLN.Text = "Các ước số chung của n và m ";
            this.rdoUCLN.UseVisualStyleBackColor = true;
            // 
            // rdoBCLN
            // 
            this.rdoBCLN.AutoSize = true;
            this.rdoBCLN.Location = new System.Drawing.Point(43, 142);
            this.rdoBCLN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoBCLN.Name = "rdoBCLN";
            this.rdoBCLN.Size = new System.Drawing.Size(297, 26);
            this.rdoBCLN.TabIndex = 1;
            this.rdoBCLN.TabStop = true;
            this.rdoBCLN.Text = "Ước số chung lớn nhất của m và n";
            this.rdoBCLN.UseVisualStyleBackColor = true;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(316, 362);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(118, 51);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(543, 362);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 51);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(770, 362);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 51);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Lệnh lặp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.RadioButton rdoBCLN;
        private System.Windows.Forms.RadioButton rdoUCLN;
    }
}

