namespace Bài_6._2
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.grpLop = new System.Windows.Forms.GroupBox();
            this.radLopA = new System.Windows.Forms.RadioButton();
            this.radLopB = new System.Windows.Forms.RadioButton();
            this.groubda = new System.Windows.Forms.GroupBox();
            this.groundb = new System.Windows.Forms.GroupBox();
            this.btnTongSV = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnAllSangA = new System.Windows.Forms.Button();
            this.btnAllSangB = new System.Windows.Forms.Button();
            this.btnSangA = new System.Windows.Forms.Button();
            this.btnSangB = new System.Windows.Forms.Button();
            this.lstLopA = new System.Windows.Forms.ListBox();
            this.lstLopB = new System.Windows.Forms.ListBox();
            this.grpLop.SuspendLayout();
            this.groubda.SuspendLayout();
            this.groundb.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(50, 17);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(49, 15);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên: ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(125, 10);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(325, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(488, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 27);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grpLop
            // 
            this.grpLop.Controls.Add(this.radLopB);
            this.grpLop.Controls.Add(this.radLopA);
            this.grpLop.Location = new System.Drawing.Point(181, 56);
            this.grpLop.Name = "grpLop";
            this.grpLop.Size = new System.Drawing.Size(233, 49);
            this.grpLop.TabIndex = 3;
            this.grpLop.TabStop = false;
            this.grpLop.Text = "Chọn lớp ";
            // 
            // radLopA
            // 
            this.radLopA.AutoSize = true;
            this.radLopA.Location = new System.Drawing.Point(27, 21);
            this.radLopA.Name = "radLopA";
            this.radLopA.Size = new System.Drawing.Size(57, 19);
            this.radLopA.TabIndex = 0;
            this.radLopA.TabStop = true;
            this.radLopA.Text = "Lớp A";
            this.radLopA.UseVisualStyleBackColor = true;
            // 
            // radLopB
            // 
            this.radLopB.AutoSize = true;
            this.radLopB.Location = new System.Drawing.Point(141, 21);
            this.radLopB.Name = "radLopB";
            this.radLopB.Size = new System.Drawing.Size(58, 19);
            this.radLopB.TabIndex = 1;
            this.radLopB.TabStop = true;
            this.radLopB.Text = "Lớp B";
            this.radLopB.UseVisualStyleBackColor = true;
            // 
            // groubda
            // 
            this.groubda.Controls.Add(this.lstLopA);
            this.groubda.Location = new System.Drawing.Point(12, 142);
            this.groubda.Name = "groubda";
            this.groubda.Size = new System.Drawing.Size(210, 198);
            this.groubda.TabIndex = 4;
            this.groubda.TabStop = false;
            this.groubda.Text = "Lớp A";
            // 
            // groundb
            // 
            this.groundb.Controls.Add(this.lstLopB);
            this.groundb.Location = new System.Drawing.Point(394, 142);
            this.groundb.Name = "groundb";
            this.groundb.Size = new System.Drawing.Size(233, 198);
            this.groundb.TabIndex = 0;
            this.groundb.TabStop = false;
            this.groundb.Text = "LỚp B";
            // 
            // btnTongSV
            // 
            this.btnTongSV.Location = new System.Drawing.Point(39, 369);
            this.btnTongSV.Name = "btnTongSV";
            this.btnTongSV.Size = new System.Drawing.Size(156, 27);
            this.btnTongSV.TabIndex = 5;
            this.btnTongSV.Text = "Tổng số sinh viên ";
            this.btnTongSV.UseVisualStyleBackColor = true;
            this.btnTongSV.Click += new System.EventHandler(this.btnTongSV_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(474, 369);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 27);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnAllSangA
            // 
            this.btnAllSangA.Location = new System.Drawing.Point(277, 313);
            this.btnAllSangA.Name = "btnAllSangA";
            this.btnAllSangA.Size = new System.Drawing.Size(87, 27);
            this.btnAllSangA.TabIndex = 7;
            this.btnAllSangA.Text = "<<";
            this.btnAllSangA.UseVisualStyleBackColor = true;
            this.btnAllSangA.Click += new System.EventHandler(this.btnAllSangA_Click);
            // 
            // btnAllSangB
            // 
            this.btnAllSangB.Location = new System.Drawing.Point(277, 257);
            this.btnAllSangB.Name = "btnAllSangB";
            this.btnAllSangB.Size = new System.Drawing.Size(87, 27);
            this.btnAllSangB.TabIndex = 8;
            this.btnAllSangB.Text = ">>";
            this.btnAllSangB.UseVisualStyleBackColor = true;
            this.btnAllSangB.Click += new System.EventHandler(this.btnAllSangB_Click);
            // 
            // btnSangA
            // 
            this.btnSangA.Location = new System.Drawing.Point(277, 205);
            this.btnSangA.Name = "btnSangA";
            this.btnSangA.Size = new System.Drawing.Size(87, 27);
            this.btnSangA.TabIndex = 9;
            this.btnSangA.Text = "<";
            this.btnSangA.UseVisualStyleBackColor = true;
            this.btnSangA.Click += new System.EventHandler(this.btnSangA_Click);
            // 
            // btnSangB
            // 
            this.btnSangB.Location = new System.Drawing.Point(277, 155);
            this.btnSangB.Name = "btnSangB";
            this.btnSangB.Size = new System.Drawing.Size(87, 27);
            this.btnSangB.TabIndex = 10;
            this.btnSangB.Text = ">";
            this.btnSangB.UseVisualStyleBackColor = true;
            this.btnSangB.Click += new System.EventHandler(this.btnSangB_Click);
            // 
            // lstLopA
            // 
            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.ItemHeight = 15;
            this.lstLopA.Items.AddRange(new object[] {
            "Trần Duy Khánh ",
            "Huỳnh Phú Lợi "});
            this.lstLopA.Location = new System.Drawing.Point(18, 24);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.Size = new System.Drawing.Size(177, 154);
            this.lstLopA.TabIndex = 0;
            // 
            // lstLopB
            // 
            this.lstLopB.FormattingEnabled = true;
            this.lstLopB.ItemHeight = 15;
            this.lstLopB.Items.AddRange(new object[] {
            "Lý Bá Phú ",
            "Phan Nguyễn Khôi Nguyên "});
            this.lstLopB.Location = new System.Drawing.Point(19, 24);
            this.lstLopB.Name = "lstLopB";
            this.lstLopB.Size = new System.Drawing.Size(201, 154);
            this.lstLopB.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 498);
            this.Controls.Add(this.btnSangB);
            this.Controls.Add(this.btnSangA);
            this.Controls.Add(this.btnAllSangB);
            this.Controls.Add(this.btnAllSangA);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTongSV);
            this.Controls.Add(this.groundb);
            this.Controls.Add(this.groubda);
            this.Controls.Add(this.grpLop);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Danh sách sinh viên ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLop.ResumeLayout(false);
            this.grpLop.PerformLayout();
            this.groubda.ResumeLayout(false);
            this.groundb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grpLop;
        private System.Windows.Forms.RadioButton radLopB;
        private System.Windows.Forms.RadioButton radLopA;
        private System.Windows.Forms.GroupBox groubda;
        private System.Windows.Forms.GroupBox groundb;
        private System.Windows.Forms.Button btnTongSV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnAllSangA;
        private System.Windows.Forms.Button btnAllSangB;
        private System.Windows.Forms.Button btnSangA;
        private System.Windows.Forms.Button btnSangB;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.ListBox lstLopB;
    }
}

