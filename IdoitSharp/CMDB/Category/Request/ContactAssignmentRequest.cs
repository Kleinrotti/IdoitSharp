﻿namespace IdoitSharp.CMDB.Category
{
    public class ContactAssignmentRequest : IRequest
    {
        public int? category_id { get; set; }
        public string contact { get; set; }
        public string primary_contact { get; set; }
        public string contact_object { get; set; }
        public string primary { get; set; }
        public string role { get; set; }
        public string contact_list { get; set; }
        public string description { get; set; }
    }
}