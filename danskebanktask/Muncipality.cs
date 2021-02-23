using System;
using System.Collections.Generic;

namespace danskebanktask
{
    public class Muncipality : Imunicipalities
    {
        private string NAME;
        private List<Daily> DAILYTAX;
        private List<Weekly> WEEKLYTAX;
        private List<Monthly> MONTHLYTAX;
        private List<Yearly> YEARLYTAX;


        public string Name
        {
            get { return NAME; }   // get method
            set { NAME = value; }  // set method
        }

        public List<Daily> dailyTax
        {
            get { return DAILYTAX; }   // get method
            set { DAILYTAX = value; }
        }

        public List<Weekly> weeklyTax
        {
            get { return WEEKLYTAX; }   // get method
            set { WEEKLYTAX = value; }
        }

        public List<Monthly> monthlyTax
        {
            get { return MONTHLYTAX; }   // get method
            set { MONTHLYTAX = value; }
        }

        public List<Yearly> yearlyTax
        {
            get { return YEARLYTAX; }   // get method
            set { YEARLYTAX = value; }
        }
    }


    public class Daily
    {
        private string PERIOD_DAY;
        private double TAX_DAY;
        public Double taxPer_Daily
        {
            get { return TAX_DAY; }   // get method
            set { TAX_DAY = value; }  // set method
        }
        public string period_daily
        {
            get { return PERIOD_DAY; }   // get method
            set { PERIOD_DAY = value; }  // set method
        }
    }


    public class Weekly
    {
        private string PERIOD_WEEK;
        private double TAX_WEEK;
        public string period_week
        {
            get { return PERIOD_WEEK; }   // get method
            set { PERIOD_WEEK = value; }  // set method
        }
        public Double taxPer_Week
        {
            get { return TAX_WEEK; }   // get method
            set { TAX_WEEK = value; }  // set method
        }

    }
    public class Monthly
    {
        private string PERIOD_MONTH;
        private double TAX_MONTH;
        public string period_month
        {
            get { return PERIOD_MONTH; }   // get method
            set { PERIOD_MONTH = value; }  // set method
        }
        public Double taxPer_Month
        {
            get { return TAX_MONTH; }   // get method
            set { TAX_MONTH = value; }  // set method
        }
    }

    public class Yearly
    {
        private string PERIOD_YEAR;
        private double TAX_YEAR;

        public string period_year
        {
            get { return PERIOD_YEAR; }   // get method
            set { PERIOD_YEAR = value; }  // set method
        }
        public Double taxPer_year
        {
            get { return TAX_YEAR; }   // get method
            set { TAX_YEAR = value; }  // set method
        }
    }
}

