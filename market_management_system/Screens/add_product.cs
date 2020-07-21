using market_management_system.Classes;
using market_management_system.Managers;
using System;
using System.Windows.Forms;

namespace market_management_system
{
    public partial class add_product : Form
    {
        category_transactions category_Transactions;
        company_transactions company_Transactions;
        product_transactions product_Transactions;
        CompanyManager companyManager;
        CategoryManager categoryManager;
        ProductManager productManager;
        Company company;
        Category category;
        Product product;

        public add_product()
        {
            InitializeComponent();
        }

        public int _ID;

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            category_Transactions = new category_transactions();
            category_Transactions.Show();
            this.Close();
            
        }

        private void addCompanyBtn_Click(object sender, EventArgs e)
        {
            company_Transactions = new company_transactions();
            company_Transactions.Show();
            this.Close();
        }

        private void add_product_Load(object sender, EventArgs e)
        {
            FillCompanyComboBox();
            FillCategoryComboBox();
        }
        private void FillCompanyComboBox()
        {
            companyManager = new CompanyManager();
            company = new Company();
            var list = companyManager.GetAll();
            cNameCbx.DataSource = list;            
            cNameCbx.ValueMember = nameof(company.ID);
            cNameCbx.DisplayMember = nameof(company.CompanyName);
            
        }

        private void FillCategoryComboBox()
        {
            categoryManager = new CategoryManager();
            category = new Category();
            var list = categoryManager.GetAll();
            categoryCbx.DataSource = list;
            categoryCbx.ValueMember = nameof(category.ID);
            categoryCbx.DisplayMember = nameof(category.CategoryName);
            
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (pNameTxt.Text.Trim() != "" && pCodeTxt.Text.Trim() != "")
                {
                    product = new Product()
                    {
                        ID = _ID,
                        ProductName = pNameTxt.Text.Trim(),
                        Code = Convert.ToInt32(pCodeTxt.Text.Trim()),
                        companyID = Convert.ToInt32(cNameCbx.SelectedValue),
                        purchasePrice = Convert.ToInt32(pPriceTxt.Text.Trim()),
                        salePrice = Convert.ToInt32(sPriceTxt.Text.Trim()),
                        categoryID = Convert.ToInt32(categoryCbx.SelectedValue)
                    };
                }
                else
                {
                    if (pNameTxt.Text.Trim() == "")
                        pNameLabel.ForeColor = System.Drawing.Color.Red;
                    if (pCodeTxt.Text.Trim() == "")
                        pCodeLabel.ForeColor = System.Drawing.Color.Red;
                   
                    MessageBox.Show("Please Fill The Required Areas!!");
                }

                if (_ID == 0)
                {
                    productManager = new ProductManager();
                    productManager.Save(product);
                    MessageBox.Show("Register Successfull!");
                    //customer_Transactions = new customer_transactions();
                    //customer_Transactions.FillGrid();
                }
                else
                {
                    productManager = new ProductManager();
                    productManager.Update(product);
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
            product_Transactions = new product_transactions();
            product_Transactions.Show();
        }
    }
}
