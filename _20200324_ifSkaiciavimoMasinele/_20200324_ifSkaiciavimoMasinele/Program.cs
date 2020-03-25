using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200324_ifSkaiciavimoMasinele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite zenkla");
            char zenklas = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine("\nIveskite skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            if (zenklas == '+')
            {
                Console.WriteLine("{0} {1} {2} = {3}", sk1, zenklas, sk2, sk1 + sk2);
            }
            else if (zenklas == '-')
            {
                Console.WriteLine("{0} {1} {2} = {3}", sk1, zenklas, sk2, sk1 - sk2);
            }
            else if (zenklas == '*')
            {
                Console.WriteLine("{0} {1} {2} = {3}", sk1, zenklas, sk2, sk1 * sk2);
            }
            else if (zenklas == '/')
            {
                if (sk2 != 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3:0.00}", sk1, zenklas, sk2, (double)sk1 / sk2);
                }
                else
                {
                    Console.WriteLine("Dalyba iš 0 negalima");
                }
            }
            else
            {
                Console.WriteLine("Neatpažintas ženklas");
            }

        }
    }
}
