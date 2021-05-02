using Newtonsoft.Json;

namespace IdoitSharp.CMDB.Category
{
    public class Title
    {
        [JsonProperty("title")]
        public string title { get; set; }
    }
}