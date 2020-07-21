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
    class CategoryManager : IDatabaseManager<Category, int>
    {
        SqlConnection connection = new SqlConnection(@"Data Source =DESKTOP-499E88S\SQLEXPRESS; initial Catalog = MarketManagementSystem;
        Integrated Security=True;");


        public bool Delete(Category item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Category>(@"DELETE FROM [dbo].[Category] WHERE ID = @ID",item);
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("DELETE Error : "+ex.Message.ToString());
            }
            finally
            {
                CloseSqlConnection();
            }
        }

        public List<Category> GetAll()
        {
            try
            {
                OpenSqlConnection();
                List<Category> categories = connection.Query<Category>(@"SELECT * FROM [dbo].[Category]").ToList();
                return categories;
            }
            catch (Exception ex)
            {
                throw new Exception("LOAD List Error : "+ex.Message.ToString());
            }
            finally
            {
                CloseSqlConnection();
            }
        }

        public bool Save(Category item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Customer>(@"INSERT INTO [dbo].[Category] (CategoryName)
                                                                    VALUES(@CategoryName)", item);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Saving Error : "+ex.Message.ToString());
            }
            finally
            {
                CloseSqlConnection();
            }
        }

        public bool Update(Category item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Customer>(@"UPDATE [dbo].[Category] SET CategoryName = @CategoryName                                                                       
                                                                        WHERE ID = @ID", item);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Update Error : "+ex.Message.ToString());
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
