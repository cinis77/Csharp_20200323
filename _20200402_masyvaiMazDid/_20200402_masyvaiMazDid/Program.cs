using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace _20200402_masyvaiMazDid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek vesite skaiciu?");
            int[] masyvas = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.Write("Iveskite skaiciu: ");
                masyvas[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] > max)
                {
                    max = masyvas[i];
                }
                if (masyvas[i] < min)
                {
                    min = masyvas[i];
                }

            }
            Console.WriteLine("Didziausia reiksme masyve yra {0} o maziausia reiksme masyve {1}", max, min);
            Console.WriteLine("Didziausia reiksme masyve yra {0} o maziausia reiksme masyve {1}", masyvas.Max(), masyvas.Min());
        }
    }
}
