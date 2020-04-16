using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200416_Figuros
{
    abstract class Figura
    {
        public int Krastine { get; set; }

        public abstract double PlotoSkaiciavimas();

        public void Metodas()
        {

        }
    }

    class Kvadratas : Figura
    {
        public int a;
        public int b;

        public override double PlotoSkaiciavimas()
        {
            return a * b;
        }

        public Kvadratas(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }

    class Trikampis : Figura
    {
        public int a;
        public int b;

        public override double PlotoSkaiciavimas()
        {
            return (0.5) * a * b;
        }
    }

    class Apskritimas : Figura
    {
        public int R;

        public override double PlotoSkaiciavimas()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Figura kvadratas = new Kvadratas(10, 15);
            Console.WriteLine(kvadratas.PlotoSkaiciavimas());
        }
    }
}
