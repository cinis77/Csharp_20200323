using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _200200505_Ivykiai
{
    public partial class Form1 : Form
    {
        bool PaspaustasPaveiksliukas;
        public Form1()
        {
            InitializeComponent();

            button1.Click += button1_Click;
            button1.Click += button1DarVienas_Click;
        }

        private void PictureboxCreate()
        {
            PaspaustasPaveiksliukas = false;
            PictureBox box = new PictureBox();
            box.Width = 50;
            box.Height = 50;
            box.BackColor = Color.White;
            box.Location = new Point(100, 100);
            box.MouseDown += PictureBox_Click;
            box.MouseUp += Picturebox_MouseUp;
            box.MouseMove += PictureBox_MouseMove;
            box.Paint += (sender, e) =>
            {
                Pen p = new Pen(Color.Red);
                e.Graphics.DrawLine(p, new Point(1, 2), new Point(48, 30));
            };

            Controls.Add(box);
        }

        Point BuvusiPozicija ;
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (PaspaustasPaveiksliukas)
            {
                PictureBox paveiksliukas = (PictureBox)sender;
                Xpozicija.Text = MousePosition.X.ToString() ;
                Ypozicija.Text = MousePosition.Y.ToString();
                paveiksliukas.Location = new Point()
                {
                    X = paveiksliukas.Location.X - (MouseLocation.X - MousePosition.X),
                    Y = paveiksliukas.Location.Y - (MouseLocation.Y - MousePosition.Y)
               };

                MouseLocation =MousePosition;
            }
        }

        Point MouseLocation;
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PaspaustasPaveiksliukas = true;
            PictureBox paspaustasPaveiksliukas = (PictureBox)sender;
            MouseLocation = MousePosition;
            paspaustasPaveiksliukas.BackColor = Color.Green;
        }

        private void Picturebox_MouseUp(object sender, EventArgs e)
        {
            PaspaustasPaveiksliukas = false;
            PictureBox paveiksliukas = (PictureBox)sender;
            paveiksliukas.BackColor = Color.White;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Click -= button1_Click;
            MessageBox.Show("Suveike ivykis");
        }

        private void button1DarVienas_Click(object sender, EventArgs e)
        {
            PictureboxCreate();
        }
    }
}
