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
    public partial class AddCustomer : Form
    {
        int no;
        compassdbEntities DB;
        public AddCustomer()
        {
            InitializeComponent();
            loadCustomer();
          
        }

       

        private void loadCustomer()
        {
            DB = new compassdbEntities();
            var item = DB.Customer.ToArray();
            no = item.LastOrDefault().CustomerID + 1;
            textCustomerID.Text = Convert.ToString(no);
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DB = new compassdbEntities();
            Customer newCustomer = new Customer();

            newCustomer.FirstName = textFname.Text.Trim();
            newCustomer.LastName = textLname.Text.Trim();
            newCustomer.PhoneNumber = PhoneNumber(textPhone.Text);
            newCustomer.Booking = textBooking.Text.Trim();
            newCustomer.Passport = textPassport.Text.Trim();
            newCustomer.TicketNumber = textTicket.Text.Trim();
            newCustomer.TicketFee = (!String.IsNullOrEmpty(textTfee.Text)) ? Convert.ToDecimal(textTfee.Text) : 0.00m;
            newCustomer.Tax = (!String.IsNullOrEmpty(textTax.Text)) ? Convert.ToDecimal(textTax.Text) : 0.00m;
            newCustomer.Commission = (!String.IsNullOrEmpty(textCommission.Text)) ? Convert.ToDecimal(textCommission.Text) : 0.00m;
            newCustomer.Total = (!String.IsNullOrEmpty(textTotal.Text)) ? Convert.ToDecimal(textTotal.Text) : 0.00m;
            newCustomer.RecordDate = dateTimePicker1.Value;
            newCustomer.Note = richTextBox1.Text.Trim();

            DB.Customer.Add(newCustomer);
            DB.SaveChanges();
            MessageBox.Show("SAVED");
            this.Close();
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

        private void textCommission_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void textTfee_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void textTax_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
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

        private void textTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textLname_KeyDown(object sender, KeyEventArgs e)
        {

        }

    }
}