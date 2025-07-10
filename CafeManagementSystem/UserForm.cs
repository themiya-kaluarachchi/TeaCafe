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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Other\Documents\cafedb.mdf;Integrated Security=True;Connect Timeout=30");


        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            UserOrder uorder = new UserOrder();
            uorder.Show();
            this.Hide();
        }

        private void itemsBtn_Click(object sender, EventArgs e)
        {
            ItemForm item = new ItemForm();
            item.Show();
            this.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "insert into UsersTbl values('" + UnameTb.Text + "','" + UphoneTb.Text + "','" + UpassTb.Text + "')";
            
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Close();
        }
    }
}
