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
    public partial class FormEmployeeAdmin : Form
    {

        Form currentForm;

        public FormEmployeeAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OpenForm(Form childForm)
        {
            //open only form
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //panel1.Dock = DockStyle.Fill;
            panelGuest.Controls.Add(childForm);
            panelGuest.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //titleCurrent.Text = childForm.Text;


        }



        private void btnGuestFurther_Click(object sender, EventArgs e)
        {
          
            OpenForm(new FormNewGuestNext());

        }


        

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenForm(new FormNewEmployeeAdmin());
        }

        private void txtSearchFoodCashier_TextChanged(object sender, EventArgs e)
        {

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
    }
}
