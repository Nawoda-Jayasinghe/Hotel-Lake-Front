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
    public partial class FormNewGuest : Form
    {

        Form currentForm;

        public FormNewGuest()
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


        private void cbForeign_CheckedChanged(object sender, EventArgs e)
        {
            if (cbForeign.Checked)
            {
                lblNIC.Text = "Passport No";

                mtbTP1.Mask = "(+0) 000-000-0000";
                mtbTP2.Mask = "(+0) 000-000-0000";
            }

            else
            {
                lblNIC.Text = "National ID";
               mtbTP1.Mask = "(\\000) 000-0000";
                mtbTP2.Mask = "(\\000) 000-0000";
            }
        }

        private void mtbTP1_Click(object sender, EventArgs e)
        {
            mtbTP1.SelectionStart = 2;
        }


        private void mtbTP2_MouseClick(object sender, MouseEventArgs e)
        {
            mtbTP2.SelectionStart = 1;
        }


        private void txtAddressLine1_Enter(object sender, EventArgs e)
        {
            if(txtAddressLine1.Text == "Address Line 1")
            {
                txtAddressLine1.Text = "";
                txtAddressLine1.ForeColor = Color.FromArgb(26, 25, 62);
            }
        }

        private void txtAddressLine1_Leave(object sender, EventArgs e)
        {
            if (txtAddressLine1.Text == "")
            {
                txtAddressLine1.Text = "Address Line 1";
                txtAddressLine1.ForeColor = Color.Gray;
            }
        }

        private void txtAddressLine2_Enter(object sender, EventArgs e)
        {
            if (txtAddressLine2.Text == "Address Line 2")
            {
                txtAddressLine2.Text = "";
                txtAddressLine2.ForeColor = Color.FromArgb(26, 25, 62);
            }
        }

        private void txtAddressLine2_Leave(object sender, EventArgs e)
        {
            if (txtAddressLine2.Text == "")
            {
                txtAddressLine2.Text = "Address Line 2";
                txtAddressLine2.ForeColor = Color.Gray;
            }
        }

        private void txtAddressLine3_Enter(object sender, EventArgs e)
        {
            if (txtAddressLine3.Text == "Address Line 3")
            {
                txtAddressLine3.Text = "";
                txtAddressLine3.ForeColor = Color.FromArgb(26, 25, 62);
            }
        }

        private void txtAddressLine3_Leave(object sender, EventArgs e)
        {
            if (txtAddressLine3.Text == "")
            {
                txtAddressLine3.Text = "Address Line 3";
                txtAddressLine3.ForeColor = Color.Gray;
            }
        }
    }
}
