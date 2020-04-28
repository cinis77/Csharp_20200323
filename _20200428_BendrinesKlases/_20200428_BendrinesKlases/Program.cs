using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200428_BendrinesKlases
{
    class Sarasas <T>
    {
        public T[] Masyvas;

        public T PirmasElementas()
        {
            return Masyvas[0];
        }

        public void GautiKintamaji(T kintamasis)
        {

        }

        public void Add(T elementa)
        {
            T[] laikinaiIssisaugoit = Masyvas;
            Masyvas = new T[Masyvas.Length + 1];
        }
    }

    class Zodynelis<T, K>
    {

    }


    class ManoKlase
    {
        public readonly List<int> Skaiciai;

        public int MyProperty { get;}

        public ManoKlase()
        {
            Skaiciai = new List<int>();
        }


        public void Metodas()
        {
            
        }
    }


    class Program
    {




        static void Main(string[] args)
        {
            List<int> sarasas = new List<int>();
            List<string> sar = new List<string>();
            List<List<List<int>>> vs = new List<List<List<int>>>();

            int sk;

            List<int> A = new List<int> { 0, 1, 2, 3 };
            List<int> B = new List<int>();
                            
                B = A;

            ManoKlase klase = new ManoKlase();
          
            klase.Skaiciai.Clear();
            Dictionary<int, List<int>> dicti = new Dictionary<int, List<int>>();

            Dictionary<string, string> zodynelis = new Dictionary<string, string>();
            zodynelis.Add("Labas", "Hello");
            zodynelis.Add("Aciu", "Thank you");

            var sara = zodynelis.Keys.ToList();

            foreach (var item in zodynelis)
            {
                if (item.Value == "Thank you")
                {
                    Console.WriteLine(item.Key);
                }
            }
            Console.WriteLine(zodynelis["Labas"]);
            Console.WriteLine(zodynelis["Aciu"]);


            B.Add(5);

            dicti.Add(0, A);

            A = new List<int>();


           string dd = "a";
         }
    }
}
