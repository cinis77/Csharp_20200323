using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vartotojasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vartotojasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.duombazeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duombazeDataSet.Vartotojas' table. You can move, or remove it, as needed.
            this.vartotojasTableAdapter.Fill(this.duombazeDataSet.Vartotojas);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vartotojasTableAdapter.FillBy(this.duombazeDataSet.Vartotojas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void grazintiAtgalToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vartotojasTableAdapter.GrazintiAtgal(this.duombazeDataSet.Vartotojas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vartotojasTableAdapter.FillBy1(this.duombazeDataSet.Vartotojas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vartotojasTableAdapter.FillBy2(this.duombazeDataSet.Vartotojas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
