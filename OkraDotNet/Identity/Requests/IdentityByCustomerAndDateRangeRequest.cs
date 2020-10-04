using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Identity.Requests
{
    public class IdentityByCustomerAndDateRangeRequest : IdentityByDateRangeRequest
    {
        public string Customer { get; set; }
    }
}