using Newtonsoft.Json;
using OkraDotNet.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Income.Responses
{
    public class RetrieveIncomeResponse : BaseResponse, IBaseResponse<RetrieveIncomeResponseData>
    {
        [JsonProperty("data")]
        public RetrieveIncomeResponseData Data { get; set; } //Todo: review response
    }

    public class RetrieveIncomeResponseData
    {
        [JsonProperty("streams")]
        public List<Stream> Streams { get; set; }

        [JsonProperty("last_year_income")]
        public long LastYearIncome { get; set; }

        [JsonProperty("projected_yearly_income")]
        public long ProjectedYearlyIncome { get; set; }

        [JsonProperty("transactions")]
        public long Transactions { get; set; }

        [JsonProperty("credits")]
        public long Credits { get; set; }

        [JsonProperty("number_of_income_streams")]
        public long NumberOfIncomeStreams { get; set; }

        [JsonProperty("max_number_of_overlapping_income_streams")]
        public long MaxNumberOfOverlappingIncomeStreams { get; set; }
    }

    public class Stream
    {
        [JsonProperty("days")]
        public long Days { get; set; }

        [JsonProperty("monthly_income")]
        public long MonthlyIncome { get; set; }

        [JsonProperty("avg_monthly_income")]
        public long AvgMonthlyIncome { get; set; }

        [JsonProperty("employer")]
        public string Employer { get; set; }
    }
}