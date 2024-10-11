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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LUCKY-LAPTOP;Initial Catalog=Ayubo_Drive;Integrated Security=True");
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Uname.Text = "";
            Password.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String query = "select count(*) from UserTable where user_name = '" + Uname.Text + "' and pasword='" + Password.Text + "'; ";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                MainForm MainForm = new MainForm();
                MainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            con.Close();
        }
    }
}
