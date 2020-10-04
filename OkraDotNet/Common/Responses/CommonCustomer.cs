using Newtonsoft.Json;

namespace OkraDotNet.Common.Responses
{
    public partial class CommonCustomer
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}