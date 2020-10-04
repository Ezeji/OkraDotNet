using OkraDotNet.Common.Requests;

namespace OkraDotNet.Transactions.Requests
{
    public class TransactionByCustomerRequest : PaginatedRequest
    {
        public string Customer { get; set; }
    }
}