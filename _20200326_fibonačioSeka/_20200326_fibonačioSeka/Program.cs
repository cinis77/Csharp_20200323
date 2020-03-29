using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200326_fibonačioSeka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kiek norite matyti fibonačio sekos narių");
            int n = Convert.ToInt32(Console.ReadLine());
            int sk1 = 1;
            int sk2 = 1;
            int sk3 = 0;
            Console.WriteLine(sk1);
            Console.WriteLine(sk2);
            for (int i = 2; i < n; i++)
            {
                sk3 = sk1 + sk2;
                Console.WriteLine(sk3);
                sk1 = sk2;
                sk2 = sk3;
            }
        }
    }
}
