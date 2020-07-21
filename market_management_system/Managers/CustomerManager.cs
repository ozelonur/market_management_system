using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_management_system
{
    class CustomerManager : IDatabaseManager<Customer, int>
    {
        SqlConnection connection = new SqlConnection(@"Data Source =DESKTOP-499E88S\SQLEXPRESS; initial Catalog = MarketManagementSystem;
        Integrated Security=True;");

        public bool Delete(Customer item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Customer>(@"DELETE FROM [dbo].[Customer] WHERE ID = @ID", item);
                return true;
            }catch(Exception ex)
            {
                throw new Exception("Delete Error : " + ex.Message.ToString());
            }
            finally
            {
                CloseSqlConnection();
            }
        }

       

        public List<Customer> GetAll()
        {
            try
            {
                OpenSqlConnection();
                List<Customer> customers = connection.Query<Customer>(@"SELECT * FROM [dbo].[Customer]").ToList();
                return customers;
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
        
        public List<Customer> Search(string type, string value)
        {
            try
            {
                string query = @"SELECT * FROM [dbo].[Customer] WHERE "+type+" = '"+value+"'";
                OpenSqlConnection();
                List<Customer> customers = connection.Query<Customer>(query).ToList();
                return customers;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                CloseSqlConnection();
            }           
        }

        public bool Save(Customer item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Customer>(@"INSERT INTO [dbo].[Customer] (Name,SurName,IDNumber,MobilePhone,HomePhone,Address)
                                                                    VALUES(@Name, @SurName, @IDNumber, @MobilePhone, @HomePhone, @Address)",item);
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

        public bool Update(Customer item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Customer>(@"UPDATE [dbo].[Customer] SET Name = @Name
                                                                        ,SurName = @SurName
                                                                        ,IDNumber = @IDNumber
                                                                        ,MobilePhone = @MobilePhone
                                                                        ,HomePhone = @HomePhone
                                                                        ,Address = @Address
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
