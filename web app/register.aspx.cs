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
            String semesterString = semester.Text;

            bool areAllFieldsValid = true;

            if (firstNameString.Equals(""))
            {
                Response.Write("First name is empty.");
                areAllFieldsValid = false;
            }

            if (lastNameString.Equals(""))
            {
                Response.Write("Last name is empty.");
                areAllFieldsValid = false;
            }

            if (passwordString.Equals(""))
            {
                Response.Write("Password is empty.");
                areAllFieldsValid = false;
            }

            if (facultyString.Equals(""))
            {
                Response.Write("Faculty is empty.");
                areAllFieldsValid = false;
            }

            if (emailString.Equals(""))
            {
                Response.Write("Email is empty.");
                areAllFieldsValid = false;
            }

            if (majorString.Equals(""))
            {
                Response.Write("Major is empty.");
                areAllFieldsValid = false;
            }

            if (semesterString.Equals(""))
            {
                Response.Write("Semester is empty.");
                areAllFieldsValid = false;
            }

            if (areAllFieldsValid)
            {
                SqlCommand register = new SqlCommand("Procedures_StudentRegistration", conn);
                register.Parameters.AddWithValue("@first_name", firstNameString);
                register.Parameters.AddWithValue("@last_name", lastNameString);
                register.Parameters.AddWithValue("@password", passwordString);
                register.Parameters.AddWithValue("@faculty", facultyString);
                register.Parameters.AddWithValue("@email", emailString);
                register.Parameters.AddWithValue("@major", majorString);
                register.Parameters.AddWithValue("@Semester", Convert.ToInt32(semesterString));

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
        }

        protected void Back(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}
