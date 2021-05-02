using Newtonsoft.Json;

namespace IdoitSharp.CMDB.Category
{
    public class Frequency : IdoitAttribute
    {
        [JsonProperty("sysid")]
        public string sysId { get; set; }
    }
}