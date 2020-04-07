namespace _20200407_InventoriausPrograma
{
    class Preke
    {
        public int Id { get;  }
        public string Pavadinimas { get; set; }
        public double Kaina { get; set; }
        public int Kiekis { get; set; }

        public Preke(int id, string pav, double kaina, int kiekis)
        {
            Id = id;
            Pavadinimas = pav;
            Kaina = kaina;
            Kiekis = kiekis;
        }
    }
}
