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

        private IconButton currentBtn;
        private Panel leftBoarderBtn;
        private Form currentForm;
        


       /* private struct RGBColors
        {

            public static Color color7 = Color.FromArgb(253, 138, 114);

        }*/


        public FormGuestDetails()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormGuestDetails_Load(object sender, EventArgs e)
        {

        }

       /* private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }*/

       /* public void OpenForm(Form childForm)
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
            panelGuestDetails.Controls.Add(childForm);
            panelGuestDetails.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           


        }*/

       /* public void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                
              leftBoarderBtn.BackColor = color;
                leftBoarderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBoarderBtn.Visible = true;
                leftBoarderBtn.BringToFront();
                
               //iconCurrent.IconChar = currentBtn.IconChar;
               // iconCurrent.IconColor = color;

            }
        }*/


        private void iconButton3_Click_1(object sender, EventArgs e)
        {

            FormMain newFormMain = new FormMain();
            this.Close();
            newFormMain.Visible = true;
            newFormMain.OpenForm(new FormPayments());
            newFormMain.ActivateButton(newFormMain.btnPayments, Color.FromArgb(253,138,114));

            //ActivateButton(sender, RGBColors.color7);
           // OpenForm(new FormPayments());


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
