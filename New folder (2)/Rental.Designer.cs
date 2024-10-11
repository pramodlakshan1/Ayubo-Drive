namespace AuboDrive
{
    partial class Rental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rental));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Return = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.Totalrent = new System.Windows.Forms.TextBox();
            this.Rented = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Vehiclelist = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Driver = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.VehNoCb = new System.Windows.Forms.ComboBox();
            this.wcharge = new System.Windows.Forms.TextBox();
            this.Dcharge = new System.Windows.Forms.TextBox();
            this.mCharge = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(1132, 162);
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
            this.label2.Location = new System.Drawing.Point(1069, 9);
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
            this.label4.Location = new System.Drawing.Point(584, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 53);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rent Calculation\r\n";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(4, 747);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1131, 16);
            this.panel2.TabIndex = 54;
            // 
            // Return
            // 
            this.Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Return.CalendarForeColor = System.Drawing.Color.White;
            this.Return.CalendarMonthBackground = System.Drawing.Color.DarkSlateGray;
            this.Return.CalendarTitleBackColor = System.Drawing.Color.DarkSlateGray;
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Return.Location = new System.Drawing.Point(175, 390);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(163, 30);
            this.Return.TabIndex = 81;
            this.Return.Value = new System.DateTime(2022, 8, 8, 2, 30, 12, 0);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(984, 675);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 57);
            this.button4.TabIndex = 74;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Calculate.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.ForeColor = System.Drawing.Color.White;
            this.Calculate.Location = new System.Drawing.Point(737, 675);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(225, 57);
            this.Calculate.TabIndex = 71;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.button2_Click);
            // 
            // Totalrent
            // 
            this.Totalrent.Enabled = false;
            this.Totalrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totalrent.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Totalrent.Location = new System.Drawing.Point(566, 687);
            this.Totalrent.Name = "Totalrent";
            this.Totalrent.Size = new System.Drawing.Size(165, 32);
            this.Totalrent.TabIndex = 69;
            // 
            // Rented
            // 
            this.Rented.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rented.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Rented.Location = new System.Drawing.Point(173, 322);
            this.Rented.Name = "Rented";
            this.Rented.Size = new System.Drawing.Size(167, 30);
            this.Rented.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(12, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 35);
            this.label3.TabIndex = 91;
            this.label3.Text = "VehNo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(12, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 35);
            this.label5.TabIndex = 92;
            this.label5.Text = "Rented";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(13, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 35);
            this.label6.TabIndex = 93;
            this.label6.Text = "Return";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(12, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 35);
            this.label7.TabIndex = 94;
            this.label7.Text = "Driver";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(423, 687);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 35);
            this.label8.TabIndex = 95;
            this.label8.Text = "Total Rent";
            // 
            // Vehiclelist
            // 
            this.Vehiclelist.BackgroundColor = System.Drawing.Color.White;
            this.Vehiclelist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Vehiclelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vehiclelist.GridColor = System.Drawing.Color.White;
            this.Vehiclelist.Location = new System.Drawing.Point(369, 281);
            this.Vehiclelist.Name = "Vehiclelist";
            this.Vehiclelist.RowHeadersWidth = 62;
            this.Vehiclelist.RowTemplate.Height = 28;
            this.Vehiclelist.Size = new System.Drawing.Size(751, 330);
            this.Vehiclelist.TabIndex = 97;
            this.Vehiclelist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Vehiclelist_CellContentClick);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(604, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 47);
            this.label9.TabIndex = 96;
            this.label9.Text = "Vehicles";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(12, 522);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 35);
            this.label10.TabIndex = 98;
            this.label10.Text = "Monthly rent";
            // 
            // Driver
            // 
            this.Driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Driver.Location = new System.Drawing.Point(173, 465);
            this.Driver.Name = "Driver";
            this.Driver.Size = new System.Drawing.Size(165, 32);
            this.Driver.TabIndex = 100;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(12, 598);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 35);
            this.label11.TabIndex = 101;
            this.label11.Text = "Weekly Rent";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label12.Location = new System.Drawing.Point(13, 660);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 35);
            this.label12.TabIndex = 102;
            this.label12.Text = "Daily rent";
            // 
            // VehNoCb
            // 
            this.VehNoCb.FormattingEnabled = true;
            this.VehNoCb.Location = new System.Drawing.Point(173, 273);
            this.VehNoCb.Name = "VehNoCb";
            this.VehNoCb.Size = new System.Drawing.Size(165, 28);
            this.VehNoCb.TabIndex = 105;
            this.VehNoCb.SelectedIndexChanged += new System.EventHandler(this.VehNoCb_SelectedIndexChanged);
            // 
            // wcharge
            // 
            this.wcharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wcharge.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.wcharge.Location = new System.Drawing.Point(189, 602);
            this.wcharge.Name = "wcharge";
            this.wcharge.Size = new System.Drawing.Size(165, 32);
            this.wcharge.TabIndex = 107;
            // 
            // Dcharge
            // 
            this.Dcharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dcharge.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Dcharge.Location = new System.Drawing.Point(189, 664);
            this.Dcharge.Name = "Dcharge";
            this.Dcharge.Size = new System.Drawing.Size(165, 32);
            this.Dcharge.TabIndex = 108;
            // 
            // mCharge
            // 
            this.mCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCharge.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mCharge.Location = new System.Drawing.Point(189, 526);
            this.mCharge.Name = "mCharge";
            this.mCharge.Size = new System.Drawing.Size(165, 32);
            this.mCharge.TabIndex = 109;
            this.mCharge.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 760);
            this.Controls.Add(this.mCharge);
            this.Controls.Add(this.Dcharge);
            this.Controls.Add(this.wcharge);
            this.Controls.Add(this.VehNoCb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Driver);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Vehiclelist);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rented);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Totalrent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker Return;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox Totalrent;
        private System.Windows.Forms.DateTimePicker Rented;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Vehiclelist;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Driver;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox VehNoCb;
        private System.Windows.Forms.TextBox wcharge;
        private System.Windows.Forms.TextBox Dcharge;
        private System.Windows.Forms.TextBox mCharge;
    }
}