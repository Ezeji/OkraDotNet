using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Balance.Requests
{
    public class BalanceCallBackRequest
    {
        public string Record { get; set; }

        public string Method { get; } = CallBackRequestTypes.BALANCE;
    }
}