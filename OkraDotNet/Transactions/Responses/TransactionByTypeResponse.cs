using Newtonsoft.Json;
using OkraDotNet.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Transactions.Responses
{
    public class TransactionByTypeResponse : BaseResponse, IBaseResponse<TransactionByTypeResponseData>
    {
        [JsonProperty("data")]
        public TransactionByTypeResponseData Data { get; set; }
    }

    public class TransactionByTypeResponseData
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("transaction")]
        public List<TransactionByTypeResponseTransaction> Transaction { get; set; } //Todo: confirm response data
    }

    public partial class TransactionByTypeResponseTransaction
    {
        [JsonProperty("notes")]
        public Notes Notes { get; set; }

        [JsonProperty("fetched")]
        public List<string> Fetched { get; set; }

        [JsonProperty("owner")]
        public List<object> Owner { get; set; }

        [JsonProperty("record")]
        public List<string> Record { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("trans_date")]
        public DateTimeOffset TransDate { get; set; }

        [JsonProperty("cleared_date")]
        public DateTimeOffset ClearedDate { get; set; }

        [JsonProperty("debit")]
        public object Debit { get; set; }

        [JsonProperty("credit")]
        public long Credit { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("benefactor")]
        public object Benefactor { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("env")]
        public string Env { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("__v")]
        public long V { get; set; }

        [JsonProperty("unformatted_cleared_date")]
        public string UnformattedClearedDate { get; set; }

        [JsonProperty("unformatted_trans_date")]
        public string UnformattedTransDate { get; set; }
    }
}