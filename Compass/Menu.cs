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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                AddCustomer f1 = new AddCustomer();
                f1.ShowDialog();
            }
            if (e.KeyCode == Keys.D2)
            {
                RemoveCustomer f2 = new RemoveCustomer();
                f2.ShowDialog();
            }
            if (e.KeyCode == Keys.D3)
            {
                UpdateCustomer f3 = new UpdateCustomer();
                f3.ShowDialog();
            }



            if (e.KeyCode == Keys.D4)
            {
                CustomerList f4 = new CustomerList();
                f4.ShowDialog();
            }

            if (e.KeyCode == Keys.D5)
            {
                Report f5 = new Report();
                f5.ShowDialog();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
