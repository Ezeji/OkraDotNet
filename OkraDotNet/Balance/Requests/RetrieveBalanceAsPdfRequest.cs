using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Balance.Requests
{
    internal class RetrieveBalanceAsPdfRequest : PaginatedRequest
    {
        public bool Pdf { get; set; } = true;
    }
}