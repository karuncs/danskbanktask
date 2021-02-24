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

            return muncipalities;
        }
    }
}
