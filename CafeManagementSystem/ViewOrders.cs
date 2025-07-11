using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Other\Documents\cafedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void addToCard_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        void populate()
        {
            Con.Open();
            String query = "select * from OrdersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrdersGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("===== TeaCafe Software =====", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(200, 40));
            e.Graphics.DrawString("===== Order Summary =====", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(208,80));
            e.Graphics.DrawString("Number:" + OrdersGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Abeezee", 15, FontStyle.Regular), Brushes.Black, new Point(120, 185));
            e.Graphics.DrawString("Date:" + OrdersGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Abeezee", 15, FontStyle.Regular), Brushes.Black, new Point(120, 225));
            e.Graphics.DrawString("Seller:" + OrdersGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Abeezee", 15, FontStyle.Regular), Brushes.Black, new Point(120, 265));
            e.Graphics.DrawString("Amount:" + OrdersGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Abeezee", 15, FontStyle.Regular), Brushes.Black, new Point(120, 305));
            e.Graphics.DrawString("===== Devloped By KTK =====", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(208, 405));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
