using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using BAL;

namespace ProductUI
{
    public partial class InsertProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayProducts();
            }
        }
        internal void DisplayProducts()
        {
            Service service = new Service();
            List<Product> product = service.GetProductDetails();
            gvProduct.DataSource = product;
            gvProduct.DataBind();
            Session["product"] = product;
        }
        protected void InsertProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductId = Convert.ToInt32(tbProductId.Text);
            product.ProductName = tbProductName.Text;
            product.Manufacturer = tbManufacturer.Text;
            product.Quantity = Convert.ToInt32(tbQuantity.Text);
            Service service = new Service();
            service.AddProduct(product);
            DisplayProducts();
            Response.Redirect("ViewProducts.aspx");
        }
    }
}