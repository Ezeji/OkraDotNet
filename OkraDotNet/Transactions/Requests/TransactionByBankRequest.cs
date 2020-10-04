using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Transactions.Requests
{
    public class TransactionByBankRequest : PaginatedRequest
    {
        public string Bank { get; set; }
    }
}