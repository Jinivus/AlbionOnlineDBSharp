using System;
using System.Collections.Generic;
using System.Text;

namespace AlbionOnlineDB.Models
{
    public class Craftresource
    {
        public string uniquename { get; set; }
        public string count { get; set; }
        public string maxreturnamount { get; set; }
    }

    public class Craftingrequirements
    {
        public string silver { get; set; }
        public string time { get; set; }
        public string craftingfocus { get; set; }
        public Craftresource craftresource { get; set; }
    }

    interface ICraftable
    {
        Craftingrequirements craftingrequirements { get; set; }
    }
}
