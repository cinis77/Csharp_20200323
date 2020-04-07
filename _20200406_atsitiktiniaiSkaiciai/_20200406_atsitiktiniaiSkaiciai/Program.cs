using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200406_atsitiktiniaiSkaiciai
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            List<int> sarasas = new List<int>();
            int kiekis = rng.Next(0, 5000000);
            for (int i = 0; i < kiekis; i++)
            {
                sarasas.Add(rng.Next(-50000, 50000));
            }
            Console.WriteLine("Sarase yra :" + sarasas.Count);
            Console.WriteLine("Vidurkis skaiciu yra " + sarasas.Average());
            Console.WriteLine("Skaiciu suma yra " + sarasas.Sum());
            Console.WriteLine("Minimali reiksme yra: " + sarasas.Min());
            Console.WriteLine("Maksimali reiksme yra: " + sarasas.Max());
            
        }
    }
}
