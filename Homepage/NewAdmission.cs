using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Step 1
using System.Data.SqlClient;



namespace Homepage
{
    public partial class NewAdmission : Form
    {
        public NewAdmission()
        {
            InitializeComponent();
        }



        private void textBox_weight_Enter(object sender, EventArgs e)
        {
            if (textBox_weight.Text == "kg")
            {
                textBox_weight.Text = "";
                textBox_weight.ForeColor = Color.Black;
            }
        }

        private void textBox_weight_Leave(object sender, EventArgs e)
        {
            if (textBox_weight.Text == "")
            {
                textBox_weight.Text = "kg";
                textBox_weight.ForeColor = Color.Black;
            }
        }


        private void textBox_height_ft_Enter(object sender, EventArgs e)
        {
            if (textBox_height_ft.Text == "ft")
            {
                textBox_height_ft.Text = "";
                textBox_height_ft.ForeColor = Color.Black;
            }
        }

        private void textBox_height_ft_Leave(object sender, EventArgs e)
        {
            if (textBox_height_ft.Text == "")
            {
                textBox_height_ft.Text = "ft";
                textBox_height_ft.ForeColor = Color.Black;
            }
        }

        private void textBox_height_in_Enter(object sender, EventArgs e)
        {
            if (textBox_height_in.Text == "in")
            {
                textBox_height_in.Text = "";
                textBox_height_in.ForeColor = Color.Black;
            }
        }

        private void textBox_height_in_Leave(object sender, EventArgs e)
        {
            if (textBox_height_in.Text == "")
            {
                textBox_height_in.Text = "in";
                textBox_height_in.ForeColor = Color.Black;
            }
        }

        private void textBox_reason_Enter(object sender, EventArgs e)
        {
            if (textBox_purpose.Text == "bulk | cut | fitness")
            {
                textBox_purpose.Text = "";
                textBox_purpose.ForeColor = Color.Black;
            }
        }

        private void textBox_reason_Leave(object sender, EventArgs e)
        {
            if (textBox_purpose.Text == "")
            {
                textBox_purpose.Text = "bulk | cut | fitness";
                textBox_purpose.ForeColor = Color.Black;
            }
        }

        private void comboBox_package_Enter(object sender, EventArgs e)
        {



            if (comboBox_package.Text == "                             Select Package")
            {
                comboBox_package.Text = "";
                comboBox_package.ForeColor = Color.Black;
            }
            if (comboBox_category.Text == "Student")
            {
                comboBox_package.Items.Clear();
                comboBox_package.Items.Add("Student 1 month without Treadmill[1500 / RS]");
                comboBox_package.Items.Add("Student month with Treadmill [2300/RS]");
                comboBox_package.Items.Add("Student 2 month without Treadmill [2700/RS]");
                comboBox_package.Items.Add("Student 4 month without Treadmill [4600/RS]");
                comboBox_package.Items.Add("Student 6 month without Treadmill [7000/RS]");
                comboBox_package.Items.Add("Student 12 month without Treadmill [14200/RS]");
            }

            if (comboBox_category.Text == "Non Student")
            {
                comboBox_package.Items.Clear();
                comboBox_package.Items.Add("Non-Student 1 month without Treadmill [1700/RS]");
                comboBox_package.Items.Add("Non-Student month with Treadmill [2500/RS]");
                comboBox_package.Items.Add("Non-Student 2 month without Treadmill [2900/RS]");
                comboBox_package.Items.Add("Non-Student 4 month without Treadmill [4800/RS]");
                comboBox_package.Items.Add("Non-Student 6 month without Treadmill [7200/RS]");
                comboBox_package.Items.Add("Non-Student 12 month without Treadmill [14400/RS]");
            }

            else if (comboBox_category.SelectedIndex == -1|| comboBox_category.Text == "") {
                comboBox_package.Items.Clear();
            }

        }

        private void comboBox_package_Leave(object sender, EventArgs e)
        {
            if (comboBox_package.SelectedIndex == -1)
            {
                label_errorpackage.Visible = true;
            }
            if (comboBox_package.SelectedIndex != -1)
            {
                label_errorpackage.Visible = false;
            }

            if (comboBox_package.Text == "")
            {
                comboBox_package.Text = "                             Select Package";
                comboBox_package.ForeColor = Color.Black;
            }
        }

        private void comboBox_selecttrainer_Enter(object sender, EventArgs e)
        {
            if (comboBox_selecttrainer.Text == "                             Select Trainer")
            {
                comboBox_selecttrainer.Text = "";
                comboBox_selecttrainer.ForeColor = Color.Black;
            }
        }

