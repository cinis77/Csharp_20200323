using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200406_misrusisDvigarsis
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "a";
            int kiekisAu = 0;
            while (!string.IsNullOrEmpty(line))
            {
                Console.WriteLine("Iveskite teksta");
                line = Console.ReadLine();
                if (!string.IsNullOrEmpty(line))
                {
                    var zodziai = line.Split(' ');
                    for (int i = 0; i < zodziai.Length; i++)
                    {
                        kiekisAu += KiekYraAuTekste(zodziai[i]);
                    }
                }
            }
            Console.WriteLine("Tekste buvo {0} kiekis au dvigarsiu", kiekisAu);
        }

        private static int KiekYraAuTekste(string zodis)
        {
            int kiekis = 0;
            char[] raides = zodis.ToLower().ToCharArray();
            for (int i = 0; i < raides.Length - 1; i++)
            {
                if (raides[i] =='a' && raides[i+1]=='u')
                {
                    kiekis++;
                }
            }
            return kiekis;
        }
    }
}
