using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200504_ZmonesUzklausuRasymas
{
    class Zmogus
    {
        public int Amzius { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Zmogus> zmones = new List<Zmogus>()
            {
                new Zmogus(){Amzius=12, Vardas="Vita", Pavarde="Oryte"},
                new Zmogus(){Amzius=29, Vardas="Robertas", Pavarde="Robertas"},
                new Zmogus(){Amzius=56, Vardas="Gintare", Pavarde="Gint"},
                new Zmogus(){Amzius=87, Vardas="Osvaldas", Pavarde="GR"},
                new Zmogus(){Amzius=58, Vardas="Lina"}
            };

            var vyriausias = zmones.Where(x=> x.Amzius == zmones.Max(y=> y.Amzius))
                .ToList().First();
            var surikiuotiDuomenys = zmones.OrderBy(x => x.Amzius);
            var pagalPavardeSurikiuotiDuomenys = zmones.OrderBy(x => x.Pavarde);
            var atrinkimas = zmones.Where(x =>
            {
                Console.WriteLine("Debug: " + x.Vardas);
                return x.Amzius > 20 && x.Amzius < 80;
            }).ToList();
            Console.WriteLine("Vyriausias zmogus yra: " + vyriausias.Vardas);
            foreach (var item in pagalPavardeSurikiuotiDuomenys)
            {
                Console.WriteLine("{0}, {1}, {2}", item.Vardas, item.Pavarde, item.Amzius);
            }

            
        }

        
    }
}
