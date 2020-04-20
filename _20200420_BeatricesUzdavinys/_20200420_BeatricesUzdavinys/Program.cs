using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200420_BeatricesUzdavinys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());

            if (sk == 0)
            {
                Console.WriteLine("NEMIGA");
            }
            else
            {
                int[] skaiciai = new int[10];
                int i = 0;
                while (skaiciai.Sum() != 10)
                {
                    PoVienaSkaiciu(ref skaiciai, sk * ++i);
                }
                Console.WriteLine("Beatrice uzmigs su skaiciumi: " + (sk * i));
            }
        }

        private static void PoVienaSkaiciu(ref int[] skaiciai, int skaicius)
        {
            while (skaicius > 0)
            {
                int liekana = skaicius % 10;
                if (skaiciai[liekana] == 0)
                {
                    skaiciai[liekana]++;
                }
                skaicius /= 10;
            }
        }
    }
}
