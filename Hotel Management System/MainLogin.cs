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
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        
        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (txtUserNameLogin.Text.Length >= 3)
            {
                string User = txtUserNameLogin.Text.Substring(0, 3);

                if (User == "ADM")
                {
                    FormMainAdmin newFormAdmin = new FormMainAdmin();
                    newFormAdmin.Show();
                    this.Visible = false;

                }

                else if (User == "RCP")
                {
                    FormMain newFormMain = new FormMain();
                    newFormMain.Show();
                    this.Visible = false;

                }

                else if (User == "CSH")
                {
                    FormMainCashier newFormMainCashier = new FormMainCashier();
                    newFormMainCashier.Show();
                    this.Visible = false;

                }

                else
                {
                   // Messa
                }
            }
        }

        private void txtUserNameLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnklblClearFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUserNameLogin.Text = "";
            txtPwLogin.Text = "";
        }

        private void lnklblChangePw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnklblChangePw.Text == "Change Password") 
            { 
                lnklblClearFields.Visible = false;
                panel3.Visible = true;
                panel4.Visible = true;
                txtNewPwLogin.Visible = true;
                txtConfirmPwLogin.Visible = true;
                btnLogin.Text = "Update Password";
                icnUser.Visible = false;
                icnKey.Visible = false;
                lblUserName.Visible = true;
                lblCrntPw.Visible = true;
                lblNewPw.Visible = true;
                lblConfrimPw.Visible = true;
                lnklblChangePw.Text = "Log In";
                btnLogin.Location = new Point(54, 555);
                lnklblChangePw.Location = new Point(302, 631);
            }

            else if (lnklblChangePw.Text == "Log In")
            {
                lnklblClearFields.Visible = true;
                panel3.Visible = false;
                panel4.Visible = false;
                txtNewPwLogin.Visible = false;
                txtConfirmPwLogin.Visible = false;
                btnLogin.Text = "Log In";
                icnUser.Visible = true;
                icnKey.Visible = true;
                lblUserName.Visible = false;
                lblCrntPw.Visible = false;
                lblNewPw.Visible = false;
                lblConfrimPw.Visible = false;
                lnklblChangePw.Text = "Change Password";
                btnLogin.Location = new Point(54, 500);
                lnklblChangePw.Location = new Point(279, 573);
            }
        }
    }
}
