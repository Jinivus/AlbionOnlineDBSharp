using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AlbionOnlineDB.Models
{
    public class Item : BaseItem
    {
        public string JsonSource { get; set; }
        [DefaultValue(false)]
        [Newtonsoft.Json.JsonProperty(DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Populate)]
        public string tier { get; set; }
        public string maxstacksize { get; set; }
        public string shopcategory { get; set; }
        public string shopsubcategory1 { get; set; }

    }
}
