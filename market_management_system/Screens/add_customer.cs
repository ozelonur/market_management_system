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
    public partial class add_customer : Form
    {
        public Form1 form1;
        public add_customer()
        {
            InitializeComponent();
        }

        CustomerManager manager;
        Customer customer;
        public int _ID;
        customer_transactions customer_Transactions;

        private void saveCustBtn_Click(object sender, EventArgs e)
        {
           
            try
            {
                if(nameTxt.Text.Trim() != "" && surnameTxt.Text.Trim() != "" && idNumberTxt.Text.Trim() != "")
                {
                    customer = new Customer()
                    {
                        ID = _ID,
                        Name = nameTxt.Text.Trim(),
                        SurName = surnameTxt.Text.Trim(),
                        IDNumber = idNumberTxt.Text.Trim(),
                        MobilePhone = mPhoneTxt.Text.Trim(),
                        HomePhone = hPhoneTxt.Text.Trim(),
                        Address = addressTxt.Text.Trim()
                    };
                }
                else
                {                    
                    if (nameTxt.Text.Trim() == "")
                        nameLabel.ForeColor = System.Drawing.Color.Red;
                    if (surnameTxt.Text.Trim() == "")
                        surNameLabel.ForeColor = System.Drawing.Color.Red;
                    if (idNumberTxt.Text.Trim() == "")
                        idNumberLabel.ForeColor = System.Drawing.Color.Red;

                    MessageBox.Show("Please Fill The Required Areas!!");
                }

                if(_ID == 0)
                {
                    manager = new CustomerManager();
                    manager.Save(customer);
                    MessageBox.Show("Register Successfull!");
                    customer_Transactions = new customer_transactions();
                    customer_Transactions.FillGrid();
                }
                else
                {                    
                    manager = new CustomerManager();
                    manager.Update(customer);
                    MessageBox.Show("Update Successfull!");
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show("Saving Unsuccessfull " + ex.Message.ToString());
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            customer_Transactions = new customer_transactions();
            customer_Transactions.Show();
            this.Close();
        }

        private void add_customer_Load(object sender, EventArgs e)
        {
           
        }
    }
}
