using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200406_Miestai
{
    class Program
    {
        static void Main(string[] args)
        {
            var duomenys = NusiskaitytiMiestusIsFailo();
            string[] miestai = new string[duomenys.Length];
            string[] salys = new string[duomenys.Length];
            AtskirtiMiestusNuoSaliu(duomenys, out miestai, out salys);
            string[] SalysAtsakymas = new string[1];
            int[] MiestuKiekis = new int[1];
            GautiAtsakyma(salys, out SalysAtsakymas, out MiestuKiekis);
            for (int i = 0; i < SalysAtsakymas.Length; i++)
            {
                Console.WriteLine("Salyje {0} faile miestu buvo: {1}", SalysAtsakymas[i], MiestuKiekis[i]);
            }

        }

        private static void GautiAtsakyma(string[] salys, out string[] SalysPo, out int[] miestuSkaicius )
        {
            SalysPo = new string[1] { salys[0] };
            miestuSkaicius = new int[1] { 1 };
            for (int i = 1; i < salys.Length; i++)
            {
                bool NaujaSalis = true;
                for (int j = 0; j < SalysPo.Length; j++)
                {
                    if (SalysPo[j] == salys[i])
                    {
                        miestuSkaicius[j]++;
                        NaujaSalis = false;
                        break;
                    }
                }

                if (NaujaSalis)
                {
                    string laikinasKintamasis = "";
                    string laikinasKintamasisSkaiciams = "";
                    for (int j = 0; j < SalysPo.Length; j++)
                    {
                        laikinasKintamasis += SalysPo[j] + " ";
                        laikinasKintamasisSkaiciams += miestuSkaicius[j] + " ";
                    }
                    laikinasKintamasis += salys[i];
                    laikinasKintamasisSkaiciams += "1";
                    SalysPo = laikinasKintamasis.Split(' ');
                    miestuSkaicius = new int[SalysPo.Length];
                    var duomenys = laikinasKintamasisSkaiciams.Split(' ');
                    for (int j = 0; j < miestuSkaicius.Length; j++)
                    {
                        miestuSkaicius[j] = Convert.ToInt32(duomenys[j]);
                    }
                }
            }
        }

        private static void AtskirtiMiestusNuoSaliu(string[] visiDuomenys, out string[] Miestai, out string[] Salys)
        {
            Miestai = new string[visiDuomenys.Length];
            Salys = new string[visiDuomenys.Length];
            for (int i = 0; i < visiDuomenys.Length; i++)
            {
                var AtskirtiDuomenys = visiDuomenys[i].Split(' ');
                Miestai[i] = AtskirtiDuomenys[1];
                Salys[i] = AtskirtiDuomenys[0];
            }
        }

        private static string[] NusiskaitytiMiestusIsFailo()
        {

            System.IO.StreamReader reader = new System.IO.StreamReader("Miestai.txt");
        
            int kiekis = Convert.ToInt32(reader.ReadLine());
            string[] visiMiestaiSuSalimis = new string[kiekis];
            for (int i = 0; i < kiekis; i++)
            {
                visiMiestaiSuSalimis[i] = reader.ReadLine();
            }
            return visiMiestaiSuSalimis;
        }
    }
}
