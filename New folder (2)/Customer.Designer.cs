namespace AuboDrive
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneTbl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Customerslist = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.AddressTbl = new System.Windows.Forms.TextBox();
            this.NameTbl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdTbl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customerslist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 162);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1110, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 53);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(567, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 53);
            this.label4.TabIndex = 4;
            this.label4.Text = "Manage Customers";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 105);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ayubo Drive";
            // 
            // PhoneTbl
            // 
            this.PhoneTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PhoneTbl.Location = new System.Drawing.Point(181, 440);
            this.PhoneTbl.Name = "PhoneTbl";
            this.PhoneTbl.Size = new System.Drawing.Size(165, 32);
            this.PhoneTbl.TabIndex = 51;
            this.PhoneTbl.TextChanged += new System.EventHandler(this.PhoneTbl_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(28, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 53);
            this.label8.TabIndex = 50;
            this.label8.Text = "Phone";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Customerslist
            // 
            this.Customerslist.BackgroundColor = System.Drawing.Color.White;
            this.Customerslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customerslist.GridColor = System.Drawing.Color.White;
            this.Customerslist.Location = new System.Drawing.Point(402, 221);
            this.Customerslist.Name = "Customerslist";
            this.Customerslist.RowHeadersWidth = 62;
            this.Customerslist.RowTemplate.Height = 28;
            this.Customerslist.Size = new System.Drawing.Size(736, 475);
            this.Customerslist.TabIndex = 49;
            this.Customerslist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Customerslist_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(139, 591);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 57);
            this.button4.TabIndex = 48;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(258, 528);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 57);
            this.button3.TabIndex = 47;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(139, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 57);
            this.button1.TabIndex = 46;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(20, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 57);
            this.button2.TabIndex = 45;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(591, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 53);
            this.label7.TabIndex = 44;
            this.label7.Text = "customers List";
            // 
            // AddressTbl
            // 
            this.AddressTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AddressTbl.Location = new System.Drawing.Point(181, 380);
            this.AddressTbl.Name = "AddressTbl";
            this.AddressTbl.Size = new System.Drawing.Size(165, 32);
            this.AddressTbl.TabIndex = 43;
            this.AddressTbl.TextChanged += new System.EventHandler(this.AddressTbl_TextChanged);
            // 
            // NameTbl
            // 
            this.NameTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NameTbl.Location = new System.Drawing.Point(181, 313);
            this.NameTbl.Name = "NameTbl";
            this.NameTbl.Size = new System.Drawing.Size(165, 32);
            this.NameTbl.TabIndex = 42;
            this.NameTbl.TextChanged += new System.EventHandler(this.NameTbl_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(28, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 53);
            this.label5.TabIndex = 41;
            this.label5.Text = "Address";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(28, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 53);
            this.label3.TabIndex = 40;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // IdTbl
            // 
            this.IdTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.IdTbl.Location = new System.Drawing.Point(181, 243);
            this.IdTbl.Name = "IdTbl";
            this.IdTbl.Size = new System.Drawing.Size(165, 32);
            this.IdTbl.TabIndex = 39;
            this.IdTbl.TextChanged += new System.EventHandler(this.IdTbl_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(28, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 38);
            this.label6.TabIndex = 38;
            this.label6.Text = "Id";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(0, 719);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 56);
            this.panel2.TabIndex = 52;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 754);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PhoneTbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Customerslist);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddressTbl);
            this.Controls.Add(this.NameTbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdTbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "Customer";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customerslist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PhoneTbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Customerslist;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AddressTbl;
        private System.Windows.Forms.TextBox NameTbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdTbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
    }
}