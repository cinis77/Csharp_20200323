using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaiduBiblioteka
{
    public class SavoException : Exception
    {
        public string KodoDalisKuriIskvieteKlaida { get; set; }

        public override string Message => "Mano klaida";
    }



    public class SkaiciuDarboKlase
    {

        public int GrandParent(int kelintas)
        {
            return Parent(kelintas);
        }

        public int Parent(int kelintas)
        {
            return GautiSkaiciu(kelintas);
        }

        private int GautiSkaiciu(int kelintas)
        {
            int[] skaiciai = { 1, 3, 5, 8, 6 };
            if (kelintas < 0)
            {
                throw new SavoException();
            }
            return skaiciai[kelintas];
        }

    }
}
