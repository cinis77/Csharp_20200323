using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace _20200512_ProjektasSuDuomenimis
{
    public partial class Form1 : Form
    {

        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\Csharp_20200323\_20200512_ProjektasSuDuomenimis\_20200512_ProjektasSuDuomenimis\RobotDataBase.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Ieskoti_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext(ConnectionString);
            IQueryable<DrawingInDB> element;
            if (Pradzia.Value.Date == Pabaiga.Value.Date)
            {

                element = db.GetTable<DrawingInDB>().
               Where(x => x.Sheet.Uzsakymai.State == "Done" &&
                x.Code == PaieskosTekstas.Text);

            }
            else
            {
                element = db.GetTable<DrawingInDB>().
               Where(x => x.Sheet.Uzsakymai.State == "Done" &&
                  x.Code == PaieskosTekstas.Text &&
                  x.Sheet.Uzsakymai.DeliveryDate > Pradzia.Value.Date
                  && x.Sheet.Uzsakymai.DeliveryDate < Pabaiga.Value.Date);
            }
            var elementas = element.ToList();
            dataGridView1.DataSource = elementas.ToList()
                .Select(x=> new 
                {
                    x.Code,
                    x.Sheet.DoneAmount,
                    x.Sheet.Uzsakymai.DeliveryDate
                });

            SumaVisuGaminiu.Text = element.Sum(x=> x.Sheet.DoneAmount).ToString();
        }
    }
}
