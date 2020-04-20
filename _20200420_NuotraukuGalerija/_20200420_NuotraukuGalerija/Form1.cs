using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _20200420_NuotraukuGalerija
{
    public partial class Form1 : Form
    {
        private string Path;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                Path = folderBrowser.SelectedPath;
            }

            if (Path != null)
            {
                LoadPicture();
            }
        }

        private void LoadPicture()
        {
            DirectoryInfo info = new DirectoryInfo(Path);
            PictureBox pic = null;
            foreach (var item in info.GetFiles())
            {
                if (item.Extension == ".jpg" || item.Extension == ".png" || item.Extension == ".jpeg")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(300, 200);
                    if (pic == null)
                    {
                        pictureBox.Location = new Point(10, 10);
                    }
                    else
                    {
                        if (pic.Location.X + 10 + pic.Width + pictureBox.Width <= NuotraukuGalerijosVaizdas.Width)
                        {
                            pictureBox.Location = new Point(pic.Location.X + 10 + pic.Width, pic.Location.Y);
                        }
                        else
                        {
                            pictureBox.Location = new Point(10, pic.Location.Y + pic.Height + 10);
                        }
                    }
                    pictureBox.BackgroundImage = Image.FromFile(item.FullName);
                    pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                    NuotraukuGalerijosVaizdas.Controls.Add(pictureBox);
                    pic = pictureBox;
                }
            }
        }

        private void NuotraukuGalerijosVaizdas_SizeChanged(object sender, EventArgs e)
        {
            NuotraukuGalerijosVaizdas.Controls.Clear();
            if (Path != null)
            {
                LoadPicture();
            }
        }
    }
}
