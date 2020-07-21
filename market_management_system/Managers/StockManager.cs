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
    class StockManager:IDatabaseManager<Stock,int>, IResultManager<StockResult,int>
    {
        SqlConnection connection = new SqlConnection(@"Data Source =DESKTOP-499E88S\SQLEXPRESS; initial Catalog = MarketManagementSystem;
        Integrated Security=True;");

        public bool Delete(Stock item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Stock>(@"DELETE FROM [dbo].[Stock] WHERE ID = @ID", item);
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

        public List<Stock> GetAll()
        {
            try
            {
                OpenSqlConnection();
                string query = @"SELECT Stock.ID,Stock.Name,Stock.Code,Company.Name,Stock.purchasePrice,Stock.salePrice,Category.Name FROM Stock 
                                 INNER JOIN Category ON Stock.categoryID = Category.ID
					             INNER JOIN Company ON Stock.companyID=Company.ID";
                List<Stock> stocks = connection.Query<Stock>(query).ToList();
                return stocks;
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

        public List<StockResult> GetAllSpecified()
        {
            try
            {
                OpenSqlConnection();
                string query = @"SELECT Stock.ID, Product.ProductName, Stock.UnitPrice, Stock.Tax, Stock.Piece FROM Stock
	                             INNER JOIN Product ON Stock.ProductID = Product.ID";
                List<StockResult> stocks = connection.Query<StockResult>(query).ToList();
                return stocks;
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

        public List<StockResult> Search(string type, string value)
        {
            try
            {
                string query = @"SELECT Stock.ID, Product.ProductName, Stock.UnitPrice, Stock.Tax, Stock.Piece FROM Stock
	                             INNER JOIN Product ON Stock.ProductID = Product.ID WHERE " + type + " = '" + value + "'";
                OpenSqlConnection();
                List<StockResult> stocks = connection.Query<StockResult>(query).ToList();
                return stocks;
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

        public bool Save(Stock item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Stock>(@"INSERT INTO [dbo].[Stock] (ProductID,UnitPrice,Tax,Piece)
                                                                    VALUES(@ProductID, @UnitPrice, @Tax, @Piece)", item);
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

        public bool Update(Stock item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Stock>(@"UPDATE [dbo].[Stock] SET ProductID = @ProductID
                                                                        ,UnitPrice = @UnitPrice
                                                                        ,Tax = @Tax
                                                                        ,Piece = @Piece
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
