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
        public async static Task<List<Item>> GetItems()
        {
            var result = await AlbionOnlineDB.BaseURL
                .AppendPathSegment("items")
                .GetAsync()
                .ReceiveJson<List<Item>>();
            return result;
        }

        public async static Task<Item> GetItem(string uniqueName)
        {
            var resultJson = await AlbionOnlineDB.BaseURL
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
