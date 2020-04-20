using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200416_Klientai
{
    class Vartotojai
    {
        public virtual double Susimokejimas(double suma)
        {
            return suma;
        }
    }

    class VIP : Vartotojai
    {
        public override double Susimokejimas(double suma)
        {
            return suma * 0.7;
        }
    }

    class Silver: Vartotojai
    {
        public override double Susimokejimas(double suma)
        {
            return suma * 0.9;
        }
    }

    class Basic :Vartotojai
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Vartotojai> vart = new List<Vartotojai>();
            vart.Add(new VIP());
            vart.Add(new Silver());
            vart.Add(new Basic());

            foreach (var item in vart)
            {
                Console.WriteLine(item.Susimokejimas(100));
            }
        }
    }
}
