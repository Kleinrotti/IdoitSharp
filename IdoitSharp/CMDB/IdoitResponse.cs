using Newtonsoft.Json;

namespace IdoitSharp.CMDB
{
    /// <summary>
    /// Represents a response from Idoit when executing actions.
    /// </summary>
    internal class IdoitResponse
    {
        /// <summary>
        /// Id of the modified or created idoit object.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; internal set; }

        /// <summary>
        /// Response message from idoit.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; internal set; }

        /// <summary>
        /// Indicates wether an action was successfull or not.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; internal set; }
    }
}