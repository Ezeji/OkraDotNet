using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Identity.Requests
{
    public class IdentityByDateRangeRequest : PaginatedRequest
    {
        public DateTime From { get; set; }

        public DateTime To { get; set; }
    }
}