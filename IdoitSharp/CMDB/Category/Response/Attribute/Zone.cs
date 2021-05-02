using Newtonsoft.Json;

namespace IdoitSharp.CMDB.Category
{
    public class Zone : IdoitAttribute
    {
        [JsonProperty("sysid")]
        public string sysId { get; set; }

        [JsonProperty("type_title")]
        public string typeTitle { get; set; }
    }
}