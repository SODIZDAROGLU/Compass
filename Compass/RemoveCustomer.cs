using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Compass
{
    public partial class RemoveCustomer : Form
    {
        compassdbEntities DB;
        BindingList<Customer> BL;
        SqlConnection con = new SqlConnection("server = .\\sqlexpress;database = compassdb;integrated security=True");
       
        public RemoveCustomer()
        {
            InitializeComponent();
            autoCompleteFirstName();
            autoCompleteLastName();
        }

      

        private void autoCompleteFirstName()
        {
            textFname.AutoCompleteMode = AutoCompleteMode.Suggest;
            textFname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select FirstName FROM Customer", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Collection.Add(rd.GetString(0));
            }
            con.Close();
            textFname.AutoCompleteCustomSource = Collection;
        }

        private void autoCompleteLastName()
        {
            textLname.AutoCompleteMode = AutoCompleteMode.Suggest;
            textLname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select LastName FROM Customer", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Collection.Add(rd.GetString(0));
            }
            con.Close();
            textLname.AutoCompleteCustomSource = Collection;
        }

      

        private void buttonSearchFname_Click(object sender, EventArgs e)
        {
            BL = new BindingList<Customer>();
            DB = new compassdbEntities();
           
            var item = DB.Customer.Where(a => a.FirstName == textFname.Text );
         
            foreach (var i in item)
            {
                BL.Add(i);
            }
            dataGridView1.DataSource = BL;
            dataGridView1.Columns["Total"].DefaultCellStyle
            .Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Commission"].DefaultCellStyle
              .Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["TicketFee"].DefaultCellStyle
              .Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Tax"].DefaultCellStyle
              .Alignment = DataGridViewContentAlignment.MiddleRight;
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
              
                DB = new compassdbEntities();
                var cid = Convert.ToInt32(labelID.Text);
                Customer deleteCustomer = DB.Customer.First(a => a.CustomerID.Equals(cid));
                DB.Customer.Remove(deleteCustomer);
               
                DB.SaveChanges();
                MessageBox.Show("Customer Removed");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DB = new compassdbEntities();
            var cid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var person = DB.Customer.First(a => a.CustomerID == cid);
            labelID.Text = person.CustomerID.ToString();

        }

        private void buttonSearchLname_Click_1(object sender, EventArgs e)
        {
            BL = new BindingList<Customer>();
            DB = new compassdbEntities();

            var item = DB.Customer.Where(a => a.LastName == textLname.Text);
            foreach (var i in item)
            {
                BL.Add(i);
            }
            dataGridView1.DataSource = BL;
            dataGridView1.Columns["Total"].DefaultCellStyle
            .Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Commission"].DefaultCellStyle
              .Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["TicketFee"].DefaultCellStyle
              .Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Tax"].DefaultCellStyle
              .Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void buttonSearchLname_Click(object sender, EventArgs e)
        {
           
        }
        private void buttonSearchID_Click(object sender, EventArgs e)
        {

        }
        private void RemoveCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
