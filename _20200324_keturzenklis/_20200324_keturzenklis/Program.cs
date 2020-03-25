using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200324_keturzenklis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaicius");
            int sk = Convert.ToInt32(Console.ReadLine());
            int tuks = sk / 1000;
            int simt = sk / 100 % 10;
            int desimt = sk / 10 % 10;
            int vnt = sk % 10;
            Console.WriteLine(tuks);
            Console.WriteLine(simt);
            Console.WriteLine(desimt);
            Console.WriteLine(vnt);
            int atv = vnt * 1000 + desimt * 100 + simt * 10 + tuks;
            Console.WriteLine(atv);
            if (sk == atv)
            {
                Console.WriteLine("Polinaris skaicius");
            }
        }
    }
}
