using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200407_KortuKalade
{
    class Korta
    {
        public string Tipas { get; }
        public string Reiksme { get; }

        public Korta(string tipas, string reiksme)
        {
            Tipas = tipas;
            Reiksme = PakeitimaReiksmes(reiksme);
        }

        private string PakeitimaReiksmes(string reiksme)
        {
            if (reiksme == "1")
            {
                return "A";
            }
            else if (reiksme == "11")
            {
                return "J";
            }
            else if (reiksme == "12")
            {
                return "Q";
            }
            else if (reiksme == "13")
            {
                return "K";
            }
            else
            {
                return reiksme;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            List<Korta> kalade = new List<Korta>();
            string[] tipai = { "D", "S", "P", "K" };
            int i = 0;
            while (i < 52)
            {
                //A- 1;  2=2; 3=3 ... 10=10, J = 11, Q = 12, K = 13 
                Korta korta = new Korta(tipai[rng.Next(0, tipai.Length)], rng.Next(1, 14).ToString());
                bool naujaKorta = true;
                foreach (var item in kalade)
                {
                    if (item.Tipas==korta.Tipas && item.Reiksme == korta.Reiksme)
                    {
                        naujaKorta = false;
                        break;
                    }
                }
                if (naujaKorta)
                {
                    kalade.Add(korta);
                    i++;
                }
            }

            foreach (var item in kalade)
            {
                Console.WriteLine(item.Tipas + " " + item.Reiksme);
            }
        }
    }
}
