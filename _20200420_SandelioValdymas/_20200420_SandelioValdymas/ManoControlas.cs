using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200420_SandelioValdymas
{
    class ManoControlas : System.Windows.Forms.TextBox
    {
        public string ManoElementas { get; set; }

        public ManoControlas()
        {
            
        }
        public void Metodas()
        {
            BackColor = System.Drawing.Color.Green;
            
        }
        
    }
}
