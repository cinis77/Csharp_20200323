using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200326_forPirmasUždavinys
{
    class Program
    {
        static void Main(string[] args)
        {
            //I variantas
            for (int i = 0; i < 20; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //II
            for (int i = 0; i < 20; i += 3) // i = i + 3 => i +=3
            {
                Console.WriteLine(i);
            }
        }
    }
}
