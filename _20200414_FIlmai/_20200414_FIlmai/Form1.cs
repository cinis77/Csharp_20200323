using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200414_FIlmai
{
    public partial class Form1 : Form
    {
        private const string FolderioKelias = "ManoFilmai";
        public Form1()
        {
            InitializeComponent();
            VisiFailaiEsantysFolderyje();
        }

        private void VisiFailaiEsantysFolderyje()
        {
            VisiFilmai.Items.Clear();
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(FolderioKelias);
            foreach (var item in dir.GetFiles())
            {
                var skaidytasPavadinimas = item.Name.Split('.');
                VisiFilmai.Items.Add(skaidytasPavadinimas[0]);
            }
        }

        private void IsvalytiTekstiniusLaukus()
        {
            PavadinimasText.Text = string.Empty; // => ""
            AprasymasText.Text = string.Empty;
            Reitingas.Text = string.Empty;
            ReziusieriusText.Text = string.Empty;
            TrukmeText.Text = string.Empty;
        }

        private void NaujasFailas_Click(object sender, EventArgs e)
        {
            Filmas filmas = new Filmas();
            filmas.Pavadinimas = PavadinimasText.Text;
            filmas.Reitingas = int.Parse(Reitingas.Text);
            filmas.Aprasymas = AprasymasText.Text;
            filmas.Reziusierius = ReziusieriusText.Text;
            filmas.Trukme = int.Parse(TrukmeText.Text);
            System.IO.StreamWriter writer = new System.IO.StreamWriter(FolderioKelias + @"\" + filmas.Pavadinimas + ".filmas");
            writer.WriteLine(filmas.Pavadinimas);
            writer.WriteLine(filmas.Reitingas);
            writer.WriteLine(filmas.Aprasymas);
            writer.WriteLine(filmas.Reziusierius);
            writer.WriteLine(filmas.Trukme);
            writer.Flush();
            writer.Close();
            writer.Dispose();
            IsvalytiTekstiniusLaukus();
            MessageBox.Show("Išsaugoti pavyko sėkmingai!");
            VisiFailaiEsantysFolderyje();
        }

        private void VisiFilmai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pasirinktasElementas = VisiFilmai.SelectedItem.ToString();
            System.IO.StreamReader reader = new System.IO.StreamReader(FolderioKelias + @"\" + pasirinktasElementas + ".filmas");
            PavadinimasText.Text = reader.ReadLine();
            Reitingas.Text = reader.ReadLine();
            AprasymasText.Text = reader.ReadLine();
            ReziusieriusText.Text = reader.ReadLine();
            TrukmeText.Text = reader.ReadLine();
            reader.Close();
            reader.Dispose();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var klausimas = MessageBox.Show("Ar tikrai norite istrinti faila", "failo istrinimas", MessageBoxButtons.YesNo);
            if (klausimas == DialogResult.Yes)
            {
                System.IO.File.Delete(FolderioKelias + @"\" + VisiFilmai.SelectedItem.ToString() + ".filmas");
                VisiFailaiEsantysFolderyje();
            }
        }
    }
}
