using Newtonsoft.Json;

namespace IdoitSharp.CMDB.Dialog
{
    public sealed class DialogResult
    {
        [JsonProperty("id")]
        public string id { get; internal set; }

        [JsonProperty("Const")]
        public string Const { get; internal set; }

        [JsonProperty("title")]
        public string title { get; internal set; }
    }
}