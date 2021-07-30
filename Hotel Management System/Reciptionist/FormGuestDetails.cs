using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;



namespace Hotel_Management_System
{
    public partial class FormGuestDetails : Form
    {

        public FormGuestDetails()
        {
            InitializeComponent();
            
        }


        private void FormGuestDetails_Load(object sender, EventArgs e)
        {

        }


        private void iconButton3_Click_1(object sender, EventArgs e)
        {

            FormMain newFormMain = new FormMain();
            this.Close();
            newFormMain.Visible = true;
            newFormMain.OpenForm(new FormPayments());
            newFormMain.ActivateButton(newFormMain.btnPayments, Color.FromArgb(253,138,114));

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(txtGuestDetailsSearch.Text == "Guest NIC")
            {
                txtGuestDetailsSearch.Text = "";
            }
        }

        private void txtGuestDetailsSearch_Leave(object sender, EventArgs e)
        {
            if (txtGuestDetailsSearch.Text == "")
            {
                txtGuestDetailsSearch.Text = "Guest NIC";
            }
        }
    }
}
