using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdvisingSystem
{
    public partial class NewCourse : System.Web.UI.Page
    {

        protected void btnAddCourse_Click(object sender, EventArgs e)
        {
            AddNewCourse();
        }

        private void AddNewCourse()
        {
            string connectionString = "AdvisingSystem";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("Procedures_AdminAddingCourse", connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Set parameters
                command.Parameters.AddWithValue("@major", txtMajor.Text);
                command.Parameters.AddWithValue("@semester", Convert.ToInt32(txtSemester.Text));
                command.Parameters.AddWithValue("@credit_hours", Convert.ToInt32(txtCreditHours.Text));
                command.Parameters.AddWithValue("@name", txtCourseName.Text);
                command.Parameters.AddWithValue("@is_offered", chkIsOffered.Checked);

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