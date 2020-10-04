using Newtonsoft.Json;
using OkraDotNet.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Balance.Responses
{
    public class BalanceCallbackResponse : BaseResponse, IBaseResponse<BalanceCallbackResponseData>
    {
        [JsonProperty("data")]
        public BalanceCallbackResponseData Data { get; set; }
    }

    public class BalanceCallbackResponseData
    {
        [JsonProperty("balance")]
        public BalanceCallbackBalance Balance { get; set; }

        [JsonProperty("balances")]
        public List<BalanceCallbackBalance> Balances { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("record")]
        public string Record { get; set; }

        [JsonProperty("products")]
        public BalanceCallbackProducts Products { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    public partial class BalanceCallbackBalance
    {
        [JsonProperty("account")]
        public BalanceCallbackAccount Account { get; set; }

        [JsonProperty("available_balance")]
        public long AvailableBalance { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public BalanceCallbackCustomer Customer { get; set; }

        [JsonProperty("ledger_balance")]
        public double LedgerBalance { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("connected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Connected { get; set; }
    }

    public class BalanceCallbackAccount
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("nuban")]
        public string Nuban { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BalanceCallbackCustomer
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public List<string> Email { get; set; }

        [JsonProperty("phone")]
        public List<string> Phone { get; set; }
    }

    public class BalanceCallbackProducts
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