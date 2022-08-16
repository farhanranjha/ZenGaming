using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2.DAL
{
    
    public class DAL1
    {
        private static readonly string connString =
      System.Configuration.ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;
        public int login(String email, String pass, ref DataTable DT)
        {
            DataSet ds = new DataSet();
            int Found = 0;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("searcustomer ", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@email", SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@email"].Value = email;
                cmd.Parameters["@password"].Value = pass;


                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@Found"].Value); //convert to output parameter to interger format

                if (Found == 1)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                    {
                        da.Fill(ds);

                    }

                    DT = ds.Tables[0];

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

            return Found;

        }
        public void signup(String fname, String lname,String email,String password,DateTime time,String State,String phone,String address,String billing_address,int payment_type, ref DataTable DT)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("addcustomer", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@fname", SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@lname", SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@time", SqlDbType.DateTime);
                cmd.Parameters.Add("@state", SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@phone", SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@address", SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@billing_address", SqlDbType.VarChar,15);
                cmd.Parameters.Add("@paymenttype", SqlDbType.Int);
                // set parameter values
                cmd.Parameters["@email"].Value = email;
                cmd.Parameters["@password"].Value = password;
                cmd.Parameters["@email"].Value = email;
                cmd.Parameters["@fname"].Value = fname;
                cmd.Parameters["@lname"].Value = lname;
                cmd.Parameters["@time"].Value = time;
                cmd.Parameters["@state"].Value = State;
                cmd.Parameters["@phone"].Value = phone;
                cmd.Parameters["@address"].Value = address;
                cmd.Parameters["@billing_address"].Value = billing_address;
                


                cmd.ExecuteNonQuery();

                // read output value 
                


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
    }
}