using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200409_RegistracijosForma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TelefonasText_TextChanged(object sender, EventArgs e)
        {
            var skaiciai = TelefonasText.Text.ToCharArray();
            foreach (var skaicius in skaiciai)
            {
                if (char.IsLetter(skaicius))
                {
                    MessageBox.Show("Raides negalimo telefono numeryje!!!");
                }
            }
        }

        private void SlaptazodisText_TextChanged(object sender, EventArgs e)
        {
            var elementai = SlaptazodisText.Text.ToCharArray();
            if (elementai.Length < 8)
            {
                SlaptazodzioInfoL.Text = "Slaptazodis per trumpas turi buti 8 simboliai";
                SlaptazodzioInfoL.ForeColor = Color.Red;
            }
            else
            {
                SlaptazodzioInfoL.Text = "Slaptazodis tinkamas";
                SlaptazodzioInfoL.ForeColor = Color.LightGreen;
            }
        }
    }
}
