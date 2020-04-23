using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200423_MockStud
{
    public class DuomenuNuskaitymas : IDuomenuNuskaitymas
    {

        public string ReadDataString()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("duomenuBase.txt");
            return reader.ReadLine();
        }
    }

    public class Komunikacija : IKomunikacija
    {
        public bool SiustiDuomenis(string zinute)
        {
            Console.WriteLine("ZinutePateikiama");
            Console.WriteLine(zinute);
            if (Handshake() == zinute)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private string Handshake()
        {
            return "";
        }
    }

    public class ZinutesParuosimas
    {
        IKomunikacija Coms;
        IDuomenuNuskaitymas Skaitymas;

        public ZinutesParuosimas( IKomunikacija komunikacija, IDuomenuNuskaitymas duomenys)
        {
            Coms = komunikacija;
            Skaitymas = duomenys;
        }

        public void  PradetiDuomenuSiuntima()
        {
            var duomenys = Skaitymas.ReadDataString();
            string zinute = "";
            if (duomenys.ToCharArray().Count() >  256)
            {
                var pirmasDuomuo = "";
                for (int i = 0; i < 255; i++)
                {
                    pirmasDuomuo += duomenys.ToCharArray()[i].ToString();
                }
                zinute = "<Message><Body " + pirmasDuomuo + @"/></Message>";
                pirmasDuomuo = "";
                for (int i = 256; i < duomenys.ToCharArray().Length; i++)
                {
                    pirmasDuomuo += duomenys.ToCharArray()[i].ToString();
                }
                zinute += "<Message><Body " + pirmasDuomuo + @"/></Message>";
            }
            else
            {
                zinute = "<Message><Body " + duomenys + @"/></Message>";
            }

            Coms.SiustiDuomenis(zinute);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
