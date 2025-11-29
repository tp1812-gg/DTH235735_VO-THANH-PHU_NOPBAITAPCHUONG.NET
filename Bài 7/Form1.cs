using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void GetValues(out double a, out double b)
        {
            double.TryParse(txtA.Text, out a);
            double.TryParse(txtB.Text, out b);
        }

        private void tongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetValues(out double a, out double b);
            txtKQ.Text = (a + b).ToString();
        }

        private void hieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetValues(out double a, out double b);
            txtKQ.Text = (a - b).ToString();
        }

        private void tichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetValues(out double a, out double b);
            txtKQ.Text = (a * b).ToString();
        }

        private void thuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetValues(out double a, out double b);
            if (b != 0)
                txtKQ.Text = (a / b).ToString();
            else
                MessageBox.Show("Không thể chia cho 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
