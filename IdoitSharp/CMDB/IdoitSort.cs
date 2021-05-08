namespace IdoitSharp.CMDB
{
    /// <summary>
    /// This enum can be used to sort a result from idoit objects.
    /// <br/>Use the extension method GetStringValue for the actual values!
    /// </summary>
    public enum IdoitSort
    {
        [StringValue(null)]
        None = 0,

        [StringValue("ASC")]
        Acsending,

        [StringValue("DESC")]
        Descending
    }
}