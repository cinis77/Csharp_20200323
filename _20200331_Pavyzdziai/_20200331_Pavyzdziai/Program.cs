using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200331_Pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kuru uzdavini noretumete matyti: ");
            int uzdavinioNr = Convert.ToInt32(Console.ReadLine());
            switch (uzdavinioNr)
            {
                case 1:
                    PirmasUzdavinys();
                    break;
                case 2:
                    AntrasUzdavinys();
                    break;
                case 3:
                    TreciasUzdavinys();
                    break;
                case 4:
                    KetvirtasUzdavinys();
                    break;
                case 5:
                    PenktasUzdavinys();
                    break;
                case 6:
                    SestasUzdavinys();
                    break;
                case 7:
                    SeptintasUzdavinys();
                    break;
                case 8:
                    AstuntasUzdavinys();
                    break;
                default:
                    Console.WriteLine("Tokio uzdavinio nera");
                    break;
            }
        }

        public static void AstuntasUzdavinys()
        {
            double benzKaina = 2500;
            double dyzKaina = 3200;
            double benz = 0;
            double dyz = 0;
            double nuvaziuojaPerMetus = 18000;
            SkaitymasIsFailo(out benz, out dyz);
            double KainaBenz = benzKaina + benz * ((nuvaziuojaPerMetus / 100) * 2);
            double KainaDyz = dyzKaina + dyz * ((nuvaziuojaPerMetus / 100) * 2);
            Console.WriteLine(KainaBenz);
            Console.WriteLine(KainaDyz);
            RasymasIFaila(KainaBenz, KainaDyz);
        }

        private static void RasymasIFaila(double benz, double dyz)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter("Rez.txt");
            writer.WriteLine("Benzinio automobilio kaina: " + benz);
            writer.WriteLine("Dyzelinio automobilio kaina: " + dyz);
            if (benz > dyz)
            {
                writer.WriteLine("Labiau apsimoka pirkti dyzelini automobili");
            }
            else
            {
                writer.WriteLine("Labiau apsimoka pirkti benzinini automobili");
            }
            writer.Flush();
            writer.Close();
            writer.Dispose();
        }

        private static void SkaitymasIsFailo(out double benzininis, out double dyzelino)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("Duomenys.txt");
            string benzinoSanaudos = reader.ReadLine();
            string dyzelinoSanaudos = reader.ReadLine();
            reader.Close();
            reader.Dispose();
            benzininis = Convert.ToDouble(benzinoSanaudos);
            dyzelino = Convert.ToDouble(dyzelinoSanaudos);
        }

        public static void SeptintasUzdavinys()
        {
            Console.WriteLine("Iveskite pradzia");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pabaiga");
            int n = Convert.ToInt32(Console.ReadLine());
            int kiekisLaimingu = 0;
            if (m < n)
            {
                for (int i = m; i <= n; i++)
                {
                    if (i == SkaiciusAtbulai(i))
                    {
                        kiekisLaimingu++;
                    }
                }
            }
            else
            {
                for (int i = m; i >= n; i--)
                {
                    if (i == SkaiciusAtbulai(i))
                    {
                        kiekisLaimingu++;
                    }
                }
            }
            Console.WriteLine("Laimingu bilietu kiekis yra: " + kiekisLaimingu);
        }

        public static void SestasUzdavinys()
        {
            for (int i = 2; i <= 1000; i++)
            {
                if (ArPirminis(i))
                {
                    if (ArPirminis(SkaiciusAtbulai(i)))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        private static bool ArPirminis(int skaiciu)
        {
            bool pirminis = true;

            for (int i = 2; i < skaiciu; i++)
            {
                if (skaiciu % i ==0)
                {
                    pirminis = false;
                    break;
                }
            }

            return pirminis;
        }

        private static int SkaiciusAtbulai(int skaicius)
        {
            string skaiciukas = "";
            while (skaicius > 0)
            {
                skaiciukas += (skaicius % 10);
                skaicius /= 10;
                // "5" + "5" = "55"
            }

            return Convert.ToInt32(skaiciukas);
        }

        public static void PenktasUzdavinys()
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int kelintas = 0;
            int sandauga = 1;
            while (skaicius > sandauga)
            {
                kelintas++;
                sandauga *= kelintas;
                if (sandauga == skaicius)
                {
                    Console.WriteLine("Fakotrialas {0}!", kelintas);
                }
            }
        }
        
        public static void KetvirtasUzdavinys()
        {
            int sumaPazymiu = 0;
            int kiekisPazymiu = 0;
            int IrasytasPazimys = 0;
            do
            {
                Console.WriteLine("Iveskite pazymi");
                IrasytasPazimys = Convert.ToInt32(Console.ReadLine());
                if (IrasytasPazimys > 0)
                {
                    sumaPazymiu += IrasytasPazimys;
                    kiekisPazymiu++;
                }
            } while (IrasytasPazimys !=0);

            Console.WriteLine("Vidurkis yra: " + (double)sumaPazymiu/kiekisPazymiu);
        }

        public static void TreciasUzdavinys()
        {
            Console.WriteLine("Iveskite perkamo mobilaus telefono kaina");
            double telefonoKaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite palukanu norma");
            double palukanuNorma = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Issimokejimo laikotarpis");
            int laikotarpis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite sutarties mokestis");
            double sutartiesMokestis = Convert.ToDouble(Console.ReadLine());
            double pabrandimas = sutartiesMokestis;
            double sumokamaSuma = telefonoKaina / laikotarpis;
            for (int i = 0; i < laikotarpis; i++)
            {
                pabrandimas += (telefonoKaina - sumokamaSuma * i) * (palukanuNorma/12);
            }

            Console.WriteLine("Isviso sumoketa uz telefona: " + (telefonoKaina+pabrandimas));
            Console.WriteLine("Procentiskai pabrango man: " + ((telefonoKaina+pabrandimas) / telefonoKaina) * 100 + "%");
        }

        public static void AntrasUzdavinys()
        {
            Console.WriteLine("Kiek seima uzsipyle kuro?");
            double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kiek suvartoja degalu per diena automobilis?");
            double n = Convert.ToDouble(Console.ReadLine());
            int diena = 1;
            int kelionesDienos = 0;
            while (t > 0)
            {
                if (diena % 2 == 0 )
                {
                    t -= n;
                }
                else
                {
                    t -= 2 * n;
                }
                diena++;
                kelionesDienos++;
            }
            Console.WriteLine("Seima is viso keliaus {0} dienu", kelionesDienos);
        }

        public static void PirmasUzdavinys()
        {
            Console.WriteLine("Iveskite pradzios skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pabaigos skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            int kiekis = 0;
            if (sk < sk2)
            {
                for (int i = sk; i < sk2; i++)
                {
                    suma += i;
                    kiekis++; 
                }
                Console.WriteLine("Vidurkis yra: " + ((double)suma/kiekis));
            }
            else
            {
                for (int i = sk; i >= sk2; i--)
                {
                    suma += i;
                    kiekis++;
                }
                Console.WriteLine("Vidurkis yra: " + ((double)suma/kiekis));
            }
        }
    }
}
