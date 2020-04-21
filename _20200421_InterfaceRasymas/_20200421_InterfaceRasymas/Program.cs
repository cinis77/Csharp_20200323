using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200421_InterfaceRasymas
{
    interface IRasymas
    {
        void Rasyti(string tekstas);
    }

    class RasytiIFaila : IRasymas
    {
        public void Rasyti(string tekstas)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter("tekstas.txt");
            writer.WriteLine(tekstas);
            writer.Close();
        }
    }

    class RasytiIConsole : IRasymas
    {
        public void Rasyti (string tekstas)
        {
            Console.WriteLine(tekstas);
        }
    }

    class TekstoFormatas
    {
        private IRasymas Rasymo;

        public TekstoFormatas(IRasymas rasymas)
        {
            Rasymo = rasymas;
        }

        public void SuFormatuotiIrSaugoti(string tekstas)
        {
            Rasymo.Rasyti("++" + tekstas + "++");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            TekstoFormatas tekstoFormatas = new TekstoFormatas(new RasytiIFaila());
            tekstoFormatas.SuFormatuotiIrSaugoti("Labas pasauli");
        }
    }
}
