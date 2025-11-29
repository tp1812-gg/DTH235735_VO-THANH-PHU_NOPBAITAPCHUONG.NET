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
            this.lblCanh = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblDai = new System.Windows.Forms.Label();
            this.lblRong = new System.Windows.Forms.Label();
            this.lblBanKinh = new System.Windows.Forms.Label();
            this.txtBankinh = new System.Windows.Forms.TextBox();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.txtCanh = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtDai = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCanh
            // 
            this.lblCanh.AutoSize = true;
            this.lblCanh.Location = new System.Drawing.Point(507, 162);
            this.lblCanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCanh.Name = "lblCanh";
            this.lblCanh.Size = new System.Drawing.Size(53, 19);
            this.lblCanh.TabIndex = 0;
            this.lblCanh.Text = "Cạnh:";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.Location = new System.Drawing.Point(352, 60);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(298, 32);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Tính diện tích và chu vi";
            // 
            // lblDai
            // 
            this.lblDai.AutoSize = true;
            this.lblDai.Location = new System.Drawing.Point(672, 210);
            this.lblDai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDai.Name = "lblDai";
            this.lblDai.Size = new System.Drawing.Size(41, 19);
            this.lblDai.TabIndex = 3;
            this.lblDai.Text = "Dài:";
            // 
            // lblRong
            // 
            this.lblRong.AutoSize = true;
            this.lblRong.Location = new System.Drawing.Point(522, 210);
            this.lblRong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRong.Name = "lblRong";
            this.lblRong.Size = new System.Drawing.Size(54, 19);
            this.lblRong.TabIndex = 4;
            this.lblRong.Text = "Rộng:";
            // 
            // lblBanKinh
            // 
            this.lblBanKinh.AutoSize = true;
            this.lblBanKinh.Location = new System.Drawing.Point(486, 256);
            this.lblBanKinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBanKinh.Name = "lblBanKinh";
            this.lblBanKinh.Size = new System.Drawing.Size(101, 19);
            this.lblBanKinh.TabIndex = 5;
            this.lblBanKinh.Text = "Bán kính R: ";
            // 
            // txtBankinh
            // 
            this.txtBankinh.Enabled = false;
            this.txtBankinh.Location = new System.Drawing.Point(585, 248);
            this.txtBankinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtBankinh.Name = "txtBankinh";
            this.txtBankinh.Size = new System.Drawing.Size(206, 27);
            this.txtBankinh.TabIndex = 6;
            // 
            // txtRong
            // 
            this.txtRong.Enabled = false;
            this.txtRong.Location = new System.Drawing.Point(584, 202);
            this.txtRong.Margin = new System.Windows.Forms.Padding(4);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(58, 27);
            this.txtRong.TabIndex = 7;
            // 
            // txtCanh
            // 
            this.txtCanh.Location = new System.Drawing.Point(585, 154);
            this.txtCanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtCanh.Name = "txtCanh";
            this.txtCanh.Size = new System.Drawing.Size(206, 27);
            this.txtCanh.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Location = new System.Drawing.Point(168, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(265, 144);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.ForeColor = System.Drawing.Color.Blue;
            this.rb3.Location = new System.Drawing.Point(78, 90);
            this.rb3.Margin = new System.Windows.Forms.Padding(4);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(107, 23);
            this.rb3.TabIndex = 2;
            this.rb3.Text = "Hình tròn ";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.ForeColor = System.Drawing.Color.Blue;
            this.rb2.Location = new System.Drawing.Point(78, 59);
            this.rb2.Margin = new System.Windows.Forms.Padding(4);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(138, 23);
            this.rb2.TabIndex = 1;
            this.rb2.Text = "Hình chữ nhật ";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.ForeColor = System.Drawing.Color.Blue;
            this.rb1.Location = new System.Drawing.Point(78, 28);
            this.rb1.Margin = new System.Windows.Forms.Padding(4);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(119, 23);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Hình vuông ";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(303, 352);
            this.btnThucHien.Margin = new System.Windows.Forms.Padding(4);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(94, 27);
            this.btnThucHien.TabIndex = 3;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(548, 352);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 27);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtDai
            // 
            this.txtDai.Enabled = false;
            this.txtDai.Location = new System.Drawing.Point(720, 202);
            this.txtDai.Name = "txtDai";
            this.txtDai.Size = new System.Drawing.Size(71, 27);
            this.txtDai.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 534);
            this.Controls.Add(this.txtDai);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCanh);
            this.Controls.Add(this.txtRong);
            this.Controls.Add(this.txtBankinh);
            this.Controls.Add(this.lblBanKinh);
            this.Controls.Add(this.lblRong);
            this.Controls.Add(this.lblDai);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblCanh);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bài tập – Hình học cơ bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCanh;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblDai;
        private System.Windows.Forms.Label lblRong;
        private System.Windows.Forms.Label lblBanKinh;
        private System.Windows.Forms.TextBox txtBankinh;
        private System.Windows.Forms.TextBox txtRong;
        private System.Windows.Forms.TextBox txtCanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtDai;
    }
}

