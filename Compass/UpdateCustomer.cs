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
    public partial class UpdateCustomer : Form
    {
        
        compassdbEntities DB;
        BindingList<Customer> BL;
        SqlConnection con = new SqlConnection("server = .\\sqlexpress;database = compassdb;integrated security=True");

        public UpdateCustomer()
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

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
        }
          

         

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DB = new compassdbEntities();
            var cid = Convert.ToInt32(textCustomerID.Text);
            Customer updateCustomer = DB.Customer.First(a => a.CustomerID.Equals(cid));

            updateCustomer.CustomerID = cid;
            updateCustomer.FirstName = textFname.Text;
            updateCustomer.LastName = textLname.Text;
            updateCustomer.PhoneNumber = textPhone.Text;
            updateCustomer.Booking = textBooking.Text;
            updateCustomer.Passport = textPassport.Text;
            updateCustomer.TicketNumber = textTicket.Text;
            updateCustomer.TicketFee = (!String.IsNullOrEmpty(textTfee.Text)) ? Convert.ToDecimal(textTfee.Text) : 0.00m;
            updateCustomer.Tax = (!String.IsNullOrEmpty(textTax.Text)) ? Convert.ToDecimal(textTax.Text) : 0.00m;
            updateCustomer.Commission = (!String.IsNullOrEmpty(textCommission.Text)) ? Convert.ToDecimal(textCommission.Text) : 0.00m;
            updateCustomer.Total = (!String.IsNullOrEmpty(textTotal.Text)) ? Convert.ToDecimal(textTotal.Text) : 0.00m;
            updateCustomer.Note = richTextBox1.Text;
            updateCustomer.RecordDate = dateTimePicker1.Value;

            DB.SaveChanges();
            BL = new BindingList<Customer>();
            DB = new compassdbEntities();
            var item = DB.Customer.Where(a => a.CustomerID == cid);
            foreach (var i in item)
            {
                BL.Add(i);
            }
            dataGridView1.DataSource = BL;
            MessageBox.Show("UPDATED");
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DB = new compassdbEntities();
            var cid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var person = DB.Customer.Where(a => a.CustomerID == cid).FirstOrDefault();

            textCustomerID.Text = person.CustomerID.ToString();
            textFname.Text = person.FirstName;
            textLname.Text = person.LastName;
            textPhone.Text = PhoneNumber(person.PhoneNumber);
            textBooking.Text = person.Booking;
            textPassport.Text = person.Passport;
            textTicket.Text = person.TicketNumber;
            textTfee.Text = Convert.ToString(person.TicketFee);
            textTax.Text = Convert.ToString(person.Tax);
            textCommission.Text = Convert.ToString(person.Commission);
            textTotal.Text = Convert.ToString(person.Total);
            richTextBox1.Text = person.Note;
            dateTimePicker1.Text = person.RecordDate.Value.ToString();
        }

        public static string PhoneNumber(string value)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;
            value = new System.Text.RegularExpressions.Regex(@"\D")
                .Replace(value, string.Empty);
            value = value.TrimStart('1');
            if (value.Length == 7)
                return Convert.ToInt64(value).ToString("###-####");
            if (value.Length == 10)
                return Convert.ToInt64(value).ToString("###-###-####");
            if (value.Length > 10)
                return Convert.ToInt64(value)
                    .ToString("###-###-#### " + new String('#', (value.Length - 10)));
            return value;
        }

        private void CalculateTotal()
        {

            decimal TicketFee;
            decimal Tax;
            decimal Commission;
            decimal Total;


            TicketFee = (!String.IsNullOrEmpty(textTfee.Text)) ? Convert.ToDecimal(textTfee.Text) : 0.00m;
            Tax = (!String.IsNullOrEmpty(textTax.Text)) ? Convert.ToDecimal(textTax.Text) : 0.00m;
            Commission = (!String.IsNullOrEmpty(textCommission.Text)) ? Convert.ToDecimal(textCommission.Text) : 0.00m;
            Total = TicketFee + Tax + Commission;
            textTotal.Text = Total.ToString();
        }

        private void textTfee_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void textTax_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void textCommission_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void textTfee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textCommission_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonFname_Click(object sender, EventArgs e)
        {
            BL = new BindingList<Customer>();
            DB = new compassdbEntities();
            var Fname = textFname.Text.Trim();
            var item = DB.Customer.Where(a => a.FirstName == Fname);
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

        private void buttonLname_Click(object sender, EventArgs e)
        {
            BL = new BindingList<Customer>();
            DB = new compassdbEntities();
            var Lname = textLname.Text.Trim();
            var item = DB.Customer.Where(a => a.LastName == Lname);
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

        private void buttonBooking_Click(object sender, EventArgs e)
        {
            BL = new BindingList<Customer>();
            DB = new compassdbEntities();
            var Booking = textBooking.Text.Trim();
            var item = DB.Customer.Where(a => a.Booking == Booking);
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

        private void buttonPassport_Click(object sender, EventArgs e)
        {
            BL = new BindingList<Customer>();
            DB = new compassdbEntities();
            var Passport = textPassport.Text.ToLower().Trim();
            var item = DB.Customer.Where(a => a.Passport == Passport);
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

        private void buttonTicketNo_Click(object sender, EventArgs e)
        {
            BL = new BindingList<Customer>();
            DB = new compassdbEntities();
            var TicketNo = textTicket.Text.Trim();
            var item = DB.Customer.Where(a => a.TicketNumber == TicketNo);
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

        private void buttonCustomerID_Click(object sender, EventArgs e)
        {
            BL = new BindingList<Customer>();
            DB = new compassdbEntities();
            var cid = Convert.ToInt32(textCustomerID.Text);
            var item = DB.Customer.Where(a => a.CustomerID == cid);
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

        private void textTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBooking_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBooking.MaxLength = 6;
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textPassport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

  

        private void textFname_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void textLname_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void textLname_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textCustomerID.Clear();
            textFname.Clear();
            textLname.Clear();
            textPhone.Clear();
            textBooking.Clear();
            textPassport.Clear();
            textTicket.Clear();
            textTfee.Clear();
            textTax.Clear();
            textCommission.Clear();
            textTotal.Clear();
            richTextBox1.Clear();
            
        }
           
     





            

            
           
    }
}

       

       

       
       

      

      

       

       

       

       

       

        

       

       

       

      

      

      

       

       

      

     

      
