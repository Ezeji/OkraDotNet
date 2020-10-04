using Newtonsoft.Json;
using OkraDotNet.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Identity.Responses
{
    public class IdentityCallbackResponse : BaseResponse, IBaseResponse<IdentityCallbackResponseData>
    {
        [JsonProperty("data")]
        public IdentityCallbackResponseData Data { get; set; }
    }

    public class IdentityCallbackResponseData
    {
        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("record")]
        public string Record { get; set; }

        [JsonProperty("products")]
        public Products Products { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    public class Products
    {
        [JsonProperty("periodic-transactions")]
        public Directors PeriodicTransactions { get; set; }

        [JsonProperty("guarantors")]
        public Directors Guarantors { get; set; }

        [JsonProperty("directors")]
        public Directors Directors { get; set; }

        [JsonProperty("auth")]
        public bool Auth { get; set; }

        [JsonProperty("balance")]
        public bool Balance { get; set; }

        [JsonProperty("accounts")]
        public bool Accounts { get; set; }

        [JsonProperty("transactions")]
        public bool Transactions { get; set; }

        [JsonProperty("income")]
        public bool Income { get; set; }

        [JsonProperty("identity")]
        public bool Identity { get; set; }

        [JsonProperty("direct-debit")]
        public bool DirectDebit { get; set; }
    }

    public partial class Directors
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }
    }

    public partial class Status
    {
        [JsonProperty("transactions")]
        public dynamic Transactions { get; set; }

        [JsonProperty("last_callback")]
        public dynamic LastCallback { get; set; }

        [JsonProperty("process")]
        public Process Process { get; set; }
    }

    public partial class Process
    {
        [JsonProperty("running")]
        public bool Running { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }
    }
}