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
    public partial class Package : Form
    {
        public Package()
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
            Packagelist.DataSource = ds.Tables[0];
            con.Close();
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

            if (PackNoTbl.Text == "" || PackNameTbl.Text == "" || PackTypeTbl.Text == "" || PriceTbl.Text == "" || ExtrakmTbl.Text == "" || WaitingTbl.Text == "" || DriverNigtrateTbl.Text == "" || vehiclenightTbl.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Package_Table values(" + PackNoTbl.Text + ",'" + PackNameTbl.Text + "','" + PackTypeTbl.Text + "','" + PriceTbl.Text + "','" + ExtrakmTbl.Text + "','" + WaitingTbl.Text + "','" + DriverNigtrateTbl.Text + "','" + vehiclenightTbl.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Package successfully Added");
                    con.Close();
                    populate();


                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Package_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Packagelist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PackNoTbl.Text = Packagelist.SelectedRows[0].Cells[0].Value.ToString();
            PackNameTbl.Text = Packagelist.SelectedRows[0].Cells[1].Value.ToString();
            PackTypeTbl.Text = Packagelist.SelectedRows[0].Cells[2].Value.ToString();
            PriceTbl.Text = Packagelist.SelectedRows[0].Cells[3].Value.ToString();
            ExtrakmTbl.Text = Packagelist.SelectedRows[0].Cells[4].Value.ToString();
            WaitingTbl.Text = Packagelist.SelectedRows[0].Cells[5].Value.ToString();
            DriverNigtrateTbl.Text = Packagelist.SelectedRows[0].Cells[6].Value.ToString();
            vehiclenightTbl.Text = Packagelist.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void PriceTbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void PackNameTbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PackNoTbl.Text == "" || PackNameTbl.Text == "" || PackTypeTbl.Text == "" || PriceTbl.Text == "" || ExtrakmTbl.Text == "" || WaitingTbl.Text == "" || DriverNigtrateTbl.Text == "" || vehiclenightTbl.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Update Package_Table Set Pack_Name='" + PackNameTbl.Text + "',Pack_Type='" + PackTypeTbl.Text + "', Price='" + PriceTbl.Text + "'," +
                        "Driverovernight='" + DriverNigtrateTbl.Text + "',VehNightpark='" + vehiclenightTbl.Text + "' where Pack_No=" + PackNoTbl.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User successfully Updated");
                    con.Close();
                    populate();


                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }


            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (PackNoTbl.Text == "")
            {
                MessageBox.Show("Missing Information.");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from Package where Pack_No =" + PackNoTbl.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Package Deleted Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
    }
}




