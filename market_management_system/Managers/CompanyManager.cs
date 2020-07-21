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
    class CompanyManager : IDatabaseManager<Company, int>
    {
        SqlConnection connection = new SqlConnection(@"Data Source =DESKTOP-499E88S\SQLEXPRESS; initial Catalog = MarketManagementSystem;
        Integrated Security=True;");

        public bool Delete(Company item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Company>(@"DELETE FROM [dbo].[Company] WHERE ID = @ID", item);
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



        public List<Company> GetAll()
        {
            try
            {
                OpenSqlConnection();
                List<Company> companies = connection.Query<Company>(@"SELECT * FROM [dbo].[Company]").ToList();
                return companies;
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
        

        public bool Save(Company item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Company>(@"INSERT INTO [dbo].[Company] (CompanyName,Address)
                                                                    VALUES(@CompanyName, @Address)", item);
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

        public bool Update(Company item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Company>(@"UPDATE [dbo].[Company] SET CompanyName = @CompanyName                                                                       
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
