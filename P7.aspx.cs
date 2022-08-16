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
    public partial class P7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["product"] = 7;
            
            String prodName = "Xbox Controller";
            int prodID = (int)Session["product"];
            int price =90;
            int quantity=99;
            String prodDescription = "Experience the modernized design of the Xbox Wireless Controller – Carbon Black, featuring sculpted surfaces and refined geometry for enhanced comfort and effortless control during gameplay.Stay on target with textured grip on the triggers, bumpers, and back case and with a new hybrid D - pad for accurate, yet familiar input.";
            String imgurl = "https://i.postimg.cc/zXS1SQxX/contr.jpg";
           
            DAL1 obj = new DAL1();
            DataTable dt = new DataTable();
            quantity = obj.GetproQty(7);
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
