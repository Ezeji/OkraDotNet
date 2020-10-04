using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Income.Requests
{
    public class ProcessIncomeRequest
    {
        public string CustomerId { get; set; }

        public string AccessToken { get; set; }
    }
}