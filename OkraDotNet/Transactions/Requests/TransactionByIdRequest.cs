using OkraDotNet.Common.Requests;

namespace OkraDotNet.Transactions.Requests
{
    public class TransactionByIdRequest : PaginatedRequest
    {
        public string Id { get; set; }
    }
}