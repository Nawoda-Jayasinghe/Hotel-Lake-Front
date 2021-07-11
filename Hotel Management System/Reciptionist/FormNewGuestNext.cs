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
    public partial class FormNewGuestNext : Form
    {

        DateTimePicker DateTimePicker1;
        Form currentForm;

        public FormNewGuestNext()
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            OpenForm(new FormNewGuestNext2());
        }

        private void tblReservationDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //reservation check box value
            bool cbResrvation = Convert.ToBoolean(tblReservationDetails.Rows[e.RowIndex].Cells[2].Value);

            if (cbResrvation == true)
            {
                //datepicker
                if ((e.ColumnIndex == 3 && e.RowIndex >= 0) || (e.ColumnIndex == 4 && e.RowIndex >= 0))
                {

                    DateTimePicker DateTimePicker1 = new DateTimePicker();
                    tblReservationDetails.Controls.Add(DateTimePicker1);
                    DateTimePicker1.Format = DateTimePickerFormat.Short;

                    Rectangle displayCalendar = tblReservationDetails.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    DateTimePicker1.Size = new Size(displayCalendar.Width, displayCalendar.Height);
                    DateTimePicker1.Location = new Point(displayCalendar.X, displayCalendar.Y);

                }

                //checkbox read only disable
                tblReservationDetails.Rows[e.RowIndex].Cells[5].ReadOnly = false;
                tblReservationDetails.Rows[e.RowIndex].Cells[6].ReadOnly = false;
                tblReservationDetails.Rows[e.RowIndex].Cells[7].ReadOnly = false;
                tblReservationDetails.Rows[e.RowIndex].Cells[8].ReadOnly = false;
                tblReservationDetails.Rows[e.RowIndex].Cells[9].ReadOnly = false;

            }


            if (cbResrvation == false)
            {
                //if reservation check box unchecked, other check boxes will be disabled
                for (int i = 5; i < 10; i++)
                {
                    if (Convert.ToBoolean(tblReservationDetails.Rows[e.RowIndex].Cells[i].Value) == true)
                    {
                        tblReservationDetails.Rows[e.RowIndex].Cells[i].Value = false;
                    }
                }

                //checkbox read only 
                tblReservationDetails.Rows[e.RowIndex].Cells[5].ReadOnly = true;
                tblReservationDetails.Rows[e.RowIndex].Cells[6].ReadOnly = true;
                tblReservationDetails.Rows[e.RowIndex].Cells[7].ReadOnly = true;
                tblReservationDetails.Rows[e.RowIndex].Cells[8].ReadOnly = true;
                tblReservationDetails.Rows[e.RowIndex].Cells[9].ReadOnly = true;
            }


        }

        private void FormNewGuestNext_Load(object sender, EventArgs e)
        {
           
            tblReservationDetails.Rows.Add(6, "Single Luxury");
            tblReservationDetails.Rows.Add(8, "Single Luxury");
            tblReservationDetails.Rows.Add(9, "Single Luxury");
            tblReservationDetails.Rows.Add(10, "Single Luxury");
            tblReservationDetails.Rows.Add(11, "Double Normal");
            tblReservationDetails.Rows.Add(12, "Double Normal");
            tblReservationDetails.Rows.Add(13, "Double Normal");
            tblReservationDetails.Rows.Add(14, "Double Normal");
            tblReservationDetails.Rows.Add(15, "Double Normal");
           


        }

    }
    
}
