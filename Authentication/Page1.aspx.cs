using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Authentication
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            Session["Name"] = txtName.Text;

            Application["Message"] = "Data saved successfully";
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("Page2.aspx");
        }
    }
}