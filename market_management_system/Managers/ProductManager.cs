using market_management_system.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace market_management_system.Managers
{
    class ProductManager:IDatabaseManager<Product,int>, IResultManager<ProductResult,int>
    {
        SqlConnection connection = new SqlConnection(@"Data Source =DESKTOP-499E88S\SQLEXPRESS; initial Catalog = MarketManagementSystem;
        Integrated Security=True;");

        public bool Delete(Product item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Product>(@"DELETE FROM [dbo].[Product] WHERE ID = @ID", item);
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


        
        public List<Product> GetAll()
        {
            try
            {
                OpenSqlConnection();
                string query = @"SELECT Product.ID,Product.Name,Product.Code,Company.Name,Product.purchasePrice,Product.salePrice,Category.Name FROM Product 
                                 INNER JOIN Category ON Product.categoryID = Category.ID
					             INNER JOIN Company ON Product.companyID=Company.ID";
                List<Product> products = connection.Query<Product>(query).ToList();
                return products;
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

        public List<ProductResult> GetAllSpecified()
        {
            try
            {
                OpenSqlConnection();
                string query = @"SELECT Product.ID,Product.ProductName,Product.Code,Company.CompanyName,Product.purchasePrice,Product.salePrice,Category.CategoryName FROM Product 
                                 INNER JOIN Category ON Product.categoryID = Category.ID
					             INNER JOIN Company ON Product.companyID=Company.ID";
                List<ProductResult> products = connection.Query<ProductResult>(query).ToList();
                return products;
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

        public List<ProductResult> Search(string type, string value)
        {
            try
            {
                string query = @"SELECT Product.ID,Product.ProductName,Product.Code,Company.CompanyName,Product.purchasePrice,Product.salePrice,Category.CategoryName FROM Product 
                                 INNER JOIN Category ON Product.categoryID = Category.ID
					             INNER JOIN Company ON Product.companyID=Company.ID WHERE " + type + " = '" + value + "'";
                OpenSqlConnection();
                List<ProductResult> products = connection.Query<ProductResult>(query).ToList();
                return products;
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

       
        public bool Save(Product item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Product>(@"INSERT INTO [dbo].[Product] (ProductName,Code,companyID,purchasePrice,salePrice,categoryID)
                                                                    VALUES(@ProductName, @Code, @companyID, @purchasePrice, @salePrice, @categoryID)", item);
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

        public bool Update(Product item)
        {
            try
            {
                OpenSqlConnection();
                connection.Query<Product>(@"UPDATE [dbo].[Product] SET ProductName = @ProductName
                                                                        ,Code = @Code
                                                                        ,companyID = @companyID
                                                                        ,purchasePrice = @purchasePrice
                                                                        ,salePrice = @salePrice
                                                                        ,categoryID = @categoryID
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
