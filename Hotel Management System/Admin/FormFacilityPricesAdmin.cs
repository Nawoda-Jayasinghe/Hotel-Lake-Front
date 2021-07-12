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
    public partial class FormFacilityPricesAdmin : Form
    {
        public FormFacilityPricesAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRestaurant_Load(object sender, EventArgs e)
        {
            tbleFoodDetailsAdmin.Rows.Add("FA1", "Wi-Fi", "500");
            tbleFoodDetailsAdmin.Rows.Add("FA2", "Satellite TV", "450");
            tbleFoodDetailsAdmin.Rows.Add("FA3", "Hot Water", "500");
            tbleFoodDetailsAdmin.Rows.Add("FA4", "Extra Bed", "400");
            tbleFoodDetailsAdmin.Rows.Add("FA5", "Pets Allowed", "600");
        }

        private void txtSearchFoodCashier_Leave(object sender, EventArgs e)
        {
            if (txtSearchFacility.Text == "")
            {
                txtSearchFacility.Text = "Search";
                txtSearchFacility.ForeColor = Color.Gray;
            }

        }

        private void txtSearchFoodCashier_Enter(object sender, EventArgs e)
        {
            if (txtSearchFacility.Text == "Search")
            {
                txtSearchFacility.Text = "";
                txtSearchFacility.ForeColor = Color.Black;
            }
        }
    }
}
