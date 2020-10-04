using OkraDotNet.Auth.Requests;
using OkraDotNet.Common.Requests;
using System;

namespace OkraDotNet.Balance.Requests
{
    public class BalanceByDateRangeRequest : PaginatedRequest
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}