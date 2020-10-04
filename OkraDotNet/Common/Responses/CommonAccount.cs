using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Common.Responses
{
    public partial class CommonAccount
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}