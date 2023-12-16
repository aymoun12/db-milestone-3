using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace web_app
{
    public partial class PhoneNumbersForm : System.Web.UI.Page
    {
        
        private SqlConnection connection;

        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            connection = new SqlConnection(connstr);
        }

        protected void Add(object sender, EventArgs e)
        {
            if (phoneNumber.Text.Equals(""))
            {
                Response.Write("Phone number is empty.");
                return;
            }

            connection.Open();

            SqlCommand request = new SqlCommand("[Procedures_StudentaddMobile]", connection);
            request.CommandType = CommandType.StoredProcedure;
            request.Parameters.AddWithValue("@StudentID", Convert.ToInt32((string)Session["user_id"]));
            request.Parameters.AddWithValue("@mobile_number", phoneNumber.Text);

            request.ExecuteNonQuery();
            phoneNumber.Text = null;
            Response.Write("Phone number got added successfully.");

            connection.Close();
        }

        protected void Back(object sender, EventArgs e)
        {
            Response.Redirect("main_menu.aspx");
        }
    }
}
