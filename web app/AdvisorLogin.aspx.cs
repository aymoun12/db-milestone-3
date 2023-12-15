using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

    namespace AdvisingSystem
    {
        public partial class AdvisorLogin : System.Web.UI.Page
        {

            protected void btnLogin_Click(object sender, EventArgs e)
            {
                int advisorId;
                if (!int.TryParse(txtAdvisorId.Text.Trim(), out advisorId))
                {
                    // Handle invalid input
                    return;
                }

                string password = txtPassword.Text.Trim();

                using (SqlConnection connection = new SqlConnection("AdvisingSystem"))
                using (SqlCommand command = new SqlCommand("SELECT dbo.FN_AdvisorLogin(@advisor_Id, @password)", connection))
                {
                    command.Parameters.AddWithValue("@advisor_Id", advisorId);
                    command.Parameters.AddWithValue("@password", password);

                    try
                    {
                        connection.Open();
                        bool success = (bool)command.ExecuteScalar();

                        if (success)
                        {
                            
                            Response.Write("Login Successful!");
                        }
                        else
                        {
                            
                            Response.Write("Login Failed!");
                        }
                    }
                    catch (Exception ex)
                    {
                        
                    }
                }
            }
        }
    }