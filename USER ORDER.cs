using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CAFE_MANAGEMENT_2
{
    public partial class USER_ORDER : Form
    {
        public USER_ORDER()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Poonam\OneDrive\Documents\ITEM.accdb");

        private void PopulateAllItems()
        {
            try
            {
                con.Open();
                string query = "select * from ITEM";
                OleDbDataAdapter sda = new OleDbDataAdapter(query, con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                if (con.State == System.Data.ConnectionState.Open) con.Close();
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from ITEM";
                OleDbDataAdapter sda = new OleDbDataAdapter(query, con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                
                System.Data.DataView dv = dt.DefaultView;
                if (dt.Columns.Count > 2)
                {
                    string colName = dt.Columns[2].ColumnName;
                    dv.RowFilter = colName + " = '" + comboBox1.SelectedItem.ToString() + "'";
                }
                
                dataGridView1.DataSource = dv.ToTable();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State == System.Data.ConnectionState.Open) con.Close();
            }
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ITEM item = new ITEM();
            item.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            USERFORM ufrom= new USERFORM();
            ufrom.Show();
        }


        DataTable orderTable = new DataTable();

        int totalAmount = 0;
        int currentPrice = 0;
        string selectedItemName = "";

        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int qty = 0;
            if (int.TryParse(textBox3.Text, out qty))
            {
                textBox2.Text = (qty * currentPrice).ToString();
            }
            else
            {
                textBox2.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill all the details before adding to cart.");
                return;
            }

            // Calculate total
            int qty = 0;
            if (int.TryParse(textBox3.Text, out qty))
            {
                totalAmount += qty * currentPrice;
                label3.Text = "order Amount: Rs " + totalAmount;
            }

            // Add to DataGridView
            orderTable.Rows.Add(
                selectedItemName, 
                comboBox1.Text, 
                currentPrice.ToString(),
                textBox3.Text, 
                textBox2.Text
            );

            // After adding to cart, clear the fields
            textBox3.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            currentPrice = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                selectedItemName = row.Cells[1].Value.ToString();
                comboBox1.Text = row.Cells[2].Value.ToString();
                
                // Get price from column 3
                if (row.Cells[3].Value != null)
                {
                    int.TryParse(row.Cells[3].Value.ToString(), out currentPrice);
                }
                textBox3_TextChanged(null, null); // Trigger total calculation
            }
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            if (orderTable.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            BillingForm billForm = new BillingForm(orderTable.Copy(), totalAmount);
            billForm.ShowDialog();
            
            // Clear cart
            orderTable.Rows.Clear();
            totalAmount = 0;
            label3.Text = "order Amount:";
        }


        private void USER_ORDER_Load(object sender, EventArgs e)
        {
            textBox1.Text = new Random().Next(10000, 99999).ToString();
            textBox1.ReadOnly = true;
            if (Form1.userType == "Guest")
            {
                button4.Hide(); // USERS button
                button5.Hide(); // ITEM button
            }

            orderTable.Columns.Add("ItemName", typeof(string));
            orderTable.Columns.Add("Category", typeof(string));
            orderTable.Columns.Add("Price", typeof(string));
            orderTable.Columns.Add("Qty", typeof(string));
            orderTable.Columns.Add("Total", typeof(string));
            dataGridView2.DataSource = orderTable;
            PopulateAllItems();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        

        private void textBox1_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_CursorChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
