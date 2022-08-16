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
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LoginVerify(object sender, EventArgs e)
        {
            String emailID = email.Text;
            String pw = password.Text;
            DAL1 obj = new DAL1();
            DataTable DT = new DataTable();


            int found;
            found = obj.login(emailID, pw, ref DT);

            if (found > 0)
            {
                //loginGrid.DataSource = DT;
                //loginGrid.DataBind();
                Session["user"] = email.Text;
                returnMsg.InnerHtml = Convert.ToString("Login Successful");
                Response.Redirect("ProfileEdit.aspx");
            }
            else
            {
                LoginResponse.Text = "Login Failed";
                //returnMsg.InnerHtml= Convert.ToString("Login Failed");
                //loginGrid.DataSource =null;
                //loginGrid.DataBind();
                //Response.Redirect("LogIn.aspx");

            }
        }
    }
}