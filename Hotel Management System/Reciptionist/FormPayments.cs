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
    public partial class FormPayments : Form
    {
        public FormPayments()
        {
            InitializeComponent();
        }

        private void txtSearchFoodCashier_Enter(object sender, EventArgs e)
        {

        }

        private MySqlConnection dbQuery()
        {
            DBConnection dBclass = new DBConnection();
            MySqlConnection conn = dBclass.getConnection();
            return conn;
        }

        private void DataAdapter(String sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "food");
            tblGuestDetails.DataSource = ds.Tables["food"];
            conn.Close();
        }

        private void DataAdapter1(String sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "room_booking");
            tblRoomDetails.DataSource = ds.Tables["room_booking"];
            conn.Close();
        }

        private void DataAdapter2(String sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "service_booking");
            tblServiceDetails.DataSource = ds.Tables["service_booking"];
            conn.Close();
        }


        //data reader
        private string DataReader(string sql, MySqlConnection conn)
        {
            string output = "";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                output += dataReader.GetValue(0).ToString();
            }
            conn.Close();
            return output;

        }


        private void DataReader2(string sql, MySqlConnection conn)
        {
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                comboID.Items.Add(dataReader.GetString("IDNumber"));
            }
        }

        private void FormPayments_Load(object sender, EventArgs e)
        {
            lblFtotal.Text = "0";
            lblStotal.Text = "0";
            lblPaid.Text = "0";
            lblRtotal.Text = "0";
            lblTobePaid.Text = "0";
            lblTotal.Text = "0";
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 15);
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 15);
            dateTimePicker1.CustomFormat = "ddd dd MMM yyyy";
            dateTimePicker2.CustomFormat = "ddd dd MMM yyyy";
            tblGuestDetails.EnableHeadersVisualStyles = false;
            tblGuestDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
            tblGuestDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblGuestDetails.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblGuestDetails.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);

            tblRoomDetails.EnableHeadersVisualStyles = false;
            tblRoomDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
            tblRoomDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblRoomDetails.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblRoomDetails.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);

            tblServiceDetails.EnableHeadersVisualStyles = false;
            tblServiceDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
            tblServiceDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblServiceDetails.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblServiceDetails.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);


            try
            {
                string Idvalues = "CALL getID";
                DataReader2(Idvalues, dbQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboID_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

                string sql = "CALL getRoomsForPayment('" + comboID.Text + "','" + date + "')";
                DataAdapter(sql, dbQuery());

                lblRtotal.Text = "0";
                int rAmount = 0;

                for (int i = 0; i < tblGuestDetails.RowCount; i++)
                {

                    string room = tblGuestDetails.Rows[i].Cells["Room No"].Value.ToString();
                    string aDate = tblGuestDetails.Rows[i].Cells["Arrival"].Value.ToString();
                    string id = tblGuestDetails.Rows[i].Cells["ID No"].Value.ToString();
                    string gid = DataReader("SELECT GuestId FROM Reservation WHERE IDNumber='" + id + "'", dbQuery());

                    string eDate = "'" + DataReader("SELECT DATE_FORMAT(EndDate, '%Y-%m-%d %T') FROM Room_booking WHERE RoomID='" + room + "' AND GuestID='" + gid + "'", dbQuery()) + "'";

                    if (eDate == "''")
                    {
                        eDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                        
                    }


                    int roomTotal = int.Parse(DataReader("CALL getReservationPayment(" + room + ",'" + aDate + "'," + eDate + ")", dbQuery()));

                    rAmount += roomTotal;
                    lblRtotal.Text = rAmount.ToString();
                    //MessageBox.Show(P.ToString());
                }


               
            }

            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            } 

        }

        private void tblGuestDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sDate = tblGuestDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            string id = tblGuestDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            string room = tblGuestDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
            try
            {
                lblname.Text = DataReader("SELECT FullName FROM guest_details WHERE IDNumber='" + id + "'", dbQuery());

                string gid = DataReader("SELECT GuestId FROM Reservation WHERE IDNumber='" + id + "'", dbQuery());
                string eDate = DataReader("SELECT DATE_FORMAT(EndDate, '%Y-%m-%d %T') FROM Room_booking WHERE RoomID='" + room + "' AND GuestID='"+gid+"'", dbQuery());
                // MessageBox.Show(eDate);

                string roomDetails = "CALL getFoodPayment('" + room + "','" + sDate + "','" + eDate + "')";
                DataAdapter1(roomDetails, dbQuery());
                tblRoomDetails.Columns[0].Width = 90;
                tblRoomDetails.Columns[1].Width = 130;
                tblRoomDetails.Columns[2].Width = 130;
                tblRoomDetails.Columns[3].Width = 220;

                string serviceDetails = "CALL getServicePayment('" + room + "','" + sDate + "','" + eDate + "')";
                DataAdapter2(serviceDetails, dbQuery());
                tblServiceDetails.Columns[3].Width = 90;
                tblGuestDetails.Columns[0].Width = 220;
                tblGuestDetails.Columns[2].Width = 80;

                lblFtotal.Text = "0";
                lblStotal.Text = "0";
                int fAmount = 0;

                for (int i = 0; i < tblRoomDetails.RowCount; i++)
                {

                    int amount = int.Parse(tblRoomDetails.Rows[i].Cells["Amount"].Value.ToString());
                    fAmount += amount;
                    lblFtotal.Text = fAmount.ToString();

                    //MessageBox.Show(fAmount.ToString());
                }

                int sAmount = 0;

                for (int i = 0; i < tblServiceDetails.RowCount; i++)
                {

                    int amount = int.Parse(tblServiceDetails.Rows[i].Cells["Amount"].Value.ToString());
                    sAmount += amount;
                    lblStotal.Text = sAmount.ToString();

                    //MessageBox.Show(sAmount.ToString());
                }

                lblTotal.Text = (int.Parse(lblRtotal.Text) + int.Parse(lblFtotal.Text) + int.Parse(lblStotal.Text)).ToString();
                lblTobePaid.Text = (int.Parse(lblTotal.Text) - int.Parse(lblPaid.Text)).ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string sDate = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm");
            string eDate = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm");

            DataAdapter("CALL getRoomsPaymentByDate('" + sDate + "','" + eDate + "')", dbQuery());
            tblGuestDetails.Columns[0].Width = 220;
            tblGuestDetails.Columns[2].Width = 80;

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string sDate = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm");
            string eDate = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm");

            DataAdapter("CALL getRoomsPaymentByDate('" + sDate + "','" + eDate + "')", dbQuery());
            tblGuestDetails.Columns[0].Width = 220;
            tblGuestDetails.Columns[2].Width = 80;
        }

        private void dateTimePicker1_Enter(object sender, EventArgs e)
        {
            comboID.Items.Clear();
        }

        private void dateTimePicker2_Enter(object sender, EventArgs e)
        {
            comboID.Items.Clear();
        }

        private void comboID_Enter(object sender, EventArgs e)
        {
            comboID.Items.Clear();
            string Idvalues = "CALL getID";
            DataReader2(Idvalues, dbQuery());
        }
    }
}
