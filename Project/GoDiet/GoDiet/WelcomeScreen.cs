using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GoDiet
{
    public partial class WelcomeScreen : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Owner\Documents\GoDietCustInfo.mdf;Integrated Security = True";

        void ClosePreviousWindow()
        {
            InitialWindow init = new InitialWindow();
            init.Close();
        }
        public WelcomeScreen()
        {
            InitializeComponent();
        }
        string Username = InitialWindow.SetUsername;
        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            unameBox.Text = Username;

            using (
                SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from [tblMeasures] where Username=@Username";
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Connection = connection;
                string weight = "0";
                try
                {
                    connection.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            weight = dataReader.GetInt32(3).ToString();
                        }
                    }
                    weightBox.Text = weight;
                    dataReader.Close();
                    connection.Close();
                }
                catch (Exception)
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }

            dietModeBox.Text = "tbc";
            BMIBox.Text = "tbc";
            kgBox.Text = "tbc";
            intakeBox.Text = "tbc";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RemoveAccountBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            // here is space to add some information about user
            // such as login, and other included already in the dbs

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            // here is space to show predicted weight loss
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void GenderBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void unameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void intakeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            surnameBox.Text = "";
            yesRadioBtn.Checked = false;
            noRadioBtn.Checked = false;
            GenderBox.SelectedItem = "";
            oldPasswBox.Text = "";
            newPasswBox.Text = "";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //declare variables needed for operations
            string Name = "";
            string Surname = "";
            string Vegetarian = "";
            string Gender = "";
            string Password = "";

            //assign variables to data
            Name = nameBox.Text;
            Surname = surnameBox.Text;
            if (yesRadioBtn.Checked)
            {
                Vegetarian = "Yes";
            }

            if (noRadioBtn.Checked)
            {
                Vegetarian = "No";
            }

            Gender = GenderBox.Text;
            Password = oldPasswBox.Text;

            using (SqlConnection sqlConnect = new SqlConnection(connectionString))
            {
                if (Name != "" || Surname != "")
                {
                    // code to update Name and Surname
                    try
                    {
                        sqlConnect.Open();
                        SqlCommand sqlCmdUpdateNameSurname = new SqlCommand("NameSurnameUpdate", sqlConnect);
                        sqlCmdUpdateNameSurname.CommandType = CommandType.StoredProcedure;
                        SqlCommand cmdUpdateNameSurname = new SqlCommand();
                        cmdUpdateNameSurname.CommandText = "SELECT * from [tblOtherInfo] WHERE UserName=@UserName";
                        cmdUpdateNameSurname.Parameters.AddWithValue("@UserName", Username);
                        cmdUpdateNameSurname.Parameters.AddWithValue("@Name", Name);
                        cmdUpdateNameSurname.Parameters.AddWithValue("@Surname", Surname);

                        cmdUpdateNameSurname.Connection = sqlConnect;
                        sqlCmdUpdateNameSurname.Parameters.AddWithValue("@UserName", Username);
                        sqlCmdUpdateNameSurname.Parameters.AddWithValue("@Name", Name);
                        sqlCmdUpdateNameSurname.Parameters.AddWithValue("@Surname", Surname);
                        sqlCmdUpdateNameSurname.ExecuteNonQuery();
                        MessageBox.Show("SQL Query successful!");
                        sqlConnect.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("SQL Query unsuccessful");
                    }
                }

                // code to update vegetarian option
                if (Vegetarian != "")
                {
                    try
                    {
                        sqlConnect.Open();
                        SqlCommand sqlCmdUpdateVegetarian = new SqlCommand("VegetarianUpdate", sqlConnect);
                        sqlCmdUpdateVegetarian.CommandType = CommandType.StoredProcedure;
                        SqlCommand cmdUpdateVegetarian = new SqlCommand();
                        cmdUpdateVegetarian.CommandText = "SELECT * from [tblUserNamePassw] WHERE UserName=@UserName";
                        cmdUpdateVegetarian.Parameters.AddWithValue("@Username", Username);
                        cmdUpdateVegetarian.Parameters.AddWithValue("@Vegetarian", Vegetarian);
                        cmdUpdateVegetarian.Connection = sqlConnect;
                        sqlCmdUpdateVegetarian.Parameters.AddWithValue("@Username", Username);
                        sqlCmdUpdateVegetarian.Parameters.AddWithValue("@Vegetarian", Vegetarian);
                        sqlCmdUpdateVegetarian.ExecuteNonQuery();
                        MessageBox.Show("SQL Query successful!");
                        sqlConnect.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("SQL Query unsuccessful");
                    }
                }

                //code to update Gender
                if (Gender != "")
                {
                    try
                    {
                        sqlConnect.Open();
                        SqlCommand sqlCmdUpdateGender = new SqlCommand("GenderUpdate", sqlConnect);
                        sqlCmdUpdateGender.CommandType = CommandType.StoredProcedure;
                        SqlCommand cmdUpdateGender = new SqlCommand();
                        cmdUpdateGender.CommandText = "SELECT * from [tblUserNamePassw] WHERE UserName=@UserName";
                        cmdUpdateGender.Parameters.AddWithValue("@Username", Username);
                        cmdUpdateGender.Parameters.AddWithValue("@Gender", Gender);
                        cmdUpdateGender.Connection = sqlConnect;
                        sqlCmdUpdateGender.Parameters.AddWithValue("@Username", Username);
                        sqlCmdUpdateGender.Parameters.AddWithValue("@Gender", Gender);
                        sqlCmdUpdateGender.ExecuteNonQuery();
                        MessageBox.Show("SQL Query successful!");
                        sqlConnect.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("SQL Query unsuccessful");
                    }
                }

                // fun now... .code to update Password
                if (Password != "")
                {
                    try
                    {
                        sqlConnect.Open();
                        SqlCommand sqlCmdUpdatePassword = new SqlCommand("PasswordUpdate", sqlConnect);
                        sqlCmdUpdatePassword.CommandType = CommandType.StoredProcedure;
                        SqlCommand cmdUpdatePassword = new SqlCommand();
                        cmdUpdatePassword.CommandText = "SELECT Password from [tblUserNamePassw] WHERE UserName=@UserName";
                        cmdUpdatePassword.Parameters.AddWithValue("@Username", Username);
                        //cmdUpdatePassword.Parameters.AddWithValue("@Gender", Gender);
                        cmdUpdatePassword.Connection = sqlConnect;
                        try
                        {
                            string oldPassword = "";
                            SqlDataReader dataReader = cmdUpdatePassword.ExecuteReader();
                            if (dataReader.HasRows)
                            {
                                while (dataReader.Read())
                                {
                                    oldPassword = dataReader.GetSqlString(0).ToString();
                                }
                            }
                            dataReader.Close();

                            if (Password == oldPassword)
                            {
                                if (newPasswBox.Text != "" && newPasswBox.Text.Count() > 6)
                                {
                                    Password = newPasswBox.Text;
                                }
                                else
                                {
                                    MessageBox.Show("Please make sure your new password contains at least 7 letters!");
                                }
                            }

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Unsuccessful operation!");
                        }

                        sqlCmdUpdatePassword.Parameters.AddWithValue("@Username", Username);
                        sqlCmdUpdatePassword.Parameters.AddWithValue("@Password", Password);
                        sqlCmdUpdatePassword.ExecuteNonQuery();
                        sqlConnect.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("SQL Query unsuccessful");
                    }
                }

            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void predictedProgressWeightLossLbl_Click(object sender, EventArgs e)
        {

        }
    }
}

