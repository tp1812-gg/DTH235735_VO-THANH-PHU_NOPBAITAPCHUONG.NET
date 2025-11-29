using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_7._5
{
    public partial class Form1 : Form
    {
        // Các biến dùng để lưu trạng thái vẽ
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing = false;

        private Color borderColor = Color.Blue;
        private Color fillColor = Color.Red;
        private int borderSize = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Các loại hình vẽ
            cboShape.Items.Add("Line");
            cboShape.Items.Add("Rectangle");
            cboShape.Items.Add("Ellipse");
            cboShape.Items.Add("Filled Rectangle");
            cboShape.Items.Add("Filled Ellipse");
            cboShape.SelectedIndex = 0;

            numSize.Minimum = 1;
            numSize.Maximum = 10;
            numSize.Value = 2;

            panelDraw.BackColor = Color.White;
        }

        private void btnBorderColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                borderColor = colorDialog1.Color;
                btnBorderColor.BackColor = borderColor;
            }
        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                fillColor = colorDialog1.Color;
                btnFillColor.BackColor = fillColor;
            }
        }
        private void numSize_ValueChanged(object sender, EventArgs e)
        {
            borderSize = (int)numSize.Value;
        }
        // --- Sự kiện chuột ---
        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                isDrawing = false;

                using (Graphics g = panelDraw.CreateGraphics())
                {
                    Pen pen = new Pen(borderColor, borderSize);
                    SolidBrush brush = new SolidBrush(fillColor);

                    Rectangle rect = new Rectangle(
                        Math.Min(startPoint.X, endPoint.X),
                        Math.Min(startPoint.Y, endPoint.Y),
                        Math.Abs(startPoint.X - endPoint.X),
                        Math.Abs(startPoint.Y - endPoint.Y)
                    );

                    switch (cboShape.Text)
                    {
                        case "Line":
                            g.DrawLine(pen, startPoint, endPoint);
                            break;
                        case "Rectangle":
                            g.DrawRectangle(pen, rect);
                            break;
                        case "Ellipse":
                            g.DrawEllipse(pen, rect);
                            break;
                        case "Filled Rectangle":
                            g.FillRectangle(brush, rect);
                            g.DrawRectangle(pen, rect);
                            break;
                        case "Filled Ellipse":
                            g.FillEllipse(brush, rect);
                            g.DrawEllipse(pen, rect);
                            break;
                    }
                }
            }
        }
    }
}
