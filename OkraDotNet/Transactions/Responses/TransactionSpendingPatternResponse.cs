using Newtonsoft.Json;
using OkraDotNet.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Transactions.Responses
{
    public class TransactionSpendingPatternResponse : BaseResponse, IBaseResponse<TransactionSpendingPatternResponseData>
    {
        [JsonProperty("data")]
        public TransactionSpendingPatternResponseData Data { get; set; } //Todo: review data
    }

    public partial class TransactionSpendingPatternResponseData
    {
        [JsonProperty("data")]
        public DataData Data { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("receipt")]
        public PurpleReceipt Receipt { get; set; }
    }

    public partial class DataData
    {
        [JsonProperty("channel")]
        public Channel Channel { get; set; }

        [JsonProperty("pattern")]
        public Pattern Pattern { get; set; }
    }

    public partial class Channel
    {
        [JsonProperty("Cash")]
        public Cash Cash { get; set; }

        [JsonProperty("Transfer")]
        public Cash Transfer { get; set; }

        [JsonProperty("web_pos")]
        public Cash WebPos { get; set; }
    }

    public partial class Cash
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("percentage")]
        public double Percentage { get; set; }

        [JsonProperty("sum")]
        public double Sum { get; set; }
    }

    public partial class Pattern
    {
        [JsonProperty("bills")]
        public Cash Bills { get; set; }

        [JsonProperty("entertainment")]
        public Cash Entertainment { get; set; }

        [JsonProperty("financial_services")]
        public Cash FinancialServices { get; set; }

        [JsonProperty("fitness_health")]
        public Cash FitnessHealth { get; set; }

        [JsonProperty("food")]
        public Cash Food { get; set; }

        [JsonProperty("gambling")]
        public Cash Gambling { get; set; }

        [JsonProperty("miscellaneous")]
        public Cash Miscellaneous { get; set; }

        [JsonProperty("retail")]
        public Cash Retail { get; set; }

        [JsonProperty("transportation")]
        public Cash Transportation { get; set; }
    }

    public partial class PurpleReceipt
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("data")]
        public ReceiptData Data { get; set; }
    }

    public partial class ReceiptData
    {
        [JsonProperty("receipt")]
        public FluffyReceipt Receipt { get; set; }
    }

    public partial class FluffyReceipt
    {
        [JsonProperty("breakdown")]
        public Breakdown Breakdown { get; set; }

        [JsonProperty("billingStatus")]
        public bool BillingStatus { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("charge")]
        public double Charge { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("plan")]
        public string Plan { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("__v")]
        public long V { get; set; }
    }

    public partial class Breakdown
    {
        [JsonProperty("discount")]
        public long Discount { get; set; }

        [JsonProperty("billable_products")]
        public List<object> BillableProducts { get; set; }
    }
}