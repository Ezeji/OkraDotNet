using OkraDotNet.Common.Requests;

namespace OkraDotNet.Auth.Requests
{
    public class AuthByCustomerRequest : PaginatedRequest
    {
        public string Customer { get; set; }
    }
}