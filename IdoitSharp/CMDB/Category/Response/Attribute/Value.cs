using Newtonsoft.Json;

namespace IdoitSharp.CMDB.Category
{
    public class Value
    {
        [JsonProperty("value")]
        public string value { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }
    }
}