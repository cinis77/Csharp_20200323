using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200323_ketvirtaUzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            //1-----------------------
            int suma = sk1 + sk2;
            int skirtumas = sk1 - sk2;
            int sandauga = sk1 * sk2;
            double dalyba = (double)sk1 / sk2;
            Console.WriteLine("{0} + {1} = {2}", sk1, sk2, suma);
            Console.WriteLine("{0} - {1} = {2}", sk1, sk2, skirtumas);
            Console.WriteLine("{0} * {1} = {2}", sk1, sk2, sandauga);
            Console.WriteLine("{0} / {1} = {2}", sk1, sk2, dalyba);
            //2-----------------------
            Console.WriteLine("{0} + {1} = {2}", sk1, sk2, (sk1+sk2));
            Console.WriteLine("{0} - {1} = {2}", sk1, sk2, (sk1-sk2));
            Console.WriteLine("{0} * {1} = {2}", sk1, sk2, (sk1*sk2));
            Console.WriteLine("{0} / {1} = {2}", sk1, sk2, ((double)sk1/sk2));
        }
    }
}
