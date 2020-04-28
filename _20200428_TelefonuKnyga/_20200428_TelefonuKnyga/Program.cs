using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200428_TelefonuKnyga
{

    class Skaiciai <T, K> where T : class
        where K : IList<T>
    {

    }



    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> TelefonuKnyga = new Dictionary<string, int>();


            TelefonuKnyga.Add("Rokas", 865794248);
            TelefonuKnyga.Add("Lukas", 86458987);
            TelefonuKnyga.Add("Toma", 86545789);
            TelefonuKnyga.Add("Sima", 86477897);
            TelefonuKnyga.Add("Povilas", 86259754);
            TelefonuKnyga.Add("Julija", 86111055);

            


            Console.WriteLine("Tomos telefono numeris yra : " + TelefonuKnyga["Toma"]);
            Console.WriteLine("Nurodykite kieno telefono numeri norite matyti: ");
            string vardas = Console.ReadLine();

            if (TelefonuKnyga.Keys.Contains(vardas))
            {
                Console.WriteLine(TelefonuKnyga[vardas]);

            }
            else
            {
                Console.WriteLine("Nepavyko rasti tokio zmogaus telefono numerio");
            }

        }
    }
}
