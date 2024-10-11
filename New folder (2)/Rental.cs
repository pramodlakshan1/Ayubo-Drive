using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AuboDrive
{
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rezath\Documents\Ayubo_Drive.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            string query = "Select * from VehicleTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Vehiclelist.DataSource = ds.Tables[0];
            con.Close();
        }

        private void fillCombo1()
        {
            con.Open();
            string query = "Select Veh_No from VehicleTable Where Available='" + "Yes" + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Veh_No", typeof(string));
            dt.Load(rdr);
            VehNoCb.ValueMember = "Veh_No";
            VehNoCb.DataSource = dt;
            con.Close();
        }

        

        private void Rental_Load(object sender, EventArgs e)
        {
            fillCombo1();
            
            populate();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string query = ("Select * from VehicleTable(Veh_No ='" + VehNoCb.Text + "', Price_Day = '" + Dcharge.Text + "', Price_Week = '" + wcharge.Text + "', Price_month = '" + mCharge.Text + "') " +
            "Select * from Service_Table  Rented_Date = '" + Rented.Text + "',Return_Date = '" + Return.Text + "';");
            SqlCommand cmd = new SqlCommand(query, con);
            con.Close();
            DateTime d1 = Rented.Value.Date;
            DateTime d2 = Return.Value.Date;
            TimeSpan t = d2 - d1;
            int Days = Convert.ToInt32(t.TotalDays);
            int x = Days / 30;//months
            int d = Int32.Parse(Driver.Text);
            int D = Int32.Parse(Dcharge.Text);
            int W = Int32.Parse(wcharge.Text);
            int M = Int32.Parse(mCharge.Text);
            int b = Days / 7;
            if (Days >= 30 && Days % 30 == 0)

            {
                int ans = (x * M) + (d * Days);
                Totalrent.Text = ans.ToString();
                MessageBox.Show(Totalrent.Text);
            }
            else if (Days > 30 && Days % 30 >= 7)
            {
                int a = Days % 30;
                int g = a / 7; // weeks
                int c = a % 7;
                int ans = (M * x) + (W * g) + (D * c) + (d * Days);
                Totalrent.Text = ans.ToString();
                MessageBox.Show(Totalrent.Text);
            }
            else if (Days >= 7 && Days < 30 && Days % 7 == 0)
            {
                int ans = (W * b) + (d * Days);
                Totalrent.Text = ans.ToString();
                MessageBox.Show(Totalrent.Text);
            }

            else if (30 > Days && Days > 7 && Days % 7 > 0)
            {
                int f = Days % 7;
                int ans = (W * b) + (D * f) + (d * Days);
                Totalrent.Text = ans.ToString();
                MessageBox.Show(Totalrent.Text);
            }

            else
            {
                int ans = ( D * Days) + (d * Days);
                Totalrent.Text = ans.ToString();
            }
                MessageBox.Show(Totalrent.Text);

            }
             private void Vehiclelist_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {

                    VehNoCb.Text = Vehiclelist.SelectedRows[0].Cells[1].Value.ToString();
                    mCharge.Text = Vehiclelist.SelectedRows[0].Cells[2].Value.ToString();
                    wcharge.Text = Vehiclelist.SelectedRows[0].Cells[3].Value.ToString();
                    Dcharge.Text = Vehiclelist.SelectedRows[0].Cells[4].Value.ToString();



                }

                private void rent_month_TextChanged(object sender, EventArgs e)
                {

                }

                private void textBox2_TextChanged(object sender, EventArgs e)
                {

                }

        private void VehNoCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
