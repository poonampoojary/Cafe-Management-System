namespace CAFE_MANAGEMENT_2
{
    partial class USERFORM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonItem = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.upassTb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.uphoneTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.unameTb = new System.Windows.Forms.TextBox();
            this.UserGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dividerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.poonamDataSet = new CAFE_MANAGEMENT_2.poonamDataSet();
            this.poonamDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poonamDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.poonamDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UserGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poonamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poonamDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poonamDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poonamDataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.editbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.White;
            this.editbtn.Location = new System.Drawing.Point(320, 390);
            this.editbtn.Name = "editbtn";
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.FlatAppearance.BorderSize = 0;
            this.editbtn.Size = new System.Drawing.Size(102, 42);
            this.editbtn.TabIndex = 46;
            this.editbtn.Text = "EDIT";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(51, 119);
            this.button5.Name = "button5";
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button5.Size = new System.Drawing.Size(204, 41);
            this.button5.TabIndex = 10;
            this.button5.Text = "ORDER";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(320, 438);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.Size = new System.Drawing.Size(102, 42);
            this.deletebtn.TabIndex = 45;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 27);
            this.label6.TabIndex = 44;
            this.label6.Text = "password:";
            // 
            // upassTb
            // 
            this.upassTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upassTb.Location = new System.Drawing.Point(320, 304);
            this.upassTb.Name = "upassTb";
            this.upassTb.Size = new System.Drawing.Size(150, 28);
            this.upassTb.TabIndex = 43;
            this.upassTb.Text = "\r\n";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(51, 172);
            this.button4.Name = "button4";
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button4.Size = new System.Drawing.Size(204, 41);
            this.button4.TabIndex = 9;
            this.button4.Text = "USER";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // 
            // buttonItem
            // 
            this.buttonItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.buttonItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItem.ForeColor = System.Drawing.Color.White;
            this.buttonItem.Location = new System.Drawing.Point(51, 225);
            this.buttonItem.Name = "buttonItem";
            this.buttonItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItem.FlatAppearance.BorderSize = 0;
            this.buttonItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonItem.Size = new System.Drawing.Size(204, 41);
            this.buttonItem.TabIndex = 11;
            this.buttonItem.Text = "ITEMS";
            this.buttonItem.UseVisualStyleBackColor = false;
            this.buttonItem.Click += new System.EventHandler(this.buttonItem_Click);
            // 
            // uphoneTb
            // 
            this.uphoneTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uphoneTb.Location = new System.Drawing.Point(320, 203);
            this.uphoneTb.Name = "uphoneTb";
            this.uphoneTb.Size = new System.Drawing.Size(150, 28);
            this.uphoneTb.TabIndex = 42;
            this.uphoneTb.Text = "\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 27);
            this.label5.TabIndex = 41;
            this.label5.Text = "phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 27);
            this.label4.TabIndex = 40;
            this.label4.Text = "username:";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.Location = new System.Drawing.Point(320, 342);
            this.addbtn.Name = "addbtn";
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.Size = new System.Drawing.Size(102, 42);
            this.addbtn.TabIndex = 39;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(51, 636);
            this.button2.Name = "button2";
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(204, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "LOGOUT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(742, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 27);
            this.label3.TabIndex = 38;
            this.label3.Text = "USER LIST";
            // 
            // unameTb
            // 
            this.unameTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameTb.Location = new System.Drawing.Point(320, 101);
            this.unameTb.Name = "unameTb";
            this.unameTb.Size = new System.Drawing.Size(150, 28);
            this.unameTb.TabIndex = 37;
            this.unameTb.Text = "\r\n";
            // 
            // UserGV
            // 
            this.UserGV.BackgroundColor = System.Drawing.Color.White;
            this.UserGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGV.Location = new System.Drawing.Point(500, 87);
            this.UserGV.Name = "UserGV";
            this.UserGV.Size = new System.Drawing.Size(650, 614);
            this.UserGV.TabIndex = 36;
            this.UserGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserGV_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 35);
            this.label2.TabIndex = 35;
            this.label2.Text = "MANAGE USER";
            
            // 
            // dividerPanel
            // 
            this.dividerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(110)))), ((int)(((byte)(99)))));
            this.dividerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dividerPanel.Location = new System.Drawing.Point(295, 0);
            this.dividerPanel.Name = "dividerPanel";
            this.dividerPanel.Size = new System.Drawing.Size(4, 727);
            this.dividerPanel.TabIndex = 999;
            // 
            // panel1

            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.buttonItem);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 727);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // poonamDataSet
            // 
            this.poonamDataSet.DataSetName = "poonamDataSet";
            this.poonamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poonamDataSetBindingSource
            // 
            this.poonamDataSetBindingSource.DataSource = this.poonamDataSet;
            this.poonamDataSetBindingSource.Position = 0;
            // 
            // poonamDataSetBindingSource1
            // 
            this.poonamDataSetBindingSource1.DataSource = this.poonamDataSet;
            this.poonamDataSetBindingSource1.Position = 0;
            // 
            // poonamDataSetBindingSource2
            // 
            this.poonamDataSetBindingSource2.DataSource = this.poonamDataSet;
            this.poonamDataSetBindingSource2.Position = 0;
            // 
            // USERFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 727);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.upassTb);
            this.Controls.Add(this.uphoneTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unameTb);
            this.Controls.Add(this.UserGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dividerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "USERFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USERFORM";
            this.Load += new System.EventHandler(this.USERFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserGV)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poonamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poonamDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poonamDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poonamDataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox upassTb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox uphoneTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox unameTb;
        private System.Windows.Forms.DataGridView UserGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource poonamDataSetBindingSource;
        private poonamDataSet poonamDataSet;
        private System.Windows.Forms.BindingSource poonamDataSetBindingSource2;
        private System.Windows.Forms.BindingSource poonamDataSetBindingSource1;
        private System.Windows.Forms.Panel dividerPanel;
    }
}