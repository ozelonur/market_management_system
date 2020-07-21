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
    public partial class stock_transactions : Form
    {
        StockManager stockManager;
        add_stock add_Stock;
        Stock stock;

        public stock_transactions()
        {
            InitializeComponent();
            add_Stock = new add_stock();
        }

        private void stock_transactions_Load(object sender, EventArgs e)
        {
            cmbSearch.SelectedIndex = 0;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            try
            {
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        private void FillGrid()
        {
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            stockManager = new StockManager();
            var list = stockManager.GetAllSpecified();
            dgvStock.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add_Stock = new add_stock();
            add_Stock.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            add_Stock = new add_stock();
            add_Stock._ID = Convert.ToInt32(dgvStock.CurrentRow.Cells[0].Value.ToString());
            add_Stock.saveBtn.Text = "Update";
            add_Stock.saveBtn.ImageKey = "update.png";
            add_Stock.Text = "Update Stock";
            add_Stock.Show();
            FillGrid();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                stock = new Stock()
                {
                    ID = add_Stock._ID
                };

                stockManager = new StockManager();
                stockManager.Delete(stock);

                MessageBox.Show("Successfully Deleted!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            FillGrid();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStock.CurrentRow.Index != -1)
                {
                    add_Stock._ID = Convert.ToInt32(dgvStock.CurrentRow.Cells[0].Value.ToString());
                    add_Stock.cmbProduct.ValueMember = dgvStock.CurrentRow.Cells[1].Value.ToString();
                    add_Stock.txtUnitPrice.Text = dgvStock.CurrentRow.Cells[2].Value.ToString();
                    add_Stock.txtTax.Text = dgvStock.CurrentRow.Cells[3].Value.ToString();
                    add_Stock.txtPiece.Text = dgvStock.CurrentRow.Cells[4].Value.ToString();
                    
                    
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;

                }



            }
            catch (Exception ex)
            {
                throw new Exception("Nothing to use." + ex.Message.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string typee = "";
            if (cmbSearch.Text == "Product Name") { typee = "Product.ProductName"; }
            else if (cmbSearch.Text == "Unit Price") { typee = "UnitPrice"; }
            else if (cmbSearch.Text == "Tax") { typee = "Tax"; }
            else if (cmbSearch.Text == "Piece") { typee = "Piece"; }
            

            if (cmbSearch.Text == "All")
            {
                FillGrid();
            }
            else
            {
                stockManager = new StockManager();
                var list = stockManager.Search(typee, txtSearch.Text.ToString());
                dgvStock.DataSource = list;
            }
        }
    }
}
