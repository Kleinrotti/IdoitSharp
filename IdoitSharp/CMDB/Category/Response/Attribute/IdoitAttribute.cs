using Newtonsoft.Json;

namespace IdoitSharp.CMDB.Category
{
    public class IdoitAttribute
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }
    }
}