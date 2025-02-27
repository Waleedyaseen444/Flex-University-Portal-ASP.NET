using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class genratereports : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["AdminName"] != null)
            {
                string adminName = Session["AdminName"].ToString();
                Label1.Text = adminName;

            }
            else
            {
            }
        }
    }

    protected void OfferedCoursesReport_Click(object sender, EventArgs e)
    {
        Response.Redirect("courseofferreport.aspx");

    }

    protected void StudentSectionReport_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentsectionreport.aspx");
    }

    protected void CourseAllocationReport_Click(object sender, EventArgs e)
    {
        Response.Redirect("courseallocationreport.aspx");

    }


    protected void LogsReport_Click(object sender, EventArgs e)
    {
        Response.Redirect("logreport.aspx");
    }
}