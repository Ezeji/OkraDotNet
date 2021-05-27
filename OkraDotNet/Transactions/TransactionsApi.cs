using CSharpFunctionalExtensions;
using OkraDotNet.Common;
using OkraDotNet.Common.Requests;
using OkraDotNet.Common.Responses;
using OkraDotNet.Transactions.Requests;
using OkraDotNet.Transactions.Responses;
using System.Threading.Tasks;

namespace OkraDotNet.Transactions
{
    public interface ITransactionsApi
    {
        /// <summary>
        /// Returns the real-time TRANSACTION at anytime on each of an Record's accounts
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<PeriodicResponseData, OkraError>> PeriodicTransactionAsync(PeriodicTransactionRequest request);

        /// <summary>
        /// Receive customer-authorized transaction data for current, savings, and domiciliary Accounts
        /// </summary>
        /// <returns></returns>
        Task<Result<RetrieveTransactionResponseData, OkraError>> RetrieveTransactionsAsync(PaginatedRequest request);

        /// <summary>
        /// Allows you to fetch transaction info using the account id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<TransactionResponseData, OkraError>> TransactionByAccountAsync(TransactionByAccountRequest request);

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

        /// <summary>
        /// Returns the spending pattern of a customer
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<TransactionSpendingPatternResponseData, OkraError>> TransactionSpendingPatternAsync(TransactionSpendingPatternRequest request);

        /// <summary>
        /// Allows you to fetch transaction info by type
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<TransactionByTypeResponseData, OkraError>> TransactionByTypeAsync(TransactionByTypeRequest request);

        /// <summary>
        /// Allows you to fetch transactions info using the options metadata you provided when
        /// setting up the widget
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<TransactionsByOptionsResponseData, OkraError>> TransactionsByOptionsAsync(TransactionByOptionsRequest request);

        Task<Result<TransactionCallbackResponseData, OkraError>> TransactionCallBackAsync(string record);

        TransactionsApi.IVersion1 V1 { get; }
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

        #region |V1 only|

        public IVersion1 V1 => new Version1(_okraApi.AccessToken);

        public interface IVersion1
        {
            /// <summary>
            /// Receive customer-authorized transaction data for current, savings, and domiciliary Accounts
            /// </summary>
            /// <returns></returns>
            Task<Result<RetrieveTransactionResponseData, OkraError>> RetrieveTransactionsAsync(PaginatedRequest request);

            /// <summary>
            /// Receive customer-authorized transaction data for current, savings, and domiciliary
            /// Accounts as pdf file link
            /// </summary>
            /// <returns></returns>
            Task<Result<string, OkraError>> RetrieveTransactionsAsPdfAsync(PaginatedRequest request);

            Task<Result<TransactionsByOptionsResponseData, OkraError>> TransactionsByOptionsAsync(TransactionByOptionsRequest request);

            Task<Result<TransactionResponseData, OkraError>> TransactionByAccountAsync(TransactionByAccountRequest request);

            Task<Result<TransactionByTypeResponseData, OkraError>> TransactionByTypeAsync(TransactionByTypeRequest request);

            Task<Result<TransactionSpendingPatternResponseData, OkraError>> TransactionSpendingPatternAsync(TransactionSpendingPatternRequest request);

            Task<Result<PeriodicResponseData, OkraError>> PeriodicTransactionAsync(PeriodicTransactionRequest request);

            Task<Result<TransactionCallbackResponseData, OkraError>> TransactionCallBackAsync(string record);
        }

        public class Version1 : IVersion1
        {
            private readonly OkraApi _okraApi;

            public Version1(string accessToken)
            {
                _okraApi = new OkraApi(accessToken, "https://api.okra.ng/sandbox/v2/");
            }

            public async Task<Result<RetrieveTransactionResponseData, OkraError>> RetrieveTransactionsAsync(PaginatedRequest request)
            {
                var url = "products/transactions";

                var response = await _okraApi.Post<RetrieveTransactionsResponse, PaginatedRequest>(url, request);

                return response.ToResult();
            }

            public async Task<Result<string, OkraError>> RetrieveTransactionsAsPdfAsync(PaginatedRequest request)
            {
                var url = "products/transactions";

                var response = await _okraApi.Post<RetrieveTransactionsAsPdfResponse, RetrieveTransactionsAsPdfRequest>(url,
                    new RetrieveTransactionsAsPdfRequest { Limit = request.Limit, Page = request.Page });

                return response.ToResult();
            }

            public async Task<Result<TransactionsByOptionsResponseData, OkraError>> TransactionsByOptionsAsync(TransactionByOptionsRequest request)
            {
                var url = "transactions/byOptions";

                var response = await _okraApi.Post<TransactionsByOptionsResponse, TransactionByOptionsRequest>(url, request);

                return response.ToResult();
            }

            public async Task<Result<TransactionResponseData, OkraError>> TransactionByAccountAsync(TransactionByAccountRequest request)
            {
                var url = "transactions/getByAccount";

                var response = await _okraApi.Post<TransactionResponse, TransactionByAccountRequest>(url, request);

                return response.ToResult();
            }

            public async Task<Result<TransactionByTypeResponseData, OkraError>> TransactionByTypeAsync(TransactionByTypeRequest request)
            {
                var url = "transactions/getByType";

                var response = await _okraApi.Post<TransactionByTypeResponse, TransactionByTypeRequest>(url, request);

                return response.ToResult();
            }

            public async Task<Result<TransactionSpendingPatternResponseData, OkraError>> TransactionSpendingPatternAsync(TransactionSpendingPatternRequest request)
            {
                var url = "products/transactions/spending-pattern";

                var response = await _okraApi.Post<TransactionSpendingPatternResponse, TransactionSpendingPatternRequest>(url, request); //Todo: issues with error response data

                return response.ToResult();
            }

            public async Task<Result<PeriodicResponseData, OkraError>> PeriodicTransactionAsync(PeriodicTransactionRequest request)
            {
                var url = "products/transactions/periodic";

                var response = await _okraApi.Post<PeriodicResponse, PeriodicTransactionRequest>(url, request);

                return response.ToResult();
            }

            public async Task<Result<TransactionCallbackResponseData, OkraError>> TransactionCallBackAsync(string record)
            {
                var url = "callback";

                var request = new TransactionsCallBackRequest { Record = record };

                var response =
                    await _okraApi.Get<TransactionCallbackResponse, TransactionsCallBackRequest>(url, request);

                return response.ToResult();
            }

            #endregion |V1 only|
        }
    }
}