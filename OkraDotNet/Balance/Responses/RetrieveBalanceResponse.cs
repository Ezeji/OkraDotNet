using Newtonsoft.Json;
using OkraDotNet.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Balance.Responses
{
    public class RetrieveBalanceResponse : BaseResponse, IBaseResponse<RetrieveBalanceResponseData>
    {
        [JsonProperty("data")]
        public RetrieveBalanceResponseData Data { get; set; }
    }

    public partial class RetrieveBalanceResponseData
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("balances")]
        public List<RetrievedBalance> Balances { get; set; }
    }

    public partial class RetrievedBalance
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("account")]
        public BalanceAccount Account { get; set; }

        [JsonProperty("ledger_balance")]
        public double LedgerBalance { get; set; }

        [JsonProperty("available_balance")]
        public long AvailableBalance { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("connected")]
        public bool Connected { get; set; }

        [JsonProperty("env")]
        public string Env { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }
    }

    public partial class BalanceAccount
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("bank")]
        public Bank Bank { get; set; }

        [JsonProperty("nuban")]
        public string Nuban { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Bank
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class RetrieveBalanceAsPdfResponse : BaseResponse, IBaseResponse<string>
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}