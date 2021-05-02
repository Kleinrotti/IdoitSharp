using Newtonsoft.Json;

namespace IdoitSharp.CMDB.Category
{
    public class Alias
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("hostName")]
        public string hostname { get; set; }

        [JsonProperty("domain")]
        public string domain { get; set; }
    }
}