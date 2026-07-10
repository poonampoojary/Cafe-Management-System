using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace coffee_management
{
    public partial class registerform : Form
    {
        public registerform()
        {
            InitializeComponent();
            SqlCeCommand cmd = new
            SqlCeCommand("SELECT*FROM REGISTER",
                new SqlCeConnection("data source=coffee.sdf;"));
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_loginbtn_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();


            this.Hide();

        }

        private void register_showpass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showpass.Checked ? '\0' : '*';
            register_cpassword.PasswordChar = register_showpass.Checked ? '\0' : '*';

        }
        public bool emptyfields()
        {
            if (register_username.Text == "" || register_password.Text == "" || register_cpassword.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (emptyfields())
            {
                MessageBox.Show("All fields are required to be filled.", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (register_cpassword.Text != register_cpassword.Text)
            {
                MessageBox.Show("password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string username = register_username.Text.Trim();
            string password = register_password.Text;
            string checkQuery = "SELECT COUNT(*)FROM REGISTER WHERE username=@username";
            string connectingString =@"Data Source=C:\Users\Poonam\onedrive\documents\visual studio 2010\Projects\coffee management\coffee management\coffee.sdf";
            SqlCeConnection con = new
            SqlCeConnection(connectingString);
            {
                try
                {
                    con.Open();
                    SqlCeCommand cmd = new SqlCeCommand(checkQuery, con);
                    cmd.Parameters.AddWithValue("@username", "admin");
                    int userCount = (int)cmd.ExecuteScalar();
                    if (userCount > 0)
                    {
                        MessageBox.Show("username already exists please choose anathoer one .", "duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string insertQuery = "INSERT INTO REGISTER(username,password,date_reg)"+" VALUES (@username, @password,@date_reg)";
                    cmd = new SqlCeCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@usernaame",register_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", register_password.Text.Trim());
                    cmd.Parameters.AddWithValue("@date_reg", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("registeration successful !", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    register_username.Text = "";
                    register_password.Text = "";
                    register_cpassword.Text = "";
                    register_showpass.Checked = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }


            }
        }
    }
}
 