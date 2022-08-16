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
    public partial class P1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["product"] = 1;            
            String prodName = "Sony Playstation 5";
            int prodID = (int)Session["product"];
            int price = 499;
            int quantity=0;
            String prodDescription = "Play Has No Limits™PlayStation®5 The PS5™ console unleashes new gaming possibilities that you never anticipated.Experience lightning fast loading with an ultra - high speed SSD, deeper immersion with support for haptic feedback, adaptive triggers, and 3D Audio *, and an all - new generation of incredible PlayStation® games.Lightning Speed Harness the power of a custom CPU, GPU, and SSD with Integrated I / O that rewrite the rules of what a PlayStation® console can do.Stunning Games Marvel at incredible graphics and experience new PS5™";
            String imgurl = "https://atreboot.com/wp-content/uploads/2020/11/619BkvKW35L._SL1500_.jpg";
           
            DAL1 obj = new DAL1();
            DataTable dt = new DataTable();
            quantity = obj.GetproQty(1);

            //ProdName.Text = "itworks";
            if (Session["product"]!=null) //productID stored in sessionProduct
            {
                //obj.LoadProduct(prodID, prodName, prodDescription, price, quantity, imgurl, ref dt);    
               
                ProdName.Text = prodName;
                description.Text = prodDescription;
                Image1.ImageUrl = imgurl;
                priceLabel.Text = "$"+price.ToString()+".00";// (String)price;
                if(quantity>0)
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
            int quantity = 0;
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
