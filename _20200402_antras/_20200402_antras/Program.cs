using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200402_antras
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = {5, 6, 8, 9, -2, 8, 6, 10, 8, 5 };
            Console.WriteLine("Masyve nariu yra: " + masyvas.Length);
            Console.WriteLine("Masyvo pirmas narys yra: " + masyvas[0]);
            Console.WriteLine("Masyva paskutnis narys yra: " + masyvas[masyvas.Length - 1]);
            Console.WriteLine("Masyvo antras narys yra: " + masyvas[1]);

            string[] mas = Console.ReadLine().Split(' ');
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].ToCharArray().Length; j++)
                {
                    Console.WriteLine(mas[i].ToCharArray()[j]);
                }
            }
        }
    }
}
