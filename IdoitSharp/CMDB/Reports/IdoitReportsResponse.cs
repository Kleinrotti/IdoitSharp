using Newtonsoft.Json;

namespace IdoitSharp.CMDB.Reports
{
    /// <summary>
    /// Represents an object which will be returned from an reports request.
    /// </summary>
    public class IdoitReportsResponse
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }

        [JsonProperty("category")]
        public string Category { get; internal set; }

        [JsonProperty("title")]
        public string Title { get; internal set; }

        [JsonProperty("description")]
        public string Description { get; internal set; }

        [JsonProperty("created")]
        public string Created { get; internal set; }
    }
}