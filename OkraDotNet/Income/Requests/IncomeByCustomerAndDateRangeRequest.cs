using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Income.Requests
{
    public class IncomeByCustomerAndDateRangeRequest : IncomeByCustomerRequest
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}