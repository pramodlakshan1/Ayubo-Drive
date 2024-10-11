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
    public partial class DayTour : Form
    {
        public DayTour()
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

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void DayTour_Load(object sender, EventArgs e)
        {
            fillCombo1();
            
            fillPackage();
            populate();
        }

        private void Vehiclelist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PackCb.SelectedValue = packagelist.SelectedRows[0].Cells[1].Value.ToString();
            PackCharge.Text = packagelist.SelectedRows[0].Cells[2].Value.ToString();
            PackCharge.Text = packagelist.SelectedRows[0].Cells[3].Value.ToString();


        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * from Package_Table where Pack_No ='" + PackCb.Text + "', Price = '" + PackCharge.Text +"';";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Close();
            DateTime d1 = Started.Value.Date;
            DateTime d2 = Return.Value.Date;
            TimeSpan t = d2 - d1;
            int Hours = Convert.ToInt32(t.TotalHours);
            int s1 = Convert.ToInt32(this.Startkmreading.Text);
            int s2 = Convert.ToInt32(this.EndKmreading.Text);
            int s = s2 - s1;
            int S = Convert.ToInt32(this.kmlimit.Text);
            int T = Convert.ToInt32(this.Timelimit.Text);
            int P = Convert.ToInt32(this.PackCharge.Text);
            if ( s > S && Hours < T )
            {
               int ans = ( P + s * 200) ; // 200 per km 
                Totalhire.Text = ans.ToString();
                MessageBox.Show(Totalhire.Text);

            }
            else if (s > S && Hours > T)
            {
                int ans = (P + s * 200 + Hours * 200); // 200 per hour
                Totalhire.Text = ans.ToString();
                MessageBox.Show(Totalhire.Text);
            }

            else if ( s < S && Hours > T)
            {
                int ans = (P + Hours * 200);
                Totalhire.Text = ans.ToString();
                MessageBox.Show(Totalhire.Text);
            }
            else
            {
                int ans = P;
                Totalhire.Text = ans.ToString();
                MessageBox.Show(Totalhire.Text);

            }
        }

        private void Return_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
