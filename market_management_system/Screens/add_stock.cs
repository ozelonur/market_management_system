using market_management_system.Classes;
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
    public partial class add_stock : Form
    {
        ProductManager productManager;
        ProductResult product;
        Stock stock;
        StockManager stockManager;
        stock_transactions stock_Transactions;
        public int _ID;
        public add_stock()
        {
            InitializeComponent();
            
        }
        private void add_stock_Load(object sender, EventArgs e)
        {
            FillProductComboBox();
        }
        private void FillProductComboBox()
        {
            productManager = new ProductManager();
            product = new ProductResult();
            var list = productManager.GetAllSpecified();
            cmbProduct.DataSource = list;
            cmbProduct.ValueMember = nameof(product.ID);
            cmbProduct.DisplayMember = nameof(product.ProductName);
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProduct.DisplayMember.ToString() != "Choose")
                {
                    stock = new Stock()
                    {
                        ID = _ID,
                        ProductID = Convert.ToInt32(cmbProduct.SelectedValue),
                        UnitPrice = Convert.ToInt32(txtUnitPrice.Text),
                        Tax = float.Parse(txtTax.Text),
                        Piece = Convert.ToInt32(txtPiece.Text)

                };
                }
                else
                {
                    
                    MessageBox.Show("Please Choose a Product!!");
                }

                if (_ID == 0)
                {
                    stockManager = new StockManager();
                    stockManager.Save(stock);
                    MessageBox.Show("Register Successfull!");
                    //customer_Transactions = new customer_transactions();
                    //customer_Transactions.FillGrid();
                }
                else
                {
                    stockManager = new StockManager();
                    stockManager.Update(stock);
                    MessageBox.Show("Update Successfull!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Saving Unsuccessfull " + ex.Message.ToString());
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            stock_Transactions= new stock_transactions();
            stock_Transactions.Show();
        }
    }
}
