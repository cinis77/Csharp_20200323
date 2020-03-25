using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200324_if_pirmaUzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičių:");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių:");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            if (sk1 > sk2)
            {
                Console.WriteLine("Pirmas skaičius yra didesnis už antrą skaičių");
            }
            if (sk1 < sk2)
            {
                Console.WriteLine("Pirmas skaičius yra mažesnis už antrą skaičių");
            }
            if (sk1 == sk2)
            {
                Console.WriteLine("Abu skaičiai yra lygūs");
            }
        }
    }
}
