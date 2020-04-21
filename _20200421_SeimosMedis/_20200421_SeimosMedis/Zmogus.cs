using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200421_SeimosMedis
{
    class Zmogus
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
    }

    class Vaikas : Zmogus
    {
        public Zmogus Mama { get; set; }
        public Zmogus Tevas { get; set; }
    }
}
