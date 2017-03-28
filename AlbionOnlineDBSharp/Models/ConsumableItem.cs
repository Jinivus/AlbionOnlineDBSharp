using System;
using System.Collections.Generic;
using System.Text;

namespace AlbionOnlineDB.Models
{
    public class ConsumableItem : Item, ICraftable
    {
        public Craftingrequirements craftingrequirements { get; set; }
        public string uisprite { get; set; }
        public string abilitypower { get; set; }
        public string slottype { get; set; }
        public string consumespell { get; set; }
        public string uiatlas { get; set; }
        public string unlockedtocraft { get; set; }
        public string unlockedtoequip { get; set; }
    }
}
