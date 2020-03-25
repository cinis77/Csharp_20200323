using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200324_if_antra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičių:");
            int skaičius = Convert.ToInt32(Console.ReadLine());
            int liekana = skaičius % 2;
            if (liekana == 0)
            {
                Console.WriteLine("Skaičius yra lyginis");
            }

            if ((skaičius % 2) == 0)
            {
                Console.WriteLine("Skaičius yra lyginis");
            }

            bool lyginis = skaičius % 2 == 0;


            if (!lyginis)
            {
                Console.WriteLine("Skaicius yra nelyginis");
            }
        }
    }
}
