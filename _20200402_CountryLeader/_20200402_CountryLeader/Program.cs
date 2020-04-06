using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200402_CountryLeader
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string kel = GrazinsFailoKelia();
            System.IO.StreamReader reader = new System.IO.StreamReader(kel);
            int T = Convert.ToInt32(reader.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int N = Convert.ToInt32(reader.ReadLine());
                string[] kandidatai = new string[N];
                for (int j = 0; j < kandidatai.Length; j++)
                {
                    kandidatai[j] = reader.ReadLine();
                }
                int max = 0;
                int idLaimetojo = 0;
                for (int j = 0; j < kandidatai.Length; j++)
                {
                    char[] raides = kandidatai[j].ToUpper().ToCharArray();
                    int kandidatoUnikalios = KiekisUnikaliuRaidziu(raides);
                    if (max < kandidatoUnikalios)
                    {
                        max = kandidatoUnikalios;
                        idLaimetojo = j;
                    }
                }

                
                Console.WriteLine("Laimetojas yra: " + kandidatai[idLaimetojo]);
            }
           
        }

        private static int KiekisUnikaliuRaidziu(char[] raides)
        {
            int kiekis = 0;
            for (int i = 0; i < raides.Length; i++)
            {
                bool unikaliRaide = true;
                for (int j = i + 1; j < raides.Length; j++)
                {
                    if (raides[i] == raides[j])
                    {
                        unikaliRaide = false;
                        break;
                    }
                }
                if (unikaliRaide)
                {
                    kiekis++;
                }
            }
            return kiekis;
        }

        private static string GrazinsFailoKelia()
        {
            string kelias = null;

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                kelias = ofd.FileName;
            }
            ofd.Dispose();
            return kelias;
        }
    }
}
