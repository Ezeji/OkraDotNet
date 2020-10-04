using Newtonsoft.Json;
using OkraDotNet.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Auth.Responses
{
    public class AuthCallbackResponse : BaseResponse, IBaseResponse<AuthCallbackResponseData>
    {
        [JsonProperty("data")]
        public AuthCallbackResponseData Data { get; set; }
    }

    public class AuthCallbackResponseData
    {
        [JsonProperty("auth")]
        public CallBackAuth Auth { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("record")]
        public string Record { get; set; }

        [JsonProperty("products")]
        public Products Products { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    public partial class CallBackAuth
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("record")]
        public string Record { get; set; }

        [JsonProperty("__v")]
        public long V { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("env")]
        public string Env { get; set; }

        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("validated")]
        public bool Validated { get; set; }
    }

    public class Products
    {
        [JsonProperty("periodic-transactions")]
        public PeriodicTransactions PeriodicTransactions { get; set; }

        [JsonProperty("guarantors")]
        public Guarantors Guarantors { get; set; }

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

    public class Directors
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }
    }

    public class PeriodicTransactions
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }
    }

    public class Guarantors
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }
    }

    public class Status
    {
        [JsonProperty("transactions")]
        public dynamic Transactions { get; set; }

        [JsonProperty("last_callback")]
        public dynamic LastCallback { get; set; }

        [JsonProperty("process")]
        public Process Process { get; set; }
    }

    public class Process
    {
        [JsonProperty("running")]
        public bool Running { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }
    }
}