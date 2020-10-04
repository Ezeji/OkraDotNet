using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Transactions.Requests
{
    public class TransactionByOptionsRequest : PaginatedRequest
    {
        public dynamic Options { get; set; }
    }

    //public class Options
    //{
    //    public string FirstName { get; set; }

    //    public string LastName { get; set; }
    //}
}