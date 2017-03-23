using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AlbionOnlineDB.Models
{
    public class Item
    {
        public string _id { get; set; }
        public string uniquename { get; set; }
        public string JsonSource { get; set; }
        [DefaultValue(false)]
        [Newtonsoft.Json.JsonProperty(DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Populate)]
        public bool HasRetrieved { get; set; }
        public string tier { get; set; }
        public string maxstacksize { get; set; }
        public string shopcategory { get; set; }
        public string shopsubcategory1 { get; set; }

    }
}
