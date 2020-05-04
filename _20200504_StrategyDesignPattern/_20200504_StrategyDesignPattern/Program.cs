using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200504_StrategyDesignPattern
{
    class Program
    {
        static Dictionary<char, Action<int, int>> Skaiciuotuvas;
        static void Main(string[] args)
        {
            Skaiciuotuvas = 
                new Dictionary<char, Action<int, int>>()
            { {'+', Suma }, {'-', Atimtis }, {'*', Sandauga }, {'/', Dalyba } };

            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite zenkla");
            char zenklas = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine("\nIveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());

            PridetiNaujaStrategija('%', Liekana);

            Skaiciuotuvas[zenklas](sk, sk1);
        }

        private static void Liekana(int skai, int sk)
        {
            int liekana = skai % sk;
            Console.WriteLine(liekana);
        }

        private static void PridetiNaujaStrategija(char rakta, Action<int, int> strategija)
        {
            Skaiciuotuvas.Add(rakta, strategija);
        }

        private static void Suma(int skaicius, int skaicius1)
        {
            int suma = skaicius + skaicius1;
            Console.WriteLine(suma);
        }

        private static void Atimtis(int skaicius, int skaicius1)
        {
            int atimtis = skaicius - skaicius;
            Console.WriteLine(atimtis);
        }

        private static void Sandauga(int skaicius, int skaicius1)
        {
            int sandauga = skaicius * skaicius1;
            Console.WriteLine(sandauga);
        }

        private static void Dalyba(int skaicius, int skaicius1)
        {
            double dalyba = (double)skaicius / skaicius1;
            Console.WriteLine(dalyba);
        }
    }
}
