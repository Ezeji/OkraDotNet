using OkraDotNet.Common.Requests;
using System;

namespace OkraDotNet.Auth.Requests
{
    public class AuthByDateRequest : PaginatedRequest
    {
        public DateTime From { get; set; }

        public DateTime To { get; set; }
    }
}