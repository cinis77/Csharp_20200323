using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200330_AnaRekursija
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaiciu = Convert.ToInt32(Console.ReadLine());
            // 224488
            for (int i = skaiciu; i >= 1; i--)
            {
                if (ArTvarkingas(i))
                {
                    Console.WriteLine("Didziausias tvarkingas skaicius yra: " + i);
                    break;
                }
            }
        }

        public static bool ArTvarkingas(int sk)
        {
            int pask = sk % 10;
            int priesp = sk / 10 % 10;
            if (pask >= priesp)
            {
                int temp = sk / 10;
                if (temp > 10)
                {
                    return ArTvarkingas(temp); //222444466666
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
