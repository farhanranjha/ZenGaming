using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZenGaming.DAL;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.Ajax.Utilities;

namespace ZenGaming
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // LoadGrid();
        }
        public void LoadGrid()
        {
            if (Session["user"]!=null)
            {
                DataTable DT = new DataTable();

                DAL1 dalobj = new DAL1();
                int n= dalobj.Getlogid((string)Session["user"]);
                ocart.DataSource = dalobj.displaycart(n, ref DT);
                
                ocart.DataBind();

            }
        }
    }
}