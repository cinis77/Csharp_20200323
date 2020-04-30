using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200430_ValgymoCempionatas
{

    class PersiValgymoException: Exception
    {
        public override string Message => "Persivalge";
    }

    class Dalyvis
    {
        public string Vardas { get; set; }
        public double ValgymoGreitis { get; set; }
        public double SkrandzioTalpa { get; set; }

        private double JauSuvalgyta;

        public void Valgyti()
        {
            JauSuvalgyta += ValgymoGreitis;
            if (JauSuvalgyta > SkrandzioTalpa)
            {
                throw new PersiValgymoException();
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            double ValgymoKonkursoKiekis = 3;
            var dalyviai = SukurtiDalyviuSarasa();
            string GreiciausiaiValgo = "";
            while (ValgymoKonkursoKiekis > 0)
            {
                double daugiausiaiPerIteracija = 0;
                foreach (var item in dalyviai)
                {
                    if (daugiausiaiPerIteracija <= item.ValgymoGreitis)
                    {
                        daugiausiaiPerIteracija = item.ValgymoGreitis;
                        GreiciausiaiValgo = item.Vardas;
                    }
                    try
                    {
                        item.Valgyti();
                    }
                    catch (PersiValgymoException ex)
                    {
                        Console.WriteLine( ex.Message);
                        Console.WriteLine("Persivalge: " + item.Vardas);
                    }
                    
                }
                ValgymoKonkursoKiekis -= daugiausiaiPerIteracija;
            }

            Console.WriteLine("Laimejo " + GreiciausiaiValgo);
        }

        private static List<Dalyvis> SukurtiDalyviuSarasa()
        {
            List<Dalyvis> dalyviai = new List<Dalyvis>();
            dalyviai.Add(new Dalyvis() { Vardas = "Tomas", ValgymoGreitis = 0.87, SkrandzioTalpa = 3 });
            dalyviai.Add(new Dalyvis() { Vardas = "Luka", ValgymoGreitis = 0.6, SkrandzioTalpa = 1 });
            dalyviai.Add(new Dalyvis() { Vardas = "Simonas", ValgymoGreitis = 1.5, SkrandzioTalpa = 4 });

            return dalyviai;
        }
    }
}
