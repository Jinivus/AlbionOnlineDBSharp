using System;
using System.Collections.Generic;
using System.Text;

namespace AlbionOnlineDB.Models
{
    public class FarmablesItem : Item, ICraftable, IFarmable
    {
        public string craftfamegainfactor { get; set; }
        public string placecost { get; set; }
        public string placefame { get; set; }
        public string pickupable { get; set; }
        public string destroyable { get; set; }
        public string unlockedtoplace { get; set; }
        public string kind { get; set; }
        public string unlockedtocraft { get; set; }
        public string uiatlas { get; set; }
        public string animationid { get; set; }
        public string activefarmfocuscost { get; set; }
        public string activefarmmaxcycles { get; set; }
        public string activefarmactiondurationseconds { get; set; }
        public string activefarmcyclelengthseconds { get; set; }
        public string activefarmbonus { get; set; }
        public Craftingrequirements craftingrequirements { get; set; }
        public AudioInfo AudioInfo { get; set; }
        public Harvest harvest { get; set; }
    }

}
