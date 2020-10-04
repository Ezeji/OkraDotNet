using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Balance.Requests
{
    public class PeriodicBalanceRequest
    {
        //public string AccessToken { get; set; }

        public string account_id { get; set; }

        public string record_id { get; set; }

        public string Currency { get; set; }
    }
}