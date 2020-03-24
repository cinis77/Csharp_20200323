using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200323_trečiasUždavinys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite savo vardą");
            string vardas = Console.ReadLine();
            Console.WriteLine("Įveskite spalvos pirmą raidę");
            char raidė = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine("\nĮveskite atsitiktinį skaičių");
            double sk1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Įveskite atsitiktinį skaičių");
            double sk2 = Convert.ToDouble(Console.ReadLine());
            double sk3 = double.Parse("852,8");
            Console.WriteLine("Jūsų vardas yra {0}, mėgiamiausia spalvos raidė yra {1}, atsitiktinis skaičius {2} ir {3}",
                vardas, raidė, sk1, sk2);
        }
    }
}
