using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200324_if_didziausiasSkaicius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk3 = Convert.ToInt32(Console.ReadLine());

            if (sk1 > sk2 && sk1 > sk3)
            {
                Console.WriteLine("Pirmas skaičius yra didžiausias");
            }
            else if (sk2 > sk3 && sk2 > sk1)
            {
                Console.WriteLine("Antras skaičius yra didžiausias");
            }
            else if (sk3 > sk2 && sk3 > sk1)
            {
                Console.WriteLine("Trečias skaičius yra didžiausias");
            }
        }
    }
}
