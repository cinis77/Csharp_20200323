using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _20200507_DuomenuBazes
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\Csharp_20200323\_20200507_DuomenuBazes\_20200507_DuomenuBazes\TestuojamaDuomenuBaze.mdf;Integrated Security=True";
            SqlConnection sql = new SqlConnection(connectionString);
            string querry = "Insert into Vartotojas(Vardas, Pavarde, GimimoData) VALUES(@Vardas, @Pavarde, @GimimoData)";
            SqlCommand command = new SqlCommand(querry, sql);

            command.Parameters.AddWithValue("@Vardas", "Robertas");
            Console.WriteLine("Iveskite pavarde");
            command.Parameters.AddWithValue("@Pavarde", Console.ReadLine());
            command.Parameters.AddWithValue("@GimimoData", DateTime.Now.ToShortDateString().Replace('-', '/'));
            sql.Open();
            var atsakymas = command.ExecuteNonQuery();
            if (atsakymas < 0)
            {
                Console.WriteLine("Irasyti i duomenu baze nepavyko");
            }
            sql.Close();

        }

        static void SkaitytiIsDuomenuBazes()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\Csharp_20200323\_20200507_DuomenuBazes\_20200507_DuomenuBazes\TestuojamaDuomenuBaze.mdf;Integrated Security=True";
            SqlConnection sql = new SqlConnection(connectionString);
            string querry = "SELECT * FROM Vartotojas WHERE Vardas = 'Rokas'";
            SqlCommand command = new SqlCommand(querry, sql);
            sql.Open();
            var skaitytojas = command.ExecuteReader();
            while (skaitytojas.Read())
            {
                Console.WriteLine(skaitytojas["Vardas"].ToString());
                Console.WriteLine(skaitytojas["Pavarde"].ToString());
            }
            sql.Close();
        }
    }
}
