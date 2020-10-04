using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Identity.Requests
{
    public class IdentityByCustomerRequest : PaginatedRequest
    {
        public string Customer { get; set; }
    }
}