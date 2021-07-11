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
    public partial class FormOrdersCashier : Form
    {
        public FormOrdersCashier()
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
            tbleRoomFoodOrderDetailsCashier.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tbleRoomFoodOrderDetailsListCashier.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Checkbox default value checked
            foreach (DataGridViewRow row in tbleRoomFoodOrderDetailsListCashier.Rows)
            {
                row.Cells[FoodSelectOrders.Name].Value = true;
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


        private void FormOrdersCashier_Load(object sender, EventArgs e)
        {
            tbleRoomFoodOrderDetailsCashier.Rows.Add("2", "ODR254888");
            tbleRoomFoodOrderDetailsCashier.Rows.Add("4", "ODR254889");
            tbleRoomFoodOrderDetailsCashier.Rows.Add("15", "ODR154890");

            tbleRoomFoodOrderDetailsListCashier.Rows.Add("F0005", "Sea Food Special Buriyani(L)", "1", "800");
            tbleRoomFoodOrderDetailsListCashier.Rows.Add("F0009", "Broccoli cheddar baked potato", "2", "2500");
            tbleRoomFoodOrderDetailsListCashier.Rows.Add("F0002", "Chicken Cheese Masala Kottu(S)", "1", "750");
        }
    }
}
