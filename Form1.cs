using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CAFE_MANAGEMENT_2
{
     public partial class Form1 : Form
    {
        public static string userType = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "poonam" && login_password.Text == "poonam2006")
            {
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                login_username.Clear();
                login_password.Clear();
                userType = "Admin";
                USER_ORDER uorder = new USER_ORDER();
                uorder.Show();
                this.Hide();
                return;
            }

            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Poonam\OneDrive\Documents\poonam.accdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * from userTbl Where uname = '" + login_username.Text + "' AND upassword = '" + login_password.Text + "'";
                OleDbDataReader dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    login_username.Clear();
                    login_password.Clear();
                    USER_ORDER uorder = new USER_ORDER();
                    uorder.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userType = "Guest";
            this.Hide();
            USER_ORDER uorder = new USER_ORDER();
            uorder.Show();
        }


        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (login_password.PasswordChar == '*')
            {
                login_password.PasswordChar = '\0';
                btnShowPassword.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                login_password.PasswordChar = '*';
                btnShowPassword.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            login_username.Text = "";
            login_password.Text = "";
        }
    }
}
