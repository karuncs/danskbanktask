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
        public Consumer()
        {

            //cheak whether muncipality is exists
            DirectoryInfo d = new DirectoryInfo(filePath);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.json"); //Getting Text files

            bool isMuncipalityExists = false;
            String fileFullPath = "";
            int count = 1;

            foreach (FileInfo file in Files)
            {
                Muncipality muncipality = new JSONReader().GetMuncipality(file.FullName);
                //append data
                Console.WriteLine("Munc Record Number : " + count);
                Console.WriteLine("Muncipality Record Data : ");
                Console.WriteLine();
                Console.WriteLine(JsonConvert.DeserializeObject(File.ReadAllText(file.FullName)).ToString());
                Console.WriteLine();
                count++;
            }
        }
    }
}
