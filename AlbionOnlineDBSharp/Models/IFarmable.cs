using System;
using System.Collections.Generic;
using System.Text;

namespace AlbionOnlineDB.Models
{
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

    interface IFarmable
    {
        string craftfamegainfactor { get; set; }
        string placecost { get; set; }
        string placefame { get; set; }
        string pickupable { get; set; }
        string destroyable { get; set; }
        string unlockedtoplace { get; set; }
        string kind { get; set; }
        string weight { get; set; }
        string unlockedtocraft { get; set; }
        string uiatlas { get; set; }
        string animationid { get; set; }
        string activefarmfocuscost { get; set; }
        string activefarmmaxcycles { get; set; }
        string activefarmactiondurationseconds { get; set; }
        string activefarmcyclelengthseconds { get; set; }
        string activefarmbonus { get; set; }
        Craftingrequirements craftingrequirements { get; set; }
        AudioInfo AudioInfo { get; set; }
        Harvest harvest { get; set; }
    }
}
