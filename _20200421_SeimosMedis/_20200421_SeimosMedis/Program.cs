using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200421_SeimosMedis
{
    class Program
    {
        static void Main(string[] args)
        {
            Zmogus mama = new Zmogus() { Vardas = "MA", Pavarde = "MA" };
            Zmogus tevas = new Zmogus() { Vardas = "Te", Pavarde = "Vas" };
            Vaikas vaikas = new Vaikas() { Vardas = "V", Pavarde = "P", Mama = mama, Tevas = tevas };
            ((Vaikas)mama).Tevas = new Zmogus();
        }
    }
}
