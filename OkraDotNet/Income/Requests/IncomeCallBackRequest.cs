using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Income.Requests
{
    public class IncomeCallBackRequest
    {
        public string Record { get; set; }

        public string Method { get; } = CallBackRequestTypes.INCOME;
    }
}