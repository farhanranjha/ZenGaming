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
    public partial class P8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["product"] = 8;
            
            String prodName = "Logitech G503 HERO Gaming Mouse";
            int prodID = (int)Session["product"];
            int price =359;
            int quantity=99;
            String prodDescription = "High performance HERO 16K Sensor: Logitech's most accurate sensor yet with up to 16,000 DPI for the ultimate in gaming speed, accuracy and responsiveness across entire DPI range. 11 Customizable Buttons and Onboard Memory: Assign custom commands to the buttons and save up to five ready to play profiles directly to the mouse.Zero smoothing/ acceleration / filtering";
            String imgurl = "https://i.postimg.cc/gjHBRCmC/download.jpg";
           
            DAL1 obj = new DAL1();
            DataTable dt = new DataTable();
            quantity = obj.GetproQty(8);
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
            
            int customerid = obj.Getlogid((string)Session["user"]);
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
                  //  obj.ADDToCart(8, customerid);
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
