using Newtonsoft.Json;

namespace IdoitSharp.CMDB.Category
{
    public class ContactObject : IdoitAttribute
    {
        [JsonProperty("connection_id")]
        public string connectionId { get; set; }

        [JsonProperty("type_title")]
        public string typeTitle { get; set; }

        [JsonProperty("sysid")]
        public string sysId { get; set; }
    }
}