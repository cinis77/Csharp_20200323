using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200421_UnitTest
{
    public class Klientas
    {
        public bool YraAdministratorius { get; }

        public Klientas(bool administratorius)
        {
            YraAdministratorius = administratorius;
        }
    }

    public class Rezervacija
    {
        public Klientas Uzsakytojas { get; }

        public Rezervacija(Klientas rezervuotojas)
        {
            Uzsakytojas = rezervuotojas;
        }

        public bool AtsauktiRezervacija(Klientas atsaukejas)
        {
            if (atsaukejas.YraAdministratorius)
            {
                return true;
            }
            else if (atsaukejas == Uzsakytojas)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
