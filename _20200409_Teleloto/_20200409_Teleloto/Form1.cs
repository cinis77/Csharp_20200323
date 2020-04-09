using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200409_Teleloto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GeneruotiB_Click(object sender, EventArgs e)
        {
            TextBox[] melyni = { M1, M2, M3, M4, M5 };
            TextBox[] juodi = { J1, J2, J3, J4, J5 };
            TextBox[] raudoni = { R1, R2, R3, R4, R5 };
            TextBox[] geltoni = { G1, G2, G3, G4, G5 };
            TextBox[] zali = { Z1, Z2, Z3, Z4, Z5 };
            GeneruotiStulpeli(melyni, 1, 16);
            GeneruotiStulpeli(juodi, 16, 31);
            GeneruotiStulpeli(raudoni, 31, 46);
            GeneruotiStulpeli(geltoni, 46, 61);
            GeneruotiStulpeli(zali, 61, 76);
        }


        private void GeneruotiStulpeli(TextBox[] masyvas, int a, int b)
        {
            Random rng = new Random();
            int i = 0;
            while (i < 5)
            {
                int kamuoliukas = rng.Next(a, b);
                bool nesikartoja = true;
                foreach (var item in masyvas)
                {
                    if (item.Text == kamuoliukas.ToString())
                    {
                        nesikartoja = false;
                        break;
                    }
                }
                if (nesikartoja)
                {
                    masyvas[i].Text = kamuoliukas.ToString();
                    i++;
                }
            }
        }
    }
}
