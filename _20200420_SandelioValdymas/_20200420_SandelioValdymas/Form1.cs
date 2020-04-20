using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200420_SandelioValdymas
{
    public partial class Form1 : Form
    {
        private List<Preke> VisosPrekes;

        public Form1()
        {
            InitializeComponent();
            VisosPrekes = new List<Preke>();
            LoadPrekes();
        }

        private void LoadPrekes()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("duomenys.csv");
            string line = null;
           
            while ((line = reader.ReadLine())!= null)
            {
                var data = line.Split(';');
                Preke preke = new Preke(int.Parse(data[0]), data[1]) { Kiekis = int.Parse(data[2]), Lokacija = data[3] };
                VisosPrekes.Add(preke);
            }
            SandelioVaizdas.DataSource = VisosPrekes;
            reader.Close();
        }

        private void RefreshView()
        {
            VisosPrekes.Clear();
            SandelioVaizdas.DataSource = null;
            LoadPrekes();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Preke preke = new Preke(int.Parse(Id.Text), Pavadinimas.Text) { Kiekis= int.Parse(Kiekis.Text), Lokacija = Lokacija.Text };
            System.IO.StreamWriter writer = new System.IO.StreamWriter("duomenys.csv", true);
            writer.Write(preke.ID + ";");
            writer.Write(preke.Pavadinimas + ";");
            writer.Write(preke.Kiekis + ";");
            writer.WriteLine(preke.Lokacija);
            writer.Flush();
            writer.Close();

            Id.Text = string.Empty;
            Pavadinimas.Text = string.Empty;
            Kiekis.Text = string.Empty;
            Lokacija.Text = string.Empty;

            RefreshView();
        }

        private void SandelioVaizdas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var eilute = ((DataGridView)sender).SelectedRows[0];
            Id.Text = eilute.Cells["Id"].Value.ToString();
            Pavadinimas.Text = eilute.Cells["Pavadinimas"].Value.ToString();
            Kiekis.Text = eilute.Cells["Kiekis"].Value.ToString();
            Lokacija.Text = eilute.Cells["Lokacija"].Value.ToString();
            Pakeisti.Enabled = true;
        }

        private void Pakeisti_Click(object sender, EventArgs e)
        {
            foreach (var item in VisosPrekes)
            {
                if (item.ID == int.Parse(Id.Text))
                {
                    item.Lokacija = Lokacija.Text;
                    item.Kiekis = int.Parse(Kiekis.Text);
                }
            }
            PerrasytiFaila();
        }

        private void PerrasytiFaila()
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter("duomenys.csv");
            foreach (var preke in VisosPrekes)
            {
                writer.Write(preke.ID + ";");
                writer.Write(preke.Pavadinimas + ";");
                writer.Write(preke.Kiekis + ";");
                writer.WriteLine(preke.Lokacija);
                writer.Flush();
            }
            writer.Close();
            RefreshView();
        }
    }
}
