using IdoitSharp.Contants;

namespace IdoitSharp.CMDB.Object
{
    /// <summary>
    /// Represents an IdoitObject which can be created, updated, read and archived.
    /// </summary>
    public sealed class IdoitObjectInstance : IdoitInstanceBase, IReadable<IdoitObjectResult>, ICreatable, IUpdatable,
        IDeletable, IPurgeable, IArchiveable, IRecycable
    {
        /// <summary>
        /// Type of the object, defined in IdoitObjectTypes.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Type of the object, defined in IdoitCategory.
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        /// Type of the object. Optional when creating a new object.
        /// </summary>
        public IdoitCmdbStatus CmdbStatus { get; set; }

        /// <summary>
        /// Description of the object. Optional when creating a new object.
        /// </summary>
        public string Description { get; set; }

        public int? ObjectId { get; set; }

        public IdoitObjectInstance(IClient myClient) : base(myClient)
        {
        }

        /// <summary>
        /// Create a new object. Property Type and Value has to be set.
        /// </summary>
        /// <returns>The id of the created object</returns>
        public int Create()
        {
            parameter = Client.Parameters;
            parameter.Add("type", Type);
            parameter.Add("title", Value);
            parameter.Add("purpose", Purpose);
            parameter.Add("cmdb_status", CmdbStatus);
            parameter.Add("description", Description);
            parameter.Add("category", Category);
            var response = Execute<IdoitResponse>("cmdb.object.create");
            if (!response.Success)
                throw new IdoitBadResponseException(response.Message);
            Id = response.Id;
            return Id;
        }

        /// <summary>
        /// Update the title of an object. Property ObjectId and Value has to be set.
        /// </summary>
        public void Update()
        {
            parameter = Client.Parameters;
            parameter.Add("id", ObjectId);
            parameter.Add("title", Value);
            var response = Execute<IdoitResponse>("cmdb.object.update");
            if (!response.Success)
                throw new IdoitBadResponseException(response.Message);
        }

        /// <summary>
        /// Delete the given object. Property ObjectId has to be set.
        /// </summary>
        public void Delete()
        {
            parameter = Client.Parameters;
            parameter.Add("id", ObjectId);
            parameter.Add("status", "C__RECORD_STATUS__DELETED");
            var response = Execute<IdoitResponse>("cmdb.object.delete");
            if (!response.Success)
                throw new IdoitBadResponseException(response.Message);
        }

        /// <summary>
        /// Purge the given object. This will remove it completely from the database. Property ObjectId has to be set.
        /// </summary>
        public void Purge()
        {
            parameter = Client.Parameters;
            parameter.Add("object", ObjectId);
            var response = Execute<IdoitResponse>("cmdb.object.purge");
            if (!response.Success)
                throw new IdoitBadResponseException(response.Message);
        }

        /// <summary>
        /// Archive the given object. Property ObjectId has to be set.
        /// </summary>
        public void Archive()
        {
            parameter = Client.Parameters;
            parameter.Add("object", ObjectId);
            var response = Execute<IdoitResponse>("cmdb.object.archive");
            if (!response.Success)
                throw new IdoitBadResponseException(response.Message);
        }

        /// <summary>
        /// Read the given object. Property ObjectId has to be set.
        /// </summary>
        /// <returns>An <see cref="IdoitObjectResult"/></returns>
        public IdoitObjectResult Read()
        {
            parameter = Client.Parameters;
            parameter.Add("id", ObjectId);
            return Execute<IdoitObjectResult>("cmdb.object.read");
        }

        /// <summary>
        /// Set object state as template. Property ObjectId has to be set.
        /// </summary>
        public void MarkAsTemplate()
        {
            parameter = Client.Parameters;
            parameter.Add("object", ObjectId);
            var response = Execute<IdoitResponse>("cmdb.object.markAsTemplate");
            if (!response.Success)
                throw new IdoitBadResponseException(response.Message);
        }

        /// <summary>
        /// Set object state as mass change template. Property ObjectId has to be set.
        /// </summary>
        public void MarkAsMassChangeTemplate()
        {
            parameter = Client.Parameters;
            parameter.Add("object", ObjectId);
            var response = Execute<IdoitResponse>("cmdb.object.markAsMassChangeTemplate");
            if (!response.Success)
                throw new IdoitBadResponseException(response.Message);
        }

        /// <summary>
        /// Recycle an idoit object. Property ObjectId has to be set.
        /// </summary>
        public void Recycle()
        {
            parameter = Client.Parameters;
            parameter.Add("object", ObjectId);
            var response = Execute<IdoitResponse>("cmdb.object.recycle");
            if (!response.Success)
                throw new IdoitBadResponseException(response.Message);
        }
    }
}