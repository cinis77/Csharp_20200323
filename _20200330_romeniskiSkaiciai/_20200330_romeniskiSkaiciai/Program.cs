using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200330_romeniskiSkaiciai
{
    class Program
    {
        /*
         *
1-1000

1 - I
4 - IV
5 - V
9 - IX
10- X
40 - XL
50 - L
90 - XC
100 - C
400 - CD
500 - D
900 - CM
1000 - M 
         * 
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaičių nuo 1 iki 1000");
            int sk = Convert.ToInt32(Console.ReadLine());
            if (sk < 1000)
            {
                int simt = sk / 100;
                int desim = sk / 10 % 10;
                int vnt = sk % 10;
                Console.WriteLine(RomeniskoKonvertavimas(simt, "C", "D", "M") + RomeniskoKonvertavimas(desim, "X", "L", "C") + 
                    RomeniskoKonvertavimas(vnt, "I", "V", "X"));
            }
            else
            {
                Console.WriteLine("M");
            }
        }

        public static string RomeniskoKonvertavimas(int skaicius, string vienas, string penki, string desimt)
        {
            if (skaicius == 4)
            {
                return vienas + penki;
            }
            else if (skaicius == 9)
            {
                return vienas + desimt;
            }
            else
            {
                // 1, 2, 3, 5, 6, 7,8
                // 2 => II 7 => VII
                // 3 => III 8 => VIII
                string atsakymas = "";
                if (skaicius / 5 != 0)
                {
                    atsakymas += penki;
                }
                int n = skaicius % 5;
                for (int i = 0; i < n; i++)
                {
                    atsakymas += vienas;
                }
                return atsakymas;

            }
        }
    }
}
