using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200407_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vardai = { "Inga", "Petras", "Jonas", "Laima", "Gabriele" };
            List<string> atsitiktinisSarasas = new List<string>();
            Random rng = new Random();
            int n = rng.Next(10, 999999);
            for (int i = 0; i < n; i++)
            {
                atsitiktinisSarasas.Add(vardai[rng.Next(0, vardai.Length)]);
            }

            foreach (var vardas in atsitiktinisSarasas)
            {
                Console.WriteLine(vardas);
            }
        }
    }
}
