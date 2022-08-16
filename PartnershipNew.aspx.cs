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
    public partial class PartnershipNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddPartnership(object sender, EventArgs e)
        {
            bool flag = false;
            String Name = name.Text;
            String Email = email.Text;
            String msg = message.Text;

            DAL1 obj_Partnership = new DAL1();
            DataTable table_partnership = new DataTable();

            if (Name.Length == 0)
            {
                flag = true;
                returnMsg.InnerHtml = Convert.ToString("Name cannot be empty");
            }
            if (Email.Length == 0)
            {
                flag = true;
                returnMsg.InnerHtml = Convert.ToString("Email cannot be empty");
            }
            if (msg.Length == 0)
            {
                flag = true;
                returnMsg.InnerHtml = Convert.ToString("Please fill the message text box");
            }

            if (flag)
            {
                flag = false;
            }
            else if (obj_Partnership.PartnershipNew(Name, Email, msg, ref table_partnership) == -1)
            {
                returnMsg.InnerHtml = Convert.ToString("Can't request partnership, try later");
            }
            else
            {
                returnMsg.InnerHtml = Convert.ToString("Partnership Requested");
                Response.Redirect("Homepage.aspx");
            }
        }
    }
}