using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Auth.Requests
{
    public class AuthByIdRequest : PaginatedRequest
    {
        public string Id { get; set; }
    }
}