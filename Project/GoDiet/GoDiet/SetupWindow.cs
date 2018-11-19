// need to improve GUI
// change images
// connectionString is hardcoded! Change it.
// refactor code - SQL especially divide into smaller classes, DRY
// User Agreement Contract to be produced and attached


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
using System;
using System.IO;

namespace GoDiet

{
    public partial class SetupWindow : Form
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Owner\Desktop\Go Diet App\Project\GoDiet\GoDiet\Properties\DataSources\LoginCredentials.mdf;Integrated Security = True";
        public SetupWindow()
        {
            InitializeComponent();
        }
        
        private void SetupWindow_Load(object sender, EventArgs e)
        {

        }
        //private int height;
        //private float weight;
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Password.Text == "" || passwConf.Text == "" || Height2.Text == "" || Weight.Text == "")
            {
                MessageBox.Show("Please fill mandatory fields");
                
            }
            else if (Password.Text != passwConf.Text)
            {
                MessageBox.Show("Passwords are not identical");
            }
            else
            {



                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                {

                    sqlConnect.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlConnect);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from [tblUsers] where Username=@Username";
                    cmd.Parameters.AddWithValue("@Username", Username.Text.Trim());
                    cmd.Connection = sqlConnect;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("Username is already taken, try different one.");
                        //dataReader.Close();
                    }
                    else
                    {
                        int countUsernameLetters = Username.Text.Trim().Count();
                        if (countUsernameLetters > 2)
                        {
                            sqlCmd.Parameters.AddWithValue("@Username", Username.Text.Trim());
                        }
                        else
                        {
                            MessageBox.Show("Username is too short.");
                        }
                    }




                    int countPasswChars = Password.Text.Trim().Count();
                    if (countPasswChars > 6)
                    {
                        sqlCmd.Parameters.AddWithValue("@Password", Password.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show("Password is too short, should contain at least 7 digits/letters.");
                    }

                    sqlCmd.Parameters.AddWithValue("@Name", Name2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Surname", Surname.Text.Trim());
                    int heightNumber;
                    bool correctHeightValue = Int32.TryParse(Height2.Text.Trim(), out heightNumber);

                    if (correctHeightValue)
                    {
                        if (heightNumber < 50 || heightNumber > 230 )
                        {
                            MessageBox.Show("Are you sure you entered your height properly?");
                        }
                        else
                        {
                            sqlCmd.Parameters.AddWithValue("@Height", Convert.ToInt32(Height2.Text.Trim()));
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
                            sqlCmd.Parameters.AddWithValue("@Weight", decimal.Parse(Weight.Text.Trim()));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please put only digits as weight in kg");
                    }

                    if (Email.Text.Trim().Contains("@") || Email.Text.Trim().Count() == 0)
                    {
                        sqlCmd.Parameters.AddWithValue("@Email", Email.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show("Given email is invalid");
                    }

                    if (!dataReader.HasRows)
                    {
                        dataReader.Close();
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Signing Up succeeded!" + "\n" + "Your login is: " + Username.Text.Trim());
                        
                        Close();
                    }
                    else
                    {

                    }

                    Clear();
                }
                
            }
        }

        void Clear()
        {
            Password.Text = passwConf.Text = "";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from [tblUsers] where Username=@Username";
                cmd.Parameters.AddWithValue("@Username", Username.Text.Trim());
                cmd.Connection = connection;
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (!dataReader.HasRows)
                {
                    checkInfo.Visible = true;
                    checkInfo.Text = "Username available";
                    checkInfo.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    checkInfo.Visible = true;
                    checkInfo.Text = "Username taken";
                    checkInfo.ForeColor = System.Drawing.Color.Red;
                }
            }
            
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        void changeFocus(TextBox name, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                name.Focus();
            }
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    Password.Focus();
            //}
            changeFocus(Password, e);
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            changeFocus(passwConf, e);
        }

        private void passwConf_KeyDown(object sender, KeyEventArgs e)
        {
            changeFocus(Name2, e);
        }

        private void Name2_KeyDown(object sender, KeyEventArgs e)
        {
            changeFocus(Surname, e);
        }

        private void Surname_KeyDown(object sender, KeyEventArgs e)
        {
            changeFocus(Height2, e);
        }



        private void Weight_KeyDown(object sender, KeyEventArgs e)
        {
            changeFocus(Email, e);
        }

        private void Height2_KeyDown(object sender, KeyEventArgs e)
        {
            changeFocus(Weight, e);
        }

        private void Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitBtn.PerformClick();
            }
        }
    }
}
