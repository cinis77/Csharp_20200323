using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200330_metodaiPvz
{
    class Program
    {


        static void Main(string[] args)
        {
            PasisveikintiSuStatic();

            Program objektoPavadinimas = new Program();
            objektoPavadinimas.Pasisveikinimas();

            TekstoIsvedimas("Tekstas nekuriant kintamojo");
            string tekst = "Mano tekstas kintamajame";
            TekstoIsvedimas(tekst);
  
        }

        public static void TekstoIsvedimas(string tekstas)
        {
            Console.WriteLine(tekstas);
        }


        public void Pasisveikinimas()
        {
            Console.WriteLine("Labas vartotojau");
        }

        public static void PasisveikintiSuStatic()
        {
            Console.WriteLine("Labas");
        }
    }
}
