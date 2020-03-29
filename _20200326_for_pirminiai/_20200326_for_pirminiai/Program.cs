using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200326_for_pirminiai
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 2; i < 1000; i++)
            {
                //pirminis skaičius dalinasi tik iš 1 ir savęs pačio
                //Sudėtinis skaičius dalinasi bent iš vienos skaičiaus nuo 2 iki n-1
                bool pirminisSkaicius = true;
                for (int j = 2; j < i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        //skaičius yra sudėtinis
                        pirminisSkaicius = false;
                        break;
                    }
                }

                if (pirminisSkaicius)
                {
                    Console.WriteLine(i);
                    suma += i;
                }
            }
            Console.WriteLine(suma);
        }
    }
}
