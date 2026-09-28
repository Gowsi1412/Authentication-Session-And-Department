using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Authentication
{
    public partial class Page_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null)
            {
                lblName.Text = "Name: " + Session["Name"].ToString();
            }

            if (Application["Message"] != null)
            {
                lblMessage.Text =
                    Application["Message"].ToString();
            }
        }
    }
}