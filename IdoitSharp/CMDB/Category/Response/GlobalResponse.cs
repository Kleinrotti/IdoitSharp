﻿using Newtonsoft.Json;

namespace IdoitSharp.CMDB.Category
{
    public class GlobalResponse : ISingleValueResponse
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("objID")]
        public string objID { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        public DialogPlus status { get; set; }

        [JsonProperty("created")]
        public string created { get; set; }

        [JsonProperty("created_by")]
        public string createdBy { get; set; }

        [JsonProperty("changed")]
        public string changed { get; set; }

        [JsonProperty("changed_by")]
        public string changedBy { get; set; }

        public DialogPlus purpose { get; set; }
        public DialogPlus category { get; set; }

        [JsonProperty("sysid")]
        public string sysId { get; set; }

        public DialogPlus cmdb_status { get; set; }
        public DialogPlus type { get; set; }

        [JsonProperty("tag")]
        public string tag { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        public string category_id { get; } = "C__CATG__GLOBAL";
    }
}