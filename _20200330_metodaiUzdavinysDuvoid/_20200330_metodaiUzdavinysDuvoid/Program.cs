using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200330_metodaiUzdavinysDuvoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Pasisveikinimas();
            Console.WriteLine("Iveskite savo varda: ");
            string vard = Console.ReadLine();
            Console.WriteLine("Iveskite amziu: ");
            string azmi = Console.ReadLine();
            Console.WriteLine("Iveskite savo hobio pavadinima: ");
            string hob = Console.ReadLine();
            MetodasIsvedimui(vard, azmi, hob);
        }

        public static void Pasisveikinimas()
        {
            Console.WriteLine("Labas vartotojau");
        }

        public static void MetodasIsvedimui(string vardas, string amzius, string hobis)
        {
            Console.WriteLine("Jusu vardas yra {0}, jums {1} metu, pomegis kuriuo uzsiimate yra {2}", vardas, amzius, hobis);
        } 
    }
}
