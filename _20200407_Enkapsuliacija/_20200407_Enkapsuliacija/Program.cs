using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200407_Enkapsuliacija
{
    class PavyzdysEnkapsuliacijos
    {
        private int Kintamasis1;
        private int Kintamasis2 { get; }
        private string _Kintamsis3;
        public string Kintamasis3
        {
            get
            {
                Metodas();
                return _Kintamsis3;
            }
            set
            {
                if (value != _Kintamsis3)
                {
                    _Kintamsis3 = value;
                    Metodas();
                }
            }

        }

        public int Kintamasis4 { get; private set; }

        public string Kint;

        private void Metodas()
        {
            Kintamasis4 = 4;
        }

        public int GetKintamasis1()
        {
            return Kintamasis1;
        }

        public void SetKintamsis1(int kintamsis1)
        {
            Kintamasis1 = kintamsis1;
        }

        public void MetodasA()
        {

        }

        public void MetodasA(int skaicius)
        {

        }

        /// <summary>
        /// Tuscias konstruktorius
        /// </summary>
        public PavyzdysEnkapsuliacijos()
        {

        }

        /// <summary>
        /// Pirmas konstruktorius
        /// </summary>
        /// <param name="elementas">Pirmas parametras</param>
        public PavyzdysEnkapsuliacijos(int elementas)
        {

        }

        /// <summary>
        /// Antras konstruktorius
        /// </summary>
        /// <param name="el">pirmas elementas</param>
        /// <param name="kintamojo">antras elementas</param>
        public PavyzdysEnkapsuliacijos(int el, string kintamojo)
        {

        }

        public PavyzdysEnkapsuliacijos(string a, int b)
        {

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            PavyzdysEnkapsuliacijos pav = new PavyzdysEnkapsuliacijos();
            PavyzdysEnkapsuliacijos pavy = new PavyzdysEnkapsuliacijos(8, "zodis");
            pav.Kint += 1;
            pav.MetodasA(8);
   
            pav.Kintamasis3 += 1;
       
        }
    }
}
