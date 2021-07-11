using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class FormSalaryDetailsAdmin : Form
    {
        public FormSalaryDetailsAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRestaurant_Load(object sender, EventArgs e)
        {
            tbleFoodDetailsAdmin.Rows.Add("ADM", "Management", "100,000");
            tbleFoodDetailsAdmin.Rows.Add("RCP", "Receptionis", "75,000");
            tbleFoodDetailsAdmin.Rows.Add("CSH", "Cashier", "50,000");
            tbleFoodDetailsAdmin.Rows.Add("CLN", "Cleaning Staff", "30,000");
            tbleFoodDetailsAdmin.Rows.Add("WTR", "Waitress", "30,000");
        }

        private void txtSearchFoodCashier_Enter(object sender, EventArgs e)
        {
            if (txtSearchSalary.Text == "Search")
            {
                txtSearchSalary.Text = "";
                txtSearchSalary.ForeColor = Color.Black;
            }
        }

        private void txtSearchFoodCashier_Leave(object sender, EventArgs e)
        {
            if (txtSearchSalary.Text == "")
            {
                txtSearchSalary.Text = "Search";
                txtSearchSalary.ForeColor = Color.Gray;
            }
        }
    }
}
