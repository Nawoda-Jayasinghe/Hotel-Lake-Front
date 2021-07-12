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
    public partial class FormNewEmployeeAdmin : Form
    {

        Form currentForm;

        public FormNewEmployeeAdmin()
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


        
        private void mtbTP1_Click(object sender, EventArgs e)
        {
            mtbTP1.SelectionStart = 2;
        }


        private void mtbTP2_MouseClick(object sender, MouseEventArgs e)
        {
            mtbTP2.SelectionStart = 1;
        }

        private void btnPhotoUpload_Click(object sender, EventArgs e)
        {
            //OpenFileDialog op = new OpenFileDialog();
            //op.Filter = "Image Files(*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
            //if (op.ShowDialog() == DialogResult.OK)
            
        }

        private void mtbNIC_MouseClick(object sender, MouseEventArgs e)
        {
            mtbNIC.SelectionStart = 0;
        }

        private void mtbTP1_MouseClick(object sender, MouseEventArgs e)
        {
            mtbTP1.SelectionStart = 2;
        }

        private void mtbTP2_MouseClick_1(object sender, MouseEventArgs e)
        {
            mtbTP2.SelectionStart = 2;
        }
    }
}
