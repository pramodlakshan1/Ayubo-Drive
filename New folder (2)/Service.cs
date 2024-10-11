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
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rezath\Documents\Ayubo_Drive.mdf;Integrated Security=True;Connect Timeout=30");
        private void fillcombo()
        {
            con.Open();
            string query = "Select Veh_No from VehicleTable Where Available='"+"Yes"+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Veh_No", typeof(string));
            dt.Load(rdr);
            VehNoTbl.ValueMember = "Veh_No";
            VehNoTbl.DataSource = dt;
            con.Close();
        }
        private void fillCustomer()
        {
            con.Open();
            string query = "Select Cus_Id from Customer_Table";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Cus_Id", typeof(int));
            dt.Load(rdr);
            CusIdTbl.ValueMember = "Cus_Id";
            CusIdTbl.DataSource = dt;
            con.Close();
        }
        private void fetchCus_Name()
        {
            con.Open();
            string query = "Select * from customer_Table where Cus_Id=" + CusIdTbl.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                NameTbl.Text = dr["Name"].ToString();
            }
            con.Close(); 
        }
        private void populate()
        {
            con.Open();
            string query = "Select * from Service_Table";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Vehiclelist.DataSource = ds.Tables[0];
            con.Close();
        }

        private void UpdateonService()
        {
            con.Open();
            string query = "Update VehicleTable Set Available='" + "No" + "' where Veh_No='" + VehNoTbl.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
           // MessageBox.Show("Vehicle successfully Updated");
            con.Close();
        }
        private void UpdateonServiceDelete()
        {
            con.Open();
            string query = "Update VehicleTable Set Available='" + "Yes" + "' where Veh_No='" + VehNoTbl.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            // MessageBox.Show("Vehicle successfully Updated");
            con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Service_Load(object sender, EventArgs e)
        {
            fillcombo();
            fillCustomer();
            populate();
        }

        private void Vehiclelist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SerIdTbl.Text = Vehiclelist.SelectedRows[0].Cells[0].Value.ToString();
            VehNoTbl.SelectedValue = Vehiclelist.SelectedRows[0].Cells[1].Value.ToString();
            CusIdTbl.SelectedValue = Vehiclelist.SelectedRows[0].Cells[2].Value.ToString();
            NameTbl.Text = Vehiclelist.SelectedRows[0].Cells[3].Value.ToString();
            StartDate.Text = Vehiclelist.SelectedRows[0].Cells[4].Value.ToString();
            Enddate.Text= Vehiclelist.SelectedRows[0].Cells[5].Value.ToString();
            Sertype.Text = Vehiclelist.SelectedRows[0].Cells[6].Value.ToString();
            priceTbl.Text = Vehiclelist.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void VehNoTbl_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CusIdTbl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCus_Name();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SerIdTbl.Text == ""||VehNoTbl.Text == ""||CusIdTbl.Text == "" || NameTbl.Text == "" || StartDate.Text == "" ||Enddate.Text == "" ||Sertype.Text == "" || priceTbl.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Service_Table values(" + SerIdTbl.Text + ",'" + VehNoTbl.SelectedValue.ToString() + "','" + CusIdTbl.SelectedValue.ToString()+ "','" + NameTbl.Text + "','" +StartDate.Text +"','" +Enddate.Text+"','"+Sertype.Text+"','"+priceTbl.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Service successfull ");
                    con.Close();
                    UpdateonService();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (SerIdTbl.Text == "")
            {
                MessageBox.Show("Missing Information.");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from Service_Table where Ser_Id ='" + SerIdTbl.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Service Deleted Successfully");
                    con.Close();
                    UpdateonServiceDelete();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
