namespace Bai_5._5
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
            this.btnXuatMang = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnGiamDan = new System.Windows.Forms.Button();
            this.btnDemLe = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnTangDan = new System.Windows.Forms.Button();
            this.btnTongLe = new System.Windows.Forms.Button();
            this.btnTongMang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtMang = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXuatMang
            // 
            this.btnXuatMang.Location = new System.Drawing.Point(99, 257);
            this.btnXuatMang.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatMang.Name = "btnXuatMang";
            this.btnXuatMang.Size = new System.Drawing.Size(474, 58);
            this.btnXuatMang.TabIndex = 0;
            this.btnXuatMang.Text = "Xuất mảng ngẫu nhiên";
            this.btnXuatMang.UseVisualStyleBackColor = true;
            this.btnXuatMang.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(624, 257);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(474, 58);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "Tìm phân tử nhỏ nhất ";
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // btnGiamDan
            // 
            this.btnGiamDan.Location = new System.Drawing.Point(624, 497);
            this.btnGiamDan.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiamDan.Name = "btnGiamDan";
            this.btnGiamDan.Size = new System.Drawing.Size(474, 58);
            this.btnGiamDan.TabIndex = 2;
            this.btnGiamDan.Text = "Sắp mảng giảm";
            this.btnGiamDan.UseVisualStyleBackColor = true;
            // 
            // btnDemLe
            // 
            this.btnDemLe.Location = new System.Drawing.Point(99, 420);
            this.btnDemLe.Margin = new System.Windows.Forms.Padding(4);
            this.btnDemLe.Name = "btnDemLe";
            this.btnDemLe.Size = new System.Drawing.Size(474, 55);
            this.btnDemLe.TabIndex = 3;
            this.btnDemLe.Text = "Đếm số phân tử lẻ";
            this.btnDemLe.UseVisualStyleBackColor = true;
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(624, 339);
            this.btnTang2.Margin = new System.Windows.Forms.Padding(4);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(474, 58);
            this.btnTang2.TabIndex = 4;
            this.btnTang2.Text = "Tăng mõi phân tử mảng lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            // 
            // btnTangDan
            // 
            this.btnTangDan.Location = new System.Drawing.Point(624, 417);
            this.btnTangDan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTangDan.Name = "btnTangDan";
            this.btnTangDan.Size = new System.Drawing.Size(474, 58);
            this.btnTangDan.TabIndex = 5;
            this.btnTangDan.Text = "Sắp mảng tăng ";
            this.btnTangDan.UseVisualStyleBackColor = true;
            // 
            // btnTongLe
            // 
            this.btnTongLe.Location = new System.Drawing.Point(99, 497);
            this.btnTongLe.Margin = new System.Windows.Forms.Padding(4);
            this.btnTongLe.Name = "btnTongLe";
            this.btnTongLe.Size = new System.Drawing.Size(474, 58);
            this.btnTongLe.TabIndex = 6;
            this.btnTongLe.Text = "Tổng giá trị phân tử lẻ ";
            this.btnTongLe.UseVisualStyleBackColor = true;
            // 
            // btnTongMang
            // 
            this.btnTongMang.Location = new System.Drawing.Point(99, 339);
            this.btnTongMang.Margin = new System.Windows.Forms.Padding(4);
            this.btnTongMang.Name = "btnTongMang";
            this.btnTongMang.Size = new System.Drawing.Size(474, 58);
            this.btnTongMang.TabIndex = 7;
            this.btnTongMang.Text = "Tính tổng giá trị mảng ";
            this.btnTongMang.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKetQua);
            this.groupBox1.Location = new System.Drawing.Point(99, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(999, 85);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMang);
            this.groupBox2.Location = new System.Drawing.Point(99, 73);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(999, 79);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mảng gốc";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(48, 30);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(4);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(904, 30);
            this.txtKetQua.TabIndex = 10;
            // 
            // txtMang
            // 
            this.txtMang.Location = new System.Drawing.Point(48, 30);
            this.txtMang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMang.Name = "txtMang";
            this.txtMang.Size = new System.Drawing.Size(904, 30);
            this.txtMang.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 647);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDemLe);
            this.Controls.Add(this.btnGiamDan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTongMang);
            this.Controls.Add(this.btnTongLe);
            this.Controls.Add(this.btnTangDan);
            this.Controls.Add(this.btnTang2);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnXuatMang);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXuatMang;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnGiamDan;
        private System.Windows.Forms.Button btnDemLe;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnTangDan;
        private System.Windows.Forms.Button btnTongLe;
        private System.Windows.Forms.Button btnTongMang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtMang;
    }
}

