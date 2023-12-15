using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AdvisingSystem
{
    public partial class DetailInstructorCourses : System.Web.UI.Page
    {
       
        protected void btnViewDetails_Click(object sender, EventArgs e)
        {
            ViewInstructorDetails();
        }

        private void ViewInstructorDetails()
        {
            string connectionString = "AdvisingSystem";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM FN_StudentViewSlot(@CourseID, @InstructorID)", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.Text;

                // Set parameters
                command.Parameters.AddWithValue("@CourseID", Convert.ToInt32(txtCourseID.Text));
                command.Parameters.AddWithValue("@InstructorID", Convert.ToInt32(txtInstructorID.Text));

                try
                {
                    DataTable detailsTable = new DataTable();
                    adapter.Fill(detailsTable);

                    gvDetails.DataSource = detailsTable;
                    gvDetails.DataBind();
                }
                catch (Exception ex)
                {
                    // Handle errors, display a message, or log the exception
                }
            }
        }
    }
}