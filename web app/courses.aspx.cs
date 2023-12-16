using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
using System.Web.UI.WebControls;

namespace web_app
{
    public partial class CoursesForm : System.Web.UI.Page
    {

        private SqlConnection connection;

        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            connection = new SqlConnection(connstr);
        }

        protected void LoadOptionalCourses(object sender, EventArgs e)
        {
            connection.Open();
            optionalCoursesForm.Controls.Clear();

            SqlCommand courses = new SqlCommand("Procedures_ViewOptionalCourse", connection);
            courses.CommandType = CommandType.StoredProcedure;
            courses.Parameters.AddWithValue("@StudentID", Convert.ToInt32((string)Session["user_id"]));
            courses.Parameters.AddWithValue("@current_semester_code", optionalCoursesSemesterCode.Text);
            
            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                Label name = new Label();
                name.Text = courseName + "<br>";
                optionalCoursesForm.Controls.Add(name);
            }

            connection.Close();
        }

        protected void LoadAvailableCourses(object sender, EventArgs e)
        {
            connection.Open();
            availableCoursesForm.Controls.Clear();

            SqlCommand courses = new SqlCommand("SELECT * FROM dbo.FN_SemsterAvailableCourses(@semstercode)", connection);
            courses.Parameters.AddWithValue("@semstercode", availableCoursesSemesterCode.Text);

            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                Label name = new Label();
                name.Text = courseName + "<br>";
                availableCoursesForm.Controls.Add(name);
            }

            connection.Close();
        }

        protected void LoadRequiredCourses(object sender, EventArgs e)
        {
            connection.Open();
            requiredCoursesForm.Controls.Clear();

            SqlCommand courses = new SqlCommand("Procedures_ViewRequiredCourses", connection);
            courses.CommandType = CommandType.StoredProcedure;
            courses.Parameters.AddWithValue("@StudentID", Convert.ToInt32((string)Session["user_id"]));
            courses.Parameters.AddWithValue("@current_semester_code", requiredCoursesSemesterCode.Text);
            
            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                Label name = new Label();
                name.Text = courseName + "<br>";
                requiredCoursesForm.Controls.Add(name);
            }

            connection.Close();
        }

        protected void LoadMissingCourses(object sender, EventArgs e)
        {
            connection.Open();
            missingCoursesForm.Controls.Clear();

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

            connection.Close();
        }

        protected void Back(object sender, EventArgs e)
        {
            Response.Redirect("main_menu.aspx");
        }
    }
}
