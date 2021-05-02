using Newtonsoft.Json;

namespace IdoitSharp.CMDB.Category
{
    public class Cable : IdoitAttribute
    {
        [JsonProperty("cable_id")]
        public string cableId { get; set; }

        [JsonProperty("sysid")]
        public string sysId { get; set; }
    }
}