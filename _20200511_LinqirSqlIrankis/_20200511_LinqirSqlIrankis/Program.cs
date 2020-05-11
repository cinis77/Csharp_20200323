using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace _20200511_LinqirSqlIrankis
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\Csharp_20200323\_20200511_LinqirSqlIrankis\_20200511_LinqirSqlIrankis\DuomenuBaze.mdf;Integrated Security=True";
            DataContext db = new DataContext(connectionString);
            var lentele = db.GetTable<Vartotojai>().Where(x => x.Adresais.Count != 0);

            foreach (var item in lentele)
            {
                Console.WriteLine(item.Vardas + " " + item.Pavarde);
            }

            db.GetTable<Vartotojai>().DeleteOnSubmit(lentele.First());
            db.SubmitChanges();
        }

        private static void DuomenuIrasymas()
        {
            Vartotojai vartotojai = new Vartotojai();
            vartotojai.Vardas = "Povilas";
            vartotojai.Pavarde = "Lalals";
            Adresai adrs = new Adresai();
            adrs.Adresas = "Gatve";
            adrs.NamoNumber = 32;

            vartotojai.Adresais.Add(adrs);
        }
    }
}
