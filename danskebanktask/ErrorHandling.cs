using System;
using System.IO;

namespace danskebanktask
{
    public class ErrorHandling
    {
        
        public  void LogErrorsToTextFile(Exception ex)
        {
             
   

            try
            {
                 string filePath = "../../../DB/";   //Text File Path

                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);

                }
                filePath = filePath + "errorLog.txt";   //Text File Name
                if (!File.Exists(filePath))
                {

                    File.Create(filePath);

                }
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    string error = "Log Written Date:" + " " + DateTime.Now.ToString() + "Error Line No :" + " " +
                                  ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7) + "Error Message:" + " " + ex.GetType().Name.ToString() +
                                    "Exception Type:" + " " + ex.GetType().ToString() + "Error Location :" + " " + ex.Message.ToString();

                    sw.WriteLine("-----------Exception Details on " + " " + DateTime.Now.ToString() + "-----------------");
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                   
                    sw.WriteLine(error);
                    sw.WriteLine("--------------------------------*End*------------------------------------------");
                  
                    sw.Flush();
                    sw.Close();

                }

            }
            catch (Exception e)
            {
                e.ToString();

            }
        }
    }
}




 
  
       
   