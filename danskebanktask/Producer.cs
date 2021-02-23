using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace danskebanktask
{
    public class Producer
    {
        string filePath = "../../../DB/";
        //string[] filePaths = Directory.GetFiles(@filePath, "*.*");

        //Add multiple daily tax info to the list
        List<Daily> listDailyTax = new List<Daily>();

        //Add multiple daily tax info to the list
        List<Weekly> listWeeklyTax = new List<Weekly>();

        //Add multiple daily tax info to the list
        List<Yearly> listYearlyTax = new List<Yearly>();

        //Add multiple daily tax info to the list
        List<Monthly> listMonthlyTax = new List<Monthly>();


        public void insertRecord(string MuncipalityName, double dailyTax_Percentage, string period_daily, double weeklyTax_Percentage,
               string period_weekly, double monthlyTax_Percentage, string period_monthly, double yearlyTax_Percentage, string period_yearly)
        {

            //cheak whether muncipality is exists

            DirectoryInfo d = new DirectoryInfo(filePath);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.json"); //Getting Text files
            bool isMuncipalityExists = false;
            String fileFullPath = "";

            foreach (FileInfo file in Files)
            {

                if (MuncipalityName.ToLower().Equals(file.Name.Replace(".json", "").ToLower()))
                {
                    isMuncipalityExists = true;
                    fileFullPath = file.FullName;
                    break;
                }
                else
                {
                    isMuncipalityExists = false;
                }
            }

            if (isMuncipalityExists)
            {
                Console.WriteLine("file exist, append data : " + fileFullPath);
                //read file
                Muncipality muncipality = new JSONReader().GetMuncipality(fileFullPath);
                //append data
                Console.WriteLine("Munc Name : " + muncipality.Name);
                listDailyTax = muncipality.dailyTax;
                listWeeklyTax = muncipality.weeklyTax;
                listMonthlyTax = muncipality.monthlyTax;
                listYearlyTax = muncipality.yearlyTax;
            }

            //Create Daily Tax  info
            Daily dailyObj = new Daily();
            dailyObj.taxPer_Daily = dailyTax_Percentage;
            dailyObj.period_daily = period_daily;
            listDailyTax.Add(dailyObj);

            //Create weekly tax info
            Weekly weeklyObj = new Weekly();
            weeklyObj.taxPer_Week = weeklyTax_Percentage;
            weeklyObj.period_week = period_weekly;
            listWeeklyTax.Add(weeklyObj);

            //Create monthly tax info
            Monthly monthlyObj = new Monthly();
            monthlyObj.taxPer_Month = monthlyTax_Percentage;
            monthlyObj.period_month = period_monthly;
            listMonthlyTax.Add(monthlyObj);

            //Create yearly tax info
            Yearly yearlyObj = new Yearly();
            yearlyObj.taxPer_year = yearlyTax_Percentage;
            yearlyObj.period_year = period_yearly;
            listYearlyTax.Add(yearlyObj);

            //add Muncipality Data to the JSON Object
            Muncipality JsonObj_Muncipality = new Muncipality();
            JsonObj_Muncipality.Name = MuncipalityName;

            JsonObj_Muncipality.dailyTax = listDailyTax;
            JsonObj_Muncipality.weeklyTax = listWeeklyTax;
            JsonObj_Muncipality.monthlyTax = listMonthlyTax;
            JsonObj_Muncipality.yearlyTax = listYearlyTax;

            string objjsonData = JsonConvert.SerializeObject(JsonObj_Muncipality);
            File.WriteAllText(filePath + JsonObj_Muncipality.Name + ".json", objjsonData);

            // Console.WriteLine(objjsonData);

        }
    }
}
