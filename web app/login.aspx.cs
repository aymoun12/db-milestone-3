using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Web.Configuration;

namespace web_app
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            String userIdString = userId.Text;
            String passwordString = password.Text;

            bool areAllFieldsValid = true;

            if (userIdString.Equals(""))
            {
                Response.Write("User ID is empty.");
                areAllFieldsValid = false;
            }

            if (passwordString.Equals(""))
            {
                Response.Write("Password is empty.");
                areAllFieldsValid = false;
            }

            if (areAllFieldsValid)
            {
                SqlCommand login = new SqlCommand("FN_StudentLogin", conn);
                login.CommandType = CommandType.StoredProcedure;
                login.Parameters.AddWithValue("@Student_id", Convert.ToInt32(userIdString));
                login.Parameters.AddWithValue("@password", passwordString);

                conn.Open();
                object result = login.ExecuteScalar();
                bool bitResult = result != null && Convert.ToBoolean(result);
                conn.Close();

                if (bitResult)
                {
                    Session["user_id"] = userIdString;
                    Response.Redirect("main_menu.aspx");
                } else
                {
                    Response.Write("Either the user ID or the password is incorrect or the financial status is invalid.");
                }
            }
        }

        protected void Register(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}
