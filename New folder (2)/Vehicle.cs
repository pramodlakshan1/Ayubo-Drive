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
    public partial class Vehicle : Form
    {
        public Vehicle()
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

        private void Uname_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (vehnoTbl.Text == "" || veh_typetbl.Text == "" || pdayTbl.Text == "" || pweekTbl.Text == "" || pmonthTbl.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into VehicleTable values('" + vehnoTbl.Text + "','" + veh_typetbl.Text + "','" + pdayTbl.Text + "','" + pweekTbl.Text + "','" + pmonthTbl.Text + "','" + Availablecb.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vehicle successfully Added");
                    con.Close();
                    populate();


                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
        private void fillAvailable()
        {
            con.Open();
            string query = "Select Available from VehicleTable";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Available", typeof(string));
            dt.Load(rdr);
            Search.ValueMember = "Available";
            Search.DataSource = dt;
            con.Close();
        }

            private void Vehicle_Load(object sender, EventArgs e)
        {
            populate();
            fillAvailable();
        }

        private void vehnoTbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (vehnoTbl.Text == "")
            {
                MessageBox.Show("Missing Information.");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from VehicleTable where Veh_No ='" + vehnoTbl.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vehicle Deleted Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Vehiclelist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vehnoTbl.Text = Vehiclelist.SelectedRows[0].Cells[0].Value.ToString();
            veh_typetbl.Text = Vehiclelist.SelectedRows[0].Cells[1].Value.ToString();
            pdayTbl.Text = Vehiclelist.SelectedRows[0].Cells[2].Value.ToString();
            pweekTbl.Text = Vehiclelist.SelectedRows[0].Cells[3].Value.ToString();
            pmonthTbl.Text = Vehiclelist.SelectedRows[0].Cells[4].Value.ToString();
            Availablecb.SelectedItem = Vehiclelist.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vehnoTbl.Text == "" || veh_typetbl.Text == "" || pdayTbl.Text == "" || pweekTbl.Text == ""|| pmonthTbl.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Update VehicleTable Set Veh_type='" + veh_typetbl.Text + "',Price_Day='" + pdayTbl.Text + "',Price_week='" + pweekTbl.Text + "',Price_month='" + pmonthTbl.Text + "',Available='" + Availablecb.SelectedItem.ToString() + "' where Veh_No='" + vehnoTbl.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vehicle successfully Updated");
                    con.Close();
                    populate();


                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string flag = "";
            if(Search.SelectedItem.ToString() == "Available")
            {
                flag = "Yes";
            }
            else
            {
                flag = "No";
            }
            con.Open();
            string query = "Select * from VehicleTable Where Available = '"+flag+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Vehiclelist.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
 

