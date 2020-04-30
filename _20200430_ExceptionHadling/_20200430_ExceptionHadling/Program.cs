using KlaiduBiblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200430_ExceptionHadling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SkaiciuDarboKlase darboKlase = new SkaiciuDarboKlase();

                int skaicius = darboKlase.GrandParent(2);
                Console.WriteLine(skaicius);
                int? skaiciia = null; //
                Console.WriteLine(darboKlase.GrandParent(-1));
                Console.WriteLine("Programa baige darba");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Programa po visu klaidos pranesimu");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Perduotas null");
            }
            catch(SavoException ex)
            {
                Console.WriteLine(ex.KodoDalisKuriIskvieteKlaida);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Nenumatyta klaida " + ex.Message);
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.StackTrace);
            }


           
        }

    }
}
