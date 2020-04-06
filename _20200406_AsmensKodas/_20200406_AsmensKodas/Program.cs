using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200406_AsmensKodas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] visisDuomenys = NuskaitytiDuomenis();
            int[] vyriausiasVyras = new int[4] { int.MaxValue, int.MaxValue , int.MaxValue , int.MaxValue };
            int[] vyriausiasMoteris = new int[4] { int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue };
            for (int i = 0; i < visisDuomenys.Length; i++)
            {
                if (!string.IsNullOrEmpty(visisDuomenys[i]))
                {

                    var elementai = visisDuomenys[i].ToCharArray();
                    if (elementai[0] == '3' || elementai[0] == '5')
                    {
                        var kandidata = SuformuotiMasyva(elementai);
                        for (int j = 0; j < kandidata.Length; j++)
                        {
                            if (kandidata[j] < vyriausiasVyras[j])
                            {
                                vyriausiasVyras = kandidata;

                            }
                            else if (kandidata[j] != vyriausiasVyras[j])
                            {
                                break;
                            }

                        }
                    }
                    else
                    {
                        var kandidata = SuformuotiMasyva(elementai);
                        for (int j = 0; j < kandidata.Length; j++)
                        {
                            if (kandidata[j] < vyriausiasMoteris[j])
                            {
                                vyriausiasMoteris = kandidata;

                            }
                            else if (kandidata[j] != vyriausiasMoteris[j])
                            {
                                break;
                            }

                        }
                    }
                }
            }
            Console.WriteLine("Vyriausia moteris gime: {0}m. {1} {2}", vyriausiasMoteris[0], vyriausiasMoteris[1], vyriausiasMoteris[2]);
            Console.WriteLine("Vyriausias vyras gime: {0}m. {1} {2}", vyriausiasVyras[0], vyriausiasVyras[1], vyriausiasVyras[2]);
        }

        private static int[] SuformuotiMasyva(char[] data)
        {
            int[] suformuotasMasyvas = new int[4];
            if (data[0] == '3' || data[0] == '4')
            {
                suformuotasMasyvas[0] = Convert.ToInt32("19" + data[1] + data[2]);
            }
            else
            {
                suformuotasMasyvas[0] = Convert.ToInt32("20" + data[1] + data[2]);
            }

            suformuotasMasyvas[1] = Convert.ToInt32("" + data[3] + data[4]);
            suformuotasMasyvas[2] = Convert.ToInt32("" + data[5] + data[6]);
            suformuotasMasyvas[3] = Convert.ToInt32("" + data[7] + data[8] + data[9] + data[10]);

            return suformuotasMasyvas;
        }

        private static string[] NuskaitytiDuomenis()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("Kodai.txt");
            string line = null;
            string alllData = "";
            while ((line = reader.ReadLine())!= null)
            {
                alllData += line + "|";
            }
            return alllData.Split('|');
        }
    }
}
