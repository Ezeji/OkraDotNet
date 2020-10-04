namespace OkraDotNet.Balance.Requests
{
    public class BalanceByCustomerAndDateRangeRequest : BalanceByDateRangeRequest
    {
        public string Customer { get; set; }
    }
}