using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace ProductUI
{
    public partial class DeleteProduct : System.Web.UI.Page
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
        protected void DeleteProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductId = Convert.ToInt32(tbProductId.Text);
            Service service = new Service();
            service.DeleteProduct(product);
            DisplayProducts();
            Response.Redirect("ViewProducts.aspx");
        }
    }
}