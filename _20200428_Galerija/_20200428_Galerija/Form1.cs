using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200428_Galerija
{
    public partial class Form1 : Form
    {

        readonly Dictionary<TabPage, PaveiksliukoInfromacija> InformacijosZodynas;


        public Form1()
        {
            InitializeComponent();
            InformacijosZodynas = new Dictionary<TabPage, PaveiksliukoInfromacija>();
        }

        private void UzktautiFoto_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            string kelias = null;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                kelias = folder.SelectedPath;
            }

            if (kelias != null)
            {
                UzkratuVisasNuotraukasFolderyje(kelias);
            }
        }

        private void UzkratuVisasNuotraukasFolderyje(string path)
        {
            System.IO.DirectoryInfo info = new System.IO.DirectoryInfo(path);
            int i = 0;
            foreach (var item in info.GetFiles())
            {
                if (item.Extension == ".jpg" || item.Extension == ".jpeg" || item.Extension == ".png")
                {
                    TabPage page = new TabPage();
                    page.BackgroundImage = Image.FromFile(item.FullName);
                    page.BackgroundImageLayout = ImageLayout.Stretch;
                    page.Text = (++i).ToString();
                    Galerija.TabPages.Add(page);
                    PaveiksliukoInfromacija infor = new PaveiksliukoInfromacija();
                    infor.Pavadinimas = item.Name.TrimEnd(item.Extension.ToCharArray());
                    infor.Pletinys = item.Extension;
                    infor.SaugojamasFolderis = info.FullName;
                    InformacijosZodynas.Add(page, infor);
                }
            }

        }

        private void Galerija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Galerija.TabPages.Count != 0)
            {
                PavadinimasTextBox.Text = InformacijosZodynas[Galerija.SelectedTab].Pavadinimas;
                PletinysTextBox.Text = InformacijosZodynas[Galerija.SelectedTab].Pletinys;
            }
            
        }

        private void IssaugotiMygtukas_Click(object sender, EventArgs e)
        {

            string trynimoKelias = InformacijosZodynas[Galerija.SelectedTab].SaugojamasFolderis + @"\"
            + InformacijosZodynas[Galerija.SelectedTab].Pavadinimas + InformacijosZodynas[Galerija.SelectedTab].Pletinys;
            Bitmap bitmap = (Bitmap)Galerija.SelectedTab.BackgroundImage;
            string saugojimoKelias = InformacijosZodynas[Galerija.SelectedTab].SaugojamasFolderis + PavadinimasTextBox.Text + PletinysTextBox.Text;
            bitmap.Save(saugojimoKelias);
            InformacijosZodynas[Galerija.SelectedTab].Pavadinimas = PavadinimasTextBox.Text;
            string folderioKelias = InformacijosZodynas[Galerija.SelectedTab].SaugojamasFolderis;
            while (Galerija.TabPages.Count > 0)
            {
                Galerija.TabPages.Remove(Galerija.TabPages[0]);
            }
            
            InformacijosZodynas.Clear();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            System.IO.File.Delete(trynimoKelias);
            UzkratuVisasNuotraukasFolderyje(folderioKelias);
        }
    }


    class PaveiksliukoInfromacija
    {
        public string Pavadinimas { get; set; }
        public string Pletinys { get; set; }
        public string SaugojamasFolderis { get; set; }
    }

}
