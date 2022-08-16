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
    public partial class P6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["product"] = 6;
            
            String prodName = "Razer Headphones";
            int prodID = (int)Session["product"];
            int price =250;
            int quantity=99;
            String prodDescription = "THX 7.1 Surround Sound Capable: Provides industry-leading audio realism for in-game immersion by providing accurate spatial audio information beyond standard 7.1 surround sound directional cues Triforce Titanium 50mm High-End Sound Drivers: Outfitted with cutting - edge, 50mm drivers divided into 3 parts for individual tuning of highs, mids, and lows";
            String imgurl = "https://i.postimg.cc/K8Gwx8xt/Razer-Kraken-Tournament-Edition-Headset-Green-5.jpg";
           
            DAL1 obj = new DAL1();
            DataTable dt = new DataTable();
            quantity = obj.GetproQty(6);
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
