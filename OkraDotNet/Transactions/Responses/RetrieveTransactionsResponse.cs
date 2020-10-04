using Newtonsoft.Json;
using OkraDotNet.Common;
using OkraDotNet.Common.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Transactions.Responses
{
    public class RetrieveTransactionsResponse : BaseResponse, IBaseResponse<RetrieveTransactionResponseData>
    {
        [JsonProperty("data")]
        public RetrieveTransactionResponseData Data { get; set; }
    }

    public class RetrieveTransactionResponseData
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("trans")]
        public List<Tran> Trans { get; set; }
    }

    public class Tran
    {
        [JsonProperty("bank")]
        public CommonBank Bank { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("env")]
        public string Env { get; set; }

        [JsonProperty("customer")]
        public CommonCustomer Customer { get; set; }
    }

    public class RetrieveTransactionsAsPdfResponse : BaseResponse, IBaseResponse<string>
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}