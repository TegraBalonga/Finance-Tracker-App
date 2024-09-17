using System;
using System.Dynamic;

namespace TaskLib
{

    public class Class1
    {


        public static string RentorBuy { get; set; }


        //variable capturing detail for renting an accommodation
        public static double RentAmount { get; set; }



        // variables capturing details for buying a proterty
        public static double price { get; set; }

        public static double deposit { get; set; }

        public static double rate { get; set; }

        public static int NoMonths { get; set; }

        public static double HLoan { get; set; }

        public static double CalcLoan()
        {

            HLoan = ((price - deposit) * (1 + (rate / 100) * NoMonths)) / NoMonths;

            return HLoan;
        }


        // variables capturing details for buying a car

        public static bool buyCar { get; set; }
        public static string ModelandMake { get; set; }

        public static double CarPrice { get; set; }

        public static double CarDeposit { get; set; }

        public static double CarRate { get; set; }

        public static double EstimInsurance { get; set; }

        public static double totMonthlyCost { get; set; }

        public static double carLoan;


        public static double calcCarLoan()
        {
            carLoan = ((CarPrice - CarDeposit) * (1 + (CarRate / 100) * 60)) / 60;
            return carLoan;
        }






        ////////////////////////////////////////////////////////////////////////////
        ////////////////////////////TASK 2 ADDITIONS/////////////////////////////// 
        public static string Username { get; set; }

        public static string AccomProperty { get; set; }

        public static double MHLRepay { get; set; }



        public static double Income { get; set; }
        public static double Tax { get; set; }
        public static double Groceries { get; set; }
        public static double Water { get; set; }
        public static double Travel { get; set; }
        public static double Cell { get; set; }
        public static double OtherExp { get; set; }
        public static double availableMoney { get; set; }
        public static string carPurchase { get; set; }


        public static int letterCount = 0;
        public static int digitCount = 0;

        public static void NoString(string value)
        {

            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsLetter(value[i]))
                {
                    letterCount++;
                }
            }

        }



        public static void NoInt(string value)
        {

            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsDigit(value[i]))
                {
                    digitCount++;
                }
            }

        }

        ////////////////////////////////////////////////////////////////////////////
        ////////////////////////////TASK 3 ADDITIONS/////////////////////////////// 

        public static bool newUser;
        public static bool boolProperty;

        public static double savingAmount = 0;
        public static string saveReason;
        public static DateTime saveDate;
        public static int numSaveYears;
        public static double monthlySave;
        public static double SaveInterest;

        public static double calcSaving()
        {
            numSaveYears = saveDate.Year - DateTime.Now.Year;

            monthlySave = savingAmount / (1 + (SaveInterest * numSaveYears));

            return monthlySave;
        }

    }
}
