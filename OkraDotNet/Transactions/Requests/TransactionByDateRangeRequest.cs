using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Transactions.Requests
{
    public class TransactionByDateRangeRequest : PaginatedRequest
    {
        public DateTime From { get; set; }

        public DateTime To { get; set; }
    }
}