using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using TaskLib;

namespace PROG_TASK_3
{
    public partial class Home : Page
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-9A2QO06\MSSQL;Initial Catalog=Prog_Task2;Integrated Security=True");


        HtmlAnchor LogOff, Report, hHome, PandC, Financial;


        protected void Page_Load(object sender, EventArgs e)
        {

            if (Class1.newUser == false)
            {
                //Username exist
                hHome = (HtmlAnchor)Page.Master.FindControl("Home");
                hHome.Visible = true;

                Financial = (HtmlAnchor)Page.Master.FindControl("Financial");
                Financial.Visible = false;

                PandC = (HtmlAnchor)Page.Master.FindControl("PandC");
                PandC.Visible = false;

                Report = (HtmlAnchor)Page.Master.FindControl("Report");
                Report.Visible = true;

                LogOff = (HtmlAnchor)Page.Master.FindControl("LogOff");
                LogOff.Visible = true;
            }
            else
            {
                //Username doesn't exist.
                hHome = (HtmlAnchor)Page.Master.FindControl("Home");
                hHome.Visible = true;

                Financial = (HtmlAnchor)Page.Master.FindControl("Financial");
                Financial.Visible = true;

                PandC = (HtmlAnchor)Page.Master.FindControl("PandC");
                PandC.Visible = true;

                Report = (HtmlAnchor)Page.Master.FindControl("Report");
                Report.Visible = true;

                LogOff = (HtmlAnchor)Page.Master.FindControl("LogOff");
                LogOff.Visible = true;
            }

            connection.Close();



        }
    }
}