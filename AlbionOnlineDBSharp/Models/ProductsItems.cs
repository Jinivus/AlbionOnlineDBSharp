using System;
using System.Collections.Generic;
using System.Text;

namespace AlbionOnlineDB.Models
{
    class ProductsItems : Item
    {
        public string placecost { get; set; }
        public string placefame { get; set; }
        public string pickupable { get; set; }
        public string destroyable { get; set; }
        public string unlockedtoplace { get; set; }
        public string kind { get; set; }
        public string weight { get; set; }
        public string unlockedtocraft { get; set; }
        public string tile { get; set; }
        public string prefabname { get; set; }
        public string prefabscale { get; set; }
        public string uiatlas { get; set; }
        public string resourcevalue { get; set; }
        public string animationid { get; set; }
        public string activefarmfocuscost { get; set; }
        public string activefarmmaxcycles { get; set; }
        public string activefarmactiondurationseconds { get; set; }
        public string activefarmcyclelengthseconds { get; set; }
        public string activefarmbonus { get; set; }
        public AudioInfo AudioInfo { get; set; }
        public Consumption consumption { get; set; }
        public Products products { get; set; }
    }

    public class Acceptedfood
    {
        public string foodcategory { get; set; }
    }

    public class Food
    {
        public string nutritionmax { get; set; }
        public string secondspernutrition { get; set; }
        public Acceptedfood acceptedfood { get; set; }
    }

    public class Consumption
    {
        public Food food { get; set; }
    }

    public class Product
    {
        public string productiontime { get; set; }
        public string actionname { get; set; }
        public string lootlist { get; set; }
        public string lootchance { get; set; }
        public string fame { get; set; }
    }

    public class Products
    {
        public Product product { get; set; }
    }
}
