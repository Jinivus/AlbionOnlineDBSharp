using AlbionOnlineDB.Models;
using System;
using System.Collections.Generic;
using Flurl.Http;
using Flurl;
using System.Threading.Tasks;

namespace AlbionOnlineDB
{
    public static class Items
    {
        const int CACHE_MINS = 60;

        static DateTime _LastUpdatedItems = DateTime.MinValue;
        static List<BaseItem> _Items = new List<BaseItem>();

        public async static Task<List<BaseItem>> GetItems(bool useCache = true)
        {
            if (_LastUpdatedItems + TimeSpan.FromMinutes(CACHE_MINS) > DateTime.Now)
            {
                return _Items;
            }
            else
            {
                var result = await AlbionOnlineDBInfo.BaseURL
                    .AppendPathSegment("items")
                    .GetAsync()
                    .ReceiveJson<List<BaseItem>>();
                return result;
            }
        }

        public async static Task<Item> GetItem(string uniqueName)
        {

            var resultJson = await AlbionOnlineDBInfo.BaseURL
                .AppendPathSegment("items")
                .AppendPathSegment(uniqueName)
                .GetAsync()
                .ReceiveString();
            var result = Newtonsoft.Json.JsonConvert.DeserializeObject<Item>(resultJson);
            result.JsonSource = resultJson;
            result.HasRetrieved = true;
            return result;
        }
    }
}
