using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data.SqlClient;
using System.Data;
using System.CodeDom;

namespace DAL
{
    public class ProductInfo
    {
        
        public List<Product> GetProductDetails()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection cn = new SqlConnection(Utility.GetConnection()))
            {
                using(SqlCommand cmd = new SqlCommand("GetProductDetails", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        cn.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            Product product = new Product();
                            product.ProductId = Convert.ToInt32(sdr["Product_Id"]);
                            product.ProductName = sdr["Product_Name"].ToString();
                            product.Manufacturer = sdr["Manufacturer"].ToString();
                            product.Quantity = Convert.ToInt32(sdr["Quantity"]);
                            products.Add(product);
                        }
                        sdr.Close();
                    }
                    catch(SqlException ex) { Console.WriteLine(ex.Message); }
                    finally
                    {
                        if (cn.State == ConnectionState.Open)
                            cn.Close();
                    }
                }
            }
            return products;
        }
        public void AddProduct(Product product)
        {
            using(SqlConnection cn = new SqlConnection(Utility.GetConnection()))
            {
                using(SqlCommand cmd = new SqlCommand("InsertProduct", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter Id_Parameter = new SqlParameter("@productId", SqlDbType.Int);
                    SqlParameter name_Parameter = new SqlParameter("@productName", SqlDbType.VarChar, 70);
                    SqlParameter manufacturer_Parameter = new SqlParameter("@manufacturer", SqlDbType.VarChar, 70);
                    SqlParameter quantity_Parameter = new SqlParameter("@quantity", SqlDbType.Int);
                    Id_Parameter.Value = product.ProductId;
                    name_Parameter.Value = product.ProductName;
                    manufacturer_Parameter.Value = product.Manufacturer;
                    quantity_Parameter.Value = product.Quantity;
                    cmd.Parameters.Add(Id_Parameter);
                    cmd.Parameters.Add(name_Parameter);
                    cmd.Parameters.Add(manufacturer_Parameter);
                    cmd.Parameters.Add(quantity_Parameter);
                    try
                    {
                        cn.Open();
                        int count = cmd.ExecuteNonQuery();
                    }
                    catch(SqlException ex) { Console.WriteLine(ex.Message); }
                    finally
                    {
                        if (cn.State == ConnectionState.Open)
                            cn.Close();
                    }
                }
            }
        }
        public void UpdateProduct(Product product)
        {
            using(SqlConnection cn = new SqlConnection(Utility.GetConnection()))
            {
                using(SqlCommand cmd = new SqlCommand("UpdateProduct", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter Id_Parameter = new SqlParameter("@productId", SqlDbType.Int);
                    SqlParameter name_Parameter = new SqlParameter("@productName", SqlDbType.VarChar, 70);
                    SqlParameter manufacturer_Parameter = new SqlParameter("@manufacturer", SqlDbType.VarChar, 70);
                    SqlParameter quantity_Parameter = new SqlParameter("@quantity", SqlDbType.Int);
                    Id_Parameter.Value = product.ProductId;
                    name_Parameter.Value = product.ProductName;
                    manufacturer_Parameter.Value = product.Manufacturer;
                    quantity_Parameter.Value = product.Quantity;
                    cmd.Parameters.Add(Id_Parameter);
                    cmd.Parameters.Add(name_Parameter);
                    cmd.Parameters.Add(manufacturer_Parameter);
                    cmd.Parameters.Add(quantity_Parameter);
                    try
                    {
                        cn.Open();
                        int count = cmd.ExecuteNonQuery();
                    }
                    catch(SqlException ex) { Console.WriteLine(ex.Message); }
                    finally
                    {
                        if (cn.State == ConnectionState.Open)
                            cn.Close();
                    }
                }
            }
        }
        public void DeleteProduct(Product product)
        {
            using (SqlConnection cn = new SqlConnection(Utility.GetConnection()))
            {
                using(SqlCommand cmd = new SqlCommand("DeleteProduct", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter Id_Parameter = new SqlParameter("@productId", SqlDbType.Int);
                    Id_Parameter.Value = product.ProductId;
                    cmd.Parameters.Add(Id_Parameter);
                    try
                    {
                        cn.Open();
                        int count = cmd.ExecuteNonQuery();
                    }
                    catch(SqlException ex) { Console.WriteLine(ex.Message); }
                    finally
                    {
                        if (cn.State == ConnectionState.Open)
                            cn.Close();
                    }
                }
            }
        }
    }
}
