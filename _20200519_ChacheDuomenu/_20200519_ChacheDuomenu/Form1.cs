using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200519_ChacheDuomenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void CreateFormStart(Form log)
        {

            foreach (Control item in Controls)
            {
                if (item is CheckBox)
                {
                    if (((CheckBox)item).CheckState != CheckState.Indeterminate)
                    {

                    }
                }
            }

            log.TopLevel = false;
            log.Dock = DockStyle.Fill;
            log.FormBorderStyle = FormBorderStyle.None;
            InformacijosRodymas.Controls.Add(log);
            log.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("prisijungimo.chache"))
            {
                CreateFormStart(new LogedInUser());
            }
            else
            {
                CreateFormStart(new LogIn(SuccessFullLogIn));
            }
           
        }


        private void SuccessFullLogIn()
        {
            CreateFormStart(new LogedInUser());
        }
    }
}
