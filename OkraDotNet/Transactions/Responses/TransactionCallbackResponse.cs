using Newtonsoft.Json;
using OkraDotNet.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Transactions.Responses
{
    public class TransactionCallbackResponse : BaseResponse, IBaseResponse<TransactionCallbackResponseData>
    {
        [JsonProperty("data")]
        public TransactionCallbackResponseData Data { get; set; }
    }

    public partial class TransactionCallbackResponseData
    {
        [JsonProperty("transactions")]
        public List<TransactionCallbackTransaction> Transactions { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("record")]
        public string Record { get; set; }

        [JsonProperty("products")]
        public Products Products { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    public partial class Products
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

    public class TransactionCallbackTransaction
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("notes")]
        public Notes Notes { get; set; }

        [JsonProperty("fetched")]
        public List<string> Fetched { get; set; }

        [JsonProperty("owner")]
        public List<string> Owner { get; set; }

        [JsonProperty("record")]
        public List<string> Record { get; set; }

        [JsonProperty("analyzed")]
        public List<object> Analyzed { get; set; }

        [JsonProperty("ner")]
        public object Ner { get; set; }

        [JsonProperty("ner_v")]
        public long NerV { get; set; }

        [JsonProperty("branch")]
        public string Branch { get; set; }

        [JsonProperty("cleared_date")]
        public DateTimeOffset ClearedDate { get; set; }

        [JsonProperty("unformatted_cleared_date")]
        public string UnformattedClearedDate { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("credit")]
        public long? Credit { get; set; }

        [JsonProperty("debit")]
        public long? Debit { get; set; }

        [JsonProperty("trans_date")]
        public DateTimeOffset TransDate { get; set; }

        [JsonProperty("unformatted_trans_date")]
        public string UnformattedTransDate { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("env")]
        public string Env { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("__v")]
        public long V { get; set; }
    }

    public class TransactionCallbackNotes
    {
        [JsonProperty("topics")]
        public List<string> Topics { get; set; }

        [JsonProperty("places")]
        public List<string> Places { get; set; }

        [JsonProperty("people")]
        public List<string> People { get; set; }

        [JsonProperty("actions")]
        public List<string> Actions { get; set; }

        [JsonProperty("subjects")]
        public List<string> Subjects { get; set; }

        [JsonProperty("preopositions")]
        public List<string> Preopositions { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }
    }
}