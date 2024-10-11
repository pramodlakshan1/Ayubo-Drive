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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rezath\Documents\Ayubo_Drive.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            if (UId.Text == "" || Uname.Text == "" || Upass.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Update UserTable Set Uname='" + Uname.Text + "',Upass='" + Upass.Text + "' where Id=" + UId.Text + ";";
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
        private void populate()
        {
            con.Open();
            string query = "Select * from UserTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Userlist.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UId .Text == "" || Uname.Text == "" || Upass.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Usertable values(" + UId.Text + ",'" + Uname.Text + "','" + Upass.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User successfully Added");
                    con.Close();
                     populate();


                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Users_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (UId.Text == "")
            {
                MessageBox.Show("Missing Information.");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from UserTable where Id =" + UId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    con.Close();
                    populate();
                }catch(Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Userlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UId.Text = Userlist.SelectedRows[0].Cells[0].Value.ToString();
            Uname.Text = Userlist.SelectedRows[0].Cells[1].Value.ToString();
            Upass.Text = Userlist.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
