using System;
using System.Data.SqlClient;
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

            String userIdString = userID.Text;
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
                login.Parameters.Add(new SqlParameter("@Student_id", Int16.Parse(userIdString)));
                login.Parameters.Add(new SqlParameter("@password", passwordString));

                conn.Open();
                object result = login.ExecuteScalar();
                bool bitResult = result != null && Convert.ToBoolean(result);
                conn.Close();

                if (bitResult)
                {
                    Session["user_id"] = userIdString;
                    Response.Redirect("main_menu.aspx");
                }
            }
        }

        protected void Register(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}
