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
    public partial class Shipping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void track_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            if (trkorder.Text.Length != 0)
            {try
                { DataTable DT = new DataTable();
                    int n = Convert.ToInt32(trkorder.Text.ToString(), 10);
                    DAL1 dalobj = new DAL1();
                    order.DataSource = dalobj.SelectItem(n, ref DT);
                    order.DataBind(); }
                catch (Exception)
                {
                    retship.InnerHtml = Convert.ToString("No Such Record");
                }

            }
        }
        protected void trkorder_TextChanged(object sender, EventArgs e)
        {
            if (trkorder.Text.Length == 0)
            {
                track.Enabled = false;
            }
            else
            { track.Enabled = true; }
        }
    }
}