using Newtonsoft.Json;
using OkraDotNet.Auth.Responses.Common;
using OkraDotNet.Common;
using OkraDotNet.Common.Responses;
using System;
using System.Collections.Generic;

namespace OkraDotNet.Auth.Responses
{
    public class AuthResponse : BaseResponse, IBaseResponse<AuthResponseData>
    {
        [JsonProperty("data")]
        public AuthResponseData Data { get; set; }
    }

    public partial class AuthResponseData
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("auths")]
        public List<Auth> Auths { get; set; }
    }

    public class Auth
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("record")]
        public string Record { get; set; }

        [JsonProperty("__v")]
        public long V { get; set; }

        [JsonProperty("bank")]
        public AuthBank Bank { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("customer")]
        public CommonCustomer Customer { get; set; }

        [JsonProperty("env")]
        public string Env { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("validated")]
        public bool Validated { get; set; }
    }
}