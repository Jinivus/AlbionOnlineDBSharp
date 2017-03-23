using System;
using System.Collections.Generic;
using System.Text;

namespace AlbionOnlineDB.Models
{
    class ResourcesItem : Item, ICraftable
    {
        public string resourcetype { get; set; }
        public string weight { get; set; }
        public string uiatlas { get; set; }
        public string unlockedtocraft { get; set; }
        public string craftfamegainfactor { get; set; }
        public Craftingrequirements craftingrequirements { get; set; }
    }
}
