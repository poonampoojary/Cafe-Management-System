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
    public partial class ITEM : Form
    {
        public ITEM()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Poonam\OneDrive\Documents\ITEM.accdb");

        private void button2_Click(object sender, EventArgs e)
        {
            USER_ORDER Uorder = new USER_ORDER();
            Uorder.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            USER_ORDER uorder = new USER_ORDER();
            uorder.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
             USERFORM user = new USERFORM ();
            user.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ItemNO.Text == String.Empty)
            {
                if(ItemName.Text == String.Empty)
                {
                    if(ItemPrice.Text == String.Empty)
                    {
                       MessageBox.Show("Fill All the Filleds");
                    }
                }
            }
            else
            {
                con.Open();
                String query = "insert into ITEM values('" + ItemNO.Text + "','" + ItemName.Text + "','" + ItemCb.SelectedItem + "','" + ItemPrice.Text + "')";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Inserted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                populate();
            }
 

    }

        private void populate()
        {
            try
            {
                con.Open();
                string query = "select * from ITEM";
                OleDbDataAdapter sda = new OleDbDataAdapter(query, con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                UsersGV.DataSource = dt;
                UsersGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open) con.Close();
            }
        }

        private void ITEM_Load(object sender, EventArgs e)
        {
            populate();
        }
}
}
