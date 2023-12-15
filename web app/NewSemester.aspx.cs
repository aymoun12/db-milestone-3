using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AdvisingSystem
{
    public partial class NewSemester : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Page load logic, if any
        }

        protected void btnAddSemester_Click(object sender, EventArgs e)
        {
            AddNewSemester();
        }

        private void AddNewSemester()
        {
            string connectionString = "AdvisingSystem";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("AdminAddingSemester", connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Set parameters
                command.Parameters.AddWithValue("@start_date", Convert.ToDateTime(txtStartDate.Text));
                command.Parameters.AddWithValue("@end_date", Convert.ToDateTime(txtEndDate.Text));
                command.Parameters.AddWithValue("@semester_code", txtSemesterCode.Text);

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