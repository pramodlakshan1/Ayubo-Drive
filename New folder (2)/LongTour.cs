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
    public partial class LongTour : Form
    {
        public LongTour()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rezath\Documents\Ayubo_Drive.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            string query = "Select * from Package_Table";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            packagelist.DataSource = ds.Tables[0];
            con.Close();
        }

        private void fillPackage()
        {
            con.Open();
            string query = "Select Pack_No from Package_Table";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Pack_No", typeof(int));
            dt.Load(rdr);
            PackCb.ValueMember = "Pack_No";
            PackCb.DataSource = dt;
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
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void LongTour_Load(object sender, EventArgs e)
        {
            fillCombo1();
            fillPackage();
            populate();
        }

        private void packagelist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VehNoCb.SelectedValue = packagelist.SelectedRows[0].Cells[0].Value.ToString();
            VehNoCb.SelectedValue = packagelist.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
                con.Open();
                string query = "Select * from Package_Table where Pack_No ='" + PackCb.Text + "', Price = '" + Price.Text + "', Driver_over_Night = '" + DriverNight.Text+ "',vehicle_night_park = '" + NightPark+ "';";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr;
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                rdr = sqlDataReader;
                con.Close();  
                
                DateTime d1 = Started.Value.Date;
                DateTime d2 = Return.Value.Date;
                TimeSpan t = d2 - d1;
                int Days = Convert.ToInt32(t.TotalDays);
                int NightParking = Convert.ToInt32(this.NightPark.Text);
                int PackCharge = Convert.ToInt32(this.Price.Text);
                int DriverOverNight = Convert.ToInt32(this.DriverNight.Text);
                con.Close();
                if (Days > 2 )
                {
                    int ans = PackCharge +( DriverOverNight * Days-2) +( NightParking * Days-2); 
                    Totalhire.Text = ans.ToString(); 
                    MessageBox.Show(Totalhire.Text);

                }
               
                else
                {
                    int ans = PackCharge;
                    Totalhire.Text = ans.ToString();
                    MessageBox.Show(Totalhire.Text);

                }
            }

        }
 
}

