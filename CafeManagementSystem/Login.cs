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

namespace CafeManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Other\Documents\cafedb.mdf;Integrated Security=True;Connect Timeout=30");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guestLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestOrder guest = new GuestOrder();
            guest.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string user;
        private void loginBtn_Click(object sender, EventArgs e)
        {
            user = UnameTb.Text;
            
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter A Username or Password");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UsersTbl where Uname='" + UnameTb.Text + "' and Upassword='" + PasswordTb.Text + "' ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    UserOrder uorder = new UserOrder();
                    uorder.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
                Con.Close();
            }
        }
    }
}
