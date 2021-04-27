﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WindowsFormsApp_OData
{

    public class Value
    {
        [JsonProperty("odata.type")]
        public string Type { set; get; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public int Rating { get; set; }
        public double Price { get; set; }
    }

    public class OData
    {
        [JsonProperty("odata.metadata")]
        public string Metadata { get; set; }
        public List<Value> Value { get; set; }
    }


}
