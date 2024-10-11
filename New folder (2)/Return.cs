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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rezath\Documents\Ayubo_Drive.mdf;Integrated Security=True;Connect Timeout=30");
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
        private void populate1()
        {
            con.Open();
            string query = "Select * from Return_Table";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            returnList.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Deleteonreturn()
        {
            int Ser_Id;
            Ser_Id = Convert.ToInt32(Vehiclelist.SelectedRows[0].Cells[0].Value.ToString());
            con.Open();
            string query = "delete from Service_Table where Veh_No ='" + VehNoTbl.Text + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Service Deleted Successfully");
            con.Close();
            //UpdateonServiceDelete();
            populate();
        }

            private void label2_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void label9_Click(object sender, EventArgs e)
            {

            }

            private void Return_Load(object sender, EventArgs e)
            {
                populate();
                populate1();
            }

            private void Vehiclelist_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                VehNoTbl.Text = Vehiclelist.SelectedRows[0].Cells[2].Value.ToString();
                NameTbl.Text = Vehiclelist.SelectedRows[0].Cells[4].Value.ToString();
                Enddate.Text = Vehiclelist.SelectedRows[0].Cells[6].Value.ToString();
                DateTime d1 = Enddate.Value.Date;
                DateTime d2 = DateTime.Now;
                TimeSpan t = d2 - d1;
                int NrofDays = Convert.ToInt32(t.TotalDays);
                if (NrofDays <= 0)
                {
                    Delay.Text = "No Delay";
                    FineTbl.Text = "No Fine";

                }
                else
                {
                    Delay.Text = "" + NrofDays;
                    FineTbl.Text = "" + (NrofDays * 2500);
                }
            }

            private void button4_Click(object sender, EventArgs e)
            {

                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }

            private void VehNoTbl_TextChanged(object sender, EventArgs e)
            {

            }

            private void Delay_TextChanged(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void button2_Click(object sender, EventArgs e)
            {
                if (retIdTbl.Text == "" || NameTbl.Text == "" || VehNoTbl.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    try
                    {
                        con.Open();
                        string query = "insert into Return_Table values(" + retIdTbl.Text + ",'" + VehNoTbl.Text + "','" + NameTbl.Text + "','" + Enddate.Text + "','" + Delay.Text + "','" + FineTbl.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Return successfull ");
                        con.Close();
                        // UpdateonReturn();
                        populate1();
                        Deleteonreturn();




                    }
                    catch (Exception Myex)
                    {
                        MessageBox.Show(Myex.Message);
                    }
                }
            }

            private void button3_Click(object sender, EventArgs e)
            {

            }
        }
    }
