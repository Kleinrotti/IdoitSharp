namespace IdoitSharp.CMDB
{
    /// <summary>
    /// This enum can be used to order a result from idoit objects.
    /// Use the extension method GetStringValue for the actual values!
    /// </summary>
    public enum IdoitOrderBy
    {
        [StringValue(null)]
        None = 0,

        [StringValue("type")]
        Type,

        [StringValue("title")]
        Title,

        [StringValue("type_title")]
        TypeTitle,

        [StringValue("sysid")]
        SysId,

        [StringValue("first_name")]
        FirstName,

        [StringValue("last_name")]
        LastName,

        [StringValue("email")]
        Email,

        [StringValue("id")]
        Id
    }
}