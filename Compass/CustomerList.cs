using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Compass
{
    public partial class CustomerList : Form
    {
        compassdbEntities DB;
      
        public CustomerList()
        {
            InitializeComponent();
            bindgrid();
        }

        private void bindgrid()
        {
            DB = new compassdbEntities();
            var item = DB.Customer.ToList();
            dataGridView1.DataSource = item;

            dataGridView1.Columns["Total"].DefaultCellStyle
           .Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Commission"].DefaultCellStyle
              .Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["TicketFee"].DefaultCellStyle
              .Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Tax"].DefaultCellStyle
              .Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
         {
          
     

        }
    }
}
