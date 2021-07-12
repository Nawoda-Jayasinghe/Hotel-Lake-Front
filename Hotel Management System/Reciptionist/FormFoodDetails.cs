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
    public partial class FormFoodDetails : Form
    {
        public FormFoodDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchFoodCashier_Enter(object sender, EventArgs e)
        {
            if (txtSearchFoodCashier.Text == "Search")
            {
                txtSearchFoodCashier.Text = "";
                txtSearchFoodCashier.ForeColor = Color.Black;
            }
        }

        private void txtSearchFoodCashier_Leave(object sender, EventArgs e)
        {
            if (txtSearchFoodCashier.Text == "")
            {
                txtSearchFoodCashier.Text = "Search";
                txtSearchFoodCashier.ForeColor = Color.Gray;
            }
        }

        private void FormFoodDetails_Load(object sender, EventArgs e)
        {
            tblFoodDetails.Rows.Add("F0001", "Chicken Kottu(S)", "450");
            tblFoodDetails.Rows.Add("F0002", "Chicken Cheese Masala Kottu(S)", "750");
            tblFoodDetails.Rows.Add("F0003", "Beef Kottu(S)", "750");
            tblFoodDetails.Rows.Add("F0004", "Chicken fried Rice(S)", "350");
            tblFoodDetails.Rows.Add("F0005", "Sea Food Special Buriyani(L)", "800");
            tblFoodDetails.Rows.Add("F0009", "Broccoli cheddar baked potato", "1250");
            

        }
    }
}
