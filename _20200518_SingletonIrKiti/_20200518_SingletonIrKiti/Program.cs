using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200518_SingletonIrKiti
{
    class SingletonKlasesPavyzdys
    {
        private SingletonKlasesPavyzdys()
        {

        }

        public static void ManoSingleTonKlasePirma()
        {
            Console.WriteLine("Iskviesta klase");
        }

        public static void ManSing(int sk)
        {
            Console.WriteLine(sk);
        }
    }

    interface IUzklausa
    {
        void Uzklausti();
    }

    class TikrasisUzklausejas: IUzklausa
    {
        public void Uzklausti()
        {
            Console.WriteLine("Uzklausa ivykdo tikrasis uzklausejas");
        }
    }

    class ProxyUzklausejas : IUzklausa
    {
        private Lazy<TikrasisUzklausejas> _Tikrasis = new Lazy<TikrasisUzklausejas>();
        
        public void Uzklausti()
        {
            _Tikrasis.Value.Uzklausti();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IUzklausa uzklausa = new ProxyUzklausejas();
            uzklausa.Uzklausti();

        }
    }
}
