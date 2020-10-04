using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Identity.Requests
{
    public class IdentityByIdRequest : PaginatedRequest
    {
        public string Id { get; set; }
    }
}