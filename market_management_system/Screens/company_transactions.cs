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
    public partial class company_transactions : Form
    {
        CompanyManager manager;
        Company company;
        int _ID;
        add_product add_Product;
        public company_transactions()
        {
            InitializeComponent();
        }

        private void dgvCompany_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvCompany.CurrentRow.Index != -1)
                {
                    _ID = Convert.ToInt32(dgvCompany.CurrentRow.Cells[0].Value.ToString());
                    companyNameTxt.Text = dgvCompany.CurrentRow.Cells[1].Value.ToString();
                    addressTxt.Text = dgvCompany.CurrentRow.Cells[2].Value.ToString();

                    deleteBtn.Enabled = true;
                    addCompanyBtn.Text = "Update";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        private void FillGrid()
        {
            dgvCompany.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            manager = new CompanyManager();
            var list = manager.GetAll();
            dgvCompany.DataSource = list;
        }

        private void company_transactions_Load(object sender, EventArgs e)
        {
            deleteBtn.Enabled = false;
            FillGrid();
        }

        private void addCompanyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (companyNameTxt.Text.Trim() != "" && addressTxt.Text.Trim() != "")
                {
                    company = new Company()
                    {
                        ID = _ID,
                        CompanyName = companyNameTxt.Text.Trim(),
                        Address = addressTxt.Text.Trim()
                    };
                }

                else
                {
                    MessageBox.Show("Please insert blank areas");
                }

                if (_ID == 0)
                {
                    manager = new CompanyManager();
                    manager.Save(company);
                    MessageBox.Show("Register Successfull");

                }
                else
                {
                    manager = new CompanyManager();
                    manager.Update(company);
                    MessageBox.Show("Update Successfull");
                    addCompanyBtn.Text = "Add";
                    _ID = 0;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Saving Unsuccessfull : " + ex.Message.ToString());
            }
            FillGrid();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            try
            {
                company = new Company()
                {
                    ID = _ID
                };

                manager = new CompanyManager();
                manager.Delete(company);
                FillGrid();
                _ID = 0;
                addCompanyBtn.Text = "Add";
                MessageBox.Show("Successfully Deleted!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            add_Product = new add_product();

            this.Close();
            add_Product.Show();
        }
    }
}
