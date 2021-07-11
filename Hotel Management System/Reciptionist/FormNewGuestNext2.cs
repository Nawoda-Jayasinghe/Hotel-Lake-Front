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
    public partial class FormNewGuestNext2 : Form
    {

        DateTimePicker DateTimePicker1;
        Form currentForm;

        public FormNewGuestNext2()
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
            panelGuestNext.Controls.Add(childForm);
            panelGuestNext.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //titleCurrent.Text = childForm.Text;


        }


        private void DPTextchange(Object sender, EventHandler e)
        {
            tblReservationDetails.CurrentCell.Value = DateTimePicker1.Text.ToString();
        }

        private void DPClose(object sender, EventArgs e)
        {
            DateTimePicker1.Visible = false;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }


        private void FormNewGuestNext_Load(object sender, EventArgs e)
        {
            tblReservationDetails.Rows.Add("983256985V", "Nawoda Jayasinghe");
            tblReservationDetails.Rows.Add("974569871V", "Sanju Hasintha");
            tblReservationDetails.Rows.Add("974569871V", "Sanju Hasintha");
            tblReservationDetails.Rows.Add("974569871V", "Sanju Hasintha");
        }
    }
    
}
