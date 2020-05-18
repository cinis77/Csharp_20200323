using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace _20200511_Rezervacijos
{
    public partial class Form1 : Form
    {
        const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\Csharp_20200323\_20200511_Rezervacijos\_20200511_Rezervacijos\DuomenuBaze.mdf;Integrated Security=True";
        private int KambarioID = 0;
        private readonly Dictionary<string, int> KlientuSarasas;

        public Form1()
        {
            InitializeComponent();
            KlientuSarasas = new Dictionary<string, int>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataContext db = new DataContext(ConnectionString);
            var lent = db.GetTable<Vartotojai>();
            foreach (var item in lent)
            {
                RezervuojantisVartotojas.Items.Add(item.Vardas + " " + item.Pavarde);
                KlientuSarasas.Add(item.Vardas + " " + item.Pavarde, item.Id);
            }
            RezervuojantisVartotojas.SelectedIndex = 0;
            GalimiRezervuotiKambariai.DataSource = db.GetTable<Kambariai>();
        }

        private void Rezervuoti_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext(ConnectionString);
            Rezervacija rez = new Rezervacija();
            rez.Pradzia = Pradzia.Value.Date;
            rez.Pabaiga = Pabaiga.Value.Date;
            rez.KlientoId = KlientuSarasas[RezervuojantisVartotojas.SelectedItem.ToString()];
            rez.KambarioId = KambarioID;
            db.GetTable<Rezervacija>().InsertOnSubmit(rez);
            db.SubmitChanges();
            MessageBox.Show("Rezervacija ivykdyta");
        }

        private void GalimiRezervuotiKambariai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KambarioID = (int)GalimiRezervuotiKambariai.Rows[e.RowIndex].Cells[0].Value;
        }

        private void Pradzia_ValueChanged(object sender, EventArgs e)
        {
            if (Pradzia.Value.Date < Pabaiga.Value.Date)
            {
                DataContext db = new DataContext(ConnectionString);
                var rezevacijas = db.GetTable<Rezervacija>().
                    Where(x => !((Pradzia.Value.Date < x.Pradzia && Pabaiga.Value.Date < x.Pradzia) ||
                    (Pradzia.Value.Date > x.Pabaiga && Pabaiga.Value.Date > x.Pradzia)));
                var kambariai = db.GetTable<Kambariai>().ToList();
                foreach (var item in rezevacijas)
                {
                    if (kambariai.Contains(item.Kambariai))
                    {
                        kambariai.Remove(item.Kambariai);
                    }
                }

                GalimiRezervuotiKambariai.DataSource = kambariai;
            }
            else
            {
                MessageBox.Show("Netinkamai parinkta pabaigos data");
            }
        }

        private void RezRodymas_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext(ConnectionString);
            GalimiRezervuotiKambariai.DataSource = db.GetTable<Rezervacija>().Select(x=> 
            new 
            {   x.Vartotojai.Vardas,
                x.Vartotojai.Pavarde, 
                x.Kambariai.Numeris,
                x.Kambariai.Kaina,
                x.Pradzia, 
                x.Pabaiga
            });

            GalimiRezervuotiKambariai.CellClick -= GalimiRezervuotiKambariai_CellContentClick;
            GalimiRezervuotiKambariai.CellContentClick -= GalimiRezervuotiKambariai_CellContentClick;
            Rezervuoti.Enabled = false;
        }
    }
}
