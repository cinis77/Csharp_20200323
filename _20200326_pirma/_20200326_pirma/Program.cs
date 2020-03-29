using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200326_pirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite metus");
            int metai = Convert.ToInt32(Console.ReadLine());

            int olimp = metai - 1896; // 1896-1896 = 0 => Pirmosios
            int kelintosOlimp = (olimp / 4) + 1;
            Console.WriteLine("Paskutinės olimpinės buvo: "  + kelintosOlimp);
            if ((metai % 4) == 0)
            {
                Console.WriteLine("Olimpiniai metai");
            }
            else
            {
                Console.WriteLine("Neolimpiniai metai");
            }
        }
    }
}
