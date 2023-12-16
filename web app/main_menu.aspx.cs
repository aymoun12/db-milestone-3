using System;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace web_app
{
    public partial class MainMenuForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            userId.Text = "Hello user " + Session["user_id"];
        }

        protected void ViewPhoneNumbers(object sender, EventArgs e)
        {
            Response.Redirect("phone_numbers.aspx");
        }

        protected void ViewCourses(object sender, EventArgs e)
        {
            Response.Redirect("courses.aspx");
        }

        protected void ViewRequests(object sender, EventArgs e)
        {
            Response.Redirect("requests.aspx");
        }

        protected void LogOut(object sender, EventArgs e)
        {
            Session["user_id"] = null;
            Response.Redirect("login.aspx");
        }
    }
}
