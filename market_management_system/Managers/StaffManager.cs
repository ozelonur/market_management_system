using Dapper;
using market_management_system.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_management_system.Managers
{
    class StaffManager : IDatabaseManager<Staff, int>
    {
        SqlConnection connection = new SqlConnection(@"Data Source =DESKTOP-499E88S\SQLEXPRESS; initial Catalog = MarketManagementSystem;
        Integrated Security=True;");

        public bool Delete(Staff item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Staff>(@"DELETE FROM [dbo].[Staff] WHERE ID = @ID", item);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Delete Error : " + ex.Message.ToString());
            }
            finally
            {
                CloseSqlConnection();
            }
        }

        public List<Staff> GetAll()
        {
            try
            {
                OpenSqlConnection();
                List<Staff> staffs = connection.Query<Staff>(@"SELECT * FROM [dbo].[Staff]").ToList();
                return staffs;
            }
            catch (Exception ex)
            {
                throw new Exception("Load List Error : " + ex.Message.ToString());
            }
            finally
            {
                CloseSqlConnection();
            }
        }

        public bool Save(Staff item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Staff>(@"INSERT INTO [dbo].[Staff] (StaffName,StaffSurName,StaffIDNumber,StaffMobilePhone,StaffHomePhone,StaffAddress,StaffSalary,StaffCheckoutNumber,StaffDateStart,StaffDateQuit)
                                                              VALUES(@StaffName, @StaffSurName, @StaffIDNumber, @StaffMobilePhone, @StaffHomePhone, @StaffAddress, @StaffSalary, @StaffCheckoutNumber, @StaffDateStart, @StaffDateQuit)", item);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Save Error : " + ex.Message.ToString());
            }
            finally
            {
                CloseSqlConnection();
            }
        }

        public List<Staff> Search(string type, string value)
        {
            try
            {
                string query = @"SELECT * FROM [dbo].[Staff] WHERE " + type + " = '" + value + "'";
                OpenSqlConnection();
                List<Staff> staffs = connection.Query<Staff>(query).ToList();
                return staffs;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                CloseSqlConnection();
            }
        }

        public bool Update(Staff item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Staff>(@"UPDATE [dbo].[Staff] SET StaffName = @StaffName
                                                                  ,StaffSurName = @StaffSurName
                                                                  ,StaffIDNumber = @StaffIDNumber
                                                                  ,StaffMobilePhone = @StaffMobilePhone
                                                                  ,StaffHomePhone = @StaffHomePhone
                                                                  ,StaffAddress = @StaffAddress
                                                                  ,StaffSalary = @StaffSalary
                                                                  ,StaffCheckoutNumber = @StaffCheckoutNumber
                                                                  ,StaffDateStart = @StaffDateStart
                                                                  ,StaffDateQuit = @StaffDateQuit
                                                                        WHERE ID = @ID", item);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Update Error : " + ex.Message.ToString());
            }
            finally
            {
                CloseSqlConnection();
            }
        }

        private void OpenSqlConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        private void CloseSqlConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}
