using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200324_svarstyklės
{
    class Program
    {
        static void Main(string[] args)
        {
            int k1 = 2;
            int k2 = 2;
            int k3 = 2;
            int k4 = 2;
            int k5 = 2;
            int k6 = 2;
            int k7 = 2;
            int k8 = 1;

            if (k1 + k2 + k3 < k4 + k5 + k6)
            {
                if (k1 < k2)
                {
                    Console.WriteLine("Defektuotas yra pirmas kamuoliukas");
                }
                else if (k1 > k2)
                {
                    Console.WriteLine("Defektuotas yra antras kamuoliukas");
                }
                else
                {
                    Console.WriteLine("Defektuotas yra trečia kamuoliukas");
                }
            }
            else if (k1 + k2 + k3 > k4 + k5 + k6)
            {
                if (k4 < k5)
                {
                    Console.WriteLine("Defektuotas yra ketvirtas kamuoliukas");
                }
                else if (k4 > k5)
                {
                    Console.WriteLine("Defektuotas yra penktas kamuoliukas");
                }
                else
                {
                    Console.WriteLine("Defektuotas yra šeštas kamuoliukas");
                }
            }
            else
            {
                if (k7 < k8)
                {
                    Console.WriteLine("Defektuotas yra septintas kamuoliukas");
                }
                else
                {
                    Console.WriteLine("Defektuotas yra aštuntas kamuoliukas");
                }
            }
        }
    }
}
