using System;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace web_app
{
    public partial class CoursesForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Back(object sender, EventArgs e)
        {
            Response.Redirect("main_menu.aspx");
        }
    }
}
