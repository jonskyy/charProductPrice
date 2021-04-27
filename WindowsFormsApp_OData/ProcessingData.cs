using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp_OData
{
    public class ProcessingData
    {

       public Dictionary<string, float> takeNamePrice (JArray entriesArray)
        {
            var name = (from s in entriesArray
                        select s["Name"]).ToList();

            var price = (from s in entriesArray
                         select s["Price"]).ToList();

            foreach (string item in name)
            {
                Console.WriteLine(item);
            }

            Dictionary<string, float> dictData = new Dictionary<string, float>();

            for (int i = 0; i < name.Count; i++)
            {
                dictData.Add(name[i].ToString(), (float)price[i]);
            }
            return dictData;
        }

    }
}
