using Microsoft.Win32;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace web_app
{
    public partial class RequestsForm : System.Web.UI.Page
    {
        
        private SqlConnection connection;

        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            connection = new SqlConnection(connstr);
        }

        protected void SubmitCourseRequest(object sender, EventArgs e)
        {
            if (courseId.Text.Equals(""))
            {
                Response.Write("Course ID is empty.");
                return;
            }

            connection.Open();

            SqlCommand request = new SqlCommand("Procedures_StudentSendingCourseRequest", connection);
            request.CommandType = CommandType.StoredProcedure;
            request.Parameters.AddWithValue("@StudentID", Convert.ToInt32((string)Session["user_id"]));
            request.Parameters.AddWithValue("@courseID", Convert.ToInt32(courseId.Text));
            request.Parameters.AddWithValue("@comment", courseComment.Text);
            request.Parameters.AddWithValue("@type", "course");

            request.ExecuteNonQuery();
            courseId.Text = null;
            courseComment.Text = null;
            Response.Write("Course request sent. Please wait till it gets approved.");

            connection.Close();
        }

        protected void SubmitCreditHoursRequest(object sender, EventArgs e)
        {
            if (creditHoursAmount.Text.Equals(""))
            {
                Response.Write("Credit hours is empty.");
                return;
            }

            connection.Open();

            SqlCommand request = new SqlCommand("Procedures_StudentSendingCHRequest", connection);
            request.CommandType = CommandType.StoredProcedure;
            request.Parameters.AddWithValue("@StudentID", Convert.ToInt32((string)Session["user_id"]));
            request.Parameters.AddWithValue("@credit_hours", Convert.ToInt32(creditHoursAmount.Text));
            request.Parameters.AddWithValue("@comment", creditHoursComment.Text);
            request.Parameters.AddWithValue("@type", "credit_hours");

            request.ExecuteNonQuery();
            creditHoursAmount.Text = null;
            creditHoursComment.Text = null;
            Response.Write("Credit hours request sent. Please wait till it gets approved.");

            connection.Close();
        }

        protected void Back(object sender, EventArgs e)
        {
            Response.Redirect("main_menu.aspx");
        }
    }
}
