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
    class SaleManager : IDatabaseManager<Sales, int>, IResultManager<SaleResult,int>
    {
        SqlConnection connection = new SqlConnection(@"Data Source =DESKTOP-499E88S\SQLEXPRESS; initial Catalog = MarketManagementSystem;
        Integrated Security=True;");
        public bool Delete(Sales item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Sales>(@"DELETE FROM [dbo].[Sales] WHERE ID = @ID", item);
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

        public List<Sales> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<SaleResult> Search(string type, string value)
        {
            try
            {
                string query = @"SELECT Sales.ID, Sales.BillNumber, Sales.CustomerName, Sales.CustomerSurName, Sales.IDNumber, Product.ProductName, Product.salePrice, Sales.Piece, Sales.TotalAmount, Sales.CheckOutNumber, Sales.Date
		                         FROM Sales
		                         INNER JOIN Product ON Sales.ProductID = Product.ID WHERE " + type + " LIKE '%" + value + "%'";
                OpenSqlConnection();
                List<SaleResult> sales = connection.Query<SaleResult>(query).ToList();
                return sales;
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

        public bool Save(Sales item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Sales>(@"INSERT INTO [dbo].[Sales] (BillNumber,CustomerName,CustomerSurName,IDNumber,ProductID,SalePrice,Piece, TotalAmount, CheckOutNumber, Date)
                                                                    VALUES(@BillNumber, @CustomerName, @CustomerSurName, @IDNumber, @ProductID, @SalePrice, @Piece, @TotalAmount, @CheckOutNumber, @Date)", item);
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

        public bool Update(Sales item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Sales>(@"UPDATE [dbo].[Sales] SET BillNumber = @BillNumber
                                                                  ,CustomerName = @CustomerName
                                                                  ,CustomerSurName = @CustomerSurName
                                                                  ,IDNumber = @IDNumber
                                                                  ,ProductID = @ProductID
                                                                  ,SalePrice = @SalePrice
                                                                  ,Piece = @Piece                                        
                                                                  ,TotalAmount = @TotalAmount                                        
                                                                  ,CheckOutNumber = @CheckOutNumber                                        
                                                                  ,Date = @Date                                        
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

        public List<SaleResult> GetAllSpecified()
        {
            try
            {
                OpenSqlConnection();
                string query = @"SELECT [Sales].[id]
                                ,[Sales].[BillNumber]
                                ,[Sales].[CustomerName]
                                ,[Sales].[CustomerSurName]
                                ,[Sales].[IDNumber]
                                ,[Product].[ProductName]
                                ,[Sales].[SalePrice]
                                ,[Sales].[Piece]
                                ,[Sales].[TotalAmount]
                                ,[Sales].[CheckOutNumber]
                                ,[Sales].[Date]
                                FROM [dbo].[Sales]
                                INNER JOIN Product ON Sales.ProductID=Product.ID";
                List<SaleResult> sales = connection.Query<SaleResult>(query).ToList();
                return sales;
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
    }
}
