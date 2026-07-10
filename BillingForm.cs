using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CAFE_MANAGEMENT_2
{
    public class BillingForm : Form
    {
        private DataGridView dgvReceipt;
        private Label lblTotal;
        private Button btnClose;
        private Button btnDownload;
        private Label lblTitle;
        private Label lblCross;

        public BillingForm(DataTable orderData, int totalAmount)
        {
            InitializeComponent();
            
            // Populate grid with passed data
            dgvReceipt.DataSource = orderData;
            lblTotal.Text = "Total Amount: Rs " + totalAmount.ToString();
        }


        private GroupBox grpPayment;
        private RadioButton rbCash;
        private RadioButton rbOnline;
        private PictureBox picQR;

        private void InitializeComponent()
        {
            this.dgvReceipt = new DataGridView();
            this.lblTotal = new Label();
            this.btnClose = new Button();
            this.btnDownload = new Button();
            this.lblTitle = new Label();
            this.lblCross = new Label();
            this.grpPayment = new GroupBox();
            this.rbCash = new RadioButton();
            this.rbOnline = new RadioButton();
            this.picQR = new PictureBox();
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.SuspendLayout();
            
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new Point(250, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(250, 45);
            this.lblTitle.Text = "CAFE RECEIPT";
            
            // lblCross
            this.lblCross.AutoSize = true;
            this.lblCross.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblCross.ForeColor = Color.Black;
            this.lblCross.Location = new Point(760, 10);
            this.lblCross.Name = "lblCross";
            this.lblCross.Size = new Size(30, 32);
            this.lblCross.Text = "X";
            this.lblCross.Cursor = Cursors.Hand;
            this.lblCross.Click += new EventHandler(this.btnClose_Click);
            
            // dgvReceipt
            this.dgvReceipt.BackgroundColor = Color.White;
            this.dgvReceipt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Location = new Point(50, 90);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.Size = new Size(700, 300);
            this.dgvReceipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceipt.AllowUserToAddRows = false;
            this.dgvReceipt.ReadOnly = true;
            
            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new Point(450, 420);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new Size(200, 32);
            this.lblTotal.Text = "Total Amount: ";

            // grpPayment
            this.grpPayment.Location = new Point(50, 420);
            this.grpPayment.Size = new Size(300, 280);
            this.grpPayment.Text = "Payment Method";
            this.grpPayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            
            // rbCash
            this.rbCash.Location = new Point(20, 40);
            this.rbCash.Text = "Cash";
            this.rbCash.Checked = true;
            this.rbCash.CheckedChanged += new EventHandler(this.Payment_CheckedChanged);
            
            // rbOnline
            this.rbOnline.Location = new Point(120, 40);
            this.rbOnline.Text = "Online Scanner";
            this.rbOnline.Size = new Size(160, 25);
            this.rbOnline.CheckedChanged += new EventHandler(this.Payment_CheckedChanged);
            
            // picQR
            this.picQR.Location = new Point(50, 80);
            this.picQR.Size = new Size(180, 180);
            this.picQR.SizeMode = PictureBoxSizeMode.Zoom;
            this.picQR.ImageLocation = @"C:\Users\Poonam\OneDrive\Documents\Visual Studio 2010\Projects\CAFE MANAGEMENT 2\CAFE MANAGEMENT 2\qr_dummy.png";
            this.picQR.Visible = false;
            
            this.grpPayment.Controls.Add(this.rbCash);
            this.grpPayment.Controls.Add(this.rbOnline);
            this.grpPayment.Controls.Add(this.picQR);
            
            // btnDownload
            this.btnDownload.BackColor = Color.FromArgb(46, 204, 113);
            this.btnDownload.FlatStyle = FlatStyle.Flat;
            this.btnDownload.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.btnDownload.ForeColor = Color.White;
            this.btnDownload.Location = new Point(450, 480);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new Size(250, 45);
            this.btnDownload.Text = "DOWNLOAD RECEIPT";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new EventHandler(this.btnDownload_Click);

            // btnClose
            this.btnClose.BackColor = Color.FromArgb(231, 76, 60);
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.Location = new Point(450, 540);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(250, 45);
            this.btnClose.Text = "PAY && FINISH";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);
            
            // BillingForm
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(244, 241, 234);
            this.ClientSize = new Size(800, 750);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCross);
            this.Controls.Add(this.dgvReceipt);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.grpPayment);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "BillingForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "BillingForm";
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Payment_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOnline.Checked)
            {
                picQR.Visible = true;
            }
            else
            {
                picQR.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                sfd.DefaultExt = "txt";
                sfd.FileName = "Receipt_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName))
                        {
                            sw.WriteLine("=====================================");
                            sw.WriteLine("            CAFE RECEIPT             ");
                            sw.WriteLine("=====================================");
                            sw.WriteLine("Date: " + DateTime.Now.ToString("g"));
                            sw.WriteLine();
                            
                            sw.WriteLine(String.Format("{0,-20} {1,-15} {2,-10} {3,-10} {4,-10}", "ItemName", "Category", "Price", "Qty", "Total"));
                            sw.WriteLine("-------------------------------------------------------");
                            
                            DataTable dt = (DataTable)dgvReceipt.DataSource;
                            foreach (DataRow row in dt.Rows)
                            {
                                sw.WriteLine(String.Format("{0,-20} {1,-15} {2,-10} {3,-10} {4,-10}", 
                                    row["ItemName"], row["Category"], row["Price"], row["Qty"], row["Total"]));
                            }
                            
                            sw.WriteLine("-------------------------------------------------------");
                            sw.WriteLine(lblTotal.Text);
                            sw.WriteLine("=====================================");
                            sw.WriteLine("         Thank You For Visiting!     ");
                        }
                        MessageBox.Show("Receipt downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error downloading receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
