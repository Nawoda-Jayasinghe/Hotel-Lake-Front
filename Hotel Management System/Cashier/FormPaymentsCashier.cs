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
    public partial class FormPaymentsCashier : Form
    {
        public FormPaymentsCashier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //column headers align center
            tbleFoodOrderDetailsCashier.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tbleFoodDetailsCashier.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Checkbox default value checked
            foreach (DataGridViewRow row in tbleFoodOrderDetailsCashier.Rows)
            {
                row.Cells[FoodSelectPayments.Name].Value = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tbleFoodOrderDetailsCashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in tbleFoodOrderDetailsCashier.Rows)
            {
                row.Cells[FoodSelectPayments.Name].Value = true;
            }
        }

        private void tbleFoodDetailsCashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchFoodCashier_Leave(object sender, EventArgs e)
        {

        }

        private void txtSearchFoodCashier_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearchPayments1_Enter(object sender, EventArgs e)
        {
            if (txtSearchPayments1.Text == "Search")
            {
                txtSearchPayments1.Text = "";
                txtSearchPayments1.ForeColor = Color.Black;
            }
        }

        private void txtSearchPayments1_Leave(object sender, EventArgs e)
        {
            if (txtSearchPayments1.Text == "")
            {
                txtSearchPayments1.Text = "Search";
                txtSearchPayments1.ForeColor = Color.Gray;
            }
        }

        private void txtSearchPayments2_Enter(object sender, EventArgs e)
        {
            if (txtSearchPayments2.Text == "Search")
            {
                txtSearchPayments2.Text = "";
                txtSearchPayments2.ForeColor = Color.Black;
            }
        }
        
        private void txtSearchPayments2_Leave(object sender, EventArgs e)
        {
            if (txtSearchPayments2.Text == "")
            {
                txtSearchPayments2.Text = "Search";
                txtSearchPayments2.ForeColor = Color.Gray;
            }
        }

        private void FormPaymentsCashier_Load(object sender, EventArgs e)
        {

            tbleFoodOrderDetailsCashier.Rows.Add("F0005", "Sea Food Special Buriyani(L)", "1", "800");
            tbleFoodOrderDetailsCashier.Rows.Add("F0009", "Broccoli cheddar baked potato", "2", "2500");
            tbleFoodOrderDetailsCashier.Rows.Add("F0002", "Chicken Cheese Masala Kottu(S)", "1", "750");
        }
    }
}
