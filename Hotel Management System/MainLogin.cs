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
                    //FormMainAdmin newFormMainAdmin = new FormMainAdmin();
                    //newFormMainAdmin.Visible=true;

                    //this.Visible = false;

                    // Application.Run(new FormMainAdmin());

                    //this.Hide();
                    FormMainAdmin newFormAdmin = new FormMainAdmin();
                    //f2.Size = new Size();
                    newFormAdmin.Show();

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
            }
        }

        private void txtUserNameLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
