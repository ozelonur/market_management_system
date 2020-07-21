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
    public partial class sales_transactions : Form
    {
        ProductManager productManager;
        SaleManager saleManager;
        ProductResult product;
        List<ProductResult> list = new List<ProductResult>();
        public int _ID;
        Sales sales;
        Form1 form1;
        public sales_transactions()
        {
            InitializeComponent();
            form1 = new Form1();
        }

        private void sales_transactions_Load(object sender, EventArgs e)
        {
            txtTotalAmount.Enabled = false;
            salePriceTxt.Enabled = false;
            cmbSearch.SelectedIndex = 0;

            try
            {
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            FillProducts(0);
        }
        private void FillProducts(int selected)
        {
            productManager = new ProductManager();
            product = new ProductResult();
            list = productManager.GetAllSpecified();
            //cmbProductName.DataSource = list;
            //cmbProductName.ValueMember = nameof(product.ID);
            //cmbProductName.DisplayMember = product.ProductName;

            for (int i = 0; i < list.Count; i++)
            {
                cmbProductName.Items.Add(list[i].ProductName);
            }

        }


        private void btnSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBillNumber.Text.Trim() != "" && cmbProductName.SelectedItem != null)
                {
                    sales = new Sales()
                    {
                        ID = _ID,
                        BillNumber = txtBillNumber.Text.Trim(),
                        CustomerName = txtCustomerName.Text.Trim(),
                        CustomerSurName = txtCustomerSurName.Text.Trim(),
                        IDNumber = txtIdNumber.Text.Trim(),
                        ProductID = (list[cmbProductName.SelectedIndex].ID),
                        SalePrice = list[cmbProductName.SelectedIndex].salePrice,
                        Piece = Convert.ToInt32(txtPiece.Text.Trim()),
                        TotalAmount = (Convert.ToInt32(salePriceTxt.Text)*Convert.ToInt32(txtPiece.Text)),
                        CheckOutNumber = Convert.ToInt32(txtChckOut.Text.Trim()),
                        Date = dtDate.Value.ToString()
                    };
                }
                else
                {
                    if (txtBillNumber.Text.Trim() == "")
                        billNumLabel.ForeColor = System.Drawing.Color.Red;
                    if (cmbProductName.SelectedItem == null)
                        pNameLabel.ForeColor = System.Drawing.Color.Red;

                    MessageBox.Show("Please Fill The Required Areas!!");
                }

                if (_ID == 0)
                {
                    saleManager = new SaleManager();
                    saleManager.Save(sales);
                    MessageBox.Show("Register Successfull!");
                    FillGrid();
                    form1.FillGrid();
                }
                else
                {
                    saleManager = new SaleManager();
                    saleManager.Update(sales);
                    MessageBox.Show("Update Successfull!");
                    FillGrid();
                    form1.FillGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Saving Unsuccessfull " + ex.Message.ToString());
            }
        }

        private void cmbProductName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            salePriceTxt.Text = list[cmbProductName.SelectedIndex].salePrice.ToString();
        }

        private void txtPiece_TextChanged(object sender, EventArgs e)
        {
            txtTotalAmount.Text = (Convert.ToInt32(salePriceTxt.Text) * Convert.ToInt32(txtPiece.Text)).ToString();
        }

        private void dgvSales_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvSales.CurrentRow.Index != -1)
                {
                    _ID = Convert.ToInt32(dgvSales.CurrentRow.Cells[0].Value.ToString());
                    txtBillNumber.Text = dgvSales.CurrentRow.Cells[1].Value.ToString();
                    txtCustomerName.Text = dgvSales.CurrentRow.Cells[2].Value.ToString();
                    txtCustomerSurName.Text = dgvSales.CurrentRow.Cells[3].Value.ToString();
                    txtIdNumber.Text = dgvSales.CurrentRow.Cells[4].Value.ToString();
                    cmbProductName.SelectedItem = dgvSales.CurrentRow.Cells[5].ToString();
                    salePriceTxt.Text = dgvSales.CurrentRow.Cells[6].ToString();
                    txtPiece.Text = dgvSales.CurrentRow.Cells[7].ToString();
                    txtTotalAmount.Text = dgvSales.CurrentRow.Cells[8].ToString();
                    txtChckOut.Text = dgvSales.CurrentRow.Cells[9].ToString();
                    dtDate.Value = Convert.ToDateTime(dgvSales.CurrentRow.Cells[10]);
                }



            }
            catch (Exception ex)
            {
                throw new Exception("Nothing to use." + ex.Message.ToString());
            }
        }

        private void FillGrid()
        {
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            saleManager = new SaleManager();
            var list = saleManager.GetAllSpecified();
            dgvSales.DataSource = list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string typee = "";
            if (cmbSearch.Text == "Bill Number") { typee = "BillNumber"; }
            else if (cmbSearch.Text == "Customer Name") { typee = "CustomerName"; }
            else if (cmbSearch.Text == "Customer Surname") { typee = "CustomerSurName"; }
            else if (cmbSearch.Text == "ID Number") { typee = "ID Number"; }
            else if (cmbSearch.Text == "Product Name") { typee = "Product.ProductName"; }
            else if (cmbSearch.Text == "Product Name") { typee = "Product.ProductName"; }
            else if (cmbSearch.Text == "Sale Price") { typee = "SalePrice"; }
            else if (cmbSearch.Text == "Piece") { typee = "Piece"; }
            else if (cmbSearch.Text == "Total Amount") { typee = "TotalAmount"; }
            else if (cmbSearch.Text == "Checkout Number") { typee = "CheckOutNumber"; }

            if (cmbSearch.Text == "All")
            {
                FillGrid();
            }
            else
            {
                saleManager = new SaleManager();
                var list = saleManager.Search(typee, txtSearch.Text.ToString());
                dgvSales.DataSource = list;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
