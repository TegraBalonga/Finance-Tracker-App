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
    public partial class Financial : System.Web.UI.Page
    {

        HtmlAnchor LogOff, Report, Home, PandC, hFinancial;

        string income, tax, groceries, water, travel, cell, otherExp;

       

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-9A2QO06\MSSQL;Initial Catalog=Prog_Task2;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            Home = (HtmlAnchor)Page.Master.FindControl("Home");
            Home.Visible = true;

            hFinancial = (HtmlAnchor)Page.Master.FindControl("Financial");
            hFinancial.Visible = true;

            PandC = (HtmlAnchor)Page.Master.FindControl("PandC");
            PandC.Visible = true;

            Report = (HtmlAnchor)Page.Master.FindControl("Report");
            Report.Visible = true;

            LogOff = (HtmlAnchor)Page.Master.FindControl("LogOff");
            LogOff.Visible = true;


            lblError.Visible = false;

            txtSaveAmount.Enabled = false;
            txtReason.Enabled = false;
            calDate.Enabled = false;
            txtSaveInterest.Enabled = false;

            txtSaveAmount.BackColor = Color.White;
            txtReason.BackColor = Color.White;
            calDate.BackColor = Color.White;
            txtSaveInterest.BackColor = Color.White;
        }





 protected void chbSave_CheckedChanged(object sender, EventArgs e)
        {
            txtSaveAmount.Enabled = true;
            txtReason.Enabled = true;
            calDate.Enabled = true;
            txtSaveInterest.Enabled = true;
        }






        protected void btnSave_Click(object sender, EventArgs e)
        {

            txtGrossIncome.BackColor = Color.White;
            txtMonthlyTax.BackColor = Color.White;
            txtGroceries.BackColor = Color.White;
            txtWaterLight.BackColor = Color.White;
            txtTravelCost.BackColor = Color.White;
            txtCellPhone.BackColor = Color.White;
            txtOtherExpenses.BackColor = Color.White;



            income = txtGrossIncome.Text;

            tax = txtMonthlyTax.Text;

            groceries = txtGroceries.Text;

            water = txtWaterLight.Text;

            travel = txtTravelCost.Text;

            cell = txtCellPhone.Text;

            otherExp = txtOtherExpenses.Text;



            if (fieldNotEmpty())
            {


                Class1.NoString(income);
                Class1.NoString(tax);
                Class1.NoString(groceries);
                Class1.NoString(water);
                Class1.NoString(travel);
                Class1.NoString(cell);
                Class1.NoString(otherExp);


                if (Class1.letterCount == 0)
                {

                    Class1.Income = Convert.ToDouble(income);

                    Class1.Tax = Convert.ToDouble(tax);

                    Class1.Groceries = Convert.ToDouble(groceries);

                    Class1.Water = Convert.ToDouble(water);

                    Class1.Travel = Convert.ToDouble(travel);

                    Class1.Cell = Convert.ToDouble(cell);

                    Class1.OtherExp = Convert.ToDouble(otherExp);


                    connection.Open();

                    string sql = "INSERT INTO TBL_USER_DETAILS VALUES ('" + Class1.Username + "','" + Class1.Income + "','" + Class1.Tax + "','" + Class1.Groceries + "','" + Class1.Water + "','" + Class1.Travel + "','" + Class1.Cell + "','" + Class1.OtherExp + "','" + 0 + "');";


                    SqlDataAdapter SDA = new SqlDataAdapter(sql, connection);
                    SDA.SelectCommand.ExecuteNonQuery();


                    connection.Close();


                }
                else
                {

                    lblError.Text = "Fields cannot contain letters or special character.";
                    lblError.Visible = true;

                }

            }
            else
            {

                //Response.Write("<script>alert('Fields cannot be empty');</script>");
                lblError.Text = "Fields cannot be empty";
                lblError.Visible = true;
              
            }


            saving();

            Class1.letterCount = 0;

            Response.Write("<script>alert('All your info have been saved');</script>");
        }






        public bool fieldNotEmpty()
        {
            bool empty = true;

            if (income == "")
            {
                txtGrossIncome.BackColor = Color.Red;
                empty = false;
            }

            if (tax == "")
            {
                txtMonthlyTax.BackColor = Color.Red;
                empty = false;
            }

            if (groceries == "")
            {
                txtGroceries.BackColor = Color.Red;
                empty = false;
            }

            if (otherExp == "")
            {
                txtOtherExpenses.BackColor = Color.Red;
                empty = false;
            }

            if (water == "")
            {
                txtWaterLight.BackColor = Color.Red;
                empty = false;
            }

            if (travel == "")
            {
                txtTravelCost.BackColor = Color.Red;
                empty = false;
            }

            if (cell == "")
            {
                txtCellPhone.BackColor = Color.Red;
                empty = false;
            }
            return empty;
        }






        public void saving()
        {


            if (chbSave.Checked == true)
            {
                if (notEmpty()) { 
               
                    Class1.savingAmount = int.Parse(txtSaveAmount.Text);
                
                    Class1.saveReason = txtReason.Text;
                
                    Class1.saveDate = calDate.SelectedDate;


                    connection.Open();

                    string sql = "INSERT INTO TBL_SAVING VALUES ('" + Class1.Username + "','" + Class1.savingAmount + "','" + Class1.SaveInterest + "','" + Class1.saveReason + "','" + Class1.saveDate.ToString("yyyy/mm/dd") + "','" + 0 + "');";


                    SqlDataAdapter SDA = new SqlDataAdapter(sql, connection);
                    SDA.SelectCommand.ExecuteNonQuery();


                    connection.Close();

                }


            }
        }



        public bool notEmpty()
        {
            bool empty = true ;

            if (txtSaveAmount.Text == "")
            {
                txtSaveAmount.BackColor = Color.Red;
                empty = false;
            }

            if (txtReason.Text == "")
            {
                txtReason.BackColor = Color.Red;
                empty = false;
            }

            if (calDate.SelectedDate.ToString() == "")
            {
                calDate.BackColor = Color.Red;
                empty = false;
            }

            if (txtSaveInterest.Text == "")
            {
                txtSaveInterest.BackColor = Color.Red;
                empty = false;
            }

            return empty;
        }




    }
}