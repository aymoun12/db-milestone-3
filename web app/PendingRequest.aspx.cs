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
    public partial class PendingRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPendingRequests();
            }
        }

        private void LoadPendingRequests()
        {
            using (SqlConnection connection = new SqlConnection("AdvisingSystem"))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Request WHERE status = 'Pending'", connection))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    gvPendingRequests.DataSource = dt;
                    gvPendingRequests.DataBind();
                }
                catch (Exception ex)
                {
                    // Handle database connection or query execution errors
                }
            }
        }
    }
}