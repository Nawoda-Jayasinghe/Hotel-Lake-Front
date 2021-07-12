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

                mtbNIC.Mask = null;
            }

            else
            {
                lblNIC.Text = "National ID";
                mtbTP1.Mask = "(\\000) 000-0000";
                mtbTP2.Mask = "(\\000) 000-0000";
                mtbNIC.Mask = "000000000AAA";
            }
        }

        private void mtbNIC_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbForeign.Checked == false)
            {
                mtbNIC.SelectionStart = 0;
            }
        }


        private void mtbTP1_Click(object sender, EventArgs e)
        {
            mtbTP1.SelectionStart = 2;
        }


        private void mtbTP2_MouseClick(object sender, MouseEventArgs e)
        {
            mtbTP2.SelectionStart = 2;
        }


        private void mtbEmail_Enter(object sender, EventArgs e)
        {
            if (mtbEmail.Text == "example@gmail.com")
            {
                mtbEmail.Text = "";
                mtbEmail.ForeColor = Color.FromArgb(26, 25, 62);
            }
        }


        private void mtbEmail_Leave(object sender, EventArgs e)
        {
            if (mtbEmail.Text == "")
            {
                mtbEmail.Text = "example@gmail.com";
                mtbEmail.ForeColor = Color.Gray;
            }
        }

        private void mtbNIC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        private void panelGuest_Enter(object sender, EventArgs e)
        {
            if (lblSingleNormalCount.Text == "0")
            {
                cbSingleNormalCount.Enabled = false;
            }

            if (lblSingleLuxuryCount.Text == "0")
            {
                cbSingleLuxuryCount.Enabled = false;
            }

            if (lblDoubleNormalCount.Text == "0")
            {
                cbDoubleNormalCount.Enabled = false;
            }

            if (lblDoubleLuxuryCount.Text == "0")
            {
                cbDoubleLuxuryCount.Enabled = false;
            }

            if (lblSingleNormalCount.Text == "0")
            {
                cbSingleNormalCount.Enabled = false;
            }

            if (lblFamilyLuxuryCount.Text == "0")
            {
                cbFamilyLuxuryCount.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbForeign.Checked)
            {
                cbForeign.Checked = false;
            }

            mtbNIC.Text = "";
            txtFName.Text = "";
            txtFullName.Text = "";
            radioMale.Checked = true;
            rchtxtAddress.Text = "";
            mtbTP1.Text = "";
            mtbTP2.Text = "";
            mtbEmail.Text = "";     

        }

    }
}
