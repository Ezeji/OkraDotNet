using CSharpFunctionalExtensions;
using OkraDotNet.Common;
using OkraDotNet.Common.Requests;
using OkraDotNet.Transactions.Requests;
using OkraDotNet.Transactions.Responses;
using System.Threading.Tasks;

namespace OkraDotNet.Transactions
{
    public interface ITransactionsApi
    {
        /// <summary>
        /// Receive customer-authorized transaction data for current, savings, and domiciliary Accounts
        /// </summary>
        /// <returns></returns>
        Task<Result<RetrieveTransactionResponseData, OkraError>> RetrieveTransactionsAsync(PaginatedRequest request);

        /// <summary>
        /// Allows you to fetch transaction info using a bank id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<TransactionResponseData, OkraError>> TransactionByBankAsync(TransactionByBankRequest request);

        /// <summary>
        /// Allows you to fetch transaction info using the customer id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<TransactionResponseData, OkraError>> TransactionByCustomerAsync(TransactionByCustomerRequest request);

        /// <summary>
        /// Allows you to fetch transaction info of a customer using a date rage and customer id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<TransactionResponseData, OkraError>> TransactionByCustomerAndDateRangeAsync(TransactionByCustomerAndDateRangeRequest request);

        /// <summary>
        /// Allows you to fetch transaction info using a date range
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<TransactionResponseData, OkraError>> TransactionByDateRangeAsync(TransactionByDateRangeRequest request);

        /// <summary>
        /// Allows you to fetch transaction info using the id of the transaction
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<TransactionResponseData, OkraError>> TransactionByIdAsync(TransactionByIdRequest request);

        Task<Result<TotalCreditAndDebitResponseData, OkraError>> TotalCreditAndDebit(string customerId);
    }

    public class TransactionsApi : ITransactionsApi
    {
        private readonly OkraApi _okraApi;

        public TransactionsApi(OkraApi okraApi)
        {
            _okraApi = okraApi;
        }

        public async Task<Result<TransactionResponseData, OkraError>> TransactionByIdAsync(TransactionByIdRequest request)
        {
            var url = "transactions/getById";

            var response = await _okraApi.Post<TransactionResponse, TransactionByIdRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<TransactionResponseData, OkraError>> TransactionByCustomerAsync(TransactionByCustomerRequest request)
        {
            var url = "transactions/getByCustomer";

            var response = await _okraApi.Post<TransactionResponse, TransactionByCustomerRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<TransactionResponseData, OkraError>> TransactionByBankAsync(TransactionByBankRequest request)
        {
            var url = "transactions/getByBank";

            var response = await _okraApi.Post<TransactionResponse, TransactionByBankRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<TransactionResponseData, OkraError>> TransactionByDateRangeAsync(TransactionByDateRangeRequest request)
        {
            var url = "transactions/getByDate";

            var response = await _okraApi.Post<TransactionResponse, TransactionByDateRangeRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<TransactionResponseData, OkraError>> TransactionByCustomerAndDateRangeAsync(TransactionByCustomerAndDateRangeRequest request)
        {
            var url = "transactions/getByCustomerDate";

            var response = await _okraApi.Post<TransactionResponse, TransactionByCustomerAndDateRangeRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<RetrieveTransactionResponseData, OkraError>> RetrieveTransactionsAsync(PaginatedRequest request)
        {
            var url = "products/transactions/get";

            var response = await _okraApi.Post<RetrieveTransactionsResponse, PaginatedRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<TotalCreditAndDebitResponseData, OkraError>> TotalCreditAndDebit(string customerId)
        {
            var url = "products/records/credit-debit/get";

            var response = await _okraApi.Post<TotalCreditAndDebitResponse, object>(url, new { Customer = customerId });

            return response.ToResult();
        }
    }
}