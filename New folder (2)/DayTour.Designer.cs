namespace AuboDrive
{
    partial class DayTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayTour));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.packagelist = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.Totalhire = new System.Windows.Forms.TextBox();
            this.PackCharge = new System.Windows.Forms.TextBox();
            this.EndKmreading = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Startkmreading = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Started = new System.Windows.Forms.DateTimePicker();
            this.Return = new System.Windows.Forms.DateTimePicker();
            this.VehNoCb = new System.Windows.Forms.ComboBox();
            this.PackCb = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Timelimit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.kmlimit = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagelist)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1147, 162);
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
            this.label2.Location = new System.Drawing.Point(1069, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 53);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(762, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 53);
            this.label4.TabIndex = 4;
            this.label4.Text = "Day Tour";
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
            // packagelist
            // 
            this.packagelist.BackgroundColor = System.Drawing.Color.White;
            this.packagelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packagelist.GridColor = System.Drawing.Color.White;
            this.packagelist.Location = new System.Drawing.Point(486, 254);
            this.packagelist.Name = "packagelist";
            this.packagelist.RowHeadersWidth = 62;
            this.packagelist.RowTemplate.Height = 28;
            this.packagelist.Size = new System.Drawing.Size(622, 330);
            this.packagelist.TabIndex = 103;
            this.packagelist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Vehiclelist_CellContentClick);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(660, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 47);
            this.label9.TabIndex = 102;
            this.label9.Text = "Packages";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(378, 605);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 35);
            this.label8.TabIndex = 101;
            this.label8.Text = "Total Hire";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(993, 600);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 57);
            this.button4.TabIndex = 100;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Calculate.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.ForeColor = System.Drawing.Color.White;
            this.Calculate.Location = new System.Drawing.Point(721, 597);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(227, 57);
            this.Calculate.TabIndex = 99;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Totalhire
            // 
            this.Totalhire.Enabled = false;
            this.Totalhire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totalhire.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Totalhire.Location = new System.Drawing.Point(533, 609);
            this.Totalhire.Name = "Totalhire";
            this.Totalhire.Size = new System.Drawing.Size(167, 32);
            this.Totalhire.TabIndex = 98;
            // 
            // PackCharge
            // 
            this.PackCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackCharge.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PackCharge.Location = new System.Drawing.Point(173, 458);
            this.PackCharge.Name = "PackCharge";
            this.PackCharge.Size = new System.Drawing.Size(165, 32);
            this.PackCharge.TabIndex = 118;
            // 
            // EndKmreading
            // 
            this.EndKmreading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndKmreading.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.EndKmreading.Location = new System.Drawing.Point(173, 578);
            this.EndKmreading.Name = "EndKmreading";
            this.EndKmreading.Size = new System.Drawing.Size(165, 32);
            this.EndKmreading.TabIndex = 117;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label12.Location = new System.Drawing.Point(13, 455);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 35);
            this.label12.TabIndex = 116;
            this.label12.Text = "Pack Charge";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(13, 578);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 35);
            this.label11.TabIndex = 115;
            this.label11.Text = "EndKm";
            // 
            // Startkmreading
            // 
            this.Startkmreading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startkmreading.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Startkmreading.Location = new System.Drawing.Point(173, 528);
            this.Startkmreading.Name = "Startkmreading";
            this.Startkmreading.Size = new System.Drawing.Size(165, 32);
            this.Startkmreading.TabIndex = 113;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(12, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 35);
            this.label10.TabIndex = 112;
            this.label10.Text = "StartKm ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(12, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 35);
            this.label7.TabIndex = 111;
            this.label7.Text = "Package";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(13, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 35);
            this.label6.TabIndex = 110;
            this.label6.Text = "End";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(12, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 35);
            this.label5.TabIndex = 109;
            this.label5.Text = "Started";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 35);
            this.label3.TabIndex = 108;
            this.label3.Text = "VehNo";
            // 
            // Started
            // 
            this.Started.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Started.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Started.Location = new System.Drawing.Point(173, 254);
            this.Started.Name = "Started";
            this.Started.Size = new System.Drawing.Size(167, 30);
            this.Started.TabIndex = 107;
            // 
            // Return
            // 
            this.Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Return.CalendarForeColor = System.Drawing.Color.White;
            this.Return.CalendarMonthBackground = System.Drawing.Color.DarkSlateGray;
            this.Return.CalendarTitleBackColor = System.Drawing.Color.DarkSlateGray;
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Return.Location = new System.Drawing.Point(173, 296);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(179, 30);
            this.Return.TabIndex = 105;
            this.Return.Value = new System.DateTime(2022, 8, 8, 2, 30, 12, 0);
            this.Return.ValueChanged += new System.EventHandler(this.Return_ValueChanged);
            // 
            // VehNoCb
            // 
            this.VehNoCb.FormattingEnabled = true;
            this.VehNoCb.Location = new System.Drawing.Point(173, 196);
            this.VehNoCb.Name = "VehNoCb";
            this.VehNoCb.Size = new System.Drawing.Size(165, 28);
            this.VehNoCb.TabIndex = 119;
            // 
            // PackCb
            // 
            this.PackCb.FormattingEnabled = true;
            this.PackCb.Location = new System.Drawing.Point(173, 402);
            this.PackCb.Name = "PackCb";
            this.PackCb.Size = new System.Drawing.Size(165, 28);
            this.PackCb.TabIndex = 120;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label13.Location = new System.Drawing.Point(12, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 35);
            this.label13.TabIndex = 121;
            this.label13.Text = "Time Limit";
            // 
            // Timelimit
            // 
            this.Timelimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelimit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Timelimit.Location = new System.Drawing.Point(173, 358);
            this.Timelimit.Name = "Timelimit";
            this.Timelimit.Size = new System.Drawing.Size(165, 32);
            this.Timelimit.TabIndex = 122;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label14.Location = new System.Drawing.Point(14, 622);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 35);
            this.label14.TabIndex = 123;
            this.label14.Text = "kmlimit";
            // 
            // kmlimit
            // 
            this.kmlimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmlimit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.kmlimit.Location = new System.Drawing.Point(173, 622);
            this.kmlimit.Name = "kmlimit";
            this.kmlimit.Size = new System.Drawing.Size(165, 32);
            this.kmlimit.TabIndex = 124;
            // 
            // DayTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 679);
            this.Controls.Add(this.kmlimit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Timelimit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PackCb);
            this.Controls.Add(this.VehNoCb);
            this.Controls.Add(this.PackCharge);
            this.Controls.Add(this.EndKmreading);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Startkmreading);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Started);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.packagelist);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Totalhire);
            this.Controls.Add(this.panel1);
            this.Name = "DayTour";
            this.Text = "DayTour";
            this.Load += new System.EventHandler(this.DayTour_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView packagelist;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox Totalhire;
        private System.Windows.Forms.TextBox PackCharge;
        private System.Windows.Forms.TextBox EndKmreading;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Startkmreading;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Started;
        private System.Windows.Forms.DateTimePicker Return;
        private System.Windows.Forms.ComboBox VehNoCb;
        private System.Windows.Forms.ComboBox PackCb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Timelimit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox kmlimit;
    }
}