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
    public partial class GuestOrder : Form
    {
        public GuestOrder()
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
            String query = "select * from ItemTbl where ItemCat = '" + categoryCb.SelectedItem.ToString() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
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

        private void itemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Name = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
            cat = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
            price = Convert.ToInt32(ItemsGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }

        private void GuestOrder_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Num1", typeof(int));
            table.Columns.Add("Item1", typeof(string));
            table.Columns.Add("Category1", typeof(string));
            table.Columns.Add("UnitPrice1", typeof(int));
            table.Columns.Add("Total1", typeof(int));
            OrdersGV.DataSource = table;
            Datelbl.Text = DateTime.Today.Day.ToString() +"/"+ DateTime.Today.Month.ToString() +"/"+ DateTime.Today.Year.ToString();
        }

        int num = 0;
        int price, total;
        string item, cat;
        DataTable table = new DataTable();
        int flag = 0;
        int sum = 0;

        private void placeOrder_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "insert into OrdersTbl values(" + OrderNumTb.Text + ",'" + Datelbl.Text + "','" + SellerNameTb.Text + "', "+OrderAmt.Text+")";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Successfully Created");
            Con.Close();
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
            OrderAmt.Text = "" +sum;
        }

        private void categoryCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterbycategory();
        }
    }
}
