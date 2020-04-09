using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200409_WinFormos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            VirsutinePanele.Visible = false;
        }

        private void Mygtukas_Click(object sender, EventArgs e)
        {
            uzrasasKazkoks.Text = textBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (IjungtiTekstaBox.Checked)
            {
                VirsutinePanele.Visible = true;
            }
            else
            {
                VirsutinePanele.Visible = false;
            }
        }

        private void PavB_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string path = null;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }

            RodomasPB.BackgroundImage = Image.FromFile(path);
            RodomasPB.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void CreateNewTaab_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage();
            page.Text = "Mano sukurtas tab";
            page.BackColor = Color.Green;
            VisiTabai.TabPages.Add(page);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }
    }
}
