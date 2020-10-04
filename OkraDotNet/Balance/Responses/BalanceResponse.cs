using Newtonsoft.Json;
using OkraDotNet.Common;
using OkraDotNet.Common.Responses;
using System;
using System.Collections.Generic;

namespace OkraDotNet.Balance.Responses
{
    public class BalanceResponse : BaseResponse, IBaseResponse<BalanceResponseData>
    {
        [JsonProperty("data")]
        public BalanceResponseData Data { get; set; }
    }

    public partial class BalanceResponseData
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("balance")]
        public List<Balance> Balance { get; set; }
    }

    public partial class Balance
    {
        [JsonProperty("periodic")]
        public Periodic Periodic { get; set; }

        [JsonProperty("connected")]
        public List<string> Connected { get; set; }

        [JsonProperty("owner")]
        public List<string> Owner { get; set; }

        [JsonProperty("record")]
        public List<string> Record { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("account")]
        public CommonAccount Account { get; set; }

        [JsonProperty("env")]
        public string Env { get; set; }

        [JsonProperty("__v")]
        public long V { get; set; }

        [JsonProperty("available_balance")]
        public double AvailableBalance { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public CommonCustomer Customer { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("ledger_balance")]
        public double LedgerBalance { get; set; }
    }

    public partial class Periodic
    {
        [JsonProperty("available_balance")]
        public List<string> AvailableBalance { get; set; }

        [JsonProperty("ledger_balance")]
        public List<string> LedgerBalance { get; set; }
    }
}