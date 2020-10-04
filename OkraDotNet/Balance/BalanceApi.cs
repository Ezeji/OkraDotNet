using CSharpFunctionalExtensions;
using OkraDotNet.Balance.Requests;
using OkraDotNet.Balance.Responses;
using OkraDotNet.Common;
using OkraDotNet.Common.Requests;
using OkraDotNet.Common.Responses;
using System.Threading.Tasks;

namespace OkraDotNet.Balance
{
    public interface IBalanceApi
    {
        /// <summary>
        /// Pull real-time balance information with account id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<BalanceResponseData, OkraError>> BalanceByAccountAsync(BalanceByAccountRequest request);

        /// <summary>
        /// Pull real-time balance information with customer id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<BalanceResponseData, OkraError>> BalanceByCustomerAsync(BalanceByCustomerRequest request);

        /// <summary>
        /// Pull real-time balance information with date range
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<BalanceResponseData, OkraError>> BalanceByCustomerAndDateRangeAsync(BalanceByCustomerAndDateRangeRequest request);

        /// <summary>
        /// Pull real-time balance information with date range
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<BalanceResponseData, OkraError>> BalanceByDateRangeAsync(BalanceByDateRangeRequest request);

        /// <summary>
        /// Pull real-time balance information with balance id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<BalanceResponseData, OkraError>> BalanceByIdAsync(BalanceByIdRequest request);

        /// <summary>
        /// Pull real-time balance information with type of balance
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<BalanceByTypeResponseData, OkraError>> BalanceByTypeAsync(BalanceByTypeRequest request);

        /// <summary>
        /// Returns the real-time BALANCE at anytime
        /// without heavy calculation of the transactions on each of an Record's accounts
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<PeriodicResponseData, OkraError>> PeriodicBalanceAsync(PeriodicBalanceRequest request);

        /// <summary>
        /// Pull real-time balance information for each account associated
        /// with the Record
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<RetrieveBalanceResponseData, OkraError>> RetrieveBalanceAsync(PaginatedRequest request);

        /// <summary>
        /// Pull real-time balance information for each account associated
        /// with the Record as pdf file link
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<string, OkraError>> RetrieveBalanceAsPdfAsync(PaginatedRequest request);

        Task<Result<BalanceCallbackResponseData, OkraError>> BalanceCallBackAsync(string record);
    }

    public class BalanceApi : IBalanceApi
    {
        private readonly OkraApi _okraApi;

        public BalanceApi(OkraApi okraApi)
        {
            _okraApi = okraApi;
        }

        public async Task<Result<RetrieveBalanceResponseData, OkraError>> RetrieveBalanceAsync(PaginatedRequest request)
        {
            var url = "products/balances";

            var response = await _okraApi.Post<RetrieveBalanceResponse, PaginatedRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<string, OkraError>> RetrieveBalanceAsPdfAsync(PaginatedRequest request)
        {
            var url = "products/balances";

            var response = await _okraApi.Post<RetrieveBalanceAsPdfResponse, RetrieveBalanceAsPdfRequest>(url,
                new RetrieveBalanceAsPdfRequest { Limit = request.Limit, Page = request.Page });

            return response.ToResult();
        }

        public async Task<Result<BalanceResponseData, OkraError>> BalanceByIdAsync(BalanceByIdRequest request)
        {
            var url = "balance/getById";

            var response = await _okraApi.Post<BalanceResponse, BalanceByIdRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<BalanceResponseData, OkraError>> BalanceByCustomerAsync(BalanceByCustomerRequest request)
        {
            var url = "balance/getByCustomer";

            var response = await _okraApi.Post<BalanceResponse, BalanceByCustomerRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<BalanceResponseData, OkraError>> BalanceByAccountAsync(BalanceByAccountRequest request)
        {
            var url = "balance/getByAccount";

            var response = await _okraApi.Post<BalanceResponse, BalanceByAccountRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<BalanceResponseData, OkraError>> BalanceByDateRangeAsync(BalanceByDateRangeRequest request)
        {
            var url = "balance/getByDate";

            var response = await _okraApi.Post<BalanceResponse, BalanceByDateRangeRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<BalanceByTypeResponseData, OkraError>> BalanceByTypeAsync(BalanceByTypeRequest request)
        {
            var url = "balance/getByType";

            var response = await _okraApi.Post<BalanceByTypeResponse, BalanceByTypeRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<BalanceResponseData, OkraError>> BalanceByCustomerAndDateRangeAsync(BalanceByCustomerAndDateRangeRequest request)
        {
            var url = "balance/getByCustomerDate";

            var response = await _okraApi.Post<BalanceResponse, BalanceByCustomerAndDateRangeRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<PeriodicResponseData, OkraError>> PeriodicBalanceAsync(PeriodicBalanceRequest request)
        {
            var url = "products/balance/periodic";

            var response = await _okraApi.Post<PeriodicResponse, PeriodicBalanceRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<BalanceCallbackResponseData, OkraError>> BalanceCallBackAsync(string record)
        {
            var url = "callback";

            var request = new BalanceCallBackRequest { Record = record };

            var response =
                await _okraApi.Get<BalanceCallbackResponse, BalanceCallBackRequest>(url, request);

            return response.ToResult();
        }
    }
}