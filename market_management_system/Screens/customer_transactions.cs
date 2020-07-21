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
    public partial class customer_transactions : Form
    {
        public Form1 form1;
        public add_customer addCustomer;        
        Customer customer;
        CustomerManager manager;
        public customer_transactions()
        {
            InitializeComponent();
            addCustomer = new add_customer();
        }

        private void customer_transactions_Load(object sender, EventArgs e)
        {
            searchCBox.SelectedIndex = 0;
            editBtn.Enabled = false;
            deleteBtn.Enabled = false;
            
            try
            {
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception("Datas did not take from Database, please chechk your connection. " + ex.Message.ToString());
            }
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    addCustomer._ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    addCustomer.nameTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    addCustomer.surnameTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    addCustomer.idNumberTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    addCustomer.mPhoneTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    addCustomer.hPhoneTxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    addCustomer.addressTxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                    editBtn.Enabled = true;
                    deleteBtn.Enabled = true;

                }

               
             
            }
            catch(Exception ex)
            {
                throw new Exception("Nothing to use." + ex.Message.ToString());
            }

           


        }

       
        public void FillGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            manager = new CustomerManager();
            var list = manager.GetAll();
            dataGridView1.DataSource = list;                  
               
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addCustomer = new add_customer();
            addCustomer.Show();
            FillGrid();
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                customer = new Customer()
                {
                    ID = addCustomer._ID
                };

                manager = new CustomerManager();
                manager.Delete(customer);

                MessageBox.Show("Successfully Deleted!");
            }catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            
            FillGrid();
            deleteBtn.Enabled = false;
            editBtn.Enabled = false;
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string typee = "";
            if (searchCBox.Text == "Name") { typee = "Name"; }
            else if (searchCBox.Text == "Surname") { typee = "SurName"; }
            if (searchCBox.Text == "ID Number") { typee = "IDNumber"; }
            if (searchCBox.Text == "Home Phone") { typee = "HomePhone"; }
            if (searchCBox.Text == "Mobile Phone") { typee = "MobilePhone"; }
            if (searchCBox.Text == "Address") { typee = "Address"; }

            if (searchCBox.Text == "All")
            {
                FillGrid();
            }
            else
            {
                manager = new CustomerManager();
                var list = manager.Search(typee, searchTxt.Text.ToString());
                dataGridView1.DataSource = list;
            }

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            addCustomer = new add_customer();
            addCustomer._ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            addCustomer.saveCustBtn.Text = "Update";
            addCustomer.saveCustBtn.ImageKey = "update.png";
            addCustomer.Text = "Update Customer";
            addCustomer.Show();
            FillGrid();
            this.Close();
        }
    }
}
