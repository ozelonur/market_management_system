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
    public partial class product_transactions : Form
    {
        add_product add_Product;
        ProductManager productManager;
        Product product;
        public product_transactions()
        {
            InitializeComponent();
            add_Product = new add_product();
        }

       

        private void product_transactions_Load(object sender, EventArgs e)
        {
            searchCmb.SelectedIndex = 0;
            button1.Enabled = false;
            deleteProductBtn.Enabled = false;

            try
            {
                FillGrid();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvProduct.CurrentRow.Index != -1)
                {
                    add_Product._ID = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value.ToString());
                    add_Product.pNameTxt.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
                    add_Product.pCodeTxt.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
                    add_Product.cNameCbx.ValueMember = dgvProduct.CurrentRow.Cells[3].ToString();
                    add_Product.pPriceTxt.Text = dgvProduct.CurrentRow.Cells[4].ToString();
                    add_Product.sPriceTxt.Text = dgvProduct.CurrentRow.Cells[5].ToString();
                    add_Product.categoryCbx.ValueMember = dgvProduct.CurrentRow.Cells[6].ToString();

                    button1.Enabled = true;
                    deleteProductBtn.Enabled = true;

                }



            }
            catch (Exception ex)
            {
                throw new Exception("Nothing to use." + ex.Message.ToString());
            }

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void addProductBtn_Click(object sender, EventArgs e)
        {
            add_Product = new add_product();
            add_Product.Show();
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string typee = "";
            if (searchCmb.Text == "Product Name") { typee = "ProductName"; }
            else if (searchCmb.Text == "Code") { typee = "Code"; }
            else if (searchCmb.Text == "Company Name") { typee = "Company.CompanyName";  }
            else if (searchCmb.Text == "Purchase Price") { typee = "PurchasePrice"; }
            else if (searchCmb.Text == "Sale Price") { typee = "salePrice"; }
            else if (searchCmb.Text == "Category Name") { typee = "Category.CategoryName"; }

            if (searchCmb.Text == "All")
            {
                FillGrid();
            }
            else
            {
                productManager = new ProductManager();
                var list = productManager.Search(typee, searchTxt.Text.ToString());
                dgvProduct.DataSource = list;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_Product = new add_product();
            add_Product._ID = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value.ToString());
            add_Product.saveBtn.Text = "Update";
            add_Product.saveBtn.ImageKey = "update.png";
            add_Product.Text = "Update Product";
            add_Product.Show();
            FillGrid();
            this.Close();
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                product = new Product()
                {
                    ID = add_Product._ID
                };

                productManager = new ProductManager();
                productManager.Delete(product);

                MessageBox.Show("Successfully Deleted!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            FillGrid();
            deleteProductBtn.Enabled = false;
            button1.Enabled = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillGrid()
        {
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productManager = new ProductManager();
            var list = productManager.GetAllSpecified();
            dgvProduct.DataSource = list;
        }

        
    }
}
