using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200326_whilePirmas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaičių");
            int sk = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            while (sk > 0)
            {
                if (sk % 2 == 0)
                {
                    suma += sk;
                }
                Console.WriteLine(sk--);
            }
            Console.WriteLine(suma);
        }
    }
}
