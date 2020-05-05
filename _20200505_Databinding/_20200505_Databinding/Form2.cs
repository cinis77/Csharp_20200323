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
    public partial class Form2 : Form
    {
        public Form2(ViewFormBind bind)
        {
            InitializeComponent();

            label1.DataBindings.Add("Text", bind, "Tekstas");
        }
    }
}
