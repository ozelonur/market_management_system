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
    public partial class add_staff : Form
    {
        StaffManager staffManager;
        Staff staff;
        public int _ID;
        staff_transactions staff_Transactions;
        public add_staff()
        {
            InitializeComponent();
        }

        private void add_staff_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() != "" && txtSurName.Text.Trim() != "" && txtIdNumber.Text.Trim() != "")
                {
                    staff = new Staff()
                    {
                        ID = _ID,
                        StaffName = txtName.Text.Trim(),
                        StaffSurName = txtSurName.Text.Trim(),
                        StaffIDNumber = txtIdNumber.Text.Trim(),
                        StaffMobilePhone = txtmPhone.Text.Trim(),
                        StaffHomePhone = txthPhone.Text.Trim(),
                        StaffAddress = txtAddress.Text.Trim(),
                        StaffSalary = Convert.ToInt32(txtSalary.Text.Trim()),
                        StaffCheckoutNumber = Convert.ToInt32(txtChckoutNum.Text.Trim()),
                        StaffDateStart = dtpStart.Value.ToString().Trim(),
                        StaffDateQuit = dtpQuit.Value.ToString().Trim()

                    };
                }
                else
                {
                    if (txtName.Text.Trim() == "")
                        nameLabel.ForeColor = System.Drawing.Color.Red;
                    if (txtSurName.Text.Trim() == "")
                        surnameLabel.ForeColor = System.Drawing.Color.Red;
                    if (txtIdNumber.Text.Trim() == "")
                        idNumberLbl.ForeColor = System.Drawing.Color.Red;

                    MessageBox.Show("Please Fill The Required Areas!!");
                }

                if (_ID == 0)
                {
                    staffManager = new StaffManager();
                    staffManager.Save(staff);
                    MessageBox.Show("Register Successfull!");
                    staff_Transactions = new staff_transactions();
                    staff_Transactions.FillGrid();
                }
                else
                {
                    staffManager = new StaffManager();
                    staffManager.Update(staff);
                    MessageBox.Show("Update Successfull!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Saving Unsuccessfull " + ex.Message.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            staff_Transactions = new staff_transactions();
            staff_Transactions.Show();
            this.Close();
        }
    }
}
