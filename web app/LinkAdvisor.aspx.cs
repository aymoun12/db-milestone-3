using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AdvisingSystem
{
    public partial class LinkInstructor : System.Web.UI.Page
    {

        protected void btnLinkInstructor_Click(object sender, EventArgs e)
        {
        
            string connectionString = "AdvisingSystem";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("Procedures_AdminLinkInstructor", connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Set parameters
                command.Parameters.AddWithValue("@cours_id", Convert.ToInt32(txtCourseID.Text));
                command.Parameters.AddWithValue("@instructor_id", Convert.ToInt32(txtInstructorID.Text));
                command.Parameters.AddWithValue("@slot_id", Convert.ToInt32(txtSlotID.Text));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    // Handle success or redirect to another page
                }
                catch (Exception ex)
                {
                    // Handle errors, display a message, or log the exception
                }
            }
        }
    }
}