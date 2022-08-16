using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZenGaming.DAL;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace ZenGaming
{
    public partial class ProfileEdit : System.Web.UI.Page
    {
        private static readonly string connString =
      System.Configuration.ConfigurationManager.ConnectionStrings["SQLDbConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            String EmailID = (String)Session["user"];
           
            DataTable ds = new DataTable();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 255);

                cmd.Parameters["@Email"].Value = EmailID;
                cmd.ExecuteNonQuery();
                da.Fill(ds);
                if (ds.Rows.Count > 0)
                {
                    name.Text = ds.Rows[0]["first_name"].ToString();
                    Surname.Text = ds.Rows[0]["last_name"].ToString();
                    state.Text = ds.Rows[0]["State"].ToString();
                    phonenumber.Text = ds.Rows[0]["Phone"].ToString();
                    address.Text = ds.Rows[0]["Address"].ToString();
                    b_address.Text = ds.Rows[0]["BillingAddress"].ToString();
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                
            }
            finally
            {
                con.Close();

            }
        }
        protected void Profile_Load(object sender, EventArgs e)
        {
            bool flagempt = false;
            String EmailID = (String)Session["user"];
            String firstname = name.Text;
            String lastname = Surname.Text;
            String phoneNo = phonenumber.Text;
            String Address = address.Text;
            String BillAdd = b_address.Text;
            int PaymentType = 0; //by default
            String State = state.Text; //active user
            DateTime timeStamp = DateTime.Now;

            DAL1 obj = new DAL1();
            DataTable DT = new DataTable();
            if (firstname.Length == 0)
            {
                flagempt = true;
                returnMsg.InnerHtml = Convert.ToString("First Name cannot be empty");
            }
            if (lastname.Length == 0)
            {
                flagempt = true;
                returnMsg.InnerHtml = Convert.ToString("Last name cannot be empty");
            }
            if (phoneNo.Length == 0)
            {
                flagempt = true;
                returnMsg.InnerHtml = Convert.ToString("Phone Number can not be empty");
            }
            if (Address.Length == 0)
            {
                flagempt = true;
                returnMsg.InnerHtml = Convert.ToString("Address cannot be empty");
            }
            if (BillAdd.Length == 0)
            {
                flagempt = true;
                returnMsg.InnerHtml = Convert.ToString("Billing Address cannot be empty");
            }
            //int found;
            //found = 
            if (flagempt)
            {
                flagempt = false;
                // returnMsg.InnerHtml = Convert.ToString("SignUp UnSuccessful");
            }
            else if (obj.Profile_Edit(firstname, lastname,EmailID,  timeStamp, State, phoneNo, Address, BillAdd, PaymentType, ref DT) == -1)
            {

                returnMsg.InnerHtml = Convert.ToString("Profile not saved");
            }
            else
            {
                //if (found > 0)
                //{
                //loginGrid.DataSource = DT;
                //loginGrid.DataBind();
                // returnMsg.InnerHtml = Convert.ToString("SignUp Successful");
                returnMsg.InnerHtml = Convert.ToString("Profile saved successfully");
                Response.Redirect("Homepage.aspx");
                // LoadGrid();
            }

        }
    }
}