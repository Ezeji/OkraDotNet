using OkraDotNet.Common.Requests;
using System.ComponentModel;

namespace OkraDotNet.Transactions.Requests
{
    public class TransactionByTypeRequest : PaginatedRequest
    {
        [Description("See list of transaction type strings in " + nameof(TransactionType) + " class")]
        public string Type { get; set; }

        public string Value { get; set; }
    }

    public static class TransactionType
    {
        public static string Credit = "credit";

        public static string Debit = "debit";
    }
}