using OkraDotNet.Auth.Requests;
using OkraDotNet.Common.Requests;

namespace OkraDotNet.Balance.Requests
{
    public class BalanceByCustomerRequest : PaginatedRequest
    {
        public string Customer { get; set; }
    }
}