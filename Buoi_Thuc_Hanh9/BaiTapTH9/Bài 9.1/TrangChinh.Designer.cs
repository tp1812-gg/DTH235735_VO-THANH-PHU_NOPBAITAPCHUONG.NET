namespace Bài_9._1
{
    partial class TrangChinh
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblNhapN = new System.Windows.Forms.Label();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMoForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKiemTra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaoMang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(556, 302);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 27);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(381, 302);
            this.btnLamLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(94, 27);
            this.btnLamLai.TabIndex = 16;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Location = new System.Drawing.Point(591, 220);
            this.btnTaoMang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(94, 27);
            this.btnTaoMang.TabIndex = 15;
            this.btnTaoMang.Text = "Tạo mảng";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(335, 220);
            this.btnKiemTra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(211, 27);
            this.btnKiemTra.TabIndex = 14;
            this.btnKiemTra.Text = "Kiểm tra số hoàn hảo ";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(459, 132);
            this.txtN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(226, 27);
            this.txtN.TabIndex = 13;
            // 
            // lblNhapN
            // 
            this.lblNhapN.AutoSize = true;
            this.lblNhapN.Location = new System.Drawing.Point(351, 140);
            this.lblNhapN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapN.Name = "lblNhapN";
            this.lblNhapN.Size = new System.Drawing.Size(89, 19);
            this.lblNhapN.TabIndex = 12;
            this.lblNhapN.Text = "Nhập số N:";
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMoForm,
            this.mnuThoat});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(1000, 28);
            this.menuMain.TabIndex = 18;
            this.menuMain.Text = "menuStrip1";
            // 
            // mnuMoForm
            // 
            this.mnuMoForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKiemTra,
            this.mnuTaoMang});
            this.mnuMoForm.Name = "mnuMoForm";
            this.mnuMoForm.Size = new System.Drawing.Size(83, 24);
            this.mnuMoForm.Text = "Mở Form";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(61, 24);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuKiemTra
            // 
            this.mnuKiemTra.Name = "mnuKiemTra";
            this.mnuKiemTra.Size = new System.Drawing.Size(233, 26);
            this.mnuKiemTra.Text = "Kiểm tra số hoàn hảo";
            this.mnuKiemTra.Click += new System.EventHandler(this.mnuKiemTra_Click);
            // 
            // mnuTaoMang
            // 
            this.mnuTaoMang.Name = "mnuTaoMang";
            this.mnuTaoMang.Size = new System.Drawing.Size(233, 26);
            this.mnuTaoMang.Text = "Tạo mảng";
            this.mnuTaoMang.Click += new System.EventHandler(this.mnuTaoMang_Click);
            // 
            // TrangChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 534);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblNhapN);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TrangChinh";
            this.Text = "Trang chính ";
            this.Load += new System.EventHandler(this.TrangChinh_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnTaoMang;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblNhapN;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMoForm;
        private System.Windows.Forms.ToolStripMenuItem mnuKiemTra;
        private System.Windows.Forms.ToolStripMenuItem mnuTaoMang;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
    }
}

