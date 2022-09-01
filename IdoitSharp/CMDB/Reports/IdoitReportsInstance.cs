namespace IdoitSharp.CMDB.Reports
{
    /// <summary>
    /// Provides methods for Reports.
    /// </summary>
    public sealed class IdoitReportsInstance : IdoitInstanceBase, IReadable<IdoitReportsResponse[]>
    {
        public IdoitReportsInstance(IClient myClient) : base(myClient)
        {
        }

        /// <summary>
        /// Id of the report you want to request. Leave null to get all.
        /// </summary>
        public int? ObjectId { get; set; }

        /// <summary>
        /// Read all reports. Optionally set property ObjectId.
        /// </summary>
        /// <returns>An <see cref="IdoitReportsResponse"/> array.</returns>
        public IdoitReportsResponse[] Read()
        {
            parameter = Client.Parameters;
            parameter.Add("id", ObjectId);
            return Execute<IdoitReportsResponse[]>("cmdb.reports.read");
        }
    }
}