        private void comboBox_selecttrainer_Leave(object sender, EventArgs e)
        {
            if (comboBox_selecttrainer.Text == "")
            {
                comboBox_selecttrainer.Text = "                             Select Trainer";
                comboBox_selecttrainer.ForeColor = Color.Black;
            }
        }

        private void button_submit_newadmission_Enter(object sender, EventArgs e)
        {
            button_submit_newadmission.ForeColor = Color.DarkOrange;
        }

        private void button_submit_newadmission_Leave(object sender, EventArgs e)
        {
            button_submit_newadmission.ForeColor = Color.White;
        }

        private void button_submit_newadmission_MouseEnter(object sender, EventArgs e)
        {
            button_submit_newadmission.ForeColor = Color.DarkOrange;
        }

        private void button_submit_newadmission_MouseLeave(object sender, EventArgs e)
        {
            button_submit_newadmission.ForeColor = Color.White;
        }

        private void button_clear_Enter(object sender, EventArgs e)
        {
            button_reset.ForeColor = Color.DarkOrange;
        }

        private void button_clear_Leave(object sender, EventArgs e)
        {
            button_reset.ForeColor = Color.White;
        }

        private void button_clear_MouseEnter(object sender, EventArgs e)
        {
            button_reset.ForeColor = Color.DarkOrange;
        }

        private void button_clear_MouseLeave(object sender, EventArgs e)
        {
            button_reset.ForeColor = Color.White;
        }


        private void button_submit_newadmission_Click(object sender, EventArgs e)
        {
            if (textBox_gymno.Text=="")
            {
                label_errorgymno.Visible=true;
                MessageBox.Show("Gym no is missing!");
            }
            if (textBox_name.Text == "")
            {
                label_errorname.Visible = true;
                MessageBox.Show("Name is missing!");
            }
            if (comboBox_category.SelectedIndex == -1|| comboBox_category.Text=="")
            {
                label_errorcategory.Visible = true;
                MessageBox.Show("Please select a category!");
            }
            if (comboBox_package.SelectedIndex==-1)
            {
                label_errorpackage.Visible = true;
                MessageBox.Show("Please select a package!");
            }

            if (textBox_gymno.Text != "")
            {
                label_errorgymno.Visible = false;
            }
            if (textBox_name.Text != "")
            {
                label_errorname.Visible = false;
            }
            if (comboBox_category.SelectedIndex != -1)
            {
                label_errorcategory.Visible = false;
            }
            if (comboBox_package.SelectedIndex != -1)
            {
                label_errorpackage.Visible = false;
            }



            //gymno already exist check
            SqlConnection connection = SQLconnection.Connection();
            string qry_chk_memberid = "SELECT CONVERT (VARCHAR(20),MemberID) FROM MEMBER WHERE CONVERT (VARCHAR(20),MemberID) = '" + textBox_gymno.Text + "'";
            SqlCommand command1 = new SqlCommand(qry_chk_memberid, connection);
            string memberid = (string)command1.ExecuteScalar();
            command1.CommandType = CommandType.Text;

            if (memberid == textBox_gymno.Text) {

                MessageBox.Show("Gym no already exists!!!");
                label_errorgymno.Visible = true;
                label_gym_no_exists.Visible = true;
                }

            else if (memberid != textBox_gymno.Text)
            {
                label_gym_no_exists.Visible = false;
            }

            //all conditions true data insert
            if (memberid != textBox_gymno.Text)
            {
                if (comboBox_category.SelectedIndex != -1 || comboBox_category.Text == "")
                {
                    if (textBox_gymno.Text != "" && textBox_name.Text != "" && comboBox_package.SelectedIndex != -1)
                    {
                        string qry = "INSERT INTO MEMBER(MemberID, MemberName, Gender,DateOfJoining, Add_ress, Contactno, Weigh , HeightFT, HeightIN,Category,FatherName,Purpose,Admissionfee)VALUES('" + int.Parse(textBox_gymno.Text) + "','" + textBox_name.Text + "','" + comboBox_gender.Text + "','" + dateTimePicker_dateofjoining.Text + "','" + textBox_address.Text + "','" + textBox_contact.Text + "','" + textBox_weight.Text + "','" + textBox_height_ft.Text + "','" + textBox_height_in.Text + "','" + comboBox_category.Text + "','" + textBox_fathername.Text + "','" + textBox_purpose.Text + "','" + textBox_admissionfee.Text + "')";
                        SqlCommand command = new SqlCommand(qry, connection);
                        command.CommandType = CommandType.Text;

                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Record Added");
                            reset();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Record can not be added!!!");
                        }
                    }
                }
            }

            

        }
        public void reset()
        {
            textBox_gymno.Clear();
            comboBox_category.Text = string.Empty;
            textBox_name.Clear();
            textBox_fathername.Clear();
            textBox_contact.Clear();
            textBox_address.Clear();
            textBox_weight.Clear();
            textBox_height_ft.Clear();
            textBox_height_in.Clear();
            textBox_purpose.Clear();
            label_gym_no_exists.Visible = false;
            comboBox_package.Items.Clear();
            comboBox_package.Text = string.Empty;
            textBox_admissionfee.Clear();
            comboBox_selecttrainer.Text = string.Empty;
            comboBox_category.Text = string.Empty;
            dateTimePicker_dateofjoining.ResetText();
            label_errorgymno.Visible = false;
            label_errorname.Visible = false;
            label_errorcategory.Visible = false;
            label_errorpackage.Visible = false;
        }
        private void button_reset_Click(object sender, EventArgs e)
        {
            reset();
            MessageBox.Show("Cleared!");
        }

