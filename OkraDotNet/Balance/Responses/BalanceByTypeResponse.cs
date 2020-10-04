using Newtonsoft.Json;
using OkraDotNet.Common;
using OkraDotNet.Common.Responses;
using System;
using System.Collections.Generic;

namespace OkraDotNet.Balance.Responses
{
    public class BalanceByTypeResponse : BaseResponse, IBaseResponse<BalanceByTypeResponseData>
    {
        public BalanceByTypeResponseData Data { get; set; }
    }

    public class BalanceByTypeResponseData
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("balance")]
        public List<BalanceByTypeBalance> Balance { get; set; }
    }

    public partial class BalanceByTypeBalance
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("account")]
        public BalanceAccount Account { get; set; }

        [JsonProperty("ledger_balance")]
        public double LedgerBalance { get; set; }

        [JsonProperty("available_balance")]
        public long AvailableBalance { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("connected")]
        public List<string> Connected { get; set; }

        [JsonProperty("env")]
        public string Env { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }
    }

    public partial class BalanceByTypeAccount
    {
        [JsonProperty("owner")]
        public List<Owner> Owner { get; set; }

        [JsonProperty("record")]
        public List<Record> Record { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("bank")]
        public BalanceByTypeBank Bank { get; set; }

        [JsonProperty("customer")]
        public CommonCustomer Customer { get; set; }
    }

    public partial class BalanceByTypeBank
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("logo")]
        public Uri Logo { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }
    }

    public partial class Owner
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("company")]
        public Company Company { get; set; }
    }

    public partial class Company
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("app_name")]
        public string AppName { get; set; }
    }

    public partial class Record
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("env")]
        public string Env { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }
    }
}