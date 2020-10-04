using OkraDotNet.Auth.Requests;
using OkraDotNet.Common.Requests;

namespace OkraDotNet.Balance.Requests
{
    public class BalanceByAccountRequest : PaginatedRequest
    {
        public string Account { get; set; }
    }
}