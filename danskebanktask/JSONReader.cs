using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;



namespace danskebanktask
{
    public class JSONReader
    {
        public Muncipality GetMuncipality(String FilePath)
        {
            // read file into a string and deserialize JSON to a type
            Muncipality muncipalities = JsonConvert.DeserializeObject<Muncipality>(File.ReadAllText(FilePath));

            // deserialize JSON directly from a file
            /* using (StreamReader file = File.OpenText(FilePath))
             {
                 JsonSerializer serializer = new JsonSerializer();
                 Muncipality movie2 = (Movie)serializer.Deserialize(file, typeof(Movie));
             }*/

            return muncipalities;
        }
    }
}
