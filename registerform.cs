using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace coffee_management
{
    public partial class registerform : Form
    {
        public registerform()
        {
            InitializeComponent();
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
            if(register_username.Text==""||register_password.Text==""||register_cpassword.Text=="")
            {
                return true;
            }
            else
            {
                return false;
            }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if(emptyfields())
            {
                MessageBox.Show("All fields are required to be filled.","error message",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
            else
            {
                string selectusername="select * from user WHERE username=@usern:;//

       
    }
}
