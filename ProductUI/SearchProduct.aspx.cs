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
    public partial class SearchProduct : System.Web.UI.Page
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

        protected void SearchProduct_Click(object sender, EventArgs e)
        {
            List<Product> product = Session["product"] as List<Product>;
            foreach(Product p in product)
            {
                if(p.ProductId == Convert.ToInt32(tbProductId.Text))
                {
                    tbProductName.Text = p.ProductName;
                    tbManufacturer.Text = p.Manufacturer;
                    tbQuantity.Text = p.Quantity.ToString();
                    break;
                }
            }
            
        }

        protected void tbHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProducts.aspx");
        }
    }
}