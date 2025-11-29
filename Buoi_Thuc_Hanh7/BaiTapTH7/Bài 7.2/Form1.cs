using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Khi mở rộng node -> load thư mục con
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string path = e.Node.Tag.ToString();

            try
            {
                foreach (string dir in Directory.GetDirectories(path))
                {
                    TreeNode sub = new TreeNode(Path.GetFileName(dir));
                    sub.Tag = dir;
                    sub.Nodes.Add("...");
                    e.Node.Nodes.Add(sub);
                }
            }
            catch { }
        }

        // Khi chọn 1 thư mục
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag.ToString();
            LoadImages(path);
        }
        private void LoadImages(string folder)
        {
            flowLayoutPanel1.Controls.Clear();
            picMain.Image = null;

            string[] extensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
            var files = Directory.GetFiles(folder)
                .Where(f => extensions.Contains(Path.GetExtension(f).ToLower()))
                .ToArray();

            foreach (var file in files)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(file);
                pic.Width = 100;
                pic.Height = 80;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Margin = new Padding(5);
                pic.Cursor = Cursors.Hand;
                pic.Tag = file;

                // Khi click ảnh nhỏ -> hiển thị ảnh lớn
                pic.Click += (s, e) =>
                {
                    picMain.Image = Image.FromFile(((PictureBox)s).Tag.ToString());
                    picMain.SizeMode = PictureBoxSizeMode.Zoom;
                };

                flowLayoutPanel1.Controls.Add(pic);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTreeViewDrives();
        }
        private void LoadTreeViewDrives()
        {
            treeView1.Nodes.Clear();
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode root = new TreeNode(drive.Name);
                root.Tag = drive.RootDirectory.FullName;
                root.Nodes.Add("..."); // node giả để lazy load
                treeView1.Nodes.Add(root);
            }
        }

    }
}
