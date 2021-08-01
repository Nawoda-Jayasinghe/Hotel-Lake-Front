using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelGuestNext.Controls.Add(childForm);
            panelGuestNext.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        //create connection
        private MySqlConnection dbQuery()
        {
            DBConnection dBclass = new DBConnection();
            MySqlConnection conn = dBclass.getConnection();
            return conn;
        }

        //data adapter
        private void DataAdapter(string sql, MySqlConnection conn)
        {
            /*MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();*/

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "room");
            tblReservationDetails.DataSource = ds.Tables["room"];
            conn.Close();
        }

        private void DataAdder(string sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();
        }

        //data reader
        private void DataReader(string sql, MySqlConnection conn)
        {
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                comboID.Items.Add(dataReader.GetString("IDNumber"));
            }
        }

        private void FormNewGuestNext_Load(object sender, EventArgs e)
        {
            //tblReservationDetails.Rows.

            try
            {
                string sql = "CALL getAllRooms";
                string Idvalues = "CALL getID";
                DataAdapter(sql, dbQuery());
                DataReader(Idvalues, dbQuery());

                
                tblReservationDetails.Columns["No"].ReadOnly = true;
                tblReservationDetails.Columns["No"].DisplayIndex = 0;
                tblReservationDetails.Columns["No"].Width = 60;
                tblReservationDetails.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tblReservationDetails.Columns["Room Type"].ReadOnly = true;
                tblReservationDetails.Columns["Room Type"].DisplayIndex = 1;
                tblReservationDetails.Columns["Room Type"].Width = 200;
                //MessageBox.Show(tblReservationDetails.Columns[1].Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            /*tblReservationDetails.Rows.Add(6, "Single Luxury");
            tblReservationDetails.Rows.Add(8, "Single Luxury");
            tblReservationDetails.Rows.Add(9, "Single Luxury");
            tblReservationDetails.Rows.Add(10, "Single Luxury");
            tblReservationDetails.Rows.Add(11, "Double Normal");
            tblReservationDetails.Rows.Add(12, "Double Normal");
            tblReservationDetails.Rows.Add(13, "Double Normal");
            tblReservationDetails.Rows.Add(14, "Double Normal");
            tblReservationDetails.Rows.Add(15, "Double Normal");*/



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
            try
            {
                
                //reservation check box value
                bool cbResrvation = Convert.ToBoolean(tblReservationDetails.Rows[e.RowIndex].Cells[0].Value);

                if (cbResrvation == true)
                {   
                    //datepicker
                    if ((e.ColumnIndex == 1 && e.RowIndex >= 0) || (e.ColumnIndex == 2 && e.RowIndex >= 0))
                    {
                        DateTimePicker DateTimePicker1 = new DateTimePicker();
                        tblReservationDetails.Controls.Add(DateTimePicker1);
                        DateTimePicker1.Format = DateTimePickerFormat.Custom;
                        DateTimePicker1.CustomFormat = "yyyy-MM-dd ";

                        Rectangle displayCalendar = tblReservationDetails.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        DateTimePicker1.Size = new Size(displayCalendar.Width, displayCalendar.Height);
                        DateTimePicker1.Location = new Point(displayCalendar.X, displayCalendar.Y);
                        DateTimePicker1.BringToFront();

                    }

                    //if reservation check box checked, other check boxes will be clickable
                    for (int i = 3; i < 8; i++)
                    {
                        if (Convert.ToBoolean(tblReservationDetails.Rows[e.RowIndex].Cells[i].ReadOnly) == true)
                        {
                            tblReservationDetails.Rows[e.RowIndex].Cells[i].ReadOnly = false;
                        }
                    }

                }


                if (cbResrvation == false)
                {
                    if ((e.ColumnIndex == 1 && e.RowIndex >= 0) || (e.ColumnIndex == 2 && e.RowIndex >= 0))
                    {
                        
                        tblReservationDetails.Rows[e.RowIndex].Cells[1].ReadOnly = true;

                        TextBox tb = new TextBox();
                        tblReservationDetails.Controls.Add(tb);
                        tb.Enabled = false;
                        tb.BringToFront();
                        
                        Rectangle displaytb = tblReservationDetails.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        tb.Size = new Size(displaytb.Width, displaytb.Height);
                        tb.Location = new Point(displaytb.X, displaytb.Y);

                    }

                    //if reservation check box unchecked, other check boxes will be disabled
                    for (int i = 3; i < 8; i++)
                    {
                        if (Convert.ToBoolean(tblReservationDetails.Rows[e.RowIndex].Cells[i].Value) == true)
                        {
                            tblReservationDetails.Rows[e.RowIndex].Cells[i].Value = false;
                        }
                    }

                    //if reservation check box unchecked, other check boxes will be unclickable
                    for (int i = 3; i < 8; i++)
                    {
                        if (Convert.ToBoolean(tblReservationDetails.Rows[e.RowIndex].Cells[i].ReadOnly) == false)
                        {
                            tblReservationDetails.Rows[e.RowIndex].Cells[i].ReadOnly = true;
                        }
                    }

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string IDNo = comboID.Text;
                int i = 0;

                string sql = "CALL addReservation('" + IDNo + "','2021-05-01','2021-05-10')";

                DataAdder(sql, dbQuery());

                foreach (DataGridViewRow row in tblReservationDetails.Rows)
                {
                    i++;
                    bool cbResrvation = Convert.ToBoolean(tblReservationDetails.Rows[1].Cells[2].Value);
                    if (cbResrvation == true)
                    {

                       // string sql = "CALL addReservatio('" + IDNo + "','2021-05-01',2021-05-10)";

                       //DataAdder(sql, dbQuery());
                    }
                    
                }

                for (int j = 0; j < 8; j++)
                {
                    string s = (string)tblReservationDetails.Rows[2].Cells[j].Value;
                    MessageBox.Show(s);
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }

                

        }

    }
    
}
