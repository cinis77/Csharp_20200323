using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200430_ExcPirma
{
    class KlaidomsTikrintiKlase
    {
        public void SkaiciaiStringMasyve(string skaicius)
        {
            int.Parse(skaicius);
        }


        public void ZodisBeSkaiciu(string zodis)
        {
            var elementai = zodis.ToCharArray();
            foreach (var item in elementai)
            {
                if (char.IsDigit(item))
                {
                    throw new ArgumentException("Skaiciai tekste negalimi");
                }
            }
        }

        public void Dalyba(int sk, int sk1)
        {
            if (sk1 == 0)
            {
                throw new DivideByZeroException();
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            KlaidomsTikrintiKlase klase = new KlaidomsTikrintiKlase();
            bool ok = false;
            while (!ok)
            {
                try
                {
                    Console.WriteLine("Iveskite teksta");
                    string tekstas = Console.ReadLine();
                    klase.SkaiciaiStringMasyve(tekstas);
                    ok = true;
                    klase.ZodisBeSkaiciu("asdf2");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Gauta klaida");
                    Console.WriteLine("Skaiciuose yra tekstiniu elementu");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Dalyba iss 0 negalima");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nenumatyta klaida");
                    Console.WriteLine(ex.GetType());
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
