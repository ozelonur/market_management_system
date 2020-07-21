using market_management_system.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_management_system
{
    public partial class Form1 : Form
    {
        public add_customer add_Customer;
        public add_product add_Product;
        public add_staff add_Staff;
        public add_stock add_Stock;
        public category_transactions category_Transactions;
        public company_transactions company_Transactions;
        public customer_transactions customer_Transactions;
        public product_transactions product_Transactions;
        public sales_transactions sales_Transactions;
        public staff_transactions staff_Transactions;
        public stock_transactions stock_Transactions;
        public update_product update_Product;
        public update_staff update_Staff;
        public update_stock update_Stock;

        SaleManager saleManager;



        
        public Form1()
        {
            InitializeComponent();
            FillGrid();
        }

        
        private void btnCustomerTrans_Click(object sender, EventArgs e)
        {
            customer_Transactions = new customer_transactions();
            customer_Transactions.Show();
        }

        private void btnProductTrans_Click(object sender, EventArgs e)
        {
            product_Transactions = new product_transactions();
            product_Transactions.Show();
        }

        private void btnStaffTrans_Click(object sender, EventArgs e)
        {
            staff_Transactions = new staff_transactions();
            staff_Transactions.Show();
        }

        private void btnStckTrans_Click(object sender, EventArgs e)
        {
            stock_Transactions = new stock_transactions();
            stock_Transactions.Show();
        }

        private void btnSaleTrans_Click(object sender, EventArgs e)
        {
            sales_Transactions = new sales_transactions();
            sales_Transactions.Show();
        }

        private void btnShowTrans_Click(object sender, EventArgs e)
        {
            string[] date = mainDtp.Value.ToString().Split(' ');
            saleManager = new SaleManager();
            var list = saleManager.Search("Date",date[0]);
            dgvMain.DataSource = list;
        }

        public void FillGrid()
        {
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            saleManager = new SaleManager();
            var list = saleManager.GetAllSpecified();
            dgvMain.DataSource = list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnExitTrans_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
