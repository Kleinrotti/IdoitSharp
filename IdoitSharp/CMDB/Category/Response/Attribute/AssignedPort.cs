using Newtonsoft.Json;

namespace IdoitSharp.CMDB.Category
{
    public class AssignedPort : IdoitAttribute
    {
        [JsonProperty("reference")]
        public string reference { get; set; }
    }
}