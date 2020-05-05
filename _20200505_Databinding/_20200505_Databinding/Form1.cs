using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200505_Databinding
{
    public partial class Form1 : Form
    {
        ViewFormBind bind;
        public Form1()
        {
            InitializeComponent();
            bind = new ViewFormBind();
            textBox1.DataBindings.Add("Text", bind, "Tekstas", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox1.DataBindings.Add("BackColor", bind, "BindColor");
            button1.DataBindings.Add("Text", bind, "Tekstas");

            Form2 form = new Form2(bind);
            form.Show();
        }
    }
}
