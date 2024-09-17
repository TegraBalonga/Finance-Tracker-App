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
    public partial class Report : System.Web.UI.Page
    {
        SqlConnection sConnection = new SqlConnection(@"Data Source=DESKTOP-9A2QO06\MSSQL;Initial Catalog=Prog_Task2;Integrated Security=True");

        HtmlAnchor LogOff, hReport, Home, PandC, Financial;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Class1.newUser == false)
            {
                //Username exist
                Home = (HtmlAnchor)Page.Master.FindControl("Home");
                Home.Visible = true;

                Financial = (HtmlAnchor)Page.Master.FindControl("Financial");
                Financial.Visible = false;

                PandC = (HtmlAnchor)Page.Master.FindControl("PandC");
                PandC.Visible = false;

                hReport = (HtmlAnchor)Page.Master.FindControl("Report");
                hReport.Visible = true;

                LogOff = (HtmlAnchor)Page.Master.FindControl("LogOff");
                LogOff.Visible = true;
            }
            else
            {
                //Username doesn't exist.
                Home = (HtmlAnchor)Page.Master.FindControl("Home");
                Home.Visible = true;

                Financial = (HtmlAnchor)Page.Master.FindControl("Financial");
                Financial.Visible = true;

                PandC = (HtmlAnchor)Page.Master.FindControl("PandC");
                PandC.Visible = true;

                hReport = (HtmlAnchor)Page.Master.FindControl("Report");
                hReport.Visible = true;

                LogOff = (HtmlAnchor)Page.Master.FindControl("LogOff");
                LogOff.Visible = true;
            }

            sConnection.Close();





            string selectSql = "SELECT * FROM TBL_USER_DETAILS WHERE USERNAME = '" + Class1.Username + "'";
            SqlCommand com = new SqlCommand(selectSql, sConnection);

            try
            {
                sConnection.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {
                        lblIncome.Text = "R" + (read["GROSS_MONTHLY_INCOME"].ToString());
                        lblTax.Text = "R" + (read["ESTIM_MONTHLY_TAX"].ToString());
                        lblGroceries.Text = "R" + (read["GROCERIES"].ToString());
                        lblWater.Text = "R" + (read["WATER_LIGHTS"].ToString());
                        lblTravel.Text = "R" + (read["TRAVEL_COST"].ToString());
                        lblCellPhone.Text = "R" + (read["CELLPHONE_TELEPHONE"].ToString());
                        lblOtherExpenses.Text = "R" + (read["OTHERS"].ToString());
                        lblAvailMoney.Text = "R" + (read["AVAILABLE_MONEY"].ToString());


                    }
                }
            }
            finally
            {
                sConnection.Close();
            }

            getPropertyAndCar();


            if (Class1.RentorBuy == "Rent an accomodation")
            {
                RentAccom();

            }
            else if (Class1.RentorBuy == "Bought a property")
            {
                BuyProp();
            }

            if (Class1.carPurchase == "Yes")
            {
                purchasedCar();
            }
            else
            {
                lblModel.Text = "None";
                lblCarPrice.Text = "None";
                lblCarDeposit.Text = "None";
                lblCarRate.Text = "None";
                lblInsurance.Text = "None";
                lblCarLoan.Text = "None";
            }

            if(Class1.savingAmount != 0)
            {
               

                sConnection.Open();

                string sql = "UPDATE TBL_SAVING SET MONTHLY_SAVE = '"+Class1.calcSaving()+"' WHERE USERNAME = '"+Class1.Username+"');";


                SqlDataAdapter SDA = new SqlDataAdapter(sql, sConnection);
                SDA.SelectCommand.ExecuteNonQuery();


                sConnection.Close();
                getSaving();
            }
            else
            {
                lblSaveTitle.Visible = false;
                lblSavingAmount.Visible = false;
            }

        }



        ////////////////////////////////////////////////////////////////////////////////////////////////


        public void getPropertyAndCar()
        {
            string selectSql = "SELECT * FROM TBL_USER WHERE USERNAME = '" + Class1.Username + "'";
            SqlCommand com = new SqlCommand(selectSql, sConnection);

            try
            {
                sConnection.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {
                        Class1.RentorBuy = (read["PROPERTY"].ToString());
                        Class1.carPurchase = (read["CAR_PURCHASE"].ToString());

                    }
                }
            }
            finally
            {
                sConnection.Close();
            }
        }





        ////////////////////////////////////////////////////////////////////////////////////////////////

        public void BuyProp()
        {

            lblChoice.Text = Class1.RentorBuy;

            lblPriceTitle.Text = "Purchase Price of Property:";

            string selectSql = "SELECT * FROM TBL_BUY WHERE USERNAME = '" + Class1.Username + "'";
            SqlCommand com = new SqlCommand(selectSql, sConnection);

            try
            {
                sConnection.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {
                        lblPrice.Text = "R" + (read["PURCHASE_PRICE"].ToString());
                        lblDeposit.Text = "R" + (read["TOTAL_DEPOSIT"].ToString());
                        lblRate.Text = "R" + (read["INTEREST_RATE"].ToString());
                        lblNoMonths.Text = "R" + (read["NO_OF_REPAY_MONTHS"].ToString());
                        lblHomeLoan.Text = "R" + (read["MONTHLY_LOAN_REPAY"].ToString());
                    }
                }
            }
            finally
            {
                sConnection.Close();
            }
        }





        ////////////////////////////////////////////////////////////////////////////////////////////////

        public void RentAccom()
        {
            lblChoice.Text = Class1.RentorBuy;
            lblDepositTitle.Visible = false;
            lblDeposit.Visible = false;
            lblRateTitle.Visible = false;
            lblRate.Visible = false;
            lblMonthTitle.Visible = false;
            lblNoMonths.Visible = false;
            lblHomeLoanTitle.Visible = false;
            lblHomeLoan.Visible = false;

            string selectSql = "SELECT * FROM TBL_RENT WHERE USERNAME = '" + Class1.Username + "'";
            SqlCommand command = new SqlCommand(selectSql, sConnection);

            try
            {
                sConnection.Open();
                using (SqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        lblPrice.Text = "R" + (read["MONTHLY_RENTAL_AMT"].ToString());
                    }
                }
            }
            finally
            {
                sConnection.Close();
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////

        public void purchasedCar()
        {
            lblModel.Text = Class1.ModelandMake;

            string selectSql = "SELECT * FROM TBL_VEHICLE WHERE USERNAME = '" + Class1.Username + "'";
            SqlCommand command = new SqlCommand(selectSql, sConnection);

            try
            {
                sConnection.Open();
                using (SqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        lblModel.Text = (read["MODEL_MAKE"].ToString());
                        lblCarPrice.Text = "R" + (read["PURCHASE_PRICE"].ToString());
                        lblCarDeposit.Text = "R" + (read["TOTAL_DEPOSIT"].ToString());
                        lblCarRate.Text = "R" + (read["INTEREST_RATE"].ToString());
                        lblInsurance.Text = "R" + (read["ESTIM_INSURANCE"].ToString());
                        lblCarLoan.Text = "R" + (read["TOTAL_MONTHLY_COST"].ToString());
                    }
                }
            }
            finally
            {
                sConnection.Close();
            }
        }








        ////////////////////////////////////////////////////////////////////////////////////////////////
        
        public void getSaving()
        {
            string selectSql = "SELECT * FROM TBL_SAVING WHERE USERNAME = '" + Class1.Username + "'";
            SqlCommand command = new SqlCommand(selectSql, sConnection);

            try
            {
                sConnection.Open();
                using (SqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        lblSavingAmount.Text = "R" + (read["MONTHLY_SAVE"].ToString());
                    }
                }
            }
            finally
            {
                sConnection.Close();
            }
        }





    }
}