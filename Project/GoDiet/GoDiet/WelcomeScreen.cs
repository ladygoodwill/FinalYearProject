using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoDiet
{
    public partial class WelcomeScreen : Form
    {
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

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Owner\Desktop\Go Diet App\Project\GoDiet\GoDiet\Properties\DataSources\LoginCredentials.mdf;Integrated Security = True";
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
    }
}
