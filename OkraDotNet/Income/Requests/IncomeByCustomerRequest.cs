using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Income.Requests
{
    public class IncomeByCustomerRequest : PaginatedRequest
    {
        public string Id { get; set; }
    }
}