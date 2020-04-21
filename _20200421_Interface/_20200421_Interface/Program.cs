using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200421_Interface
{
    interface IPirmasisManoInterface
    {
        void MetodasA();
        int A { get; set; }
        string MetodasB();
        double MetodasC(int a);
    }

    interface IManoAntrasisInterface
    {
        void AntrasMetodas();
    }

    class PirmaKlase : IPirmasisManoInterface, IManoAntrasisInterface
    {

        public void AntrasMetodas()
        {

        }

        public int A
        {
            get
            {
                return 0;
            }
            set
            {
                ;
            }
        }

        public void MetodasA()
        {

        }

        public string MetodasB()
        {
            return "Kazkas";
        }

        public double MetodasC(int a)
        {
            return a;
        }
    }

    class Antra : IPirmasisManoInterface
    {
        public int A { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void MetodasA()
        {
            throw new NotImplementedException();
        }

        public string MetodasB()
        {
            throw new NotImplementedException();
        }

        public double MetodasC(int a)
        {
            throw new NotImplementedException();
        }
    }

    class ElementasInterface
    {
        public IPirmasisManoInterface pirmasis;

        public ElementasInterface(IPirmasisManoInterface elementas)
        {

        }

        private void Daromi()
        {
            int a = 0;
            int b = 1;
            a += b;
            pirmasis.MetodasA();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            PirmaKlase klase = new PirmaKlase();
            IPirmasisManoInterface inter = klase;
            IManoAntrasisInterface interr = klase;
            IEnumerable<int> duomenys = new int[10];
            duomenys = new List<int>();
        }
    }
}
