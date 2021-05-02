using Newtonsoft.Json;

namespace IdoitSharp
{
    public interface IRequest
    {
        int? category_id { get; }

        object GetObject()
        {
            string Json = JsonConvert.SerializeObject(this, new JsonSerializerSettings
            { DefaultValueHandling = DefaultValueHandling.Ignore });
            object data = JsonConvert.DeserializeObject(Json);
            return data;
        }
    }
}