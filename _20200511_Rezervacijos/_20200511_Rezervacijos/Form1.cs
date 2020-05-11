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
    }
}
