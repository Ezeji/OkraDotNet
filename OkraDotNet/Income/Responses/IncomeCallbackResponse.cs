using Newtonsoft.Json;
using OkraDotNet.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Income.Responses
{
    public class IncomeCallbackResponse : BaseResponse, IBaseResponse<IncomeCallbackResponseData>
    {
        [JsonProperty("data")]
        public IncomeCallbackResponseData Data { get; set; }
    }

    public class IncomeCallbackResponseData
    {
        [JsonProperty("income")]
        public IncomeCallbackResponseIncome Income { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("record")]
        public string Record { get; set; }

        [JsonProperty("products")]
        public Products Products { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    public class IncomeCallbackResponseIncome
    {
        [JsonProperty("owner")]
        public List<string> Owner { get; set; }

        [JsonProperty("record")]
        public List<string> Record { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("__v")]
        public long V { get; set; }

        [JsonProperty("confidence")]
        public string Confidence { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("env")]
        public string Env { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("last_year_income")]
        public long LastYearIncome { get; set; }

        [JsonProperty("max_number_of_overlapping_income_streams")]
        public long MaxNumberOfOverlappingIncomeStreams { get; set; }

        [JsonProperty("number_of_income_streams")]
        public long NumberOfIncomeStreams { get; set; }

        [JsonProperty("projected_yearly_income")]
        public double ProjectedYearlyIncome { get; set; }

        [JsonProperty("streams")]
        public List<IncomeCallbackResponseStream> Streams { get; set; }
    }

    public class IncomeCallbackResponseStream
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("avg_monthly_income")]
        public long AvgMonthlyIncome { get; set; }

        [JsonProperty("days")]
        public long Days { get; set; }

        [JsonProperty("monthly_income")]
        public long MonthlyIncome { get; set; }

        [JsonProperty("income_type")]
        public string IncomeType { get; set; }
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
}