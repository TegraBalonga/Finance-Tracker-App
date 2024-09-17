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
    public partial class PropertyAndCar : System.Web.UI.Page
    {

        SqlConnection sConnection = new SqlConnection(@"Data Source=DESKTOP-9A2QO06\MSSQL;Initial Catalog=Prog_Task2;Integrated Security=True");


        HtmlAnchor LogOff, Report, Home, PandC, Financial;

        bool error;
        string rentAmount, price, deposit, rate, noMonths;
        string modelandMake, carPrice, carDeposit, carRate, estimInsurance;



        protected void Page_Load(object sender, EventArgs e)
        {
            Home = (HtmlAnchor)Page.Master.FindControl("Home");
            Home.Visible = true;

            Financial = (HtmlAnchor)Page.Master.FindControl("Financial");
            Financial.Visible = true;

            PandC = (HtmlAnchor)Page.Master.FindControl("PandC");
            PandC.Visible = true;

            Report = (HtmlAnchor)Page.Master.FindControl("Report");
            Report.Visible = true;

            LogOff = (HtmlAnchor)Page.Master.FindControl("LogOff");
            LogOff.Visible = true;

            disable();

            //Class1.carPurchase = "No";

            lblError.Visible = false;

            //Class1.AccomProperty = null;
        }








        ////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Disables the textboxes
        /// </summary>
        public void disable()
        {

           

            txtRentOrPrice.Enabled = false;
            txtDepo.Enabled = false;
            txtInterest.Enabled = false;
            txtNoMonths.Enabled = false;

           

            txtModel.Enabled = false;
            txtCarPrice.Enabled = false;
            txtCarDepo.Enabled = false;
            txtCarInterest.Enabled = false;
            txtInsurance.Enabled = false;
        }





        ////////////////////////////////////////////////////////////////////////////////////////


     

        protected void rdbAccom_CheckedChanged(object sender, EventArgs e)
        {
            lblRentOrPrice.Enabled = true;
            txtRentOrPrice.Enabled = true;


            lblDepo.Visible = false;
            lblInterest.Visible = false;
            lblNoMonths.Visible = false;


            txtDepo.Visible = false;
            txtInterest.Visible = false;
            txtNoMonths.Visible = false;


            txtRentOrPrice.BackColor = Color.White;

            lblRentOrPrice.Text = "Monthly Rent Amount(R)";

            Class1.AccomProperty = "Rent an accomodation";
           

            Class1.boolProperty = false;
   

        }








        ////////////////////////////////////////////////////////////////////////////////////////
        protected void rdbProperty_CheckedChanged(object sender, EventArgs e)
        {
            txtRentOrPrice.Visible = true;
            txtDepo.Visible = true;
            txtInterest.Visible = true;
            txtNoMonths.Visible = true;

            lblRentOrPrice.Visible = true;
            lblDepo.Visible = true;
            lblInterest.Visible = true;
            lblNoMonths.Visible = true;

            txtRentOrPrice.Enabled = true;
            txtDepo.Enabled = true;
            txtInterest.Enabled = true;
            txtNoMonths.Enabled = true;

            txtRentOrPrice.BackColor = Color.White;
            txtDepo.BackColor = Color.White;
            txtInterest.BackColor = Color.White;
            txtNoMonths.BackColor = Color.White;

            lblRentOrPrice.Text = "Purchase Price(R)";
            Class1.AccomProperty = "Bought a property";

            Class1.boolProperty = true;
            
       


        }







        ////////////////////////////////////////////////////////////////////////////////////////
        protected void rdbCar_CheckedChanged(object sender, EventArgs e)
        {

           

                txtModel.Enabled = true;
                txtCarPrice.Enabled = true;
                txtCarDepo.Enabled = true;
                txtCarInterest.Enabled = true;
                txtInsurance.Enabled = true;

                txtModel.BackColor = Color.White;
                txtCarPrice.BackColor = Color.White;
                txtCarDepo.BackColor = Color.White;
                txtCarInterest.BackColor = Color.White;
                txtInsurance.BackColor = Color.White;

                Class1.carPurchase = "Yes";

  
           
        }




        /////////////////////////////////////////////////////////////////////////////////////////////
        protected void rdbCancel_CheckedChanged(object sender, EventArgs e)
        {
            

            txtModel.Enabled = false;
            txtCarPrice.Enabled = false;
            txtCarDepo.Enabled = false;
            txtCarInterest.Enabled = false;
            txtInsurance.Enabled = false;

            Class1.carPurchase = "No";

         
        }







        ////////////////////////////////////////////////////////////////////////////////////////
        protected void btnSave_Click(object sender, EventArgs e)
        {


            if (Class1.boolProperty == true)
            {
                lblError.Text = Class1.AccomProperty;
                lblError.Visible = true;
                choseBuy();
                if (error == false)
                {
                    sConnection.Open();

                    string sql = "INSERT INTO TBL_BUY VALUES ('" + Class1.Username + "','" + Class1.price + "','" + Class1.deposit + "','" + Class1.rate + "','" + Class1.NoMonths + "','" + Class1.HLoan + "');";


                    SqlDataAdapter SDA = new SqlDataAdapter(sql, sConnection);
                    SDA.SelectCommand.ExecuteNonQuery();


                    sConnection.Close();
                }
            }
            else if (Class1.boolProperty == false)
            {
                lblError.Text = Class1.AccomProperty;
                lblError.Visible = true;
                choseRent();

                if (error == false)
                {
                    sConnection.Open();

                    string sql = "INSERT INTO TBL_RENT VALUES ('" + Class1.Username + "','" + Class1.RentAmount + "');";


                    SqlDataAdapter SDA = new SqlDataAdapter(sql, sConnection);
                    SDA.SelectCommand.ExecuteNonQuery();


                    sConnection.Close();
                }
            }



            if (Class1.carPurchase == "Yes")
            {
                choseCar();
                if (error == false)
                {
                    sConnection.Open();

                    string sql = "INSERT INTO TBL_VEHICLE VALUES ('" + Class1.Username + "','" + Class1.ModelandMake + "','" + Class1.CarPrice + "','" + Class1.CarDeposit + "','" + Class1.CarRate + "','" + Class1.EstimInsurance + "','" + Class1.totMonthlyCost + "');";

                    SqlDataAdapter SDA = new SqlDataAdapter(sql, sConnection);
                    SDA.SelectCommand.ExecuteNonQuery();

                    sConnection.Close();

                }
            }
            else
            {
                sConnection.Open();

                string sql = "UPDATE TBL_USER SET CAR_PURCHASE = '" + Class1.carPurchase + "' WHERE USERNAME = '" + Class1.Username + "' ";

                SqlDataAdapter SDA = new SqlDataAdapter(sql, sConnection);
                SDA.SelectCommand.ExecuteNonQuery();

                sConnection.Close();
            }


            sConnection.Open();

            string sqlQuery = "UPDATE TBL_USER_DETAILS SET AVAILABLE_MONEY ='" + Class1.availableMoney + "' WHERE USERNAME = '" + Class1.Username + "';";

            SqlDataAdapter DA = new SqlDataAdapter(sqlQuery, sConnection);
            DA.SelectCommand.ExecuteNonQuery();
            sConnection.Close();

            if (error == false)
            {
                sConnection.Close();

            }

           // Response.Write("<script>alert('All your info have been saved');</script>");

        }








        ////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// checks if any field for properties is empty
        /// </summary>
        /// <returns></returns>
        public bool propertyFieldNotEmpty()
        {
            bool empty = true;

            if (price == "")
            {
                txtRentOrPrice.BackColor = Color.Red;
                empty = false;
            }

            if (deposit == "")
            {
                txtDepo.BackColor = Color.Red;
                empty = false;
            }

            if (rate == "")
            {
                txtInterest.BackColor = Color.Red;
                empty = false;
            }

            if (noMonths == "")
            {
                txtNoMonths.BackColor = Color.Red;
                empty = false;
            }
            return empty;
        }








        ////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// check if any fields for car is empty
        /// </summary>
        /// <returns></returns>
        public bool carFieldNotEmpty()
        {
            bool empty = true;

            if (modelandMake == "")
            {
                txtModel.BackColor = Color.Red;
                empty = false;
            }

            if (carPrice == "")
            {
                txtCarPrice.BackColor = Color.Red;
                empty = false;
            }

            if (carDeposit == "")
            {
                txtCarDepo.BackColor = Color.Red;
                empty = false;
            }

            if (carRate == "")
            {
                txtCarInterest.BackColor = Color.Red;
                empty = false;
            }

            if (estimInsurance == "")
            {
                txtInsurance.BackColor = Color.Red;
                empty = false;
            }
            return empty;
        }











        ///////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// get info if user chose to rent an accomodation
        /// </summary>
        public void choseRent()
        {
            rentAmount = txtRentOrPrice.Text;


            if (rentAmount == "")
            {

                txtRentOrPrice.BackColor = Color.Red;
                error = true;
            }
            else
            {


                Class1.NoString(rentAmount);


                if (Class1.letterCount == 0)
                {

                    Class1.RentAmount = Convert.ToDouble(rentAmount);

                    Class1.AccomProperty = "Rent an accomodation";


                    sConnection.Open();

                    string sql = "UPDATE TBL_USER SET PROPERTY = '" + Class1.AccomProperty + "' WHERE USERNAME = '" + Class1.Username + "' ";

                    SqlDataAdapter SDA = new SqlDataAdapter(sql, sConnection);
                    SDA.SelectCommand.ExecuteNonQuery();

                    sConnection.Close();


                    Class1.availableMoney = Class1.Income - Class1.RentAmount;
                }
                else
                {
 
                    lblError.Text = "Please fill in the fields correctly.";
                    lblError.Visible = true;
                    error = true;
                }

            }

            Class1.letterCount = 0;
        }




        ///////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// get info if user chose to buy a property
        /// </summary>

        public void choseBuy()
        {
            Class1.letterCount = 0;
            price = txtRentOrPrice.Text.Trim();
            deposit = txtDepo.Text.Trim();
            rate = txtInterest.Text.Trim();
            noMonths = txtRentOrPrice.Text.Trim();

            if (propertyFieldNotEmpty())
            {


                Class1.NoString(price);
                Class1.NoString(deposit);
                Class1.NoString(rate);
                Class1.NoString(noMonths);





                if (Class1.letterCount == 0)
                {


                    Class1.price = Convert.ToDouble(price);
                    Class1.deposit = Convert.ToDouble(deposit);
                    Class1.rate = Convert.ToDouble(rate);
                    Class1.NoMonths = Convert.ToInt32(noMonths);


                    Class1.HLoan = Class1.CalcLoan();


                    if (Class1.HLoan > (Class1.Income / 3))
                    {
           

                        lblError.Text = "We noticed that the monthly home loan repayment is greater than a " + "third of your gross monthly income, this means it is unlikely that your home loan will be approved.";

                        lblError.Visible = true;
                    }
                    else
                    {

                        Class1.AccomProperty = "Bought a property";
                        sConnection.Open();

                        string sql = "UPDATE TBL_USER SET PROPERTY = '" + Class1.AccomProperty + "' WHERE USERNAME = '" + Class1.Username + "' ";

                        SqlDataAdapter SDA = new SqlDataAdapter(sql, sConnection);
                        SDA.SelectCommand.ExecuteNonQuery();

                        sConnection.Close();

                        Class1.availableMoney = Class1.Income - Class1.HLoan;
                    }

                    error = false;

                }
                else
                {
           

                    lblError.Text = "Please fill in the fields correctly.";
                    lblError.Visible = true;

                    error = true;
                }

            }
            else
            {
     

                lblError.Text = "Please fill in the fields correctly.";
                lblError.Visible = true;

                error = true;
            }

            Class1.letterCount = 0;
        }










        ///////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// get info if user chose to buy a car
        /// </summary>

        public void choseCar()
        {
            modelandMake = txtModel.Text;
            carPrice = txtCarPrice.Text;
            carDeposit = txtCarDepo.Text;
            carRate = txtCarInterest.Text;
            estimInsurance = txtInsurance.Text;

            txtModel.BackColor = Color.White;
            txtCarPrice.BackColor = Color.White;
            txtCarDepo.BackColor = Color.White;
            txtCarInterest.BackColor = Color.White;
            txtInsurance.BackColor = Color.White;


            if (carFieldNotEmpty())
            {



                Class1.NoString(carPrice);
                Class1.NoString(carDeposit);
                Class1.NoString(carRate);
                Class1.NoString(estimInsurance);



                if (Class1.letterCount == 0)
                {

                    Class1.ModelandMake = modelandMake;
                    Class1.CarPrice = Convert.ToDouble(carPrice);
                    Class1.CarDeposit = Convert.ToDouble(carDeposit);
                    Class1.CarRate = Convert.ToDouble(carRate);
                    Class1.EstimInsurance = Convert.ToDouble(estimInsurance);


                    Class1.carLoan = Class1.calcCarLoan();

                    Class1.totMonthlyCost = Class1.EstimInsurance + Class1.carLoan;

                    Class1.carPurchase = "Yes";

                    sConnection.Open();

                    string sql = "UPDATE TBL_USER SET CAR_PURCHASE = '" + Class1.carPurchase + "' WHERE USERNAME = '" + Class1.Username + "' ";

                    SqlDataAdapter SDA = new SqlDataAdapter(sql, sConnection);
                    SDA.SelectCommand.ExecuteNonQuery();

                    sConnection.Close();

                    Class1.availableMoney = Class1.Income - Class1.carLoan;

                    error = false;

                }
                else
                {
            

                    lblError.Text = "Please fill in the fields correctly.";
                    lblError.Visible = true;

                    error = true;
                }

            }
            else
            {
          

                lblError.Text = "Please fill in the fields correctly.";
                lblError.Visible = true;

                error = true;
            }
        }










    }
}