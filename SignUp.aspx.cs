using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZenGaming.DAL;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace ZenGaming
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void signup_Click(object sender, EventArgs e)
        {
            bool flagempt = false;
            String firstname = fname.Text;
            String lastname = lname.Text;
            String emailID = email.Text;
            String pw = password.Text;
            String phoneNo = phone.Text;
            String shipAdd = SAdd.Text;
            String BillAdd = BAdd.Text;
            int paymentType = 0; //by default
            String state = "Current"; //active user
            DateTime timeStamp = DateTime.Now;

            DAL1 obj = new DAL1();
            DataTable DT = new DataTable();
            if (firstname.Length == 0)
            {
                flagempt = true;
                retmsg7.InnerHtml = Convert.ToString("First Name cannot be empty");
            }
            if (lastname.Length == 0)
            {
                flagempt = true;
                retmsg6.InnerHtml = Convert.ToString("Last name cannot be empty");
            }
            if (emailID.Length == 0)
            {
                flagempt = true;
                retmsg5.InnerHtml = Convert.ToString("Email cannot be empty");
            }
            if (pw.Length == 0)
            {
                flagempt = true;
                retmsg4.InnerHtml = Convert.ToString("Password cannot be empty");
            }
            if (phoneNo.Length != 11)
            {
                flagempt = true;
                retmsg3.InnerHtml = Convert.ToString("Phone Number can only be an 11 digit number");
            }
            if (shipAdd.Length == 0)
            {
                flagempt = true;
                retmsg1.InnerHtml = Convert.ToString("Shipping address cannot be empty");
            }
            if (BillAdd.Length == 0)
            {
                flagempt = true;
                retmsg2.InnerHtml = Convert.ToString("Billing Address cannot be empty");
            }
            //int found;
            //found = 
            if (flagempt)
            {
                flagempt = false;
                // returnMsg.InnerHtml = Convert.ToString("SignUp UnSuccessful");
            }
            else if (obj.signup(firstname, lastname, emailID, pw, timeStamp, state, phoneNo, shipAdd, BillAdd, paymentType, ref DT) == -1)
            {

                returnMsg.InnerHtml = Convert.ToString("SignUp UnSuccessful");
            }
            else
            {
                //if (found > 0)
                //{
                //loginGrid.DataSource = DT;
                //loginGrid.DataBind();
                // returnMsg.InnerHtml = Convert.ToString("SignUp Successful");
                Response.Redirect("Homepage.aspx");
                // LoadGrid();
            }
            //}
            //else
            //{
            //    returnMsg.InnerHtml = Convert.ToString("Login Failed");
            //    loginGrid.DataSource = null;
            //    loginGrid.DataBind();
            //}
        }

        protected void fname_TextChanged(object sender, EventArgs e)
        {

        }

        protected void lname_TextChanged(object sender, EventArgs e)
        {

        }

        protected void email_TextChanged(object sender, EventArgs e)
        {

        }

        protected void password_TextChanged(object sender, EventArgs e)
        {

        }

        protected void phone_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BAdd_TextChanged(object sender, EventArgs e)
        {

        }

        protected void SAdd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}