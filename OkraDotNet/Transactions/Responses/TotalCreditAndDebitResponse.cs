using Newtonsoft.Json;
using OkraDotNet.Common;

namespace OkraDotNet.Transactions.Responses
{
    public class TotalCreditAndDebitResponse : BaseResponse, IBaseResponse<TotalCreditAndDebitResponseData>
    {
        [JsonProperty("data")]
        public TotalCreditAndDebitResponseData Data { get; set; }
    }

    public class TotalCreditAndDebitResponseData
    {
        [JsonProperty("result")]
        public TotalCreditAndDebitResponseDataResult Result { get; set; }
    }

    public class TotalCreditAndDebitResponseDataResult
    {
        [JsonProperty("credit")]
        public string Credit { get; set; }

        [JsonProperty("debit")]
        public string Debit { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
