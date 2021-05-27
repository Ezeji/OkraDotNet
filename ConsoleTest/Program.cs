using OkraDotNet;
using OkraDotNet.Auth;
using OkraDotNet.Auth.Requests;
using OkraDotNet.Auth.Responses;
using OkraDotNet.Balance;
using OkraDotNet.Balance.Requests;
using OkraDotNet.Common.Requests;
using OkraDotNet.Identity;
using OkraDotNet.Income;
using OkraDotNet.Income.Requests;
using OkraDotNet.Transactions;
using OkraDotNet.Transactions.Requests;
using System;

namespace ConsoleTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //replace string value with access token from your dashboard
            var accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx.xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx.xxxxxxxxxxxxxxxxxxx";

            var api = new OkraApi(Key.AccessToken, true);

            //Uncomment any line below to run tests

            //AuthTests(api.Auth);
            //BalanceTests(api.Balance);
            //IdentityTests(api.Identity);
            TransactionsTests(api.Transactions);
            //IncomeTests(api.Income);

            Console.ReadLine();
        }

        public static void AuthTests(IAuthApi api)
        {
            //Retrieve Auth request
            var response1 = api.RetrieveAuthAsync(new PaginatedRequest { Limit = 10, Page = 1 }).Result;
            if (response1.IsSuccess)
            {
                RetrieveAuthResponseData data = response1.Value;
                // do something with data
            }
            else
            {
                var error = response1.Error;
                //use error
            }

            //Auth By id
            var response2 = api.AuthByIdAsync(new AuthByIdRequest { Id = "5f338d5c9e5c6e823a71e5e1", Limit = 2, Page = 1 }).Result;
            if (response2.IsSuccess)
            {
                AuthResponseData data = response2.Value;
                // do something with data
            }
            else
            {
                var error = response2.Error;
                //use error
            }

            var retAuthPdf = api.RetrieveAuthAsPdfAsync(new PaginatedRequest { Limit = 10, Page = 1, }).Result;

            var authId = api.AuthByIdAsync(new AuthByIdRequest { Id = "5f338d5c9e5c6e823a71e5e1", Limit = 2, Page = 1 }).Result;

            var authCus = api.AuthByCustomerAsync(new AuthByCustomerRequest { Customer = "5f338d5c53957a10097edaa4", Limit = 2, Page = 1 }).Result;

            var authDate = api.AuthByDateAsync(new AuthByDateRequest { From = DateTime.Now.AddDays(-50), To = DateTime.Now, Limit = 2, Page = 1 }).Result;

            var authBank = api.AuthByBankAsync(new AuthByBankRequest { Bank = "5d6fe57a4099cc4b210bbec0", Limit = 10, Page = 1 }).Result;

            var authCallBack = api.AuthCallBackAsync("5f536499e287580f4a6f1de7").Result;
        }

        public static void BalanceTests(IBalanceApi api)
        {
            var retBal = api.RetrieveBalanceAsync(new PaginatedRequest { Limit = 10, Page = 1 });

            var retBalPdf = api.RetrieveBalanceAsPdfAsync(new PaginatedRequest { Limit = 10, Page = 1 });

            var balId = api.BalanceByIdAsync(new BalanceByIdRequest { Id = "5f338d5f9e5c6e823a71e64a", Limit = 10, Page = 1 });

            var balAcc = api.BalanceByAccountAsync(new BalanceByAccountRequest { Account = "5f338d5f53957a10097edaa6", Limit = 10, Page = 1 });

            var balCus = api.BalanceByCustomerAsync(new BalanceByCustomerRequest { Customer = "5f338d5c53957a10097edaa4", Limit = 10, Page = 1 });

            var balDate = api.BalanceByDateRangeAsync(new BalanceByDateRangeRequest { From = DateTime.Now.AddDays(-50), To = DateTime.Now, Limit = 2, Page = 1 });

            var balCusDate = api.BalanceByCustomerAndDateRangeAsync(new BalanceByCustomerAndDateRangeRequest { Customer = "5f338d5c53957a10097edaa4", From = DateTime.Now.AddDays(-50), To = DateTime.Now, Limit = 2, Page = 1 });

            var balPeriod = api.PeriodicBalanceAsync(new PeriodicBalanceRequest { account_id = "5f338d5f53957a10097edaa6", Currency = "", record_id = "5f4d3d7adfc6e4088453d59f" });

            var balType = api.BalanceByTypeAsync(new BalanceByTypeRequest { Type = BalanceTypes.AvailableBalance, Value = "0.8" });

            var authCallBack = api.BalanceCallBackAsync("5f536499e287580f4a6f1de7").Result;
        }

        public static void TransactionsTests(ITransactionsApi api)
        {
            //var retTrans = api.RetrieveTransactionsAsync(new PaginatedRequest { Limit = 20, Page = 1 }).Result;

            //var retTransPdf = api.RetrieveTransactionsAsPdfAsync(new PaginatedRequest { Limit = 20, Page = 1 }).Result;

            var transId = api.TransactionByIdAsync(new TransactionByIdRequest { Id = "5f338d9f53957a10097edabe", Limit = 20, Page = 1 }).Result;

            var transAcc = api.TransactionByAccountAsync(new TransactionByAccountRequest { Account = "5f338d5f53957a10097edaa6", Limit = 20, Page = 1 }).Result;

            var transBank = api.TransactionByBankAsync(new TransactionByBankRequest { Bank = "5d6fe57a4099cc4b210bbec0", Limit = 20, Page = 1 }).Result;

            var transCus = api.TransactionByCustomerAsync(new TransactionByCustomerRequest { Customer = "5f338d5c53957a10097edaa4", Limit = 20, Page = 1 }).Result;

            var transCusDate = api.TransactionByCustomerAndDateRangeAsync(
                new TransactionByCustomerAndDateRangeRequest
                {
                    From = DateTime.Now.AddDays(-50),
                    To = DateTime.Now,
                    Customer = "5f338d5c53957a10097edaa4",
                    Limit = 20,
                    Page = 1
                }).Result;

            var transDate = api.TransactionByDateRangeAsync(
                new TransactionByDateRangeRequest { From = DateTime.Now.AddDays(-50), To = DateTime.Now, Limit = 20, Page = 1 }).Result;

            var transSpending = api.TransactionSpendingPatternAsync(new TransactionSpendingPatternRequest { CustomerId = "5f338d5c53957a10097edaa4" }).Result;

            var transOpt = api.TransactionsByOptionsAsync(new TransactionByOptionsRequest { Options = new { FirstName = "CHUKWU", LastName = "OBI" } }).Result;

            var transType = api.TransactionByTypeAsync(new TransactionByTypeRequest { Type = TransactionType.Credit, Value = "200", Limit = 20, Page = 1 }).Result;

            var transPeriod = api.PeriodicTransactionAsync(new PeriodicTransactionRequest { account_id = "5f338d5f53957a10097edaa6", Currency = "NGN", record_id = "5f338d9f53957a10097edabe" }).Result;

            var authCallBack = api.TransactionCallBackAsync("5f536499e287580f4a6f1de7").Result;
        }

        public static void IdentityTests(IIdentityApi api)
        {
            var retId = api.RetrieveIdentityAsync(new PaginatedRequest { Limit = 20, Page = 1 });
            var authCallBack = api.IdentityCallBackAsync("5f536499e287580f4a6f1de7").Result;
        }

        public static void IncomeTests(IIncomeApi api)
        {
            var authCallBack = api.IncomeCallBackAsync("5f536499e287580f4a6f1de7").Result;
            var proIncome = api.ProcessIncomeAsync(new ProcessIncomeRequest { CustomerId = "5f338d5c53957a10097edaa4" }).Result;
        }
    }
}