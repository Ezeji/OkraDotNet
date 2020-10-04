using Newtonsoft.Json;
using System;

namespace OkraDotNet.Auth.Responses.Common
{
    public class AuthBank
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("logo")]
        public Uri Logo { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}