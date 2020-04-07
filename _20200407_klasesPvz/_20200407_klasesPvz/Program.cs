using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200407_klasesPvz
{
    class Automobilis
    {
        public string Marke;
        public string Modelis;
        public int GamybosMetai;
        public int Rida;

        public double NuvaziuojaPerMetus()
        {
            int kiekPraejoMetu = DateTime.Today.Year - this.GamybosMetai + 1;
            return (double)Rida / kiekPraejoMetu;
        }

        public Automobilis(string Marke, string modelis, int gamybosMetai, int rida)
        {
            this.Marke = Marke;
            Modelis = modelis;
            GamybosMetai = gamybosMetai;
            Rida = rida;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Automobilis auto = new Automobilis("Audi", "A4", 2005, 192500);
            Automobilis auto1 = new Automobilis("BMW", "E39", 1998, 354000);
            Automobilis auto2 = new Automobilis("Porsche", "911", 2011, 5000);
            List<Automobilis> automobiliai = new List<Automobilis>();
            automobiliai.Add(auto);
            automobiliai.Add(auto1);
            automobiliai.Add(auto2);
            Automobilis[] masyvas = { auto, auto1, auto2 };
            Console.WriteLine(auto.NuvaziuojaPerMetus());
        }
    }
}
