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
    public partial class SignIn : Page
    {

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-9A2QO06\MSSQL;Initial Catalog=Prog_Task2;Integrated Security=True");



        HtmlAnchor LogOff, Report, Home, PandC, Financial;


        string name, surname, email, username, password;




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






        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            surname = txtSurname.Text;
            email = txtEmail.Text;
            username = txtUser.Text;
            password = txtPass.Text;

            txtName.BackColor = Color.White;
            txtSurname.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            txtUser.BackColor = Color.White;
            txtPass.BackColor = Color.White;




            if (fieldNotEmpty())
            {

                Class1.NoInt(name);
                Class1.NoInt(surname);


                if (Class1.digitCount == 0)
                {

                    connection.Open();

                    string query = "SELECT * FROM TBL_USER WHERE USERNAME = '" + username + "' AND PASSWORD = HASHBYTES('SHA2_256','" + password + "') ";
                    SqlCommand checkUser = new SqlCommand(query, connection);


                    SqlDataReader reader = checkUser.ExecuteReader();
                    if (reader.HasRows)
                    {

                        
                        lblError.Text = "This user already exist.";
                        lblError.Visible = true;
                        connection.Close();


                    }
                    else
                    {

                        reader.Close();

                        //Username doesn't exist.
                        string sql = "INSERT INTO TBL_USER VALUES ('" + name + "','" + surname + "','" + email + "','" + username + "',HASHBYTES('SHA2_256','" + password + "'), '','');";


                        SqlDataAdapter SDA = new SqlDataAdapter(sql, connection);
                        SDA.SelectCommand.ExecuteNonQuery();

                        connection.Close();

                        //Response.Write("<script>alert('You have been registered, you can log in now.');</script>");

                        
                        //System.Threading.WaitHandle.
                        //MessageBox.Show("You have been registered, you can log in now.");
                        //lblError.Text = "You have been registered, you will be redirected shortly";
                        //lblError.Visible = true;

                       // System.Threading.Thread.Sleep(7000);

                        Class1.digitCount = 0;

                        Response.Redirect("Login.aspx");



                    }
                }
                else
                {


                    txtName.BackColor = Color.Red;
                    txtSurname.BackColor = Color.Red;

                    
                    lblError.Text = "These fields doesn't take integers";
                    lblError.Visible = true;

                    Class1.digitCount = 0;


                }
            }


        }





        public bool fieldNotEmpty()
        {
            bool empty = true;

            if (name == "")
            {
                txtName.BackColor = Color.Red;
                empty = false;
            }

            if (surname == "")
            {
                txtSurname.BackColor = Color.Red;
                empty = false;
            }

            if (email == "")
            {
                txtEmail.BackColor = Color.Red;
                empty = false;
            }

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





        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }





    }
}