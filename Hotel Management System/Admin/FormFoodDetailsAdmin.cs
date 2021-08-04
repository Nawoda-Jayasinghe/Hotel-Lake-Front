﻿using System;
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
    public partial class FormFoodDetailsAdmin : Form
    {
        public FormFoodDetailsAdmin()
        {
            InitializeComponent();
        }


        private void txtSearchFoodCashier_Enter(object sender, EventArgs e)
        {
            if (txtSearchFoodCashier.Text == "Search")
            {
                txtSearchFoodCashier.Text = "";
                txtSearchFoodCashier.ForeColor = Color.Black;
            }
        }

        private void txtSearchFoodCashier_Leave(object sender, EventArgs e)
        {
            if (txtSearchFoodCashier.Text == "")
            {
                txtSearchFoodCashier.Text = "Search";
                txtSearchFoodCashier.ForeColor = Color.Gray;
            }
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
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                comboFID.Items.Add(dataReader.GetString("FoodCategoryName"));
            }
        }

        private void DataReader2(string sql, MySqlConnection conn)
        {
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                comboFID.Items.Add(dataReader.GetString("FoodCategoryName"));
                comboFID.SelectedIndex = 0;
            }
        }



        private void FormFoodDetailsAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "CALL getAllFood";
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

        private void txtSearchFoodCashier_TextChanged(object sender, EventArgs e)
        {
            radioAny.Checked = false;
            radioBreak.Checked = false;
            radioLunch.Checked = false;
            radioDinner.Checked = false;
            radioBeve.Checked = false;
            radioDess.Checked = false;
            radioSnacks.Checked = false;

            try
            {
                string sql = "CALL getSelectedFoodbyName('%" + txtSearchFoodCashier.Text + "%')";
                DataAdapter(sql, dbQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioAny_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAny.Checked)
            {

                try
                {
                    //string sql = "select FoodID as 'Food ID', FoodName as 'Name', FoodPrice as 'Price' from food where FoodCategoryID = '123'";
                    string sql = "CALL getSelectedFood('123')";
                    DataAdapter(sql, dbQuery());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioBreak_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBreak.Checked)
            {

                try
                {
                    string sql = "CALL getSelectedFood('%1%')";
                    DataAdapter(sql, dbQuery());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioBeve_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBeve.Checked)
            {
                try
                {
                    string sql = "CALL getSelectedFood('4')";
                    DataAdapter(sql, dbQuery());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void radioDess_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDess.Checked)
            {
                try
                {
                    string sql = "CALL getSelectedFood('5')";
                    DataAdapter(sql, dbQuery());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void radioLunch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLunch.Checked)
            {

                try
                {
                    string sql = "CALL getSelectedFood('%2%')";
                    DataAdapter(sql, dbQuery());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioDinner_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDinner.Checked)
            {
                try
                {
                    string sql = "CALL getSelectedFood('%3%')";
                    DataAdapter(sql, dbQuery());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void radioSnacks_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSnacks.Checked)
            {
                try
                {
                    string sql = "CALL getSelectedFood('6')";
                    DataAdapter(sql, dbQuery());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void radioAny_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchFoodCashier.Text = "Search";
            txtSearchFoodCashier.ForeColor = Color.Gray;
        }

        private void radioBreak_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchFoodCashier.Text = "Search";
            txtSearchFoodCashier.ForeColor = Color.Gray;
        }

        private void radioBeve_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchFoodCashier.Text = "Search";
            txtSearchFoodCashier.ForeColor = Color.Gray;
        }

        private void radioDess_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchFoodCashier.Text = "Search";
            txtSearchFoodCashier.ForeColor = Color.Gray;
        }

        private void radioLunch_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchFoodCashier.Text = "Search";
            txtSearchFoodCashier.ForeColor = Color.Gray;
        }

        private void radioDinner_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchFoodCashier.Text = "Search";
            txtSearchFoodCashier.ForeColor = Color.Gray;
        }

        private void radioSnacks_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchFoodCashier.Text = "Search";
            txtSearchFoodCashier.ForeColor = Color.Gray;
        }

        private void tblFoodDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                btnUpdate.Visible = false;
                btnReset.Visible = false;
                btnUpdate.Visible = false;

                string FID = tblFoodDetails.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtFID.Text = FID;
                txtFname.Text = DataReader1("SELECT FoodName FROM food WHERE FoodID = (" + FID + ")", dbQuery());
                txtFprice.Text = DataReader1("SELECT FoodPrice FROM food WHERE FoodID = (" + FID + ")", dbQuery());
                txtFprice.Text = DataReader1("SELECT FoodPrice FROM food WHERE FoodID = (" + FID + ")", dbQuery());
                comboFID.Items.Clear();
                DataReader2("SELECT food_category.FoodCategoryName FROM food_category INNER JOIN food ON food.FoodcategoryID = food_category.FoodcategoryID WHERE food.FoodID = (" + FID + ")", dbQuery());

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFID_Enter(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnUpdate.Visible = true;
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

        private void comboFID_Enter(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnUpdate.Visible = true;
            comboFID.Items.Clear();
            DataReader("SELECT FoodCategoryName FROM food_category", dbQuery());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tblFoodDetails_CellClick(this.tblFoodDetails, new DataGridViewCellEventArgs(this.tblFoodDetails.CurrentCell.ColumnIndex, this.tblFoodDetails.CurrentRow.Index));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string FoodCat="";

            if (comboFID.Text == "Breakfast")
            {
                FoodCat = "1";
                MessageBox.Show(FoodCat);
            }

            else if (comboFID.Text == "Breakfast and Lunch")
            {
                FoodCat = "12";
                MessageBox.Show(FoodCat);
            }

            else if (comboFID.Text == "Anytime")
            {
                FoodCat = "123";
                MessageBox.Show(FoodCat);
            }

            else if (comboFID.Text == "Breakfast and Dinner")
            {
                FoodCat = "13";
                MessageBox.Show(FoodCat);
            }

            else if (comboFID.Text == "Lunch and Dinner")
            {
                FoodCat = "23";
                MessageBox.Show(FoodCat);
            }

            else if (comboFID.Text == "Dinner")
            {
                FoodCat = "3";
                MessageBox.Show(FoodCat);
            }

            else if (comboFID.Text == "Beverage")
            {
                FoodCat = "4";
                MessageBox.Show(FoodCat);
            }

            else if (comboFID.Text == "Desserts")
            {
                FoodCat = "5";
                MessageBox.Show(FoodCat);
            }

            else if (comboFID.Text == "Snaks")
            {
                FoodCat = "6";
                MessageBox.Show(FoodCat);
            }



            try
            {
                DialogResult reslult = MessageBox.Show("Do you want to save changes?", "Confirm changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (reslult == DialogResult.Yes)
                {
                    //string sql = "CALL updateFood('"+ txtFname.Text + "','" + txtFprice.Text + "','" + FoodCat + "')";
                   // DataAdder(sql, dbQuery());
                    MessageBox.Show("Successfully Updated ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
