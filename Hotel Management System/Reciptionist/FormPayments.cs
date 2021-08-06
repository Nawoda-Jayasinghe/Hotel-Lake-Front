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

        //data adder
        private void DataAdder(string sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();
        }

        //data reader
        private string DataReader1(string sql, MySqlConnection conn)
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

        //data reader
        private void DataReader(string sql, MySqlConnection conn)
        {
          /*  MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                comboID.Items.Add(dataReader.GetString("FoodCategoryName"));
                comboFID2.Items.Add(dataReader.GetString("FoodCategoryName"));
            }*/
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
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 18);
            tblGuestDetails.EnableHeadersVisualStyles = false;
            tblGuestDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
            tblGuestDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblGuestDetails.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblGuestDetails.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);


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
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Value = DateTime.Now;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm");
            MessageBox.Show(date);

            string sql = "CALL getRoomsForPayment('" + comboID.Text +"','"+ date + "')";
            DataAdapter(sql, dbQuery());
            tblGuestDetails.Columns[0].Width = 220;
            tblGuestDetails.Columns[2].Width = 80;
        }
    }
}
