using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200423_UnitTestingToliau
{
    public class KlaseSkirtaTestuotis
    {
        public int Sandauga(int a, int b)
        {
            return a * b;
        }

        public string FormatuojamasZodis(string tekstas)
        {

            return "x" + tekstas + "x";
        }

        public void SugeneruojaKlaidosKoda()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("citatos.txt");
            var duomuo = reader.ReadLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
