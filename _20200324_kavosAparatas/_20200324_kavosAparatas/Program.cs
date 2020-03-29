using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200324_kavosAparatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KAVOS APARATAS");
            Console.WriteLine("Galimi pasirinkimai:");
            Console.WriteLine("1-limonadas");
            Console.WriteLine("2-arbata");
            Console.WriteLine("3-kakava");
            Console.WriteLine("4-kava");
            Console.WriteLine("5-nieko");
            Console.Write("Jūsų pasirinkimas: ");
            string pasirinkimas = Console.ReadLine();

            switch (pasirinkimas)
            {
                case "1":
                    Console.WriteLine("Jus pasirinkote limonada");
                    break;
                case "2":
                    Console.WriteLine("Jus pasirinkote arbata");
                    break;
                case "3":
                    Console.WriteLine("Jus pasirinkote kakavą");
                    break;
                case "4":
                    Console.WriteLine("Jus pasirinkote kava");
                    break;
                case "5":
                    Console.WriteLine("Jus pasirinkote nieko");
                    break;
                default:
                    Console.WriteLine("Blogas pasirinkimas");
                    break;
            }
        }
    }
}
