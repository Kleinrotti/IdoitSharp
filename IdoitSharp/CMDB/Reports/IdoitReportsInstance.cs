namespace IdoitSharp.CMDB.Reports
{
    /// <summary>
    /// Provides methods for Reports.
    /// </summary>
    public class IdoitReportsInstance : IdoitInstanceBase, IReadable<IdoitReportsResponse[]>
    {
        public IdoitReportsInstance(IClient myClient) : base(myClient)
        {
        }

        public int? ObjectId { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

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