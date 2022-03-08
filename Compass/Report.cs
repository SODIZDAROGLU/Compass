using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compass
{
    public partial class Report : Form
    {
        compassdbEntities DB;
        public Report()
        {
            InitializeComponent();
        }

        private void buttonSearchByDate_Click(object sender, EventArgs e)
        {
            DB = new compassdbEntities();
            List<Customer> list = new List<Customer>();
            list = DB.Customer.Where(x => x.RecordDate > dateTimePicker1.Value && x.RecordDate < dateTimePicker2.Value).ToList();
            dataGridView1.DataSource = list;
            dataGridView1.Columns["Total"].DefaultCellStyle
                .Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Commission"].DefaultCellStyle
              .Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["TicketFee"].DefaultCellStyle
              .Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Tax"].DefaultCellStyle
              .Alignment = DataGridViewContentAlignment.MiddleRight;
            total();
            counter();
        }
        private void counter()
        {
            int counter = dataGridView1.Rows.Count;
            labelCountResult.Text = Convert.ToString(counter);
        }

        private void total()
        {
            int counter = dataGridView1.Rows.Count;
            decimal sumTotal = 0;
            decimal sumCommission = 0;
            for (int i = 0; i < counter; i++)
            {

                sumTotal += Convert.ToDecimal(dataGridView1.Rows[i].Cells["Total"].Value);
                sumCommission += Convert.ToDecimal(dataGridView1.Rows[i].Cells["Commission"].Value);

            }
                labelTotalResult.Text = Convert.ToString(sumTotal);
                labelTotalCommissionResult.Text = Convert.ToString(sumCommission);
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
