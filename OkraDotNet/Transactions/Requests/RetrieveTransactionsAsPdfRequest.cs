using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Transactions.Requests
{
    public class RetrieveTransactionsAsPdfRequest : PaginatedRequest
    {
        public bool Pdf { get; set; } = true;
    }
}