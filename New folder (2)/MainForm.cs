using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuboDrive
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users Users = new Users();
            Users.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Vehicle Vehicle = new Vehicle();
            Vehicle.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer  Customer = new Customer();
            Customer.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Package package = new Package();
            package.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return Return  = new Return();
            Return.Show(); 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service service = new Service();
            service.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Rental rental = new Rental();
            rental.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            DayTour dayTour = new DayTour();
            dayTour.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LongTour longTour = new LongTour();
            longTour.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
