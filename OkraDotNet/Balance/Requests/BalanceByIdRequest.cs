using OkraDotNet.Auth.Requests;
using OkraDotNet.Common.Requests;

namespace OkraDotNet.Balance.Requests
{
    public class BalanceByIdRequest : PaginatedRequest
    {
        public string Id { get; set; }
    }
}