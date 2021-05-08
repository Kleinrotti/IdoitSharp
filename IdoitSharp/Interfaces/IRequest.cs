using Newtonsoft.Json;

namespace IdoitSharp
{
    /// <summary>
    /// Provides logic for an idoit category request.
    /// </summary>
    public interface IRequest
    {
        int? category_id { get; }

        /// <summary>
        /// Converts the current object without null properties.
        /// </summary>
        /// <returns>The current object with cleared out null properties.</returns>
        object GetObject()
        {
            string Json = JsonConvert.SerializeObject(this, new JsonSerializerSettings
            { DefaultValueHandling = DefaultValueHandling.Ignore });
            object data = JsonConvert.DeserializeObject(Json);
            return data;
        }
    }
}