namespace AlbionOnlineDB.Models
{
    public class Impactvfx
    {
        public string prefab { get; set; }
        public string impactsocket { get; set; }
    }


    public class Projectile
    {
        public string prefab { get; set; }
        public string startsocket { get; set; }
        public string hitsocket { get; set; }
        public Impactvfx impactvfx { get; set; }
    }

    public class SocketPreset
    {
        public string name { get; set; }
    }
    internal interface IEquippable
    {
        string slottype { get; set; }
        string maxqualitylevel { get; set; }
        string abilitypower { get; set; }
        string attacktype { get; set; }
        string mainhandanimationtype { get; set; }
        string attackdamage { get; set; }
        string attackspeed { get; set; }
        string attackrange { get; set; }
        string twohanded { get; set; }
        string activespellslots { get; set; }
        string passivespellslots { get; set; }
        string uiatlas { get; set; }
        string durability { get; set; }
        string durabilityloss_attack { get; set; }
        string durabilityloss_spelluse { get; set; }
        string durabilityloss_receivedattack { get; set; }
        string durabilityloss_receivedspell { get; set; }
        string fxbonename { get; set; }
        string fxboneoffset { get; set; }
        string itempower { get; set; }
        string hitpointsregenerationbonus { get; set; }
        string physicalspelldamagebonus { get; set; }
        string magicspelldamagebonus { get; set; }
        string itempowerprogressiontype { get; set; }
        string focusfireprotectionpeneration { get; set; }
        Projectile projectile { get; set; }
        SocketPreset SocketPreset { get; set; }
        AudioInfo AudioInfo { get; set; }
    }
}