using OkraDotNet.Common.Requests;

namespace OkraDotNet.Auth.Requests
{
    public class AuthByBankRequest : PaginatedRequest
    {
        public string Bank { get; set; }
    }
}