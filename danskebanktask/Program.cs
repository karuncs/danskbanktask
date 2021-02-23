using System;
using System.IO;

namespace danskebanktask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter Muncipality Tax information

            String MuncipalityName = "Copenhagen";

            // double dailyTax_Percentage = 0.1;
            double dailyTax_Percentage = 0.4;
            // double dailyTax_Percentage = 0.2;
            //double dailyTax_Percentage = 0.2;

            double weeklyTax_Percentage = 0;
            double monthlyTax_Percentage = 0.4;
            double yearlyTax_Percentage = 0.2;

            //string period_daily = "2016.01.01";
            string period_daily = "2016.05.02";
            //string period_daily = "2016.07.10";
            //string period_daily = "2016.03.16";

            string period_weekly = " 2016.05.01-2016.05.07";
            string period_monthly = " 2016.05.01-2016.05.31";
            string period_yearly = "2016.01.01-2016.12.31";


            //call producer

            /*new Producer().insertRecord( MuncipalityName,dailyTax_Percentage,period_daily,weeklyTax_Percentage,
              period_weekly,monthlyTax_Percentage,period_monthly,yearlyTax_Percentage,period_yearly);
           
             Console.WriteLine("Inserted"  );
             */

            //Call consumer
            new Consumer();


        }
    }
}
