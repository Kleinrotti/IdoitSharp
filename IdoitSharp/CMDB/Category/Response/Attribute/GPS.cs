using Newtonsoft.Json;

namespace IdoitSharp.CMDB.Category
{
    public class GPS
    {
        [JsonProperty("zero")]
        public string zero { get; set; }

        [JsonProperty("one")]
        public string one { get; set; }

        [JsonProperty("latitude")]
        public string latitude { get; set; }

        [JsonProperty("longitude")]
        public string longitude { get; set; }
    }
}