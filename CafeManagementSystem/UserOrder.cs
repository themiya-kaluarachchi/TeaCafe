using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class UserOrder : Form
    {
        public UserOrder()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Other\Documents\cafedb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            Con.Open();
            String query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        void filterbycategory()
        {
            Con.Open();
            String query = "select * from ItemTbl where ItemCat = '"+categoryCb.SelectedItem.ToString()+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        DataTable table = new DataTable();
        int flag = 0;
        int sum = 0;
        private void UserOrder_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Num1", typeof(int));
            table.Columns.Add("Item1", typeof(string));
            table.Columns.Add("Category1", typeof(string));
            table.Columns.Add("UnitPrice1", typeof(int));
            table.Columns.Add("Total1", typeof(int));
            OrdersGV.DataSource = table;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guestLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void itemsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemForm Item = new ItemForm();
            Item.Show();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm user = new UserForm();
            user.Show();
        }

        int num = 0;
        int price,  total;
        string item, cat;

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void category_DropDownStyleChanged(object sender, EventArgs e)
        {

        }

        private void category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void addToCard_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
            {
                MessageBox.Show("What is the quantity of item?");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the product to be ordered");
            }
            else
            {
                num = num + 1;
                total = price * Convert.ToInt32(QtyTb.Text);
                table.Rows.Add(num, item, cat, price, total);
                OrdersGV.DataSource = table;
                flag = 0;
            }
            sum = sum + total;
            LabelAmnt.Text = "Rs " + sum;

        }

        
        private void itemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           Name = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
           cat = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
           price = Convert.ToInt32(ItemsGV.SelectedRows[0].Cells[3].Value.ToString());
           flag = 1;
        }
    }
}
