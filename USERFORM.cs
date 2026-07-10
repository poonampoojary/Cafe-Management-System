using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace CAFE_MANAGEMENT_2
{
    public partial class USERFORM : Form
    {
        DataTable dt;

        void GetOrders()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Poonam\OneDrive\Documents\poonam.accdb");
            OleDbDataAdapter ada = new OleDbDataAdapter("select * from userTbl", con);
            dt= new DataTable();
            con.Open();
            ada.Fill(dt);
            UserGV.DataSource = dt;
            con.Close();
        }
        public USERFORM()
        {
            InitializeComponent();
            
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Poonam\OneDrive\Documents\poonam.accdb");
           void populate()
        {
            con.Open();
            string query = "select * from userTbl";
            OleDbDataAdapter sda = new OleDbDataAdapter(query, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserGV.DataSource= ds.Tables[0];
            UserGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (UserGV.Columns.Contains("upassword"))
            {
                UserGV.Columns["upassword"].Visible = false;
            }
            con.Close();
        }
          
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            USER_ORDER uorder = new USER_ORDER();
            uorder.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Already on USERFORM, do nothing or show a message
            MessageBox.Show("You are already on the User Management page.");
        }

        private void buttonItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ITEM itemForm = new ITEM();
            itemForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into UserTbl (uname,uphone,upassword) values('" + unameTb.Text + "','" + uphoneTb.Text + "','" + upassTb.Text + "');";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("user successfully created");
            con.Close();
            GetOrders();
             

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            populate();
        }

        private void USERFORM_Load(object sender, EventArgs e)
        {
            GetOrders();
            button4.Hide();
            addbtn.Hide();
            editbtn.Hide();
            upassTb.Hide();
            label6.Hide();
        }

        private void UserGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (unameTb.Text == "" || uphoneTb.Text == "" || upassTb.Text == "")
            {
                MessageBox.Show("fill all the field");
            }
            else
            {
                con.Open();
                string query = "update set name ='" + unameTb.Text + "',upassword='" + upassTb.Text + "'where uphone='" + uphoneTb.Text + "'";
                OleDbCommand cmd = new OleDbCommand(query, con);
                MessageBox.Show("users succesfully updated");
                con.Close();
                populate();
            }
   }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "delete from userTb where uphone='" + uphoneTb.Text + "';";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("user deleted succesfully");
                con.Close();
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }   
    }
}
