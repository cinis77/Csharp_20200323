using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200402_apskritimas
{
    class Program
    {
        static void Main(string[] args)
        {
            int xc = 1;
            int yc = 2;
            int R = 10;

            int[] x = new int[10];
            int[] y = new int[10];

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Iveskite tasko x");
                x[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Iveskite tasko y");
                y[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < x.Length; i++)
            {
                //atstumas nuo centro iki tasko yra mazesnis arba lygus uz R reiskia taskas priklausys apskritimui arbba bus apskritimo viduje
                //d= sqrt(pow((x-xc),2)+pow((y-yc),));
                double d = Math.Sqrt(Math.Pow(x[i] - xc, 2) + Math.Pow(y[i] - yc, 2));
                if (d <= R)
                {
                    Console.WriteLine("Taskas [{0};{1}], yra apskritimo viduryje", x[i], y[i]);
                }

            }
        }
    }
}
