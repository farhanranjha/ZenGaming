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
    public partial class CustomerFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddFeedback(object sender, EventArgs e)
        {
            bool flagempt = false;
            String Name = name.Text;
            String Email = email.Text;
            String Feedback = message.Text;

            DAL1 obj = new DAL1();
            DataTable DT = new DataTable();

            if (Name.Length == 0)
            {
                flagempt = true;
                returnMsg.InnerHtml = Convert.ToString("Name cannot be empty");
            }
            if (Email.Length == 0)
            {
                flagempt = true;
                returnMsg.InnerHtml = Convert.ToString("Email cannot be empty");
            }
            if (Feedback.Length == 0)
            {
                flagempt = true;
                returnMsg.InnerHtml = Convert.ToString("Please Enter a Feedback");
            }

            //int found;
            //found = 
            if (flagempt)
            {
                flagempt = false;
                // returnMsg.InnerHtml = Convert.ToString("SignUp UnSuccessful");
            }
            else if (obj.CustomerFeedback(Name, Email, Feedback, ref DT) == -1)
            {
                returnMsg.InnerHtml = Convert.ToString("Feedback Not Submitted");
            }
            else
            {
                //if (found > 0)
                //{
                //loginGrid.DataSource = DT;
                //loginGrid.DataBind();
                returnMsg.InnerHtml = Convert.ToString("Feedback Submitted");
                Response.Redirect("Homepage.aspx");
                // LoadGrid();
            }
        }
    }
}