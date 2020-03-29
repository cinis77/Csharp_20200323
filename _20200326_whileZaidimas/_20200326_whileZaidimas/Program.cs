using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200326_whileZaidimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ŽAIDIMAS");
            Console.WriteLine("Sugalvokite betkokį skaičių nuo 1 iki 3000");
            Console.WriteLine("Sugalvoję skaičių paspauskite enter klavišą");
            Console.ReadLine();
            string atsakymas = "";
            int min = 1;
            int max = 3000;
            while (atsakymas.ToLower() != "atspejai")
            {
                int spejimas = (min + max) / 2;
                //Padaryti spejima
                Console.WriteLine("Mano spejimas yra: " + spejimas);
                Console.WriteLine("Jei atspejau - rasyti atspejau, jei ne rasyti daugiau ar maziau");

                //Nusiskaityti vartotojo atsakyma
                atsakymas = Console.ReadLine();

                //Priimti sprendimus?
                if (atsakymas.ToLower() == "maziau")
                {
                    max = spejimas;
                }
                else if (atsakymas.ToLower() == "daugiau")
                {
                    min = spejimas;
                }
            }

            Console.WriteLine("Atspejau");
        }
    }
}
