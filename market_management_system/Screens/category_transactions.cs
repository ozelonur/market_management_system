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
    public partial class category_transactions : Form
    {
        CategoryManager manager;
        Category category;
        public int _ID;
        public category_transactions()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(categoryNameTxt.Text.Trim() != "")
                {
                    category = new Category()
                    {
                        ID = _ID,
                        CategoryName = categoryNameTxt.Text.Trim()
                    };
                }

                else
                {
                    MessageBox.Show("Please insert a Category Name");
                }

                if(_ID == 0)
                {
                    manager = new CategoryManager();
                    manager.Save(category);
                    MessageBox.Show("Register Successfull");

                }
                else
                {                                        
                    manager = new CategoryManager();
                    manager.Update(category);
                    MessageBox.Show("Update Successfull");
                    addCategoryBtn.Text = "Add";
                    _ID = 0;
                }

            }catch(Exception ex)
            {
                throw new Exception("Saving Unsuccessfull : " + ex.Message.ToString());
            }
            FillGrid();
        }

        public void FillGrid()
        {
            dgvCatecory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            manager = new CategoryManager();
            var list = manager.GetAll();
            dgvCatecory.DataSource = list;

        }

        private void category_transactions_Load(object sender, EventArgs e)
        {
            deleteBtn.Enabled = false;
            FillGrid();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                category = new Category()
                {
                    ID = _ID
                };

                manager = new CategoryManager();
                manager.Delete(category);
                FillGrid();
                _ID = 0;
                addCategoryBtn.Text = "Add";
                MessageBox.Show("Successfully Deleted!");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        private void dgvCatecory_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvCatecory.CurrentRow.Index != -1)
                {
                    _ID = Convert.ToInt32(dgvCatecory.CurrentRow.Cells[0].Value.ToString());
                    categoryNameTxt.Text = dgvCatecory.CurrentRow.Cells[1].Value.ToString();

                    deleteBtn.Enabled = true;
                    addCategoryBtn.Text = "Update";
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
