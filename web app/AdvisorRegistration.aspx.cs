using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdvisingSystem
{
    public partial class AdvisorRegistration : System.Web.UI.Page
    {
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string advisorName = txtAdvisorName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string email = txtEmail.Text.Trim();
            string office = txtOffice.Text.Trim();

            using (SqlConnection connection = new SqlConnection("AdvisingSystem"))
            using (SqlCommand command = new SqlCommand("Procedures_AdvisorRegistration", connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@advisor_name", advisorName);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@office", office);

                SqlParameter outputParameter = new SqlParameter("@Advisor_id", System.Data.SqlDbType.Int)
                {
                    Direction = System.Data.ParameterDirection.Output
                };

                command.Parameters.Add(outputParameter);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    int advisorId = Convert.ToInt32(outputParameter.Value);

                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
    