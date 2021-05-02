using Newtonsoft.Json;

namespace IdoitSharp.CMDB.Category
{
    public class Address : IdoitAttribute
    {
        [JsonProperty("hostname")]
        public string hostName { get; set; }
    }
}