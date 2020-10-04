using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OkraDotNet.Common;
using OkraDotNet.Common.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace OkraDotNet.Auth.Responses
{
    public class RetrieveAuthResponse : BaseResponse, IBaseResponse<RetrieveAuthResponseData>
    {
        [JsonProperty("data")]
        public RetrieveAuthResponseData Data { get; set; }
    }

    public class RetrieveAuthResponseData
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("auths")]
        public List<RetrievedAuth> Auths { get; set; }
    }

    public class RetrievedAuth
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("validated")]
        public bool Validated { get; set; }

        [JsonProperty("record")]
        public Record Record { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }
    }

    public class Record
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("bank")]
        public CommonBank Bank { get; set; }

        [JsonProperty("env")]
        public string Env { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("customer")]
        public CommonCustomer Customer { get; set; }
    }

    public class RetrieveAuthAsPdfResponse : BaseResponse, IBaseResponse<string>
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}