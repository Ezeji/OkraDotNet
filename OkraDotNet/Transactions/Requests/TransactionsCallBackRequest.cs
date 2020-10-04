using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Transactions.Requests
{
    public class TransactionsCallBackRequest
    {
        public string Record { get; set; }

        public string Method { get; } = CallBackRequestTypes.TRANSACTIONS;
    }
}