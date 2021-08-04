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
    public partial class FormFacilityPricesAdmin : Form
    {
        public FormFacilityPricesAdmin()
        {
            InitializeComponent();
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
            tblFoodDetails.DataSource = ds.Tables["food"];
            conn.Close();
        }

        private void DataAdder(string sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();
        }

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


        private void FormRestaurant_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "CALL getAllFacilities";
                DataAdapter(sql, dbQuery());

                tblFoodDetails.EnableHeadersVisualStyles = false;
                tblFoodDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
                tblFoodDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16);

                tblFoodDetails.Columns[0].Width = 150;
                tblFoodDetails.Columns[2].Width = 175;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchFoodCashier_Enter(object sender, EventArgs e)
        {
            if (txtSearchFacility.Text == "Search")
            {
                txtSearchFacility.Text = "";
                txtSearchFacility.ForeColor = Color.Black;
            }
        }

        private void txtSearchFoodCashier_Leave(object sender, EventArgs e)
        {
            if (txtSearchFacility.Text == "")
            {
                txtSearchFacility.Text = "Search";
                txtSearchFacility.ForeColor = Color.Gray;
            }
        }

        private void txtSearchFoodCashier_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "CALL getSelectedFacility('%" + txtSearchFacility.Text + "%')";
                DataAdapter(sql, dbQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tblFoodDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnUpdate.Visible = false;
                btnReset.Visible = false;
                btnUpdate.Visible = false;

                string FID = tblFoodDetails.Rows[e.RowIndex].Cells[0].Value.ToString();

                lblFID.Text = FID;
                txtFname.Text = DataReader1("SELECT ServiceType FROM Services WHERE servicesID = (" + FID + ")", dbQuery());
                txtFprice.Text = DataReader1("SELECT ServicePrice FROM Services WHERE ServicesID = (" + FID + ")", dbQuery());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFname_Enter(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnUpdate.Visible = true;
        }

        private void txtFprice_Enter(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnUpdate.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tblFoodDetails_CellClick(this.tblFoodDetails, new DataGridViewCellEventArgs(this.tblFoodDetails.CurrentCell.ColumnIndex, this.tblFoodDetails.CurrentRow.Index));

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lblFID.Text == "" || txtFname.Text == "" || txtFprice.Text == "")
            {
                MessageBox.Show("Fill all the fields before update ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                int fid = int.Parse(lblFID.Text);

                try
                {
                    DialogResult reslult = MessageBox.Show("Do you want to save changes?", "Confirm changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (reslult == DialogResult.Yes)
                    {
                        string sql = "CALL updateFacility('" + txtFname.Text + "','" + txtFprice.Text + "','" + fid + "')";
                        DataAdder(sql, dbQuery());
                        MessageBox.Show("Successfully Updated ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