        private void button_searchmember_Enter(object sender, EventArgs e)
        {
            button_searchmember.ForeColor = Color.DarkOrange;
        }

        private void button_searchmember_Leave(object sender, EventArgs e)
        {
            button_searchmember.ForeColor = Color.White;
        }

        private void button_searchmember_MouseEnter(object sender, EventArgs e)
        {
            button_searchmember.ForeColor = Color.DarkOrange;
        }

        private void button_searchmember_MouseLeave(object sender, EventArgs e)
        {
            button_searchmember.ForeColor = Color.White;
        }

        private void button_searchmember_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchMember s1 = new SearchMember();
            s1.ShowDialog();
            this.Show();
        }

        private void comboBox_gender_Enter(object sender, EventArgs e)
        {
            if (comboBox_gender.Text == "                             Select Gender")
            {
                comboBox_gender.Text = "";
                comboBox_gender.ForeColor = Color.Black;
            }
        }

        private void comboBox_gender_Leave(object sender, EventArgs e)
        {
            if (comboBox_gender.Text == "")
            {
                comboBox_gender.Text = "                             Select Gender";
                comboBox_gender.ForeColor = Color.Black;
            }
        }

        private void comboBox_category_Enter(object sender, EventArgs e)
        {
            if (comboBox_category.Text == "                             Select Category")
            {
                comboBox_category.Text = "";
                comboBox_category.ForeColor = Color.Black;
            }

        }

        private void comboBox_category_Leave(object sender, EventArgs e)
        {


            if (comboBox_category.SelectedIndex == -1)
            {
                label_errorcategory.Visible = true;
            }
            if (comboBox_category.SelectedIndex != -1)
            {
                label_errorcategory.Visible = false;
            }

            if (comboBox_category.Text == "")
            {
                comboBox_category.Text = "                             Select Category";
                comboBox_category.ForeColor = Color.Black;
            }
        }



        private void textBox_gymno_Enter(object sender, EventArgs e)
        {
            SqlConnection connection = SQLconnection.Connection();
            string qry_chk_memberid = "SELECT CONVERT (VARCHAR(20),MemberID) FROM MEMBER WHERE CONVERT (VARCHAR(20),MemberID) = '" + textBox_gymno.Text + "'";
            SqlCommand command = new SqlCommand(qry_chk_memberid, connection);
            string memberid = (string)command.ExecuteScalar();
            command.CommandType = CommandType.Text;
            if (memberid == textBox_gymno.Text)
            {
                label_errorgymno.Visible = true;

                label_gym_no_exists.Visible = true;
            }
            else
            {

                label_gym_no_exists.Visible = false;
                label_errorgymno.Visible = false;
                connection.Close();
            }
        }

        private void textBox_gymno_Leave(object sender, EventArgs e)
        {
            if (textBox_gymno.Text == "")
            {
                label_errorgymno.Visible = true;
            }
            else
            {
                label_errorgymno.Visible = false;
            }



            SqlConnection connection = SQLconnection.Connection();
            string qry_chk_memberid = "SELECT CONVERT (VARCHAR(20),MemberID) FROM MEMBER WHERE CONVERT (VARCHAR(20),MemberID) = '" + textBox_gymno.Text + "'";
            SqlCommand command = new SqlCommand(qry_chk_memberid, connection);
            string memberid = (string)command.ExecuteScalar();
            command.CommandType = CommandType.Text;
            if (memberid == textBox_gymno.Text)
            {
                label_errorgymno.Visible = true;
                label_gym_no_exists.Visible = true;
            }
            else
            {
                label_gym_no_exists.Visible = false;
                connection.Close();
            }
        }

        private void textBox_name_Leave(object sender, EventArgs e)
        {
            if (textBox_name.Text == "")
            {
                label_errorname.Visible = true;
            }
            else
            {
                label_errorname.Visible = false;
            }
        }
    }
}
