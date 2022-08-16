using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZenGaming.DAL;
using System.Data;

namespace ZenGaming
{
    public partial class P4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["product"] = 4;
            
            String prodName = "XBOX Series X";
            int prodID = (int)Session["product"];
            int price =499;
            int quantity=99;
            String prodDescription = "Introducing Xbox Series X, the fastest, most powerful Xbox ever. Play thousands of titles from four generations of consoles-all games look and play best on Xbox Series X.Experience next-gen speed and performance with the Xbox velocity architecture, powered by a custom SSD and integrated software.";
            String imgurl = "https://i.postimg.cc/yNnPB328/xbox.jpg";
           
            DAL1 obj = new DAL1();
            DataTable dt = new DataTable();
            quantity = obj.GetproQty(4);
            //ProdName.Text = "itworks";
            if (Session["product"]!=null) //productID stored in sessionProduct
            {
                //obj.LoadProduct(prodID, prodName, prodDescription, price, quantity, imgurl, ref dt);    
               
                ProdName.Text = prodName;
                description.Text = prodDescription;
                Image1.ImageUrl = imgurl;
                priceLabel.Text = "$"+price.ToString()+".00";// (String)price;
                if (quantity > 0)
                {
                    cart.Text = "Add to Cart";
                }
                else
                {
                    cart.Text = "Not available";
                    cart.Enabled = false;
                }
            }
        }

        protected void cart_Click(object sender, EventArgs e)
        {
            DAL1 obj = new DAL1();
            DataTable dt = new DataTable();

            int prodID = (int)Session["product"];
            int quantity = 15;
            //obj.LoadProduct(prodID, prodName, prodDescription, price, quantity, imgurl, ref dt);

            if (quantity > 0)
            {
                //call add to cart function
                if (Session["cart"] == null)
                {
                    var cart = new List<int>(); //linked list of productIDs
                    cart.Add(prodID);
                    Session["cart"] = cart;
                }
                else
                {
                    List<int> cart=(List<int>)Session["cart"];
                    cart.Add(prodID);
                    Session["cart"] = cart;
                }
            }
            
        }
    }
}
