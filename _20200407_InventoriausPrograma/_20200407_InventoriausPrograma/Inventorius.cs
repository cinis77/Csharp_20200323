using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200407_InventoriausPrograma
{
    class Inventorius
    {
        private readonly List<Preke> Prekes;

        public Inventorius()
        {
            Prekes = new List<Preke>();
        }

        public void PridetiPreke(Preke preke)
        {
            Prekes.Add(preke);
        }

        public void IsimtiPreke(int id)
        {
            // kai nenaudoju konstruktoriaus mano objekto reiksme yra null
            Preke pr = null;
            foreach (var item in Prekes)
            {
                if (item.Id == id)
                {
                    pr = item;
                    break;
                }
            }

            if (pr != null)
            {
                Prekes.Remove(pr);
            }
        }

        public void IsimtiPreke(string pavadinimas)
        {
            Preke pr = null;
            foreach (var item in Prekes)
            {
                if (item.Pavadinimas == pavadinimas)
                {
                    pr = item;
                    break;
                }
            }
            if (pr != null)
            {
                Prekes.Remove(pr);
            }
        }

        public void SumazintiKieki(string pavadinima, int sumazinamasKiekis)
        {
            foreach (var item in Prekes)
            {
                if (item.Pavadinimas == pavadinima)
                {
                    item.Kiekis -= sumazinamasKiekis;
                    break;
                }
            }
        }

        public void PadidinamasKiekis(string pavadinima, int padidinamasKiekis)
        {
            foreach (var item in Prekes)
            {
                if (item.Pavadinimas == pavadinima)
                {
                    item.Kiekis += padidinamasKiekis;
                    break;
                }
            }
        }
    }
}
