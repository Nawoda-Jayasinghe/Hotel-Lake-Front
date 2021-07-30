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
    public partial class FormNewGuest : Form
    {

        Form currentForm;

        public FormNewGuest()
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


        private void cbForeign_CheckedChanged(object sender, EventArgs e)
        {
            if (cbForeign.Checked)
            {
                lblNIC.Text = "Passport No";

                mtbTP1.Mask = "(+0) 000-000-0000";
                mtbTP2.Mask = "(+0) 000-000-0000";

                mtbNIC.Mask = null;
            }

            else
            {
                lblNIC.Text = "National ID";
                mtbTP1.Mask = "(\\000) 000-0000";
                mtbTP2.Mask = "(\\000) 000-0000";
                mtbNIC.Mask = "000000000AAA";
            }
        }

        private void mtbNIC_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbForeign.Checked == false)
            {
                mtbNIC.SelectionStart = 0;
            }
        }


        private void mtbTP1_Click(object sender, EventArgs e)
        {
            mtbTP1.SelectionStart = 2;
        }


        private void mtbTP2_MouseClick(object sender, MouseEventArgs e)
        {
            mtbTP2.SelectionStart = 2;
        }


        private void mtbEmail_Enter(object sender, EventArgs e)
        {
            if (mtbEmail.Text == "example@gmail.com")
            {
                mtbEmail.Text = "";
                mtbEmail.ForeColor = Color.FromArgb(26, 25, 62);
            }
        }


        private void mtbEmail_Leave(object sender, EventArgs e)
        {
            if (mtbEmail.Text == "")
            {
                mtbEmail.Text = "example@gmail.com";
                mtbEmail.ForeColor = Color.Gray;
            }
        }


        private void panelGuest_Enter(object sender, EventArgs e)
        {
            if (lblSingleNormalCount.Text == "0")
            {
                cbSingleNormalCount.Enabled = false;
            }

            if (lblSingleLuxuryCount.Text == "0")
            {
                cbSingleLuxuryCount.Enabled = false;
            }

            if (lblDoubleNormalCount.Text == "0")
            {
                cbDoubleNormalCount.Enabled = false;
            }

            if (lblDoubleLuxuryCount.Text == "0")
            {
                cbDoubleLuxuryCount.Enabled = false;
            }

            if (lblSingleNormalCount.Text == "0")
            {
                cbSingleNormalCount.Enabled = false;
            }

            if (lblFamilyLuxuryCount.Text == "0")
            {
                cbFamilyLuxuryCount.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbForeign.Checked)
            {
                cbForeign.Checked = false;
            }

            mtbNIC.Text = "";
            txtFName.Text = "";
            txtFullName.Text = "";
            radioMale.Checked = true;
            rchtxtAddress.Text = "";
            mtbTP1.Text = "";
            mtbTP2.Text = "";
            mtbEmail.Text = "example@gmail.com";
            mtbEmail.ForeColor = Color.Gray;

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
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();
        }

        //data reader
        private string DataReader(string sql, MySqlConnection conn)
        {
            string output = "";
            MySqlCommand command = new MySqlCommand(sql,conn);
            //command.Parameters.AddWithValue(txtFName,)
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                output += dataReader.GetValue(0).ToString();//+" - "+ dataReader.GetValue(1).ToString() + " - " + dataReader.GetValue(2).ToString()+" - " + dataReader.GetValue(3).ToString() + " - " + dataReader.GetValue(4).ToString() + " - " + dataReader.GetValue(5).ToString() + " - " + dataReader.GetValue(6).ToString();
            }
            return output;
        }

        private void btnGuestSave_Click(object sender, EventArgs e)
        {
            if(mtbNIC.Text == "" || txtFName.Text == "" || txtFullName.Text == "" || rchtxtAddress.Text == "" || mtbTP1.Text == "" || mtbTP1.Text == "(0  )    -")
            {

                DialogResult reslult = MessageBox.Show("Please fill all fields","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else { 

                try {

                    string idType;
                    string gender;
                    string email;

                    if (cbForeign.Checked) {                       
                        idType = "PASS";
                    }

                    else
                    {
                        idType = "NIC";
                    }

                    
                    if (radioMale.Checked)
                    {
                        gender = "M";
                    }

                    else
                    {
                        gender = "F";
                    }


                    if (mtbEmail.Text == "example@gmail.com")
                    {
                        email = "";
                    }

                    else
                    {
                        email = mtbEmail.Text;
                    }

                    
                    
                    string sql = "CALL addNewGuest('" + idType + "','" + mtbNIC.Text + "','" + txtFName.Text + "','" + txtFullName.Text + "','" + gender + "','" + email + "','" + rchtxtAddress.Text + "')";
                    DataAdapter(sql,dbQuery());

                    string tp1 = "CALL addNewTP('"+ mtbNIC.Text +"','"+mtbTP1.Text +"')";
                    DataAdapter(tp1, dbQuery());

                    if(mtbTP2.Text != "(0  )    -")
                    {
                        string tp2 = "CALL addNewTP('" + mtbNIC.Text + "','" + mtbTP2.Text + "')";
                        DataAdapter(tp2, dbQuery());
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void mtbNIC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string fName = DataReader("SELECT FName FROM guest_details WHERE IDNumber = '" + mtbNIC.Text + "';", dbQuery());
                string fullName = DataReader("SELECT FullName FROM guest_details WHERE IDNumber = '" + mtbNIC.Text + "';", dbQuery());
                string Gen = DataReader("SELECT Gender FROM guest_details WHERE IDNumber = '" + mtbNIC.Text + "';", dbQuery());
                string Email = DataReader("SELECT Email FROM guest_details WHERE IDNumber = '" + mtbNIC.Text + "';", dbQuery());
                string Addr = DataReader("SELECT GuestAddress FROM guest_details WHERE IDNumber = '" + mtbNIC.Text + "';", dbQuery());
                string IDCategory = DataReader("SELECT IDCategory FROM guest_details WHERE IDNumber = '" + mtbNIC.Text + "';", dbQuery());
                string TP = DataReader("CALL getTPbyID('"+ mtbNIC.Text + "');", dbQuery());

                //string sql = "CALL getValuesById('" + mtbNIC.Text +"',"+@fName+","+@fullName+ "," + @Gen + "," + @Email +"," + @Addr + "," + @IDCategory + ");";

                if (fName != "")
                {
                    DialogResult reslult = MessageBox.Show("This is registered customer. Do you want to fill in the data automatically??", "Confirm Autofill", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (reslult == DialogResult.Yes)
                    {
                        txtFName.Text = fName;
                        txtFullName.Text = fullName;
                        mtbEmail.Text = Email;
                        mtbEmail.ForeColor = Color.FromArgb(26, 25, 62);
                        rchtxtAddress.Text = Addr;
                        mtbTP1.Text = TP;

                        if (Gen == "F")
                        {
                            radioFemale.Checked=true;
                        }

                        else
                        {
                            radioMale.Checked = true;
                        }


                        if (IDCategory == "PASS")
                        {
                            cbForeign.Checked = true;
                        }

                        else if (IDCategory == "NIC")
                        {
                            cbForeign.Checked = false;
                        }


                    }
                    
                }

               
               // txtFName.Text= 
                txtFullName.Text = 
                rchtxtAddress.Text= DataReader(Addr, dbQuery());
                mtbEmail.Text= DataReader(Email, dbQuery());


            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }

        }

        private void mtbTP1_Enter(object sender, EventArgs e)
        {
            if (mtbTP1.Text == "(0  )    -")
            {
                mtbTP1.Text = "";
                mtbTP1.ForeColor = Color.FromArgb(26, 25, 62);
                MessageBox.Show("aa");
            }
        }
    }
}
