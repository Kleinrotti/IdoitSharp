namespace IdoitSharp
{
    /// <summary>
    /// Provides logic to read data from idoit. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IReadable<T>
    {
        T Read();
        int? ObjectId { get; set; }
    }
}