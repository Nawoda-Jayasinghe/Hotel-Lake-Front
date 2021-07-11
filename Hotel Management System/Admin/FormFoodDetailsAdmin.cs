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
    public partial class FormFoodDetailsAdmin : Form
    {
        public FormFoodDetailsAdmin()
        {
            InitializeComponent();
        }

            

        private void txtSearchFoodDetails_Enter(object sender, EventArgs e)
        {
            if (txtSearchFoodDetails.Text == "Search")
            {
                txtSearchFoodDetails.Text = "";
                txtSearchFoodDetails.ForeColor = Color.Black;
            }
        }

        private void txtSearchFoodDetails_Leave(object sender, EventArgs e)
        {
            if (txtSearchFoodDetails.Text == "")
            {
                txtSearchFoodDetails.Text = "Search";
                txtSearchFoodDetails.ForeColor = Color.Gray;
            }
        }
    }
}
