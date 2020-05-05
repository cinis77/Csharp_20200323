using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200504_GriztantiInfoDelegatai
{
    class Program
    {
        delegate int Metodas();

        static void Main(string[] args)
        {
            Metodas m = MetodasGrazinantisSkaiciu;
            Console.WriteLine(m);

            List<int> skaiciai = new List<int>() { 1, -7, 8, 6, -9, 5, -8, 6 };
            Func<int> func = MetodasGrazinantisSkaiciu;
            Func<string, char, int> func1 = Met;
            int skaicius = 3;
            Action act = () => Console.WriteLine("Sveikas pasauli");
            Action<int, int> action2 = (x, y) => Console.WriteLine("Suma: " + (x+y));
            Func<int, int, int> griztantisInterger = (x, y) =>
            {
                return x + y;
            };

            act();
            action2(3, 2);
            var visuTeigiamuSkaiciu = skaiciai.Where(x => x > 0).OrderBy(x=>x);
            var visiLyginiaiSkaiciai = skaiciai.Where(x => (x % 2) == 0)
                .OrderByDescending(dswer=>dswer);
            foreach (var item in visiLyginiaiSkaiciai)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Atliktas veiksmas: " + griztantisInterger(3, 2));
        }

        private static int Met(string zodis, char raide)
        {
            return 0;
        }

        private static int MetodasGrazinantisSkaiciu()
        {
            Random rng = new Random();
            return rng.Next();
        }
    }
}
