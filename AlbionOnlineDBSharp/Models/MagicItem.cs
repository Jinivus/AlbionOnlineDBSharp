using System;
using System.Collections.Generic;
using System.Text;

namespace AlbionOnlineDB.Models
{
    public class MagicItem : Item,ICraftable, IEquippable
    {
        public string slottype { get; set; }
        public string maxqualitylevel { get; set; }
        public string abilitypower { get; set; }
        public string attacktype { get; set; }
        public string mainhandanimationtype { get; set; }
        public string attackdamage { get; set; }
        public string attackspeed { get; set; }
        public string attackrange { get; set; }
        public string twohanded { get; set; }
        public string activespellslots { get; set; }
        public string passivespellslots { get; set; }
        public string uiatlas { get; set; }
        public string durability { get; set; }
        public string durabilityloss_attack { get; set; }
        public string durabilityloss_spelluse { get; set; }
        public string durabilityloss_receivedattack { get; set; }
        public string durabilityloss_receivedspell { get; set; }
        public string fxbonename { get; set; }
        public string fxboneoffset { get; set; }
        public string itempower { get; set; }
        public string hitpointsregenerationbonus { get; set; }
        public string physicalspelldamagebonus { get; set; }
        public string magicspelldamagebonus { get; set; }
        public string itempowerprogressiontype { get; set; }
        public string focusfireprotectionpeneration { get; set; }
        public Craftingrequirements craftingrequirements { get; set; }
        public Projectile projectile { get; set; }
        public SocketPreset SocketPreset { get; set; }
        public Craftingspelllist craftingspelllist { get; set; }
        public AudioInfo AudioInfo { get; set; }
    }
}
