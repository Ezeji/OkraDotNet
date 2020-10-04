using CSharpFunctionalExtensions;
using OkraDotNet.Common;
using OkraDotNet.Common.Requests;
using OkraDotNet.Identity.Requests;
using OkraDotNet.Identity.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OkraDotNet.Identity
{
    public interface IIdentityApi
    {
        /// <summary>
        /// Allows you to retrieve various account holder information on file using the customer id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<IdentityResponseData, OkraError>> IdentityByCustomerAsync(IdentityByCustomerRequest request);

        /// <summary>
        /// Allows you to an account holder information on file using date range and customer id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<IdentityResponseData, OkraError>> IdentityByCustomerAndDateRangeAsync(IdentityByCustomerAndDateRangeRequest request);

        /// <summary>
        /// Allows you to retrieve various account holder information on file using date range
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<IdentityResponseData, OkraError>> IdentityByDateRangeAsync(IdentityByDateRangeRequest request);

        /// <summary>
        /// Allows you to retrieve various account holder information on file using the id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<IdentityResponseData, OkraError>> IdentityByIdAsync(IdentityByIdRequest request);

        /// <summary>
        /// Allows you to fetch identity info using the options metadata you provided when setting up the widget
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<IdentityResponseData, OkraError>> IdentityByOptionsAsync(IdentityByOptionsRequest request);

        /// <summary>
        /// Allows you to retrieve various account holder information on file
        /// with the bank, including names, emails, phone numbers, and addresses
        /// </summary>
        /// <returns></returns>
        Task<Result<RetrieveIdentityResponseData, OkraError>> RetrieveIdentityAsync(PaginatedRequest request);

        /// <summary>
        /// Allows you to retrieve various account holder information on file
        /// with the bank, including names, emails, phone numbers, and addresses as pdf file link
        /// </summary>
        /// <returns></returns>
        Task<Result<string, OkraError>> RetrieveIdentityAsPdfAsync(PaginatedRequest request);

        Task<Result<IdentityCallbackResponseData, OkraError>> IdentityCallBackAsync(string record);
    }

    public class IdentityApi : IIdentityApi
    {
        private readonly OkraApi _okraApi;

        public IdentityApi(OkraApi okraApi)
        {
            _okraApi = okraApi;
        }

        public async Task<Result<RetrieveIdentityResponseData, OkraError>> RetrieveIdentityAsync(PaginatedRequest request)
        {
            var url = "products/identities";

            var response = await _okraApi.Post<RetrieveIdentityResponse, PaginatedRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<string, OkraError>> RetrieveIdentityAsPdfAsync(PaginatedRequest request)
        {
            var url = "products/identities";

            var response = await _okraApi.Post<RetrieveIdentityAsPdfResponse, RetrieveIdentityAsPdfRequest>(url,
                new RetrieveIdentityAsPdfRequest { Limit = request.Limit, Page = request.Page });

            return response.ToResult();
        }

        public async Task<Result<IdentityResponseData, OkraError>> IdentityByIdAsync(IdentityByIdRequest request)
        {
            var url = "identity/getById";

            var response = await _okraApi.Post<IdentityResponse, IdentityByIdRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<IdentityResponseData, OkraError>> IdentityByOptionsAsync(IdentityByOptionsRequest request)
        {
            var url = "identity/byOptions";

            var response = await _okraApi.Post<IdentityResponse, IdentityByOptionsRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<IdentityResponseData, OkraError>> IdentityByCustomerAsync(IdentityByCustomerRequest request)
        {
            var url = "identity/getByCustomer";

            var response = await _okraApi.Post<IdentityResponse, IdentityByCustomerRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<IdentityResponseData, OkraError>> IdentityByDateRangeAsync(IdentityByDateRangeRequest request)
        {
            var url = "identity/getByDate";

            var response = await _okraApi.Post<IdentityResponse, IdentityByDateRangeRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<IdentityResponseData, OkraError>> IdentityByCustomerAndDateRangeAsync(IdentityByCustomerAndDateRangeRequest request)
        {
            var url = "identity/getByCustomerDate";

            var response = await _okraApi.Post<IdentityResponse, IdentityByCustomerAndDateRangeRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<IdentityCallbackResponseData, OkraError>> IdentityCallBackAsync(string record)
        {
            var url = "callback";

            var request = new IdentityCallBackRequest { Record = record };

            var response = await _okraApi.Get<IdentityCallbackResponse, IdentityCallBackRequest>(url, request);

            return response.ToResult();
        }
    }
}