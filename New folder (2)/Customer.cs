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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rezath\Documents\Ayubo_Drive.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            string query = "Select * from Customer_Table";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Customerslist.DataSource = ds.Tables[0];
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

            if (IdTbl.Text == "" || NameTbl.Text == "" || AddressTbl.Text == "" || PhoneTbl.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Customer_Table values(" + IdTbl.Text + ",'" + NameTbl.Text + "','" + AddressTbl.Text + "','" + PhoneTbl.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer successfully Added");
                    con.Close();
                    populate();


                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Customerslist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            IdTbl.Text = Customerslist.SelectedRows[0].Cells[0].Value.ToString();
            NameTbl.Text = Customerslist.SelectedRows[0].Cells[1].Value.ToString();
            AddressTbl.Text = Customerslist.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTbl.Text = Customerslist.SelectedRows[0].Cells[3].Value.ToString();


        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (IdTbl.Text == "")
            {
                MessageBox.Show("Missing Information.");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from Customer_Table where Cus_Id ='" + IdTbl.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Successfully");
                    con.Close();
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
            if (IdTbl.Text == "" || NameTbl.Text == "" || AddressTbl.Text == "" || PhoneTbl.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Update Customer_Table Set name='" + NameTbl.Text + "',Address='" + AddressTbl.Text + "' where Cus_Id=" + IdTbl.Text + ";";
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AddressTbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IdTbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTbl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

