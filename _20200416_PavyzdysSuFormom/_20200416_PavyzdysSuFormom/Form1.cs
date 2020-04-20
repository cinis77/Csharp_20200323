using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200416_PavyzdysSuFormom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button mygtukas = new Button();
            mygtukas.Text = "Mano sukurtas mygtukas";
            mygtukas.Width = 150;
            mygtukas.Height = 100;
            mygtukas.Location = new Point(20, 20);
            Controls.Add(mygtukas);

            TextBox textas = new TextBox();
            textas.Width = 100;
            textas.Location = new Point(20, 150);

            Controls.Add(textas);
        }

        private void Mygtukas_Click(object sender, EventArgs e)
        {
            var elementas = (Button)sender;
            elementas.BackColor = Color.Red;
            foreach (Control item in Controls)
            {
                if (item is Label)
                {
                    if (item.Name == "label1")
                    {
                        ((Label)item).Text = "Pakeistas tekstas";
                    }
                }
            }
        }
    }
}
