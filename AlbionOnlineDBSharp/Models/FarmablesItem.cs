using System;
using System.Collections.Generic;
using System.Text;

namespace AlbionOnlineDB.Models
{
    public class FarmablesItem : Item, ICraftable
    {
        public string craftfamegainfactor { get; set; }
        public string placecost { get; set; }
        public string placefame { get; set; }
        public string pickupable { get; set; }
        public string destroyable { get; set; }
        public string unlockedtoplace { get; set; }
        public string kind { get; set; }
        public string weight { get; set; }
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

    public class Seed
    {
        public string chance { get; set; }
        public string amount { get; set; }
    }

    public class Harvest
    {
        public string growtime { get; set; }
        public string lootlist { get; set; }
        public string lootchance { get; set; }
        public string fame { get; set; }
        public Seed seed { get; set; }
    }
}
