using CSharpFunctionalExtensions;
using OkraDotNet.Common;
using OkraDotNet.Common.Requests;
using OkraDotNet.Income.Requests;
using OkraDotNet.Income.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OkraDotNet.Income
{
    public interface IIncomeApi
    {
        /// <summary>
        /// Allows you to retrieve information pertaining to a Record’s income using the customer id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<RetrieveIncomeResponseData, OkraError>> IncomeByCustomerAsync(IncomeByCustomerRequest request);

        /// <summary>
        /// Allows you to retrieve information pertaining to a Record’s income using the customer id and date range
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<RetrieveIncomeResponseData, OkraError>> IncomeByCustomerAndDateRangeAsync(IncomeByCustomerAndDateRangeRequest request);

        /// <summary>
        /// Allows you to retrieve information pertaining to a Record’s income using the id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<RetrieveIncomeResponseData, OkraError>> IncomeByIdAsync(IncomeByIdRequest request);

        /// <summary>
        /// Allows you to process the income of particular customer using the customer's id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<dynamic, OkraError>> ProcessIncomeAsync(ProcessIncomeRequest request);

        /// <summary>
        /// Allows you to retrieve information pertaining to a Record’s income. In addition to the annual income, detailed
        /// information will be provided for each contributing income stream (or job)
        /// </summary>
        /// <returns></returns>
        Task<Result<RetrieveIncomeResponseData, OkraError>> RetrieveIncomeAsync(PaginatedRequest request);

        Task<Result<IncomeCallbackResponseData, OkraError>> IncomeCallBackAsync(string record);
    }

    public class IncomeApi : IIncomeApi
    {
        private readonly OkraApi _okraApi;

        public IncomeApi(OkraApi okraApi)
        {
            _okraApi = okraApi;
        }

        public async Task<Result<RetrieveIncomeResponseData, OkraError>> RetrieveIncomeAsync(PaginatedRequest request)
        {
            var url = "products/income/get";

            var response = await _okraApi.Post<RetrieveIncomeResponse, PaginatedRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<RetrieveIncomeResponseData, OkraError>> IncomeByIdAsync(IncomeByIdRequest request)
        {
            var url = "identity/getById";

            var response = await _okraApi.Post<RetrieveIncomeResponse, IncomeByIdRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<RetrieveIncomeResponseData, OkraError>> IncomeByCustomerAsync(IncomeByCustomerRequest request)
        {
            var url = "identity/getByCustomer";

            var response = await _okraApi.Post<RetrieveIncomeResponse, IncomeByCustomerRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<RetrieveIncomeResponseData, OkraError>> IncomeByCustomerAndDateRangeAsync(IncomeByCustomerAndDateRangeRequest request)
        {
            var url = "identity/getByCustomer";

            var response = await _okraApi.Post<RetrieveIncomeResponse, IncomeByCustomerAndDateRangeRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<dynamic, OkraError>> ProcessIncomeAsync(ProcessIncomeRequest request)
        {
            var url = "products/income/process";

            var response = await _okraApi.Post<ProcessIncomeResponse, ProcessIncomeRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<IncomeCallbackResponseData, OkraError>> IncomeCallBackAsync(string record)
        {
            var url = "callback";

            var request = new IncomeCallBackRequest { Record = record };

            var response = await _okraApi.Get<IncomeCallbackResponse, IncomeCallBackRequest>(url, request);

            return response.ToResult();
        }
    }
}