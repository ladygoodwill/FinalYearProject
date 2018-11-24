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

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            string Username = InitialWindow.SetUsername;
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
            //using (SqlConnection sqlConnect = new SqlConnection(connectionString))
            //{

            //        sqlConnect.Open();
            //        SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlConnect);
            //        sqlCmd.CommandType = CommandType.StoredProcedure;
            //        SqlCommand cmd = new SqlCommand();
            //        cmd.CommandText = "select * from [tblUsers] where Username=@Username";
            //        cmd.Parameters.AddWithValue("@Username", Username.Text.Trim());
            //        cmd.Connection = sqlConnect;
            //        SqlDataReader dataReader = cmd.ExecuteReader();
            //        if (dataReader.HasRows)
            //        {
            //            MessageBox.Show("Username is already taken, try different one.");
            //            //dataReader.Close();
            //        }
            //        else
            //        {
            //            int countUsernameLetters = Username.Text.Trim().Count();
            //            if (countUsernameLetters > 2)
            //            {
            //                sqlCmd.Parameters.AddWithValue("@Username", Username.Text.Trim());
            //            }
            //            else
            //            {
            //                MessageBox.Show("Username is too short.");
            //            }
            //        }




            //        int countPasswChars = Password.Text.Trim().Count();
            //        if (countPasswChars > 6)
            //        {
            //            sqlCmd.Parameters.AddWithValue("@Password", Password.Text.Trim());
            //        }
            //        else
            //        {
            //            MessageBox.Show("Password is too short, should contain at least 7 digits/letters.");
            //        }

            //        sqlCmd.Parameters.AddWithValue("@Name", Name2.Text.Trim());
            //        sqlCmd.Parameters.AddWithValue("@Surname", Surname.Text.Trim());
            //        int heightNumber;
            //        bool correctHeightValue = Int32.TryParse(Height2.Text.Trim(), out heightNumber);

            //        if (correctHeightValue)
            //        {
            //            if (heightNumber < 50 || heightNumber > 230)
            //            {
            //                MessageBox.Show("Are you sure you entered your height properly?");
            //            }
            //            else
            //            {
            //                sqlCmd.Parameters.AddWithValue("@Height", Convert.ToInt32(Height2.Text.Trim()));
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Please put only digits as height in cm");
            //        }
            //        decimal weightNumber;
            //        bool correctWeightValue = decimal.TryParse(Weight.Text.Trim(), out weightNumber);
            //        if (correctWeightValue)
            //        {
            //            if (weightNumber < 30 || weightNumber > 200)
            //            {
            //                MessageBox.Show("Are you sure you entered your weight correctly?");
            //            }
            //            else
            //            {
            //                sqlCmd.Parameters.AddWithValue("@Weight", decimal.Parse(Weight.Text.Trim()));
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Please put only digits as weight in kg");
            //        }

            //        if (Email.Text.Trim().Contains("@") || Email.Text.Trim().Count() == 0)
            //        {
            //            sqlCmd.Parameters.AddWithValue("@Email", Email.Text.Trim());
            //        }
            //        else
            //        {
            //            MessageBox.Show("Given email is invalid");
            //        }

            //        if (!dataReader.HasRows)
            //        {
            //            dataReader.Close();
            //            sqlCmd.ExecuteNonQuery();
            //            MessageBox.Show("Signing Up succeeded!" + "\n" + "Your login is: " + Username.Text.Trim());

            //            Close();
            //        }
            //        else
            //        {

            //        }

            //        Clear();
            //    }

            //}
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
            using (SqlConnection sqlConnect = new SqlConnection(connectionString))
            {

                sqlConnect.Open();
                SqlCommand sqlCmdAddUserNamePasswGennderIfVeggie = new SqlCommand("UserAdd", sqlConnect);
                SqlCommand sqlCmdAddMeasures = new SqlCommand("MeasureAdd", sqlConnect);
                SqlCommand sqlCmdAddOtherInfo = new SqlCommand("OtherInfoAdd", sqlConnect);

                sqlCmdAddMeasures.CommandType = CommandType.StoredProcedure;
                sqlCmdAddUserNamePasswGennderIfVeggie.CommandType = CommandType.StoredProcedure;
                sqlCmdAddOtherInfo.CommandType = CommandType.StoredProcedure;


                SqlCommand cmdAddUser = new SqlCommand();
                cmdAddUser.CommandText = "select * from [tblUserNamePassw] where Username=@Username";
                cmdAddUser.Parameters.AddWithValue("@Username", Username.Text.Trim());
                cmdAddUser.Connection = sqlConnect;
                SqlDataReader dataReader = cmdAddUser.ExecuteReader();
                if (dataReader.HasRows)
                {
                    MessageBox.Show("Username is already taken, try different one.");

                }
                else
                {
                    int countUsernameLetters = Username.Text.Trim().Count();
                    if (countUsernameLetters > 2)
                    {
                        sqlCmdAddUserNamePasswGennderIfVeggie.Parameters.AddWithValue("@Username", Username.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show("Username is too short.");
                    }
                }
                dataReader.Close();
                int countPasswChars = Password.Text.Trim().Count();
                if (countPasswChars > 6)
                {
                    sqlCmdAddUserNamePasswGennderIfVeggie.Parameters.AddWithValue("@Password", Password.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Password is too short, should contain at least 7 digits/letters.");
                }

                bool isChecked = true;
                if (radioBtnYes.Checked == isChecked || radioBtnNo.Checked == isChecked)
                {
                    if (radioBtnYes.Checked == isChecked)
                    {
                        sqlCmdAddUserNamePasswGennderIfVeggie.Parameters.AddWithValue("@Vegetarian", "Yes");
                    }
                    else
                    {
                        sqlCmdAddUserNamePasswGennderIfVeggie.Parameters.AddWithValue("@Vegetarian", "No");
                    }
                }
                else
                {
                    MessageBox.Show("Please, select if you are vegetarian or not.");
                }


                if (GenderBox.SelectedItem.ToString() != "")
                {
                    sqlCmdAddUserNamePasswGennderIfVeggie.Parameters.AddWithValue("@Gender", GenderBox.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Please, select your gender.");
                }



                SqlCommand cmdAddMeasures = new SqlCommand();
                cmdAddMeasures.CommandText = "select Username from [tblMeasures]";
                cmdAddMeasures.Parameters.AddWithValue("@Username", Username.Text.Trim());
                cmdAddMeasures.Connection = sqlConnect;
                SqlDataReader dataReader2 = cmdAddMeasures.ExecuteReader();
                int count = 0;
                if (dataReader2.HasRows)
                {
                    while (dataReader2.Read())
                    {
                        count++;
                    }


                }
                //else
                //{
                //    sqlCmdAddMeasures.Parameters.AddWithValue("@MeasurementNo", count);
                //}
                sqlCmdAddMeasures.Parameters.AddWithValue("@MeasurementNo", count);
                sqlCmdAddMeasures.Parameters.AddWithValue("@Username", Username.Text.Trim());
                int heightNumber;
                bool correctHeightValue = Int32.TryParse(Height2.Text.Trim(), out heightNumber);

                if (correctHeightValue)
                {
                    if (heightNumber < 50 || heightNumber > 230)
                    {
                        MessageBox.Show("Are you sure you entered your height properly?");
                    }
                    else
                    {
                        sqlCmdAddMeasures.Parameters.AddWithValue("@Height", Convert.ToInt32(Height2.Text.Trim()));
                    }
                }
                else
                {
                    MessageBox.Show("Please put only digits as height in cm");
                }
                decimal weightNumber;
                bool correctWeightValue = decimal.TryParse(Weight.Text.Trim(), out weightNumber);
                if (correctWeightValue)
                {
                    if (weightNumber < 30 || weightNumber > 200)
                    {
                        MessageBox.Show("Are you sure you entered your weight correctly?");
                    }
                    else
                    {
                        sqlCmdAddMeasures.Parameters.AddWithValue("@Weight", decimal.Parse(Weight.Text.Trim()));
                    }
                }
                else
                {
                    MessageBox.Show("Please put only digits as weight in kg");
                }
                dataReader2.Close();

                SqlCommand cmdAddEmail = new SqlCommand();
                cmdAddEmail.CommandText = "select Username from [tblMeasures]";
                cmdAddEmail.Parameters.AddWithValue("@Username", Username.Text.Trim());
                cmdAddEmail.Connection = sqlConnect;
                SqlDataReader dataReader3 = cmdAddEmail.ExecuteReader();
                int countAgain = 0;
                if (dataReader3.HasRows)
                {
                    while (dataReader3.Read())
                    {
                        countAgain++;
                    }
                }

                dataReader3.Close();
                sqlCmdAddOtherInfo.Parameters.AddWithValue("@AddInfoID", countAgain);

                if (Email.Text.Trim().Contains("@") || Email.Text.Trim().Count() == 0)
                {
                    sqlCmdAddOtherInfo.Parameters.AddWithValue("@UserName", Username.Text.Trim());
                    sqlCmdAddOtherInfo.Parameters.AddWithValue("@Email", Email.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Given email is invalid");
                }

                // if (!dataReader.HasRows)
                // {
                //dataReader.Close();
                //ADD EXCEPTION !!!
                sqlCmdAddUserNamePasswGennderIfVeggie.ExecuteNonQuery();
                sqlCmdAddMeasures.ExecuteNonQuery();
                sqlCmdAddOtherInfo.ExecuteNonQuery();
                MessageBox.Show("Signing Up succeeded!" + "\n" + "Your login is: " + Username.Text.Trim());

                Close();
            }
    }
}
