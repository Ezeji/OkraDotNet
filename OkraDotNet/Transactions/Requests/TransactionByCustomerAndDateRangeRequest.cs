using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Transactions.Requests
{
    public class TransactionByCustomerAndDateRangeRequest : TransactionByDateRangeRequest
    {
        public string Customer { get; set; }
    }
}