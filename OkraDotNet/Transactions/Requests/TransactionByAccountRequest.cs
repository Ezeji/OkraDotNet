using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Transactions.Requests
{
    public class TransactionByAccountRequest : PaginatedRequest
    {
        public string Account { get; set; }
    }
}