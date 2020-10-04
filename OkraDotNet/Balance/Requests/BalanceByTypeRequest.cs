namespace OkraDotNet.Balance.Requests
{
    public class BalanceByTypeRequest
    {
        public string Type { get; set; }

        public string Value { get; set; }
    }

    public static class BalanceTypes
    {
        public static string AvailableBalance = "available_balance";
        public static string LedgerBalance = "ledger_balance";
    }
}