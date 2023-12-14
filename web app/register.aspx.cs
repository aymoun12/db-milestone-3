using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace web_app
{
    public partial class RegisterForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            String firstNameString = firstName.Text;
            String lastNameString = lastName.Text;
            String passwordString = password.Text;
            String facultyString = faculty.Text;
            String emailString = email.Text;
            String majorString = major.Text;
            int semesterInt = Int16.Parse(semester.Text);

            SqlCommand register = new SqlCommand("Procedures_StudentRegistration", conn);
            register.Parameters.Add(new SqlParameter("@first_name", firstNameString));
            register.Parameters.Add(new SqlParameter("@last_name", lastNameString));
            register.Parameters.Add(new SqlParameter("@password", passwordString));
            register.Parameters.Add(new SqlParameter("@faculty", facultyString));
            register.Parameters.Add(new SqlParameter("@email", emailString));
            register.Parameters.Add(new SqlParameter("@major", majorString));
            register.Parameters.Add(new SqlParameter("@Semester", semesterInt));

            SqlParameter studentIdParam = register.Parameters.Add(new SqlParameter("@Student_id", SqlDbType.Int));
            studentIdParam.Direction = ParameterDirection.Output;

            conn.Open();
            register.ExecuteNonQuery();
            conn.Close();

            String userId = studentIdParam.Value.ToString();
            Session["user_id"] = userId;
            Response.Write(userId);
            Response.Redirect("main_menu.aspx");
        }

        protected void Back(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}
