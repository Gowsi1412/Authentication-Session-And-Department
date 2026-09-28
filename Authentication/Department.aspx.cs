using System;
using System.Data;
using System.Data.SqlClient;

namespace Authentication
{
    public partial class Department : System.Web.UI.Page
    {
        string connectionstring =
            @"Server=Gowsalya\SQLEXPRESS;
              Database=Dotnet;
              Trusted_Connection=True;
              TrustServerCertificate=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDepartments();
            }

        }
        private void LoadDepartments()
        {
            using (SqlConnection connection =
                   new SqlConnection(connectionstring))
            {
                string query =
                    "SELECT DepartmentID, DepartmentName FROM Department";
                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ddlDepartment.DataSource = dt;
                ddlDepartment.DataTextField =
                    "DepartmentName";
                ddlDepartment.DataValueField =
                    "DepartmentID";
                ddlDepartment.DataBind();
            }
        }
    }
}


