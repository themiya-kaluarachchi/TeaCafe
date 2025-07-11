namespace CafeManagementSystem
{
    partial class GuestOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.placeOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OrdersGV = new System.Windows.Forms.DataGridView();
            this.addToCard = new System.Windows.Forms.Button();
            this.OrderAmt = new System.Windows.Forms.Label();
            this.sellerNameTb = new System.Windows.Forms.TextBox();
            this.orderNum = new System.Windows.Forms.TextBox();
            this.ItemsGV = new System.Windows.Forms.DataGridView();
            this.categoryCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guestLogin = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.QtyTb);
            this.panel1.Controls.Add(this.placeOrder);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.OrdersGV);
            this.panel1.Controls.Add(this.addToCard);
            this.panel1.Controls.Add(this.OrderAmt);
            this.panel1.Controls.Add(this.sellerNameTb);
            this.panel1.Controls.Add(this.orderNum);
            this.panel1.Controls.Add(this.ItemsGV);
            this.panel1.Controls.Add(this.categoryCb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(143, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 546);
            this.panel1.TabIndex = 0;
            // 
            // QtyTb
            // 
            this.QtyTb.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTb.Location = new System.Drawing.Point(349, 254);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QtyTb.Size = new System.Drawing.Size(121, 26);
            this.QtyTb.TabIndex = 15;
            this.QtyTb.Text = "Quantity";
            // 
            // placeOrder
            // 
            this.placeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.placeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.placeOrder.FlatAppearance.BorderSize = 0;
            this.placeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeOrder.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.placeOrder.Location = new System.Drawing.Point(418, 511);
            this.placeOrder.Name = "placeOrder";
            this.placeOrder.Size = new System.Drawing.Size(121, 26);
            this.placeOrder.TabIndex = 14;
            this.placeOrder.Text = "Place Order";
            this.placeOrder.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(413, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Your Order";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OrdersGV
            // 
            this.OrdersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.OrdersGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGV.Location = new System.Drawing.Point(230, 340);
            this.OrdersGV.MultiSelect = false;
            this.OrdersGV.Name = "OrdersGV";
            this.OrdersGV.ReadOnly = true;
            this.OrdersGV.RowHeadersVisible = false;
            this.OrdersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersGV.Size = new System.Drawing.Size(495, 159);
            this.OrdersGV.TabIndex = 12;
            // 
            // addToCard
            // 
            this.addToCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.addToCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToCard.FlatAppearance.BorderSize = 0;
            this.addToCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCard.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.addToCard.Location = new System.Drawing.Point(476, 253);
            this.addToCard.Name = "addToCard";
            this.addToCard.Size = new System.Drawing.Size(121, 26);
            this.addToCard.TabIndex = 11;
            this.addToCard.Text = "Add to Card";
            this.addToCard.UseVisualStyleBackColor = false;
            this.addToCard.Click += new System.EventHandler(this.addToCard_Click);
            // 
            // OrderAmt
            // 
            this.OrderAmt.AutoSize = true;
            this.OrderAmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.OrderAmt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderAmt.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderAmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.OrderAmt.Location = new System.Drawing.Point(612, 511);
            this.OrderAmt.Name = "OrderAmt";
            this.OrderAmt.Size = new System.Drawing.Size(156, 26);
            this.OrderAmt.TabIndex = 10;
            this.OrderAmt.Text = "Order Amount";
            this.OrderAmt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sellerNameTb
            // 
            this.sellerNameTb.Enabled = false;
            this.sellerNameTb.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerNameTb.Location = new System.Drawing.Point(49, 175);
            this.sellerNameTb.Name = "sellerNameTb";
            this.sellerNameTb.Size = new System.Drawing.Size(121, 26);
            this.sellerNameTb.TabIndex = 9;
            this.sellerNameTb.Text = "Guest";
            // 
            // orderNum
            // 
            this.orderNum.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNum.Location = new System.Drawing.Point(49, 128);
            this.orderNum.Name = "orderNum";
            this.orderNum.Size = new System.Drawing.Size(121, 26);
            this.orderNum.TabIndex = 8;
            this.orderNum.Text = "OrderNum";
            // 
            // ItemsGV
            // 
            this.ItemsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.ItemsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGV.Location = new System.Drawing.Point(230, 81);
            this.ItemsGV.MultiSelect = false;
            this.ItemsGV.Name = "ItemsGV";
            this.ItemsGV.ReadOnly = true;
            this.ItemsGV.RowHeadersVisible = false;
            this.ItemsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsGV.Size = new System.Drawing.Size(495, 145);
            this.ItemsGV.TabIndex = 7;
            this.ItemsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsGV_CellContentClick);
            // 
            // categoryCb
            // 
            this.categoryCb.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCb.FormattingEnabled = true;
            this.categoryCb.Items.AddRange(new object[] {
            "Food",
            "Beverage"});
            this.categoryCb.Location = new System.Drawing.Point(49, 81);
            this.categoryCb.Name = "categoryCb";
            this.categoryCb.Size = new System.Drawing.Size(121, 31);
            this.categoryCb.TabIndex = 6;
            this.categoryCb.Text = "Category";
            this.categoryCb.SelectionChangeCommitted += new System.EventHandler(this.categoryCb_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(323, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Place Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guestLogin
            // 
            this.guestLogin.AutoSize = true;
            this.guestLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guestLogin.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.guestLogin.Location = new System.Drawing.Point(34, 576);
            this.guestLogin.Name = "guestLogin";
            this.guestLogin.Size = new System.Drawing.Size(59, 19);
            this.guestLogin.TabIndex = 8;
            this.guestLogin.Text = "Logout";
            this.guestLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guestLogin.Click += new System.EventHandler(this.guestLogin_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.closeBtn.Location = new System.Drawing.Point(915, -4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(33, 36);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "X";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(168)))), ((int)(((byte)(68)))));
            this.Datelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Datelbl.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.Datelbl.Location = new System.Drawing.Point(659, 22);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(46, 19);
            this.Datelbl.TabIndex = 16;
            this.Datelbl.Text = "Date";
            this.Datelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GuestOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(945, 611);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.guestLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "itemForm";
            this.Load += new System.EventHandler(this.GuestOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label guestLogin;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.ComboBox categoryCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ItemsGV;
        private System.Windows.Forms.TextBox orderNum;
        private System.Windows.Forms.TextBox sellerNameTb;
        private System.Windows.Forms.Button addToCard;
        private System.Windows.Forms.Label OrderAmt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView OrdersGV;
        private System.Windows.Forms.TextBox QtyTb;
        private System.Windows.Forms.Button placeOrder;
        private System.Windows.Forms.Label Datelbl;
    }
}