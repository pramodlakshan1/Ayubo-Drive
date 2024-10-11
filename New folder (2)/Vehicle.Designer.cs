namespace AuboDrive
{
    partial class Vehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicle));
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
            this.pdayTbl = new System.Windows.Forms.TextBox();
            this.veh_typetbl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vehnoTbl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pweekTbl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pmonthTbl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Availablecb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 130);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1008, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(519, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = "Manage Vehicles";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(252, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 84);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ayubo Drive";
            // 
            // Vehiclelist
            // 
            this.Vehiclelist.BackgroundColor = System.Drawing.Color.White;
            this.Vehiclelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vehiclelist.GridColor = System.Drawing.Color.White;
            this.Vehiclelist.Location = new System.Drawing.Point(336, 199);
            this.Vehiclelist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vehiclelist.Name = "Vehiclelist";
            this.Vehiclelist.RowHeadersWidth = 62;
            this.Vehiclelist.RowTemplate.Height = 28;
            this.Vehiclelist.Size = new System.Drawing.Size(654, 351);
            this.Vehiclelist.TabIndex = 31;
            this.Vehiclelist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Vehiclelist_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(120, 505);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 46);
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
            this.button3.Location = new System.Drawing.Point(226, 454);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 46);
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
            this.button1.Location = new System.Drawing.Point(120, 454);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 46);
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
            this.button2.Location = new System.Drawing.Point(14, 454);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 46);
            this.button2.TabIndex = 27;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(499, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 42);
            this.label7.TabIndex = 26;
            this.label7.Text = "Vehicles List";
            // 
            // pdayTbl
            // 
            this.pdayTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdayTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pdayTbl.Location = new System.Drawing.Point(156, 270);
            this.pdayTbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pdayTbl.Name = "pdayTbl";
            this.pdayTbl.Size = new System.Drawing.Size(147, 28);
            this.pdayTbl.TabIndex = 25;
            // 
            // veh_typetbl
            // 
            this.veh_typetbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veh_typetbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.veh_typetbl.Location = new System.Drawing.Point(156, 217);
            this.veh_typetbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.veh_typetbl.Name = "veh_typetbl";
            this.veh_typetbl.Size = new System.Drawing.Size(147, 28);
            this.veh_typetbl.TabIndex = 24;
            this.veh_typetbl.TextChanged += new System.EventHandler(this.Uname_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(20, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 42);
            this.label5.TabIndex = 23;
            this.label5.Text = "Price/Day";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(20, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 42);
            this.label3.TabIndex = 22;
            this.label3.Text = "Veh_Type";
            // 
            // vehnoTbl
            // 
            this.vehnoTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehnoTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.vehnoTbl.Location = new System.Drawing.Point(156, 161);
            this.vehnoTbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vehnoTbl.Name = "vehnoTbl";
            this.vehnoTbl.Size = new System.Drawing.Size(147, 28);
            this.vehnoTbl.TabIndex = 21;
            this.vehnoTbl.TextChanged += new System.EventHandler(this.vehnoTbl_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(20, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.TabIndex = 20;
            this.label6.Text = "Veh_No";
            // 
            // pweekTbl
            // 
            this.pweekTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pweekTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pweekTbl.Location = new System.Drawing.Point(156, 318);
            this.pweekTbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pweekTbl.Name = "pweekTbl";
            this.pweekTbl.Size = new System.Drawing.Size(147, 28);
            this.pweekTbl.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(20, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 42);
            this.label8.TabIndex = 32;
            this.label8.Text = "Price/week";
            // 
            // pmonthTbl
            // 
            this.pmonthTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pmonthTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pmonthTbl.Location = new System.Drawing.Point(156, 368);
            this.pmonthTbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pmonthTbl.Name = "pmonthTbl";
            this.pmonthTbl.Size = new System.Drawing.Size(147, 28);
            this.pmonthTbl.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(20, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 42);
            this.label9.TabIndex = 34;
            this.label9.Text = "Price/month";
            // 
            // Availablecb
            // 
            this.Availablecb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Availablecb.FormattingEnabled = true;
            this.Availablecb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.Availablecb.Location = new System.Drawing.Point(156, 412);
            this.Availablecb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Availablecb.Name = "Availablecb";
            this.Availablecb.Size = new System.Drawing.Size(147, 28);
            this.Availablecb.TabIndex = 36;
            this.Availablecb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(20, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 42);
            this.label10.TabIndex = 37;
            this.label10.Text = "Available";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(0, 570);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 34);
            this.panel2.TabIndex = 53;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.FormattingEnabled = true;
            this.Search.Items.AddRange(new object[] {
            "Available",
            "Rented"});
            this.Search.Location = new System.Drawing.Point(709, 168);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(147, 28);
            this.Search.TabIndex = 54;
            this.Search.SelectedIndexChanged += new System.EventHandler(this.Search_SelectedIndexChanged);
            this.Search.SelectionChangeCommitted += new System.EventHandler(this.Search_SelectionChangeCommitted);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button5.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(861, 151);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 46);
            this.button5.TabIndex = 55;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1033, 612);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Availablecb);
            this.Controls.Add(this.pmonthTbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pweekTbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Vehiclelist);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pdayTbl);
            this.Controls.Add(this.veh_typetbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vehnoTbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.Vehicle_Load);
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
        private System.Windows.Forms.TextBox pdayTbl;
        private System.Windows.Forms.TextBox veh_typetbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vehnoTbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pweekTbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pmonthTbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Availablecb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Search;
        private System.Windows.Forms.Button button5;
    }
}