namespace IdoitSharp
{
    /// <summary>
    /// Provides logic for any idoit instance.
    /// </summary>
    public interface IInstance
    {
        /// <summary>
        /// Returns the current <see cref="IClient"/>
        /// </summary>
        IClient Client { get; }

        /// <summary>
        /// Returns the Id of the newly created or updated object.
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Returns the unique identifier of the idoit category.
        /// </summary>
        string Category { get; }

        /// <summary>
        /// Value of the object.
        /// </summary>
        string Value { get; }
    }
}