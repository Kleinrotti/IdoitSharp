﻿using Newtonsoft.Json;

namespace IdoitSharp.CMDB.Dialog
{
    public sealed class DialogResponse
    {
        [JsonProperty("entry_id")]
        public int entryId { get; internal set; }

        [JsonProperty("success")]
        public bool success { get; internal set; }
    }
}