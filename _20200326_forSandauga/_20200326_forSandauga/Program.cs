using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200326_forSandauga
{
    class Program
    {
        static void Main(string[] args)
        {
            int sandauga = 1;
            for (int i = 1; i < 100; i++)
            {
                if (i % 7 ==0)
                {
                    sandauga *= i; //=> sandauga = sandauga =* i
                }
            }
            Console.WriteLine(sandauga);
        }
    }
}
