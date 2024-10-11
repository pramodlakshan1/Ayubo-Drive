namespace AuboDrive
{
    partial class Package
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Package));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Packagelist = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PriceTbl = new System.Windows.Forms.TextBox();
            this.PackTypeTbl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PackNoTbl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PackNameTbl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WaitingTbl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ExtrakmTbl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.vehiclenightTbl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DriverNigtrateTbl = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Packagelist)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(1113, 9);
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
            this.label4.Text = "Manage Packages";
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
            this.panel2.Location = new System.Drawing.Point(0, 710);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 43);
            this.panel2.TabIndex = 53;
            // 
            // Packagelist
            // 
            this.Packagelist.BackgroundColor = System.Drawing.Color.White;
            this.Packagelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Packagelist.GridColor = System.Drawing.Color.White;
            this.Packagelist.Location = new System.Drawing.Point(392, 230);
            this.Packagelist.Name = "Packagelist";
            this.Packagelist.RowHeadersWidth = 62;
            this.Packagelist.RowTemplate.Height = 28;
            this.Packagelist.Size = new System.Drawing.Size(736, 492);
            this.Packagelist.TabIndex = 65;
            this.Packagelist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Packagelist_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(131, 654);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 57);
            this.button4.TabIndex = 64;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(250, 591);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 57);
            this.button3.TabIndex = 63;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(131, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 57);
            this.button1.TabIndex = 62;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 591);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 57);
            this.button2.TabIndex = 61;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(597, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 53);
            this.label7.TabIndex = 60;
            this.label7.Text = "PackageList";
            // 
            // PriceTbl
            // 
            this.PriceTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PriceTbl.Location = new System.Drawing.Point(215, 331);
            this.PriceTbl.Name = "PriceTbl";
            this.PriceTbl.Size = new System.Drawing.Size(165, 32);
            this.PriceTbl.TabIndex = 59;
            this.PriceTbl.TextChanged += new System.EventHandler(this.PriceTbl_TextChanged);
            // 
            // PackTypeTbl
            // 
            this.PackTypeTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackTypeTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PackTypeTbl.Location = new System.Drawing.Point(215, 282);
            this.PackTypeTbl.Name = "PackTypeTbl";
            this.PackTypeTbl.Size = new System.Drawing.Size(165, 32);
            this.PackTypeTbl.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(27, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 68);
            this.label5.TabIndex = 57;
            this.label5.Text = "Price";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(27, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 68);
            this.label3.TabIndex = 56;
            this.label3.Text = "Pack_Type";
            // 
            // PackNoTbl
            // 
            this.PackNoTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackNoTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PackNoTbl.Location = new System.Drawing.Point(215, 178);
            this.PackNoTbl.Name = "PackNoTbl";
            this.PackNoTbl.Size = new System.Drawing.Size(165, 32);
            this.PackNoTbl.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(27, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 53);
            this.label6.TabIndex = 54;
            this.label6.Text = "Pack_No";
            // 
            // PackNameTbl
            // 
            this.PackNameTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackNameTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PackNameTbl.Location = new System.Drawing.Point(215, 227);
            this.PackNameTbl.Name = "PackNameTbl";
            this.PackNameTbl.Size = new System.Drawing.Size(165, 32);
            this.PackNameTbl.TabIndex = 67;
            this.PackNameTbl.TextChanged += new System.EventHandler(this.PackNameTbl_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(27, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 53);
            this.label8.TabIndex = 66;
            this.label8.Text = "Pack_Name";
            // 
            // WaitingTbl
            // 
            this.WaitingTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitingTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.WaitingTbl.Location = new System.Drawing.Point(215, 440);
            this.WaitingTbl.Name = "WaitingTbl";
            this.WaitingTbl.Size = new System.Drawing.Size(165, 32);
            this.WaitingTbl.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(-5, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 49);
            this.label9.TabIndex = 70;
            this.label9.Text = "Waiting Charge/hour";
            // 
            // ExtrakmTbl
            // 
            this.ExtrakmTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtrakmTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ExtrakmTbl.Location = new System.Drawing.Point(215, 389);
            this.ExtrakmTbl.Name = "ExtrakmTbl";
            this.ExtrakmTbl.Size = new System.Drawing.Size(165, 32);
            this.ExtrakmTbl.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(-5, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(289, 49);
            this.label10.TabIndex = 68;
            this.label10.Text = "Extra Km Charge/Km";
            // 
            // vehiclenightTbl
            // 
            this.vehiclenightTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiclenightTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.vehiclenightTbl.Location = new System.Drawing.Point(215, 539);
            this.vehiclenightTbl.Name = "vehiclenightTbl";
            this.vehiclenightTbl.Size = new System.Drawing.Size(165, 32);
            this.vehiclenightTbl.TabIndex = 76;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(-5, 533);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 38);
            this.label11.TabIndex = 75;
            this.label11.Text = "Vehicle Night Parking rate";
            // 
            // DriverNigtrateTbl
            // 
            this.DriverNigtrateTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverNigtrateTbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.DriverNigtrateTbl.Location = new System.Drawing.Point(215, 492);
            this.DriverNigtrateTbl.Name = "DriverNigtrateTbl";
            this.DriverNigtrateTbl.Size = new System.Drawing.Size(165, 32);
            this.DriverNigtrateTbl.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label12.Location = new System.Drawing.Point(-5, 486);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(289, 38);
            this.label12.TabIndex = 73;
            this.label12.Text = "Driver OverNight rate";
            // 
            // Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 754);
            this.Controls.Add(this.vehiclenightTbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DriverNigtrateTbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.WaitingTbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ExtrakmTbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PackNameTbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Packagelist);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PriceTbl);
            this.Controls.Add(this.PackTypeTbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PackNoTbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Package";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package";
            this.Load += new System.EventHandler(this.Package_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Packagelist)).EndInit();
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
        private System.Windows.Forms.DataGridView Packagelist;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PriceTbl;
        private System.Windows.Forms.TextBox PackTypeTbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PackNoTbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PackNameTbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox WaitingTbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ExtrakmTbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox vehiclenightTbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DriverNigtrateTbl;
        private System.Windows.Forms.Label label12;
    }
}