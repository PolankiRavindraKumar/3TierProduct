using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BAL
{
    public class Service
    {
        ProductInfo pinfo = new ProductInfo();
        public List<Product> GetProductDetails()
        {
            List<Product> product = pinfo.GetProductDetails();
            return product;
        }
        public void AddProduct(Product product)
        {
            pinfo.AddProduct(product);
        }
        public void UpdateProduct(Product product)
        {
            pinfo.UpdateProduct(product);

        }
        public void DeleteProduct(Product product)
        {
            pinfo.DeleteProduct(product);
        }
    }
}
