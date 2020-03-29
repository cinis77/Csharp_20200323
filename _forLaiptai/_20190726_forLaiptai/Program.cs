using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190726_forLaiptai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int row = 1; row <= 6; row++)
            {
                for (int tarpai = 0; tarpai < 6 - row; tarpai++)
                {
                    Console.Write(" ");
                }
                for (int hashTag = 0; hashTag < row; hashTag++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}