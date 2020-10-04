using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Transactions.Requests
{
    public class TransactionByTypeRequest : PaginatedRequest
    {
        public string Type { get; set; }

        public string Value { get; set; }
    }

    public static class TransactionType
    {
        public static string Credit = "credit";

        public static string Debit = "debit";
    }
}