namespace AuboDrive
{
    partial class Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Vehiclelist = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.priceTbl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SerIdTbl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.VehNoTbl = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NameTbl = new System.Windows.Forms.TextBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.Enddate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.Sertype = new System.Windows.Forms.TextBox();
            this.CusIdTbl = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vehiclelist)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1224, 162);
            this.panel1.TabIndex = 4;
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
            this.label4.Location = new System.Drawing.Point(615, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 53);
            this.label4.TabIndex = 4;
            this.label4.Text = "Service";
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
            // Vehiclelist
            // 
            this.Vehiclelist.BackgroundColor = System.Drawing.Color.White;
            this.Vehiclelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vehiclelist.GridColor = System.Drawing.Color.White;
            this.Vehiclelist.Location = new System.Drawing.Point(394, 215);
            this.Vehiclelist.Name = "Vehiclelist";
            this.Vehiclelist.RowHeadersWidth = 62;
            this.Vehiclelist.RowTemplate.Height = 28;
            this.Vehiclelist.Size = new System.Drawing.Size(751, 500);
            this.Vehiclelist.TabIndex = 31;
            this.Vehiclelist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Vehiclelist_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(136, 658);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 57);
            this.button4.TabIndex = 30;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(255, 595);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 57);
            this.button3.TabIndex = 29;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(136, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 57);
            this.button1.TabIndex = 28;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(17, 595);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 57);
            this.button2.TabIndex = 27;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(535, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(484, 53);
            this.label7.TabIndex = 26;
            this.label7.Text = "Vehicles on Rent & Hire";
            // 
            // priceTbl
            // 
            this.priceTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.priceTbl.Location = new System.Drawing.Point(175, 539);
            this.priceTbl.Name = "priceTbl";
            this.priceTbl.Size = new System.Drawing.Size(165, 32);
            this.priceTbl.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(11, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 53);
            this.label5.TabIndex = 23;
            this.label5.Text = "Price";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(9, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 53);
            this.label3.TabIndex = 22;
            this.label3.Text = "CusId";
            // 
            // SerIdTbl
            // 
            this.SerIdTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerIdTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.SerIdTbl.Location = new System.Drawing.Point(175, 215);
            this.SerIdTbl.Name = "SerIdTbl";
            this.SerIdTbl.Size = new System.Drawing.Size(165, 32);
            this.SerIdTbl.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(12, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 38);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ser Id";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(0, 815);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1161, 34);
            this.panel2.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(12, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 53);
            this.label10.TabIndex = 55;
            this.label10.Text = "Veh_No";
            // 
            // VehNoTbl
            // 
            this.VehNoTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehNoTbl.FormattingEnabled = true;
            this.VehNoTbl.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.VehNoTbl.Location = new System.Drawing.Point(175, 269);
            this.VehNoTbl.Name = "VehNoTbl";
            this.VehNoTbl.Size = new System.Drawing.Size(165, 33);
            this.VehNoTbl.TabIndex = 54;
            this.VehNoTbl.SelectionChangeCommitted += new System.EventHandler(this.VehNoTbl_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(9, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 53);
            this.label8.TabIndex = 56;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(9, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 53);
            this.label9.TabIndex = 57;
            this.label9.Text = "Rented ";
            // 
            // NameTbl
            // 
            this.NameTbl.Enabled = false;
            this.NameTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NameTbl.Location = new System.Drawing.Point(175, 366);
            this.NameTbl.Name = "NameTbl";
            this.NameTbl.Size = new System.Drawing.Size(165, 32);
            this.NameTbl.TabIndex = 58;
            // 
            // StartDate
            // 
            this.StartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StartDate.CalendarForeColor = System.Drawing.Color.White;
            this.StartDate.CalendarMonthBackground = System.Drawing.Color.DarkSlateGray;
            this.StartDate.CalendarTitleBackColor = System.Drawing.Color.DarkSlateGray;
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(175, 417);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(165, 26);
            this.StartDate.TabIndex = 59;
            this.StartDate.Value = new System.DateTime(2022, 8, 8, 2, 30, 12, 0);
            this.StartDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(9, 453);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 53);
            this.label11.TabIndex = 60;
            this.label11.Text = "Return";
            // 
            // Enddate
            // 
            this.Enddate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Enddate.CalendarForeColor = System.Drawing.Color.White;
            this.Enddate.CalendarMonthBackground = System.Drawing.Color.DarkSlateGray;
            this.Enddate.CalendarTitleBackColor = System.Drawing.Color.DarkSlateGray;
            this.Enddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Enddate.Location = new System.Drawing.Point(175, 463);
            this.Enddate.Name = "Enddate";
            this.Enddate.Size = new System.Drawing.Size(165, 26);
            this.Enddate.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label12.Location = new System.Drawing.Point(9, 496);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 43);
            this.label12.TabIndex = 62;
            this.label12.Text = "SerType";
            // 
            // Sertype
            // 
            this.Sertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sertype.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Sertype.Location = new System.Drawing.Point(175, 496);
            this.Sertype.Name = "Sertype";
            this.Sertype.Size = new System.Drawing.Size(165, 32);
            this.Sertype.TabIndex = 63;
            // 
            // CusIdTbl
            // 
            this.CusIdTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusIdTbl.FormattingEnabled = true;
            this.CusIdTbl.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CusIdTbl.Location = new System.Drawing.Point(175, 320);
            this.CusIdTbl.Name = "CusIdTbl";
            this.CusIdTbl.Size = new System.Drawing.Size(165, 33);
            this.CusIdTbl.TabIndex = 64;
            this.CusIdTbl.SelectionChangeCommitted += new System.EventHandler(this.CusIdTbl_SelectionChangeCommitted);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 864);
            this.Controls.Add(this.CusIdTbl);
            this.Controls.Add(this.Sertype);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Enddate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.NameTbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.VehNoTbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Vehiclelist);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.priceTbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SerIdTbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vehiclelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Vehiclelist;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox priceTbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SerIdTbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox VehNoTbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NameTbl;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker Enddate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Sertype;
        private System.Windows.Forms.ComboBox CusIdTbl;
    }
}