using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200416_PaveldinciosKlases
{
    class Gyvunas
    {
        protected string Pavadinimas { get; set; }
        protected int Amzius { get; set; }

        public string Vardas { get; set; }

        private string KailioSpalva { get; set; }

        public void Bega()
        {
            Console.WriteLine("Gyvunas bega");
        }

        public virtual void PavyzdysVirtualausMetodo()
        {
            Console.WriteLine("Iskvieciamas virtualus metodas");
        }

        protected void Mirsta()
        {

        }

        public Gyvunas(string gyvunoPavadinimas, int amzius)
        {
            Pavadinimas = gyvunoPavadinimas;
            Amzius = amzius;
        }
    }

    class Suo : Gyvunas
    {
        public string Veisle { get; }

        public Suo(string gyvunoPavadinimas, int amzius, string veisle):base(gyvunoPavadinimas, amzius)
        {
            Amzius = 25;
            Vardas = "Alis";
            Bega();
            Mirsta();
        }

        public override void PavyzdysVirtualausMetodo()
        {
            base.PavyzdysVirtualausMetodo();
            base.Pavadinimas = "";
            Console.WriteLine("Mano daromas metodas");
        }

        public void PapildomasMetodas()
        {

        }
    }

    class Korgi : Suo
    {
        public Korgi(string gyv, int amz, string veis):base(gyv, amz, veis)
        {

        }
    }


    class Kate : Gyvunas
    {
        public string KailioTipas;

        public void SokaAukstyn()
        {

        }

        public Kate():base("Kate", 0)
        {

        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Suo suo = new Suo("Suo", 1);
            Kate kate = new Kate();
            Gyvunas gyvunas = new Suo("Suo", 0 , "");
            Gyvunas gyv = new Kate();
            Gyvunas ggg = new Korgi("", 0, "");
            LankstusMetodas(kate);
            LankstusMetodas(suo);
            object objektas = 1;
            objektas = "zodis";
            objektas = gyv;
            objektas = new Kate();
            Suo suns = (Suo)gyvunas;
            double skaiciu = 1;
            int sk = (int)skaiciu;
   
            LankstusMetodas(suo);
        }

        static void LankstusMetodas(object gyvunas)
        {
            var elementas = (Kate)gyvunas;
            
        }
    }
}
