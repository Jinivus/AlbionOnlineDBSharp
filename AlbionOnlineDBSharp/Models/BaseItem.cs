using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AlbionOnlineDB.Models
{
    public class BaseItem
    {
        public string _id { get; set; }
        public string uniquename { get; set; }
        public bool HasRetrieved { get; set; }
        private Item _itemInfo = null;
        public Item ItemInfo {
            get
            {
                if (_itemInfo == null)
                    _itemInfo = Items.GetItem(this.uniquename).Result;
                return _itemInfo;
            }
        }
    }
}
