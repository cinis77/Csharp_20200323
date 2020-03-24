using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200323_pirmaPaskaita_PirmaUzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // camel pirmasZodisSekantisZodis
            // Pascal PirmasZodisSekantisZodis
            string vardas = "Dominykas";
            string pavarde = "Rentelis"; 
            int amzius = 27;
            double svoris = 101;
            float ugis = 1.81f;
            string aukstojiMokykla = "Kaunas Coding School";
            string akademinesGrupesKodas = "Program11";
            string kursas = "1";
            string studijuProgramosPavadinimas = "C# programavimas";
            int atsiskaitytuKredituSkaicius = 180;

            Console.WriteLine("To Do programa");
            Console.WriteLine("1. Pavedžioti šunį");
            Console.WriteLine("2. Išnešti šiūkšles");
            Console.WriteLine("3. Nupirkti pieno");
            //Console.ReadKey();

            Console.WriteLine("STUDENTO DUOMENYS");
            Console.WriteLine("{0} {1} ({2}m.)", vardas, pavarde, amzius);
            Console.WriteLine("Jo ūgis yra {0:0.00}m, o svoris yra {1}kg", ugis, svoris.ToString("F4"));
            Console.WriteLine("Jis mokosi {0} aukstojoje mokykloje ({1})", aukstojiMokykla, studijuProgramosPavadinimas);
            Console.WriteLine("Akademinė grupė kuriai priklauso " + akademinesGrupesKodas);
            Console.WriteLine("Jau yra baiges 0 kursu, šiuo metu mokosi " + kursas);
            Console.WriteLine("Per studiju atsiskaite už {0} kreditų", atsiskaitytuKredituSkaicius);
            //pletinys CodeMaid
        }
    }
}
