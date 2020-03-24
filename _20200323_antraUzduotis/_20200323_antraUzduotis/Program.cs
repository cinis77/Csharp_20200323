using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200323_antraUzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite žodį arba tekstą:");
            string tekstas = Console.ReadLine();
            Console.WriteLine("Jūsų įvestas tekstas yra: ");
            Console.WriteLine(tekstas);

            Console.Write("Iveskite sveikąjį skaičių :");
            int skaičius = Convert.ToInt32(Console.ReadLine()); // mes gauname string ->(Convert) int
            Console.WriteLine("Jūsų įvestas skaičius yra: " + skaičius);
        }
    }
}
