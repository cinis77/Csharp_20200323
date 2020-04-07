using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200406_sarasas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> skaiciai = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Iveskite skaiciu");
                skaiciai.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Visu skaiciu suma yra: " + skaiciai.Sum());
            Console.WriteLine("Visu skaiciu vidurkis yra: " + skaiciai.Average());
            Console.WriteLine("Elementu kiekis: " + skaiciai.Count);
            skaiciai.Remove(2);
            Console.WriteLine("Elementu kiekis: " + skaiciai.Count);

            skaiciai.RemoveAt(3);
            Console.WriteLine("Elementu kiekis: " + skaiciai.Count);
            Console.WriteLine("Elementas trecias " + skaiciai.ElementAt(2));
            Console.WriteLine("Elementas trecias " + skaiciai[2]);
            foreach (int item in skaiciai)
            {
                Console.WriteLine(item);
            }
        }
    }
}
