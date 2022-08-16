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
    public partial class P2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["product"] = 2;
            
            String prodName = "MSI 144Hz OLED 4K Monitor";
            int prodID = (int)Session["product"];
            int price = 359;
            int quantity=10;
            String prodDescription = "Visualize victory with the MSI Optix G24C6P curved gaming monitor. Equipped with a 1920x1080, 144hz Refresh rate, 1ms response time panel, the Optix G24C6P will give you the competitive edge you need. Built with FreeSync premium technology, the Optix G24C6P can match the display's refresh rate with your GPU for ultra-smooth gameplay. Reach the peak of immersion with the latest technologies built into MSI Gaming monitors.";
            String imgurl = "https://i.postimg.cc/FsBC5gCX/download-2.jpg";
           
            DAL1 obj = new DAL1();
            DataTable dt = new DataTable();
            quantity = obj.GetproQty(2);
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

            String prodName = "MSI 144Hz OLED 4K Monitor";
            int prodID = (int)Session["product"];
            int price = 359;
            int quantity = 10;
            String prodDescription = "Visualize victory with the MSI Optix G24C6P curved gaming monitor. Equipped with a 1920x1080, 144hz Refresh rate, 1ms response time panel, the Optix G24C6P will give you the competitive edge you need. Built with FreeSync premium technology, the Optix G24C6P can match the display's refresh rate with your GPU for ultra-smooth gameplay. Reach the peak of immersion with the latest technologies built into MSI Gaming monitors.";
            String imgurl = "https://i.postimg.cc/FsBC5gCX/download-2.jpg";

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
