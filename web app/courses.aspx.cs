using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
using System.Web.UI.WebControls;

namespace web_app
{
    public partial class CoursesForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            conn.Open();
            LoadOptionalCourses(conn);
            LoadAvailableCourses(conn);
            LoadRequiredCourses(conn);
            LoadMissingCourses(conn);
            conn.Close();
        }

        private void LoadOptionalCourses(SqlConnection connection)
        {
            SqlCommand courses = new SqlCommand("Procedures_ViewOptionalCourse", connection);
            courses.CommandType = CommandType.StoredProcedure;
            courses.Parameters.AddWithValue("@StudentID", Convert.ToInt32((string)Session["user_id"]));
            courses.Parameters.AddWithValue("@current_semester_code", "");
            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                Label name = new Label();
                name.Text = courseName + "<br>";
                optionalCoursesForm.Controls.Add(name);
            }
        }

        private void LoadAvailableCourses(SqlConnection connection)
        {
            SqlCommand courses = new SqlCommand("SELECT dbo.FN_SemesterAvalaibleCourses(@semestercode)", connection);
            courses.Parameters.AddWithValue("@semestercode", "");

            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                Label name = new Label();
                name.Text = courseName + "<br>";
                availableCoursesForm.Controls.Add(name);
            }
        }

        private void LoadRequiredCourses(SqlConnection connection)
        {
            SqlCommand courses = new SqlCommand("Procedures_ViewRequiredCourses", connection);
            courses.CommandType = CommandType.StoredProcedure;
            courses.Parameters.AddWithValue("@StudentID", Convert.ToInt32((string)Session["user_id"]));
            courses.Parameters.AddWithValue("@current_semester_code", "");
            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                Label name = new Label();
                name.Text = courseName + "<br>";
                requiredCoursesForm.Controls.Add(name);
            }
        }

        private void LoadMissingCourses(SqlConnection connection)
        {
            SqlCommand courses = new SqlCommand("Procedures_ViewMS", connection);
            courses.CommandType = CommandType.StoredProcedure;
            courses.Parameters.AddWithValue("@StudentID", Convert.ToInt32((string)Session["user_id"]));

            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                Label name = new Label();
                name.Text = courseName + "<br>";
                missingCoursesForm.Controls.Add(name);
            }
        }

        protected void Back(object sender, EventArgs e)
        {
            Response.Redirect("main_menu.aspx");
        }
    }
}
