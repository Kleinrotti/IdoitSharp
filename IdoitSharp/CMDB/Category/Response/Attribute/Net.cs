using Newtonsoft.Json;

namespace IdoitSharp.CMDB.Category
{
    public class Net : IdoitAttribute
    {
        [JsonProperty("sysid")]
        public string sysId { get; set; }

        [JsonProperty("type_title")]
        public string typeTitle { get; set; }
    }
}