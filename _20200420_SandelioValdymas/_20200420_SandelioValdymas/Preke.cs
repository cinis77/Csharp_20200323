using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200420_SandelioValdymas
{
    class Preke
    {
        public int ID { get; }
        public string Pavadinimas { get; }
        public int Kiekis { get; set; }
        public string Lokacija { get; set; }

        public Preke(int id, string pavadinimas)
        {
            ID = id;
            Pavadinimas = pavadinimas;
        }
    }
}
