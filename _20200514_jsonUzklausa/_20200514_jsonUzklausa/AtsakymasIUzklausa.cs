using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200514_jsonUzklausa
{
    class AtsakymasIUzklausa
    {
       public Knygos[] docs { get; set; }
    }

    class Knygos
    {
        public string _id { get; set; }
        public string name { get; set; }
    }
    //"height":"","race":"Human","gender":"Male","birth":"SA 192","spouse":"Unnamed wife","death":"SA 603","realm":"N?menor","hair":"","name":"Tar-Amandil"
    class VeikejoAtsakymas
    {
        public Veikejas[] docs { get; set; }
    }

    class Veikejas
    {
        public string height { get; set; }
        public string race { get; set; }
        public string gender { get; set; }
        public string birth { get; set; }
        public string spouse { get; set; }
        public string death { get; set; }
        public string realm { get; set; }
        public string hair { get; set; }
        public string name { get; set; }
    }

}
