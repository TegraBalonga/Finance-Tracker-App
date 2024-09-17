using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using TaskLib;

namespace PROG_TASK_3
{
    public partial class Login : Page
    {
       SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-9A2QO06\MSSQL;Initial Catalog=Prog_Task2;Integrated Security=True");

        HtmlAnchor LogOff,Report, Home,PandC,Financial;

        string username, password;

        protected void Page_Load(object sender, EventArgs e)
        {

            lblError.Visible = false;

            Home = (HtmlAnchor)Page.Master.FindControl("Home");
            Home.Visible = false;

            Financial = (HtmlAnchor)Page.Master.FindControl("Financial");
            Financial.Visible = false;

            PandC = (HtmlAnchor)Page.Master.FindControl("PandC");
            PandC.Visible = false;

            Report = (HtmlAnchor)Page.Master.FindControl("Report");
            Report.Visible = false;

            LogOff = (HtmlAnchor)Page.Master.FindControl("LogOff");
            LogOff.Visible = false;
        }


        protected void btnLogIn_Click(object sender, EventArgs e)
        {

            username = txtUser.Text;
            password = txtPass.Text;
           // lblError.Visible = false;

            if (fieldNotEmpty())
            {

                txtUser.BackColor = Color.White;
                txtPass.BackColor = Color.White;

                connection.Open();

                string query = "SELECT * FROM TBL_USER WHERE USERNAME = '" + username + "' AND PASSWORD = HASHBYTES('SHA2_256','" + password + "') ";
                SqlCommand checkUser = new SqlCommand(query, connection);


                SqlDataReader reader = checkUser.ExecuteReader();
                if (reader.HasRows)
                {
                  // username= reader.GetString(0);
                    //Username exist

                    Class1.Username = username;
                    connection.Close();

                    connection.Open();

                    string query2 = "SELECT * FROM TBL_USER_DETAILS WHERE USERNAME = '" + Class1.Username + "' ";
                    SqlCommand checkUser2 = new SqlCommand(query2, connection);


                    SqlDataReader reader2 = checkUser2.ExecuteReader();
                    if (!reader2.HasRows)
                    {
                        Class1.newUser = true;
                    }

                        Response.Redirect("Home.aspx");


                }
                else
                {
                    //Username doesn't exist.
                    lblError.Visible = true;
                    connection.Close();
                }
                


            }
        }





        public bool fieldNotEmpty()
        {
            bool empty = true;

            if (username == "")
            {
                txtUser.BackColor = Color.Red;
                empty = false;
            }

            if (password == "")
            {
                txtPass.BackColor = Color.Red;
                empty = false;
            }
            return empty;
        }




    }
}