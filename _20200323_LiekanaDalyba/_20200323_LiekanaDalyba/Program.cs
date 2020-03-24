using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200323_LiekanaDalyba
{
    class Program
    {
        static void Main(string[] args)
        {
            int sk1 = 7;
            int sk2 = 2;
            int sveikaDalis = 7 / 2;
            int liekana = 7 % 2;
            Console.WriteLine("{0} dalinam is {1}, sveikoji dalis {2}, o liekana {3}", sk1, sk2, sveikaDalis, liekana);

            double saknies = Math.Sqrt(4);
            double absoliutiReiksme = Math.Abs(-5);
            double Pi = Math.PI;
            double laipniuKelimas = Math.Pow(2, 5);
            double x = 52;
            double z = 9;
            double y = 93;
            //(x/2) + z^8 - sqrt(y+6), kai x = 52, z = 9, y = 93
            double ats = (x / 2) + Math.Pow(z, 8) - Math.Sqrt(y + 6);
            Console.WriteLine(ats);

        }
    }
}
