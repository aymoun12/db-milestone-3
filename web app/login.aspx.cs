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

            int id = Int16.Parse(userID.Text);
            String pass = password.Text;

            SqlCommand login = new SqlCommand("FN_StudentLogin", conn);
            login.Parameters.Add(new SqlParameter("@Student_id", id));
            login.Parameters.Add(new SqlParameter("@password", pass));

            conn.Open();
            object result = login.ExecuteScalar();
            bool bitResult = result != null && Convert.ToBoolean(result);
            conn.Close();

            if (bitResult)
            {
                Session["user_id"] = id;
                Response.Redirect("main_menu.aspx");
            }
        }

        protected void Register(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}
