using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200330_intMetodas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            if (int.TryParse("5", out sk1))
            {

            }

            Console.WriteLine("Suskaiciuota suma: " + Suma(a: sk1, b: sk2));
            Console.WriteLine("Suskaiciuota skirtumas: " + Skirtumas(sk1, sk2));
            Console.WriteLine("Suskaiciuota sandauga: " + Sandauga(sk1, sk2));
            Console.WriteLine("Suskaiciuota dalyba: " + Dalmuo(sk1, sk2));
        }

        public static int Suma(int a, int b)
        {
            int suskaiciuotaSuma = a + b;
            return suskaiciuotaSuma;
        }

        public static int Skirtumas(int a, int b)
        {
            return (a - b);
        }

        public static int Sandauga(int a, int b)
        {
            return a * b;
        }

        public static double Dalmuo(int a, int b)
        {
            return (double)a / b;
        }
    }
}
