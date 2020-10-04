using Newtonsoft.Json;
using OkraDotNet.Common;
using OkraDotNet.Common.Responses;
using System;
using System.Collections.Generic;

namespace OkraDotNet.Transactions.Responses
{
    public class TransactionResponse : BaseResponse, IBaseResponse<TransactionResponseData>
    {
        [JsonProperty("data")]
        public TransactionResponseData Data { get; set; }
    }

    public class TransactionResponseData
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("transaction")]
        public List<Transaction> Transaction { get; set; }
    }

    public class Transaction
    {
        [JsonProperty("notes")]
        public Notes Notes { get; set; }

        [JsonProperty("fetched")]
        public List<string> Fetched { get; set; }

        [JsonProperty("record")]
        public List<string> Record { get; set; }

        [JsonProperty("analyzed")]
        public List<object> Analyzed { get; set; }

        [JsonProperty("ner")]
        public object Ner { get; set; }

        [JsonProperty("ner_v")]
        public long NerV { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("trans_date")]
        public DateTimeOffset TransDate { get; set; }

        [JsonProperty("cleared_date")]
        public DateTimeOffset ClearedDate { get; set; }

        [JsonProperty("unformatted_trans_date")]
        public string UnformattedTransDate { get; set; }

        [JsonProperty("unformatted_cleared_date")]
        public string UnformattedClearedDate { get; set; }

        [JsonProperty("debit")]
        public string Debit { get; set; }

        [JsonProperty("credit")]
        public string Credit { get; set; }

        [JsonProperty("bank")]
        public TransactionBank Bank { get; set; }

        [JsonProperty("customer")]
        public CommonCustomer Customer { get; set; }

        [JsonProperty("account")]
        public CommonAccount Account { get; set; }

        [JsonProperty("env")]
        public string Env { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("__v")]
        public long V { get; set; }
    }

    public class TransactionBank
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

    public class Notes
    {
        [JsonProperty("topics")]
        public List<object> Topics { get; set; }

        [JsonProperty("places")]
        public List<object> Places { get; set; }

        [JsonProperty("people")]
        public List<object> People { get; set; }

        [JsonProperty("actions")]
        public List<string> Actions { get; set; }

        [JsonProperty("subjects")]
        public List<string> Subjects { get; set; }

        [JsonProperty("preopositions")]
        public List<object> Preopositions { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }
    }
}