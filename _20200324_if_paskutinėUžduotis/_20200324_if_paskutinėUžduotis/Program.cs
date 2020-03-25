using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200324_if_paskutinėUžduotis
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

            if ((sk1 > sk2) && sk1 < 100)
            {
                Console.WriteLine("Atitinka pirmoji salyga");
            }
            else if ((sk2 > 0) && (sk2 > sk1))
            {
                Console.WriteLine("Atitinka antroji salyga");
            }
            else if ((sk1 > sk2) && (sk1 > sk3) || (sk1 > 0))
            {
                Console.WriteLine("Atitinka trecioji salyga");
            }
            else if ((sk3 >= 5 && sk3 <= 10) || (sk3 > sk1) || (sk3 > sk2))
            {
                Console.WriteLine("Atitinka ketvirotiji salyga");
            }
        }
    }
}
