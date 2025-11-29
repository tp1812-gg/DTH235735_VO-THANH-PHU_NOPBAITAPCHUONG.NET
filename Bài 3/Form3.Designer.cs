namespace Bài_3
{
    partial class Form3
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
            this.btnReSet = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cboWeb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnReSet
            // 
            this.btnReSet.Location = new System.Drawing.Point(484, 100);
            this.btnReSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnReSet.Name = "btnReSet";
            this.btnReSet.Size = new System.Drawing.Size(80, 24);
            this.btnReSet.TabIndex = 9;
            this.btnReSet.Text = "Reset";
            this.btnReSet.UseVisualStyleBackColor = true;
            this.btnReSet.Click += new System.EventHandler(this.btnReSet_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(393, 99);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 24);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(187, 132);
            this.txtKQ.Margin = new System.Windows.Forms.Padding(4);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ShortcutsEnabled = false;
            this.txtKQ.Size = new System.Drawing.Size(377, 221);
            this.txtKQ.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(181, 46);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(207, 34);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Liên kết website";
            // 
            // cboWeb
            // 
            this.cboWeb.FormattingEnabled = true;
            this.cboWeb.Items.AddRange(new object[] {
            " Tuổi trẻ",
            " Thanh niên",
            " VNExpress",
            " Dân trí",
            " Công an"});
            this.cboWeb.Location = new System.Drawing.Point(187, 100);
            this.cboWeb.Name = "cboWeb";
            this.cboWeb.Size = new System.Drawing.Size(181, 24);
            this.cboWeb.TabIndex = 10;
            this.cboWeb.Text = "Liên kết website ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboWeb);
            this.Controls.Add(this.btnReSet);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Form3";
            this.Text = "Bài 3.c";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReSet;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cboWeb;
    }
}