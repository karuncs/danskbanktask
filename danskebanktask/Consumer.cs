using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections;
using System.Collections.Generic;



namespace danskebanktask
{
    public class Consumer
    {
        string filePath = "../../../DB/";
        public String getSearchResults(String MuncipalityName, String inputDate)
        {

            string result = "";
            try
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
                    //  Console.WriteLine("file exist, append data : " + fileFullPath);
                    //read file
                    Muncipality resultMuncipality = new JSONReader().GetMuncipality(fileFullPath);

                    // Console.WriteLine("Munc Name : " + resultMuncipality.Name);
                    result = " Muncipality :  " + resultMuncipality.Name;
                    List<Daily> dailyTax = resultMuncipality.dailyTax;

                    foreach (Daily dl in dailyTax)
                    {
                        if (dl.period_daily.ToLower().Equals(inputDate))
                        {
                            result += " Date : " + inputDate;
                            result += "Tax : " + dl.taxPer_Daily.ToString();
                        }
                    }

                }
                else
                {
                    result = "Not found any results on given data";
                }

            }
            catch (Exception ex)
            {
                new ErrorHandling().LogErrorsToTextFile(ex); // log errors to the text file at DB folder
            }

            return result;

        }

    }
}
