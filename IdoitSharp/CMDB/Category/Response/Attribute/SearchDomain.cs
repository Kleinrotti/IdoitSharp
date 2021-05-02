using Newtonsoft.Json;

namespace IdoitSharp.CMDB.Category
{
    public class SearchDomain
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }
    }
}