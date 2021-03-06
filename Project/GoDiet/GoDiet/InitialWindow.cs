﻿// change absolute for relative path
// how to close this window after WelcomeScreen is shown up?

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
    public partial class InitialWindow : Form
    {
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Owner\Desktop\Go Diet App\Project\GoDiet\GoDiet\Properties\DataSources\LoginCredentials.mdf;Integrated Security = True";
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Owner\Documents\GoDietCustInfo.mdf;Integrated Security = True";
        //public string userName;
        public InitialWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }


        public static string SetUsername = "";
        public static string SetPassword = "";
        private void SignIn_Click(object sender, EventArgs e)
        {
            using (
                SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from [tblUserNamePassw] where Username=@Username and Password=@Password";
                cmd.Parameters.AddWithValue("@Username", UsernameLogin.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", PasswLogin.Text.Trim()); 
                cmd.Connection = connection;
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (!dataReader.HasRows)
                {
                    MessageBox.Show("Username does not exist or password is incorrect.");
                    Clear();
                }
                else
                {
                    SetUsername = UsernameLogin.Text;
                    //SetPassword = PasswLogin
                    WelcomeScreen welcomeSc = new WelcomeScreen();
                    welcomeSc.Show();                 
                }
            }            
        }



        void Clear()
        {
            UsernameLogin.Text = PasswLogin.Text = "";
        }

        public string getUsername(string userName)
        {
            return userName;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserLabel_TextChanged(object sender, EventArgs e)
        {
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SetupWindow setup = new SetupWindow();
            setup.Show();
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PasswLogin.Focus();
            }
        }

        private void PasswLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignIn.PerformClick();
            }
        }
    }
}
