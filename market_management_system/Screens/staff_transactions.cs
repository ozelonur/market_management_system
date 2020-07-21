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
    public partial class staff_transactions : Form
    {
        StaffManager staffManager;
        add_staff add_Staff;
        Staff staff;
        public staff_transactions()
        {
            InitializeComponent();
            add_Staff = new add_staff();
        }

        private void staff_transactions_Load(object sender, EventArgs e)
        {
            cmbSearch.SelectedIndex = 0;
            editBtn.Enabled = false;
            deleteBtn.Enabled = false;

            try
            {
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        private void addStaffBtn_Click(object sender, EventArgs e)
        {
            add_Staff = new add_staff();
            add_Staff.Show();
            FillGrid();
            this.Close();
        }
        public void FillGrid()
        {
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            staffManager = new StaffManager();
            var list = staffManager.GetAll();
            dgvStaff.DataSource = list;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            add_Staff = new add_staff();
            add_Staff._ID = Convert.ToInt32(dgvStaff.CurrentRow.Cells[0].Value.ToString());
            add_Staff.btnSave.Text = "Update";
            add_Staff.btnSave.ImageKey = "update.png";
            add_Staff.Text = "Update Staff";
            add_Staff.Show();
            FillGrid();
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                staff = new Staff()
                {
                    ID = add_Staff._ID
                };

                staffManager = new StaffManager();
                staffManager.Delete(staff);

                MessageBox.Show("Successfully Deleted!");
            }
            catch (Exception ex)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string typee = "";
            if (cmbSearch.Text == "Name") { typee = "StaffName"; }
            else if (cmbSearch.Text == "Surname") { typee = "StaffSurName"; }
            else if (cmbSearch.Text == "ID Number") { typee = "StaffIDNumber"; }
            else if (cmbSearch.Text == "Mobile Phone") { typee = "StaffMobilePhone"; }
            else if (cmbSearch.Text == "Home Phone") { typee = "StaffHomePhone"; }
            else if (cmbSearch.Text == "Address") { typee = "StaffAddress"; }
            else if (cmbSearch.Text == "Salary") { typee = "StaffSalary"; }
            else if(cmbSearch.Text == "Checkout Number") { typee = "StaffCheckoutNumber"; }
            else if(cmbSearch.Text == "Date of Start") { typee = "StaffDateStart"; }
            else if(cmbSearch.Text == "Date of Quit") { typee = "StaffDateQuit"; }

            if (cmbSearch.Text == "All")
            {
                FillGrid();
            }
            else
            {
                staffManager = new StaffManager();
                var list = staffManager.Search(typee, txtSearch.Text.ToString());
                dgvStaff.DataSource = list;
            }
        }

        private void dgvStaff_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvStaff.CurrentRow.Index != -1)
                {
                    add_Staff._ID = Convert.ToInt32(dgvStaff.CurrentRow.Cells[0].Value.ToString());
                    add_Staff.txtName.Text = dgvStaff.CurrentRow.Cells[1].Value.ToString();
                    add_Staff.txtSurName.Text = dgvStaff.CurrentRow.Cells[2].Value.ToString();
                    add_Staff.txtIdNumber.Text = dgvStaff.CurrentRow.Cells[3].Value.ToString();
                    add_Staff.txtmPhone.Text = dgvStaff.CurrentRow.Cells[4].Value.ToString();
                    add_Staff.txthPhone.Text = dgvStaff.CurrentRow.Cells[5].Value.ToString();
                    add_Staff.txtAddress.Text = dgvStaff.CurrentRow.Cells[6].Value.ToString();
                    add_Staff.txtSalary.Text = dgvStaff.CurrentRow.Cells[7].Value.ToString();
                    add_Staff.txtChckoutNum.Text = dgvStaff.CurrentRow.Cells[8].Value.ToString();
                    add_Staff.dtpStart.Text = dgvStaff.CurrentRow.Cells[9].Value.ToString();
                    add_Staff.dtpQuit.Text = dgvStaff.CurrentRow.Cells[10].Value.ToString();


                    editBtn.Enabled = true;
                    deleteBtn.Enabled = true;

                }



            }
            catch (Exception ex)
            {
                throw new Exception("Nothing to use." + ex.Message.ToString());
            }
        }
    }
}
